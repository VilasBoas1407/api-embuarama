//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_TIPO_REPOUSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TIPO_REPOUSO()
        {
            this.TB_REPOUSO = new HashSet<TB_REPOUSO>();
        }
    
        public int ID_TIPO_REPOUSO { get; set; }
        public string DS_TIPO_REPOUSO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_REPOUSO> TB_REPOUSO { get; set; }
    }
}