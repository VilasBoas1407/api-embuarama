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
    
    public partial class TB_MOSTO_PRIMARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MOSTO_PRIMARIO()
        {
            this.TB_BRASSAGEM = new HashSet<TB_BRASSAGEM>();
        }
    
        public int ID_MOSTO_PRIMARIO { get; set; }
        public Nullable<System.DateTime> HR_INICIO_MOSTO { get; set; }
        public Nullable<System.DateTime> HR_TERMINIO_MOSTO { get; set; }
        public Nullable<decimal> VL_VAZAO_MEDIA_REAL { get; set; }
        public Nullable<decimal> VL_VAZAO_MEDIA_IDEAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_BRASSAGEM> TB_BRASSAGEM { get; set; }
    }
}
