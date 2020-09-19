using FinalProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CartString : INotifyPropertyChanged
    {
        private RacquetString racquetString;
        private int quantity;
        private CultureInfo culture = new CultureInfo("en-US", false);

        public RacquetString String
        {
            get => racquetString;
            set
            {
                racquetString = value;
                Notify();
            }
        }
        public int StringQuantity
        {
            get => quantity;
            set
            {
                quantity = value;
                Notify();
            }
        }

        private void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
