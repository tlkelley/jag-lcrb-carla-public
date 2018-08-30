// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMentitlement
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentitlement
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentitlement
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlement(int? decreaseremainingon = default(int?), object startdate = default(object), int? statecode = default(int?), int? kbaccesslevel = default(int?), string entitlementid = default(string), object modifiedon = default(object), string versionnumber = default(string), int? importsequencenumber = default(int?), object enddate = default(object), string _customeridValue = default(string), bool? restrictcasecreation = default(bool?), bool? isdefault = default(bool?), string _owningteamValue = default(string), object exchangerate = default(object), int? allocationtypecode = default(int?), string _accountidValue = default(string), object remainingterms = default(object), string _contactidValue = default(string), string processid = default(string), string description = default(string), string _transactioncurrencyidValue = default(string), string _owningbusinessunitValue = default(string), string _slaidValue = default(string), object createdon = default(object), string _owninguserValue = default(string), int? statuscode = default(int?), object overriddencreatedon = default(object), object totalterms = default(object), string _owneridValue = default(string), string stageid = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), string traversedpath = default(string), string _entitlementtemplateidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string name = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> entitlementActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> entitlementAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> entitlementEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> entitlementFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> entitlementLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> entitlementPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> entitlementServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> entitlementTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> entitlementRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMconnection> entitlementConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> entitlementConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> entitlementAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMentitlementchannel> entitlementEntitlementchannelEntitlementId = default(IList<MicrosoftDynamicsCRMentitlementchannel>), IList<MicrosoftDynamicsCRMproduct> productEntitlementAssociation = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMentitlementtemplate entitlementtemplateid = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMaccount accountid = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact contactid = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsocialactivity> entitlementSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMcontact> entitlementcontactsAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMincident> entitlementCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMsyncerror> entitlementSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Decreaseremainingon = decreaseremainingon;
            Startdate = startdate;
            Statecode = statecode;
            Kbaccesslevel = kbaccesslevel;
            Entitlementid = entitlementid;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Enddate = enddate;
            this._customeridValue = _customeridValue;
            Restrictcasecreation = restrictcasecreation;
            Isdefault = isdefault;
            this._owningteamValue = _owningteamValue;
            Exchangerate = exchangerate;
            Allocationtypecode = allocationtypecode;
            this._accountidValue = _accountidValue;
            Remainingterms = remainingterms;
            this._contactidValue = _contactidValue;
            Processid = processid;
            Description = description;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._slaidValue = _slaidValue;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            Totalterms = totalterms;
            this._owneridValue = _owneridValue;
            Stageid = stageid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Traversedpath = traversedpath;
            this._entitlementtemplateidValue = _entitlementtemplateidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Name = name;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            EntitlementActivityPointers = entitlementActivityPointers;
            EntitlementAppointments = entitlementAppointments;
            EntitlementEmails = entitlementEmails;
            EntitlementFaxes = entitlementFaxes;
            EntitlementLetters = entitlementLetters;
            EntitlementPhoneCalls = entitlementPhoneCalls;
            EntitlementServiceAppointments = entitlementServiceAppointments;
            EntitlementTasks = entitlementTasks;
            EntitlementRecurringAppointmentMasters = entitlementRecurringAppointmentMasters;
            EntitlementConnections1 = entitlementConnections1;
            EntitlementConnections2 = entitlementConnections2;
            EntitlementDuplicateMatchingRecord = entitlementDuplicateMatchingRecord;
            EntitlementDuplicateBaseRecord = entitlementDuplicateBaseRecord;
            EntitlementAnnotations = entitlementAnnotations;
            EntitlementAsyncOperations = entitlementAsyncOperations;
            EntitlementBulkDeleteFailures = entitlementBulkDeleteFailures;
            CustomeridAccount = customeridAccount;
            EntitlementEntitlementchannelEntitlementId = entitlementEntitlementchannelEntitlementId;
            ProductEntitlementAssociation = productEntitlementAssociation;
            Entitlementtemplateid = entitlementtemplateid;
            Accountid = accountid;
            Contactid = contactid;
            Transactioncurrencyid = transactioncurrencyid;
            EntitlementSocialActivities = entitlementSocialActivities;
            Slaid = slaid;
            EntitlementcontactsAssociation = entitlementcontactsAssociation;
            CustomeridContact = customeridContact;
            EntitlementCases = entitlementCases;
            EntitlementSyncErrors = entitlementSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "decreaseremainingon")]
        public int? Decreaseremainingon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public object Startdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbaccesslevel")]
        public int? Kbaccesslevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public string Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public object Enddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restrictcasecreation")]
        public bool? Restrictcasecreation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allocationtypecode")]
        public int? Allocationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "remainingterms")]
        public object Remainingterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        public object Totalterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_entitlementtemplateid_value")]
        public string _entitlementtemplateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> EntitlementActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> EntitlementAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Emails")]
        public IList<MicrosoftDynamicsCRMemail> EntitlementEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> EntitlementFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Letters")]
        public IList<MicrosoftDynamicsCRMletter> EntitlementLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> EntitlementPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> EntitlementServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> EntitlementTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> EntitlementRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> EntitlementAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_entitlementchannel_EntitlementId")]
        public IList<MicrosoftDynamicsCRMentitlementchannel> EntitlementEntitlementchannelEntitlementId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlement_association")]
        public IList<MicrosoftDynamicsCRMproduct> ProductEntitlementAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public MicrosoftDynamicsCRMentitlementtemplate Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountid")]
        public MicrosoftDynamicsCRMaccount Accountid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public MicrosoftDynamicsCRMcontact Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> EntitlementSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementcontacts_association")]
        public IList<MicrosoftDynamicsCRMcontact> EntitlementcontactsAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_cases")]
        public IList<MicrosoftDynamicsCRMincident> EntitlementCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entitlement_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EntitlementSyncErrors { get; set; }

    }
}
