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
    
    public partial class TB_MOAGEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MOAGEM()
        {
            this.TB_BRASSAGEM_MOAGEM = new HashSet<TB_BRASSAGEM_MOAGEM>();
        }
    
        public int ID_MOAGEM { get; set; }
        public int ID_TIPO_MALTE { get; set; }
        public string DS_QUANT_MALTE { get; set; }
        public string DS_REND_MALTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_BRASSAGEM_MOAGEM> TB_BRASSAGEM_MOAGEM { get; set; }
        public virtual TB_TIPO_MALTE TB_TIPO_MALTE { get; set; }
    }
}
