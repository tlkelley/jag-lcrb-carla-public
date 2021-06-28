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

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_auctionpermit
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioAuctionpermit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAuctionpermit class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAuctionpermit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAuctionpermit class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAuctionpermit(string _createdonbehalfbyValue = default(string), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? adoxioIsreportreceived = default(bool?), string _owninguserValue = default(string), string adoxioEmail = default(string), decimal? adoxioBeerquantity = default(decimal?), string _owningteamValue = default(string), string adoxioEventlocation = default(string), System.DateTimeOffset? adoxioEventenddate = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statuscode = default(int?), string _createdbyValue = default(string), int? statecode = default(int?), string adoxioResponsibleindividual = default(string), string adoxioPhonenumber = default(string), string adoxioPositioninorg = default(string), int? utcconversiontimezonecode = default(int?), decimal? adoxioWinequantity = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), string adoxioAuctionpermitid = default(string), decimal? adoxioSpiritsquantity = default(decimal?), string adoxioPermitholder = default(string), System.DateTimeOffset? adoxioEventstartdate = default(System.DateTimeOffset?), string adoxioRecipientoffunds = default(string), string _owneridValue = default(string), int? timezoneruleversionnumber = default(int?), string adoxioPermitnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioAuctionpermitSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioAuctionpermitAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioAuctionpermitMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioAuctionpermitProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioAuctionpermitBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioAuctionpermitPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMqueueitem> adoxioAuctionpermitQueueItems = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMadoxioAuctionpermitschedule> adoxioAuctionpermitPermitschedules = default(IList<MicrosoftDynamicsCRMadoxioAuctionpermitschedule>))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Createdon = createdon;
            AdoxioIsreportreceived = adoxioIsreportreceived;
            this._owninguserValue = _owninguserValue;
            AdoxioEmail = adoxioEmail;
            AdoxioBeerquantity = adoxioBeerquantity;
            this._owningteamValue = _owningteamValue;
            AdoxioEventlocation = adoxioEventlocation;
            AdoxioEventenddate = adoxioEventenddate;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            AdoxioResponsibleindividual = adoxioResponsibleindividual;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioPositioninorg = adoxioPositioninorg;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioWinequantity = adoxioWinequantity;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            AdoxioAuctionpermitid = adoxioAuctionpermitid;
            AdoxioSpiritsquantity = adoxioSpiritsquantity;
            AdoxioPermitholder = adoxioPermitholder;
            AdoxioEventstartdate = adoxioEventstartdate;
            AdoxioRecipientoffunds = adoxioRecipientoffunds;
            this._owneridValue = _owneridValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioPermitnumber = adoxioPermitnumber;
            Overriddencreatedon = overriddencreatedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioAuctionpermitSyncErrors = adoxioAuctionpermitSyncErrors;
            AdoxioAuctionpermitAsyncOperations = adoxioAuctionpermitAsyncOperations;
            AdoxioAuctionpermitMailboxTrackingFolders = adoxioAuctionpermitMailboxTrackingFolders;
            AdoxioAuctionpermitProcessSession = adoxioAuctionpermitProcessSession;
            AdoxioAuctionpermitBulkDeleteFailures = adoxioAuctionpermitBulkDeleteFailures;
            AdoxioAuctionpermitPrincipalObjectAttributeAccesses = adoxioAuctionpermitPrincipalObjectAttributeAccesses;
            AdoxioAuctionpermitQueueItems = adoxioAuctionpermitQueueItems;
            AdoxioAuctionpermitPermitschedules = adoxioAuctionpermitPermitschedules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isreportreceived")]
        public bool? AdoxioIsreportreceived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_beerquantity")]
        public decimal? AdoxioBeerquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventlocation")]
        public string AdoxioEventlocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventenddate")]
        public System.DateTimeOffset? AdoxioEventenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsibleindividual")]
        public string AdoxioResponsibleindividual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_positioninorg")]
        public string AdoxioPositioninorg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_winequantity")]
        public decimal? AdoxioWinequantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermitid")]
        public string AdoxioAuctionpermitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spiritsquantity")]
        public decimal? AdoxioSpiritsquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_permitholder")]
        public string AdoxioPermitholder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_eventstartdate")]
        public System.DateTimeOffset? AdoxioEventstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recipientoffunds")]
        public string AdoxioRecipientoffunds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_permitnumber")]
        public string AdoxioPermitnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_auctionpermit_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioAuctionpermitSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioAuctionpermitAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioAuctionpermitMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioAuctionpermitProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioAuctionpermitBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioAuctionpermitPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_QueueItems")]
        public IList<MicrosoftDynamicsCRMqueueitem> AdoxioAuctionpermitQueueItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_auctionpermit_permitschedules")]
        public IList<MicrosoftDynamicsCRMadoxioAuctionpermitschedule> AdoxioAuctionpermitPermitschedules { get; set; }

    }
}
