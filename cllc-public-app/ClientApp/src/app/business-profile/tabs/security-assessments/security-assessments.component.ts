import { Component, OnInit, Input, ViewContainerRef, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort, MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material';
import { ToastsManager } from 'ng2-toastr';
import { Subscription } from 'rxjs/Subscription';
import { AdoxioLegalEntity } from '../../../models/adoxio-legalentities.model';
import { AdoxioLegalEntityDataService } from '../../../services/adoxio-legal-entity-data.service';
import { DynamicsDataService } from '../../../services/dynamics-data.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-security-assessments',
  templateUrl: './security-assessments.component.html',
  styleUrls: ['./security-assessments.component.scss']
})
export class SecurityAssessmentsComponent implements OnInit {

  @Input() accountId: string;
  @Input() parentLegalEntityId: string;
  @Input() businessType: string;

  adoxioLegalEntityList: AdoxioLegalEntity[] = [];
  dataSource = new MatTableDataSource<AdoxioLegalEntity>();
  displayedColumns = ['sendConsentRequest', 'firstname', 'lastname', 'email', 'position', 'emailsent'];
  busy: Promise<any>;
  busyObsv: Subscription;

  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private legalEntityDataservice: AdoxioLegalEntityDataService,
    private route: ActivatedRoute,
    private dynamicsDataService: DynamicsDataService,
    public toastr: ToastsManager,
    vcr: ViewContainerRef) {
    this.toastr.setRootViewContainerRef(vcr);
  }

  ngOnInit() {
    this.route.parent.params.subscribe(p => {
      this.parentLegalEntityId = p.legalEntityId;
      this.accountId = p.accountId;
      this.dynamicsDataService.getRecord('account', this.accountId)
        .then((data) => {
          this.businessType = data.businessType;
        });
      this.getDirectorsAndOfficersAndShareholders();
    });
    this.dataSource.paginator = this.paginator;
  }

  getDirectorsAndOfficersAndShareholders() {
    const legalEntitiesList = [];
    this.busyObsv = this.legalEntityDataservice.getLegalEntitiesbyPosition(this.parentLegalEntityId, 'director-officer-shareholder')
      .subscribe((result) => {
        const data = result.json();
        data.forEach((entry) => {
          entry.sendConsentRequest = false;
          if (entry.isindividual) {
            legalEntitiesList.push(entry);
          }
        });
        this.dataSource.data = legalEntitiesList;
      });
  }

  getRoles(legalEntity: AdoxioLegalEntity): string {
    const roles = [];
    if (legalEntity.isDirector === true) {
      roles.push('Director');
    }
    if (legalEntity.isOfficer === true) {
      roles.push('Officer');
    }
    if (legalEntity.isOwner === true) {
      roles.push('Owner');
    }
    if (legalEntity.isSeniorManagement === true) {
      roles.push('Senior Manager');
    }
    if (legalEntity.isShareholder === true) {
      roles.push('Shareholder');
    }
    return roles.join(', ');
  }

  sendConsentRequestEmail() {
    const consentRequestList: string[] = [];

    this.dataSource.data.forEach((row) => {
      if (row.sendConsentRequest) {
        consentRequestList.push(row.id);
      }
    });

    if (consentRequestList) {
      this.busyObsv = this.legalEntityDataservice.sendConsentRequestEmail(consentRequestList)
        .subscribe(
          res => {
            this.toastr.success('Consent Request(s) Sent ', 'Success!');
          },
          err => {
            this.handleError(err);
          }
        );
    }

  }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || '';
      const err = body || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
  }

}
