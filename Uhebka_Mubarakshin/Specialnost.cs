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
    
    public partial class Specialnost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialnost()
        {
            this.Student = new HashSet<Student>();
            this.Zaiavka = new HashSet<Zaiavka>();
        }
    
        public string Nomer_spec { get; set; }
        public string Napravlenie { get; set; }
        public string Shifr { get; set; }
    
        public virtual Kafedra Kafedra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zaiavka> Zaiavka { get; set; }
    }
}