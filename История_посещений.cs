//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Прокат
{
    using System;
    using System.Collections.Generic;
    
    public partial class История_посещений
    {
        public int Код_авторизации { get; set; }
        public int Код_сотрудника { get; set; }
        public string Последний_вход { get; set; }
        public string Тип_входа { get; set; }
    
        public virtual Пользователи Пользователи { get; set; }
    }
}
