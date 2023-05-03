﻿using Nyam_Nyam.Models;
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
    /// Логика взаимодействия для PDishes.xaml
    /// </summary>
    public partial class PDishes : Page
    {
        public PDishes()
        {
            InitializeComponent();
            Refresh();
            var category = App.DB.Category.ToList();
            category.Insert(0, new Category() { Name = "View all" });
            CBCategory.ItemsSource = category;
            CBCategory.SelectedIndex = 0;
        }

        private void AddNewdish_Click(object sender, RoutedEventArgs e)
        {
            var dish = LVDishes.SelectedItem as Dish;
            if(dish == null)
                NavigationService.Navigate(new PAddNewDish(new Dish()));
            else if(dish != null)
                NavigationService.Navigate(new PAddNewDish(dish));
        }
        private void Refresh()
        {
            var filtred = App.DB.Dish.ToList();
            var selectedCategory = CBCategory.SelectedItem as Category;
            var searchText = TBSurch.Text.ToLower();
            if (selectedCategory != null && selectedCategory.Id != 0)
                filtred = filtred.Where(d => d.CategoryId == selectedCategory.Id).ToList();
            if (string.IsNullOrWhiteSpace(searchText) == false)
                filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText) || f.Description.ToLower().Contains(searchText)).ToList();
            LVDishes.ItemsSource = filtred;
        }

        private void CBCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void TBSurch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
