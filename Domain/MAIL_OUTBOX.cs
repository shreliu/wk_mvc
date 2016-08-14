//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAIL_OUTBOX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAIL_OUTBOX()
        {
            this.MAIL_ATTACHMENT = new HashSet<MAIL_ATTACHMENT>();
            this.MAIL_INBOX = new HashSet<MAIL_INBOX>();
        }
    
        public int ID { get; set; }
        public string FK_RELATIONID { get; set; }
        public string FK_UserId { get; set; }
        public string ToUser { get; set; }
        public string MailTitle { get; set; }
        public int SendStatus { get; set; }
        public int MailType { get; set; }
        public System.DateTime SendDate { get; set; }
        public System.DateTime SaveDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAIL_ATTACHMENT> MAIL_ATTACHMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAIL_INBOX> MAIL_INBOX { get; set; }
    }
}