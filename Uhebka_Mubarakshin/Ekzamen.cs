//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhebka_Mubarakshin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ekzamen
    {
        public int Kod_Ekazmena { get; set; }
        public System.DateTime Data { get; set; }
        public int Kod_Disciplina { get; set; }
        public int Reg_Nomer_Student { get; set; }
        public int Tab_Nomer_Prepoda { get; set; }
        public string Auditoria { get; set; }
        public int Ocenka { get; set; }
    
        public virtual Disciplina Disciplina { get; set; }
        public virtual Prepodovatel Prepodovatel { get; set; }
        public virtual Student Student { get; set; }
    }
}