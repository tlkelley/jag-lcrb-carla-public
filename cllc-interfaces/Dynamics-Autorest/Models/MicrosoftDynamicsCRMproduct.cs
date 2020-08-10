// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.product
    /// </summary>
    public partial class MicrosoftDynamicsCRMproduct
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMproduct
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMproduct
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMproduct(string entityimageid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? standardcost = default(decimal?), decimal? stockweight = default(decimal?), string hierarchypath = default(string), int? productstructure = default(int?), int? importsequencenumber = default(int?), string _organizationidValue = default(string), string _defaultuomscheduleidValue = default(string), string producturl = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), decimal? stockvolume = default(decimal?), string _modifiedbyValue = default(string), decimal? quantityonhand = default(decimal?), decimal? currentcostBase = default(decimal?), bool? isstockitem = default(bool?), string _pricelevelidValue = default(string), int? statecode = default(int?), string traversedpath = default(string), string _createdbyValue = default(string), string _createdbyexternalpartyValue = default(string), decimal? standardcostBase = default(decimal?), int? dmtimportstate = default(int?), System.DateTimeOffset? validfromdate = default(System.DateTimeOffset?), decimal? currentcost = default(decimal?), decimal? price = default(decimal?), int? quantitydecimal = default(int?), string _createdonbehalfbyValue = default(string), string suppliername = default(string), string _subjectidValue = default(string), string vendorname = default(string), string _parentproductidValue = default(string), string description = default(string), string size = default(string), string _modifiedonbehalfbyValue = default(string), long? entityimageTimestamp = default(long?), int? timezoneruleversionnumber = default(int?), decimal? exchangerate = default(decimal?), string stageid = default(string), string name = default(string), int? producttypecode = default(int?), bool? iskit = default(bool?), string versionnumber = default(string), string processid = default(string), string vendorid = default(string), string vendorpartnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? validtodate = default(System.DateTimeOffset?), byte[] entityimage = default(byte[]), string entityimageUrl = default(string), string productid = default(string), string _defaultuomidValue = default(string), int? statuscode = default(int?), string _modifiedbyexternalpartyValue = default(string), string productnumber = default(string), int? utcconversiontimezonecode = default(int?), decimal? priceBase = default(decimal?), IList<MicrosoftDynamicsCRMcampaign> campaignproductAssociation = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMlead> leadproductAssociation = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMcompetitor> competitorproductAssociation = default(IList<MicrosoftDynamicsCRMcompetitor>), IList<MicrosoftDynamicsCRMsalesliterature> productsalesliteratureAssociation = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMproductassociation> productProductAssociationAssocProd = default(IList<MicrosoftDynamicsCRMproductassociation>), IList<MicrosoftDynamicsCRMproductsubstitute> productProductSubstituteProductid = default(IList<MicrosoftDynamicsCRMproductsubstitute>), IList<MicrosoftDynamicsCRMproductsubstitute> productProductSubstituteSubstitutedproductid = default(IList<MicrosoftDynamicsCRMproductsubstitute>), IList<MicrosoftDynamicsCRMentitlement> productEntitlementAssociation = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioProductAdoxioLicencetypeApplicationFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioProductAdoxioLicencetypeLicenceFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioProductAdoxioApplicationtypeApplicationFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>), IList<MicrosoftDynamicsCRMteam> productTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> productMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule> adoxioProductAdoxioApplicationtypefeescheduleFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule>), IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> adoxioProductAdoxioLicencesubcategoryLicenceFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioLicencesubcategory>), IList<MicrosoftDynamicsCRMopportunityproduct> opportunityProducts = default(IList<MicrosoftDynamicsCRMopportunityproduct>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> productSharepointDocumentLocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMincident> productIncidents = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMquotedetail> productQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), MicrosoftDynamicsCRMuomschedule defaultuomscheduleid = default(MicrosoftDynamicsCRMuomschedule), IList<MicrosoftDynamicsCRMbulkdeletefailure> productBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMentitlementtemplate> productEntitlementtemplateAssociation = default(IList<MicrosoftDynamicsCRMentitlementtemplate>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMinvoicedetail> productInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMproductassociation> productProductAssociationProd = default(IList<MicrosoftDynamicsCRMproductassociation>), MicrosoftDynamicsCRMuom defaultuomid = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMdynamicproperty> productDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), IList<MicrosoftDynamicsCRMconnection> productConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> productSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMconnection> productConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> productAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMproduct parentproductid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMproduct> productParentProduct = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMprocesssession> productProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> productPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMcontractdetail> productContractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsalesorderdetail> productOrderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMproductpricelevel> productPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), MicrosoftDynamicsCRMsubject subjectid = default(MicrosoftDynamicsCRMsubject), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMannotation> productAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> productDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioApplicationtype> adoxioProductAdoxioApplicationtypeFYLicenceFeeProduct = default(IList<MicrosoftDynamicsCRMadoxioApplicationtype>))
        {
            Entityimageid = entityimageid;
            Overriddencreatedon = overriddencreatedon;
            Standardcost = standardcost;
            Stockweight = stockweight;
            Hierarchypath = hierarchypath;
            Productstructure = productstructure;
            Importsequencenumber = importsequencenumber;
            this._organizationidValue = _organizationidValue;
            this._defaultuomscheduleidValue = _defaultuomscheduleidValue;
            Producturl = producturl;
            Createdon = createdon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Stockvolume = stockvolume;
            this._modifiedbyValue = _modifiedbyValue;
            Quantityonhand = quantityonhand;
            CurrentcostBase = currentcostBase;
            Isstockitem = isstockitem;
            this._pricelevelidValue = _pricelevelidValue;
            Statecode = statecode;
            Traversedpath = traversedpath;
            this._createdbyValue = _createdbyValue;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            StandardcostBase = standardcostBase;
            Dmtimportstate = dmtimportstate;
            Validfromdate = validfromdate;
            Currentcost = currentcost;
            Price = price;
            Quantitydecimal = quantitydecimal;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Suppliername = suppliername;
            this._subjectidValue = _subjectidValue;
            Vendorname = vendorname;
            this._parentproductidValue = _parentproductidValue;
            Description = description;
            Size = size;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            EntityimageTimestamp = entityimageTimestamp;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Exchangerate = exchangerate;
            Stageid = stageid;
            Name = name;
            Producttypecode = producttypecode;
            Iskit = iskit;
            Versionnumber = versionnumber;
            Processid = processid;
            Vendorid = vendorid;
            Vendorpartnumber = vendorpartnumber;
            Modifiedon = modifiedon;
            Validtodate = validtodate;
            Entityimage = entityimage;
            EntityimageUrl = entityimageUrl;
            Productid = productid;
            this._defaultuomidValue = _defaultuomidValue;
            Statuscode = statuscode;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Productnumber = productnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            PriceBase = priceBase;
            CampaignproductAssociation = campaignproductAssociation;
            LeadproductAssociation = leadproductAssociation;
            CompetitorproductAssociation = competitorproductAssociation;
            ProductsalesliteratureAssociation = productsalesliteratureAssociation;
            ProductProductAssociationAssocProd = productProductAssociationAssocProd;
            ProductProductSubstituteProductid = productProductSubstituteProductid;
            ProductProductSubstituteSubstitutedproductid = productProductSubstituteSubstitutedproductid;
            ProductEntitlementAssociation = productEntitlementAssociation;
            AdoxioProductAdoxioLicencetypeApplicationFeeProduct = adoxioProductAdoxioLicencetypeApplicationFeeProduct;
            AdoxioProductAdoxioLicencetypeLicenceFeeProduct = adoxioProductAdoxioLicencetypeLicenceFeeProduct;
            AdoxioProductAdoxioApplicationtypeApplicationFeeProduct = adoxioProductAdoxioApplicationtypeApplicationFeeProduct;
            ProductTeams = productTeams;
            ProductMailboxTrackingFolders = productMailboxTrackingFolders;
            AdoxioProductAdoxioApplicationtypefeescheduleFeeProduct = adoxioProductAdoxioApplicationtypefeescheduleFeeProduct;
            AdoxioProductAdoxioLicencesubcategoryLicenceFeeProduct = adoxioProductAdoxioLicencesubcategoryLicenceFeeProduct;
            OpportunityProducts = opportunityProducts;
            ProductSharepointDocumentLocation = productSharepointDocumentLocation;
            ProductIncidents = productIncidents;
            ProductQuoteDetails = productQuoteDetails;
            Defaultuomscheduleid = defaultuomscheduleid;
            ProductBulkDeleteFailures = productBulkDeleteFailures;
            ProductEntitlementtemplateAssociation = productEntitlementtemplateAssociation;
            Createdby = createdby;
            ProductInvoiceDetails = productInvoiceDetails;
            ProductProductAssociationProd = productProductAssociationProd;
            Defaultuomid = defaultuomid;
            ProductDynamicProperty = productDynamicProperty;
            ProductConnections2 = productConnections2;
            Pricelevelid = pricelevelid;
            Createdonbehalfby = createdonbehalfby;
            ProductSyncErrors = productSyncErrors;
            ProductConnections1 = productConnections1;
            ProductAsyncOperations = productAsyncOperations;
            StageidProcessstage = stageidProcessstage;
            Parentproductid = parentproductid;
            ProductParentProduct = productParentProduct;
            ProductProcessSessions = productProcessSessions;
            ProductPrincipalobjectattributeaccess = productPrincipalobjectattributeaccess;
            ProductContractLineItems = productContractLineItems;
            Transactioncurrencyid = transactioncurrencyid;
            ProductOrderDetails = productOrderDetails;
            ProductPriceLevels = productPriceLevels;
            Subjectid = subjectid;
            Modifiedby = modifiedby;
            ProductAnnotation = productAnnotation;
            ProductDynamicPropertyAssociation = productDynamicPropertyAssociation;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            AdoxioProductAdoxioApplicationtypeFYLicenceFeeProduct = adoxioProductAdoxioApplicationtypeFYLicenceFeeProduct;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardcost")]
        public decimal? Standardcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stockweight")]
        public decimal? Stockweight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hierarchypath")]
        public string Hierarchypath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productstructure")]
        public int? Productstructure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultuomscheduleid_value")]
        public string _defaultuomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producturl")]
        public string Producturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stockvolume")]
        public decimal? Stockvolume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityonhand")]
        public decimal? Quantityonhand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentcost_base")]
        public decimal? CurrentcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isstockitem")]
        public bool? Isstockitem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardcost_base")]
        public decimal? StandardcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validfromdate")]
        public System.DateTimeOffset? Validfromdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentcost")]
        public decimal? Currentcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitydecimal")]
        public int? Quantitydecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suppliername")]
        public string Suppliername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_subjectid_value")]
        public string _subjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorname")]
        public string Vendorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentproductid_value")]
        public string _parentproductidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iskit")]
        public bool? Iskit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorid")]
        public string Vendorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorpartnumber")]
        public string Vendorpartnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validtodate")]
        public System.DateTimeOffset? Validtodate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public string Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultuomid_value")]
        public string _defaultuomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_base")]
        public decimal? PriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignproduct_association")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaignproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadproduct_association")]
        public IList<MicrosoftDynamicsCRMlead> LeadproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_association")]
        public IList<MicrosoftDynamicsCRMcompetitor> CompetitorproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productsalesliterature_association")]
        public IList<MicrosoftDynamicsCRMsalesliterature> ProductsalesliteratureAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProductAssociation_AssocProd")]
        public IList<MicrosoftDynamicsCRMproductassociation> ProductProductAssociationAssocProd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_ProductSubstitute_productid")]
        public IList<MicrosoftDynamicsCRMproductsubstitute> ProductProductSubstituteProductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_ProductSubstitute_substitutedproductid")]
        public IList<MicrosoftDynamicsCRMproductsubstitute> ProductProductSubstituteSubstitutedproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlement_association")]
        public IList<MicrosoftDynamicsCRMentitlement> ProductEntitlementAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_licencetype_ApplicationFeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioProductAdoxioLicencetypeApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_licencetype_LicenceFeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioProductAdoxioLicencetypeLicenceFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_applicationtype_ApplicationFeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioProductAdoxioApplicationtypeApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_Teams")]
        public IList<MicrosoftDynamicsCRMteam> ProductTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ProductMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_applicationtypefeeschedule_FeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtypefeeschedule> AdoxioProductAdoxioApplicationtypefeescheduleFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_licencesubcategory_LicenceFeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioLicencesubcategory> AdoxioProductAdoxioLicencesubcategoryLicenceFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunity_products")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> OpportunityProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_SharepointDocumentLocation")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ProductSharepointDocumentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_incidents")]
        public IList<MicrosoftDynamicsCRMincident> ProductIncidents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> ProductQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultuomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Defaultuomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlementtemplate_association")]
        public IList<MicrosoftDynamicsCRMentitlementtemplate> ProductEntitlementtemplateAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> ProductInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProductAssociation_Prod")]
        public IList<MicrosoftDynamicsCRMproductassociation> ProductProductAssociationProd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultuomid")]
        public MicrosoftDynamicsCRMuom Defaultuomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> ProductDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ProductConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ProductConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentproductid")]
        public MicrosoftDynamicsCRMproduct Parentproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_parent_product")]
        public IList<MicrosoftDynamicsCRMproduct> ProductParentProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ProductProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ProductPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ProductContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> ProductOrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> ProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectid")]
        public MicrosoftDynamicsCRMsubject Subjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ProductAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> ProductDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_product_adoxio_applicationtype_FYLicenceFeeProduct")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtype> AdoxioProductAdoxioApplicationtypeFYLicenceFeeProduct { get; set; }

    }
}
