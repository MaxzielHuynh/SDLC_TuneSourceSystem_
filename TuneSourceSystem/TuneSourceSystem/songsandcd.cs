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
    
    public partial class songsandcd
    {
        public string song_id { get; set; }
        public string cd_id { get; set; }
        public string note { get; set; }
    
        public virtual cd cd { get; set; }
        public virtual song song { get; set; }
    }
}