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
    
    public partial class song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public song()
        {
            this.admins = new HashSet<admin>();
            this.giftcards = new HashSet<giftcard>();
            this.songsandcds = new HashSet<songsandcd>();
        }
    
        public string song_id { get; set; }
        public string song_name { get; set; }
        public string song_authors { get; set; }
        public string song_lyrics { get; set; }
        public Nullable<int> song_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin> admins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giftcard> giftcards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<songsandcd> songsandcds { get; set; }
    }
}
