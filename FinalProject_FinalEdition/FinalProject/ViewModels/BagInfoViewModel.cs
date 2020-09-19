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
    class BagInfoViewModel : INotifyPropertyChanged
    {
        Bag certainBag;

        #region Properties
        public MainViewModel MainViewModel { get; set; }
        public Bag CertainBag
        {
            get => certainBag;
            set
            {
                certainBag = value;
                Notify();
            }
        }
        #endregion

        public BagInfoViewModel() { }

        #region Notify
        void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
