//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TuneSourceSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin()
        {
            this.giftcards = new HashSet<giftcard>();
        }
    
        public string admin_id { get; set; }
        public string admin_name { get; set; }
        public int admin_username { get; set; }
        public string admin_password { get; set; }
        public string customer_email { get; set; }
        public string customer_id { get; set; }
        public string purchase_id { get; set; }
        public string cd_id { get; set; }
        public string song_id { get; set; }
    
        public virtual cd cd { get; set; }
        public virtual customer customer { get; set; }
        public virtual song song { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giftcard> giftcards { get; set; }
    }
}
