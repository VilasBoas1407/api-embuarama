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
    
    public partial class TB_REGISTRO_LAVAGEM
    {
        public int ID_REGISTRO_LAVAGEM { get; set; }
        public int ID_BRASSAGEM { get; set; }
        public Nullable<int> NR_LAVAGEM { get; set; }
        public Nullable<decimal> VL_TEMP_AGUA { get; set; }
        public Nullable<decimal> VL_VOLUME_AGUA { get; set; }
        public Nullable<System.DateTime> HR_INICIO_LAVAGEM { get; set; }
        public Nullable<System.DateTime> HR_FIM_LAVAGEM { get; set; }
        public Nullable<decimal> VL_VOLUME_LAVAGEM { get; set; }
        public Nullable<decimal> VL_EXTRATO_LAVAGEM { get; set; }
        public Nullable<decimal> VL_VAZAO_MEDIA_IDEAL { get; set; }
        public Nullable<decimal> VL_RAZAO_MEDIA_REAL { get; set; }
    
        public virtual TB_BRASSAGEM TB_BRASSAGEM { get; set; }
    }
}