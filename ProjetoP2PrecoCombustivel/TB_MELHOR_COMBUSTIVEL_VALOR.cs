//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoP2PrecoCombustivel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_MELHOR_COMBUSTIVEL_VALOR
    {
        public int ID { get; set; }
        public string tipoCombustivel { get; set; }
        public Nullable<int> id_estado { get; set; }
    
        public virtual TB_ESTADO TB_ESTADO { get; set; }
    }
}
