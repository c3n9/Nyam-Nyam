using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public partial class Ingredient : INotifyPropertyChanged
    {
        public int AvailableCountInStockPartial
        {
            get
            {
                return AvailableCountInStock;
            }
            set
            {
                AvailableCountInStock = value;
                OnPropertyChange();
            }
        }

        public void OnPropertyChange([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
    
}
