//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceASU1.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clients()
        {
            this.Records = new HashSet<Records>();
        }
    
        public int idClient { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronomic { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public System.DateTime DateBirthday { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateRegistraion { get; set; }
    
        public virtual Sex Sex1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Records> Records { get; set; }
    }
}