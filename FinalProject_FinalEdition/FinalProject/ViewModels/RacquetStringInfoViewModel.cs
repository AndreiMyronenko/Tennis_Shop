using FinalProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    class RacquetStringInfoViewModel : INotifyPropertyChanged
    {
        RacquetString certainString;

        #region Properties
        public MainViewModel MainViewModel { get; set; }
        public RacquetString CertainString
        {
            get => certainString;
            set
            {
                certainString = value;
                Notify();
            }
        }
        #endregion

        public RacquetStringInfoViewModel() { }

        #region Notify
        void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
