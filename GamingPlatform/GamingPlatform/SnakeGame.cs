//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamingPlatform
{
    using System;
    using System.Collections.Generic;
    
    public partial class SnakeGame
    {
        public int ID { get; set; }
        public Nullable<int> IDUser { get; set; }
        public Nullable<int> BestScore { get; set; }
    
        public virtual Player Player { get; set; }
    }
}