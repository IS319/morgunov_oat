//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Разговоры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Разговоры()
        {
            this.Телефоны_абонентов = new HashSet<Телефоны_абонентов>();
        }
    
        public int Код_разговора { get; set; }
        public Nullable<int> Код_ТелефонаАбонента { get; set; }
        public Nullable<int> Код_города { get; set; }
        public Nullable<System.DateTime> Дата_разговора { get; set; }
        public Nullable<int> Время_разговора { get; set; }
        public string Оплата { get; set; }
    
        public virtual Город Город { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Телефоны_абонентов> Телефоны_абонентов { get; set; }
    }
}
