﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NyamNyamEntities : DbContext
    {
        public NyamNyamEntities()
            : base("name=NyamNyamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Ingredient_Recipes> Ingredient_Recipes { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
