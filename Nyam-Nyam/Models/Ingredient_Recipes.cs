//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nyam_Nyam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient_Recipes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient_Recipes()
        {
            this.Recipes = new HashSet<Recipes>();
        }
    
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipesId { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipes> Recipes { get; set; }
    }
}