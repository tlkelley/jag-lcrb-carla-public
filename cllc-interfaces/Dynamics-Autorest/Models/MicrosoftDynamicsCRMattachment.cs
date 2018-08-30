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

    public partial class MicrosoftDynamicsCRMattachment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMattachment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMattachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMattachment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMattachment(string mimetype = default(string), string filename = default(string), string attachmentid = default(string), string body = default(string), object bodyBinary = default(object), int? filesize = default(int?), string subject = default(string), string versionnumber = default(string), IList<MicrosoftDynamicsCRMsyncerror> attachmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivitymimeattachment> attachmentActivityMimeAttachments = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>))
        {
            Mimetype = mimetype;
            Filename = filename;
            Attachmentid = attachmentid;
            Body = body;
            BodyBinary = bodyBinary;
            Filesize = filesize;
            Subject = subject;
            Versionnumber = versionnumber;
            AttachmentSyncErrors = attachmentSyncErrors;
            AttachmentActivityMimeAttachments = attachmentActivityMimeAttachments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachmentid")]
        public string Attachmentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body_binary")]
        public object BodyBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public int? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attachment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AttachmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachment_activity_mime_attachments")]
        public IList<MicrosoftDynamicsCRMactivitymimeattachment> AttachmentActivityMimeAttachments { get; set; }

    }
}
