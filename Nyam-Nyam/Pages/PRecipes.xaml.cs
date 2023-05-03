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
            var recipes = App.DB.Recipes.Where(r => r.DishId == dish.Id).ToList();
            DataContext = recipes;
        }
    }
}
