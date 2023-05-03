using Nyam_Nyam.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Nyam_Nyam
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NyamNyamEntities DB = new NyamNyamEntities();
        public static MainWindow MainWindowInstance;
    }
}
