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
    
    public partial class typeofmusic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public typeofmusic()
        {
            this.cds = new HashSet<cd>();
        }
    
        public int type_id { get; set; }
        public string type_name { get; set; }
        public string type__descriptions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cd> cds { get; set; }
    }
}
