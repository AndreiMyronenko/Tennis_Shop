using FinalProject.DAL.Models;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProject.ViewModels
{
    class InfoViewModel : INotifyPropertyChanged
    { 
        Racquet certainRacquet;

        #region Properties
        public MainViewModel MainViewModel { get; set; }
        public Racquet CertainRacquet
        {
            get => certainRacquet;
            set
            {
                certainRacquet = value;
                Notify();
            }
        }
        #endregion

        public InfoViewModel() { }

        #region Notify
        void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
