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
    
    public partial class cd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cd()
        {
            this.admins = new HashSet<admin>();
            this.songsandcds = new HashSet<songsandcd>();
        }
    
        public string cd_id { get; set; }
        public string cd_title { get; set; }
        public int cd_price { get; set; }
        public string cd_details { get; set; }
        public string cd_image { get; set; }
        public int cd_established { get; set; }
        public int type_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin> admins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<songsandcd> songsandcds { get; set; }
        public virtual typeofmusic typeofmusic { get; set; }
    }
}
