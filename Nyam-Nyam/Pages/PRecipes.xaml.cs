using Nyam_Nyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nyam_Nyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для PRecipes.xaml
    /// </summary>
    public partial class PRecipes : Page
    {
        public PRecipes(Dish dish)
        {
            InitializeComponent();
            var recipes = App.DB.RecipeSteps.Where(r => r.DishId == dish.Id).ToList();
            DataContext = dish;
            var v = dish.RecipeSteps.SelectMany(s => s.Ingredient_RecipeSteps.Select(d => d.Ingredient)).ToList();
            DGIngredient.ItemsSource = v;
            LVRecipesStep.ItemsSource = dish.RecipeSteps.ToList();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
