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
    
    public partial class giftcard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giftcard()
        {
            this.purchases = new HashSet<purchase>();
        }
    
        public string giftcard_number { get; set; }
        public string customer_id { get; set; }
        public string song_id { get; set; }
        public string admin_id { get; set; }
        public string customer_name { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual customer customer { get; set; }
        public virtual song song { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchase> purchases { get; set; }
    }
}