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
    
    public partial class TB_REPOUSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_REPOUSO()
        {
            this.TB_BRASSAGEM = new HashSet<TB_BRASSAGEM>();
        }
    
        public int ID_REPOUSO { get; set; }
        public int ID_TIPO_REPOUSO { get; set; }
        public Nullable<decimal> VL_TEMP { get; set; }
        public Nullable<System.DateTime> DT_HORA_INICIO { get; set; }
        public Nullable<System.DateTime> DT_HORA_FIM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_BRASSAGEM> TB_BRASSAGEM { get; set; }
        public virtual TB_TIPO_REPOUSO TB_TIPO_REPOUSO { get; set; }
    }
}
