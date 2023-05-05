using Microsoft.Win32;
using Nyam_Nyam.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для PAddNewDish.xaml
    /// </summary>
    public partial class PAddNewDish : Page
    {
        Dish contextDish;
        public PAddNewDish(Dish dish)
        {
            InitializeComponent();
            contextDish = dish;
            DataContext = contextDish;
            CBCategory.ItemsSource = App.DB.Category.ToList();
            if(contextDish.Id == 0)
            {
                BDelete.Visibility = Visibility.Collapsed;
            }
        }

        private void BPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg|*.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault()) 
            { 
                var image = File.ReadAllBytes(dialog.FileName);
                contextDish.Photo = image;
                DataContext = null;
                DataContext = contextDish;
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            if (String.IsNullOrWhiteSpace(contextDish.Name))
                error += "Enter name\n";
            if (String.IsNullOrWhiteSpace(contextDish.Description))
                error += "Enter description\n";
            if (String.IsNullOrWhiteSpace(contextDish.SourceRecipeLink))
                error += "Enter source recipe link\n";
            if (String.IsNullOrWhiteSpace(contextDish.FinalPrice))
                error += "Enter final price\n";
            if (CBCategory.SelectedItem == null)
                error += "Select category\n";
            if (contextDish.Photo == null)
                error += "Load image\n";
            if (!String.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            var selectedCategory = CBCategory.SelectedItem as Category; 
            contextDish.CategoryId = selectedCategory.Id;
            if(contextDish.Id == 0)
            {
                App.DB.Dish.Add(contextDish);
            }
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Dish.Remove(contextDish);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}
