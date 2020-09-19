using Caliburn.Micro;
using FinalProject.DAL.Models;
using FinalProject.DAL.Repositories;
using FinalProject.Infra;
using FinalProject.Models;
using FinalProject.Services;
using FinalProject.Views;
using LinqKit;
using MahApps.Metro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace FinalProject.ViewModels
{
    public class MainViewModel : Screen
    {
        #region Parameters
        private int selectedComboBoxItem = -1;
        private int selectedComboBoxItem1 = -1;
        private int selectedComboBoxItem2 = -1;
        private Racquet selectedRacquet;
        private Manufacturer selectedManufacturer;
        private Bag selectedBag;
        private RacquetString selectedRacquetString;
        private List<Racquet> racquets;
        private List<Racquet> racquetsCopy;
        private List<Manufacturer> manufacturers;
        private List<Bag> bags;
        private List<RacquetString> racquetStrings;
        private List<Bag> bagsCopy;
        private List<RacquetString> racquetStringsCopy;
        private bool isChecked1;
        private bool isChecked2;
        private bool isChecked3;
        private bool isChecked4;
        private bool isChecked5;
        private bool isChecked6;
        private bool isChecked7;
        private bool isChecked8;
        private bool isChecked9;
        private bool isChecked10;
        private bool isChecked11;
        private bool isChecked12;
        private bool isRadio1;
        private bool isRadio2;
        private bool isRadio3;
        private bool isRadio4;
        private bool isRadio5;
        private bool isRadio6;
        private bool isRadio7;
        private bool isRadio8;
        private bool isRadio9;
        private bool isRadio10;
        private bool isRadio11;
        private bool isRadio12;
        private ObservableCollection<CartRacquet> racquetLines = new ObservableCollection<CartRacquet>();
        private CartRacquet selectedCartRacquet;
        private ObservableCollection<CartBag> bagLines = new ObservableCollection<CartBag>();
        private CartBag selectedCartBag;
        private ObservableCollection<CartString> stringLines = new ObservableCollection<CartString>();
        private CartString selectedCartString;
        private string textRacquet;
        private string textRacquetVisibility = "Collapsed";
        private string gridRacquetVisibility = "Visible";
        private string textBag;
        private string textBagVisibility = "Collapsed";
        private string gridBagVisibility = "Visible";
        private string textString;
        private string textStringVisibility = "Collapsed";
        private string gridStringVisibility = "Visible";
        #endregion

        #region Properties
        public RacquetRepository RacquetRepository { get; set; } = new RacquetRepository();
        public BagRepository BagRepository { get; set; } = new BagRepository();
        public RacquetStringRepository RacquetStringRepository { get; set; } = new RacquetStringRepository();
        public ManufacturerRepository ManufacturerRepository { get; set; } = new ManufacturerRepository();

        public int SelectedComboBoxItem 
        {
            get => selectedComboBoxItem;
            set
            {
                selectedComboBoxItem = value;
                NotifyOfPropertyChange(() => SelectedComboBoxItem);
            }
        }

        public int SelectedComboBoxItem1
        {
            get => selectedComboBoxItem1;
            set
            {
                selectedComboBoxItem1 = value;
                NotifyOfPropertyChange(() => SelectedComboBoxItem1);
            }
        }

        public int SelectedComboBoxItem2
        {
            get => selectedComboBoxItem2;
            set
            {
                selectedComboBoxItem2 = value;
                NotifyOfPropertyChange(() => SelectedComboBoxItem2);
            }
        }

        public Racquet SelectedRacquet
        {
            get => selectedRacquet;
            set
            {
                selectedRacquet = value;
                NotifyOfPropertyChange(() => SelectedRacquet);
            }
        }

        public Manufacturer SelectedManufacturer
        {
            get => selectedManufacturer;
            set
            {
                selectedManufacturer = value;
                NotifyOfPropertyChange(() => SelectedManufacturer);
            }
        }

        public Bag SelectedBag
        {
            get => selectedBag;
            set
            {
                selectedBag = value;
                NotifyOfPropertyChange(() => SelectedBag);
            }
        }

        public RacquetString SelectedRacquetString
        {
            get => selectedRacquetString;
            set
            {
                selectedRacquetString = value;
                NotifyOfPropertyChange(() => SelectedRacquetString);
            }
        }

        public List<Racquet> Racquets
        {
            get => racquets;
            set
            {
                racquets = value;
                NotifyOfPropertyChange(() => Racquets);
            }
        }

        public List<Manufacturer> Manufacturers
        {
            get => manufacturers;
            set
            {
                manufacturers = value;
                NotifyOfPropertyChange(() => Manufacturers);
            }
        }

        public List<Bag> Bags
        {
            get => bags;
            set
            {
                bags = value;
                NotifyOfPropertyChange(() => Bags);
            }
        }

        public List<RacquetString> RacquetStrings
        {
            get => racquetStrings;
            set
            {
                racquetStrings = value;
                NotifyOfPropertyChange(() => RacquetStrings);
            }
        }

        public bool IsChecked1
        {
            get => isChecked1;
            set
            {
                isChecked1 = value;
                NotifyOfPropertyChange(() => IsChecked1);
            }
        }
        public bool IsChecked2
        {
            get => isChecked2;
            set
            {
                isChecked2 = value;
                NotifyOfPropertyChange(() => IsChecked2);
            }
        }
        public bool IsChecked3
        {
            get => isChecked3;
            set
            {
                isChecked3 = value;
                NotifyOfPropertyChange(() => IsChecked3);
            }
        }
        public bool IsChecked4
        {
            get => isChecked4;
            set
            {
                isChecked4 = value;
                NotifyOfPropertyChange(() => IsChecked4);
            }
        }

        public bool IsChecked5
        {
            get => isChecked5;
            set
            {
                isChecked5 = value;
                NotifyOfPropertyChange(() => IsChecked5);
            }
        }
        public bool IsChecked6
        {
            get => isChecked6;
            set
            {
                isChecked6 = value;
                NotifyOfPropertyChange(() => IsChecked6);
            }
        }
        public bool IsChecked7
        {
            get => isChecked7;
            set
            {
                isChecked7 = value;
                NotifyOfPropertyChange(() => IsChecked7);
            }
        }
        public bool IsChecked8
        {
            get => isChecked8;
            set
            {
                isChecked8 = value;
                NotifyOfPropertyChange(() => IsChecked8);
            }
        }

        public bool IsChecked9
        {
            get => isChecked9;
            set
            {
                isChecked9 = value;
                NotifyOfPropertyChange(() => IsChecked9);
            }
        }
        public bool IsChecked10
        {
            get => isChecked10;
            set
            {
                isChecked10 = value;
                NotifyOfPropertyChange(() => IsChecked10);
            }
        }
        public bool IsChecked11
        {
            get => isChecked11;
            set
            {
                isChecked11 = value;
                NotifyOfPropertyChange(() => IsChecked11);
            }
        }
        public bool IsChecked12
        {
            get => isChecked12;
            set
            {
                isChecked12 = value;
                NotifyOfPropertyChange(() => IsChecked12);
            }
        }

        public bool IsRadio1
        {
            get => isRadio1;
            set
            {
                isRadio1 = value;
                NotifyOfPropertyChange(() => IsRadio1);
            }
        }

        public bool IsRadio2
        {
            get => isRadio2;
            set
            {
                isRadio2 = value;
                NotifyOfPropertyChange(() => IsRadio2);
            }
        }

        public bool IsRadio3
        {
            get => isRadio3;
            set
            {
                isRadio3 = value;
                NotifyOfPropertyChange(() => IsRadio3);
            }
        }

        public bool IsRadio4
        {
            get => isRadio4;
            set
            {
                isRadio4 = value;
                NotifyOfPropertyChange(() => IsRadio4);
            }
        }

        public bool IsRadio5
        {
            get => isRadio5;
            set
            {
                isRadio5 = value;
                NotifyOfPropertyChange(() => IsRadio5);
            }
        }

        public bool IsRadio6
        {
            get => isRadio6;
            set
            {
                isRadio6 = value;
                NotifyOfPropertyChange(() => IsRadio6);
            }
        }

        public bool IsRadio7
        {
            get => isRadio7;
            set
            {
                isRadio7 = value;
                NotifyOfPropertyChange(() => IsRadio7);
            }
        }

        public bool IsRadio8
        {
            get => isRadio8;
            set
            {
                isRadio8 = value;
                NotifyOfPropertyChange(() => IsRadio8);
            }
        }

        public bool IsRadio9
        {
            get => isRadio9;
            set
            {
                isRadio9 = value;
                NotifyOfPropertyChange(() => IsRadio9);
            }
        }

        public bool IsRadio10
        {
            get => isRadio10;
            set
            {
                isRadio10 = value;
                NotifyOfPropertyChange(() => IsRadio10);
            }
        }

        public bool IsRadio11
        {
            get => isRadio11;
            set
            {
                isRadio11 = value;
                NotifyOfPropertyChange(() => IsRadio11);
            }
        }

        public bool IsRadio12
        {
            get => isRadio12;
            set
            {
                isRadio12 = value;
                NotifyOfPropertyChange(() => IsRadio12);
            }
        }

        public ObservableCollection<CartRacquet> RacquetLines
        {
            get => racquetLines;
            set
            {
                racquetLines = value;
                NotifyOfPropertyChange(() => RacquetLines);
            }
        }

        public int RacquetTotal
        {
            get
            {
                int subTotal= 0;
                foreach(var item in RacquetLines)
                {
                    subTotal += (item.Racquet.Price * item.RacquetQuantity);
                }
                return subTotal;
            }
        }

        public CartRacquet SelectedCartRacquet
        {
            get => selectedCartRacquet;
            set
            {
                selectedCartRacquet = value;
                NotifyOfPropertyChange(() => SelectedCartRacquet);
            }
        }

        public ObservableCollection<CartBag> BagLines
        {
            get => bagLines;
            set
            {
                bagLines = value;
                NotifyOfPropertyChange(() => BagLines);
            }
        }

        public int BagTotal
        {
            get
            {
                int subTotal = 0;
                foreach (var item in BagLines)
                {
                    subTotal += (item.Bag.Price * item.BagQuantity);
                }
                return subTotal;
            }
        }

        public CartBag SelectedCartBag
        {
            get => selectedCartBag;
            set
            {
                selectedCartBag = value;
                NotifyOfPropertyChange(() => SelectedCartBag);
            }
        }

        public ObservableCollection<CartString> StringLines
        {
            get => stringLines;
            set
            {
                stringLines = value;
                NotifyOfPropertyChange(() => StringLines);
            }
        }

        public int StringTotal
        {
            get
            {
                int subTotal = 0;
                foreach (var item in StringLines)
                {
                    subTotal += (item.String.Price * item.StringQuantity);
                }
                return subTotal;
            }
        }

        public CartString SelectedCartString
        {
            get => selectedCartString;
            set
            {
                selectedCartString = value;
                NotifyOfPropertyChange(() => SelectedCartString);
            }
        }

        public int Total
        {
            get
            {
                int total = RacquetTotal + BagTotal + StringTotal;
                return total;
            }
        }

        public int RacquetQuantity
        {
            get
            {
                int quantity = 0;
                foreach(var item in RacquetLines)
                {
                    quantity += item.RacquetQuantity; 
                }
                return quantity;
            }

        }

        public int BagQuantity
        {
            get
            {
                int quantity = 0;
                foreach (var item in BagLines)
                {
                    quantity += item.BagQuantity;
                }
                return quantity;
            }

        }

        public int StringQuantity
        {
            get
            {
                int quantity = 0;
                foreach (var item in StringLines)
                {
                    quantity += item.StringQuantity;
                }
                return quantity;
            }

        }

        public string TextRacquet
        {
            get => textRacquet;
            set
            {
                textRacquet = value;
                NotifyOfPropertyChange(() => TextRacquet);
            }
        }

        public string TextRacquetVisibility
        {
            get => textRacquetVisibility;
            set
            {
                textRacquetVisibility = value;
                NotifyOfPropertyChange(() => TextRacquetVisibility);
            }
        }

        public string GridRacquetVisibility
        {
            get => gridRacquetVisibility;
            set
            {
                gridRacquetVisibility = value;
                NotifyOfPropertyChange(() => GridRacquetVisibility);
            }
        }

        public string TextBag
        {
            get => textBag;
            set
            {
                textBag = value;
                NotifyOfPropertyChange(() => TextBag);
            }
        }

        public string TextBagVisibility
        {
            get => textBagVisibility;
            set
            {
                textBagVisibility = value;
                NotifyOfPropertyChange(() => TextBagVisibility);
            }
        }

        public string GridBagVisibility
        {
            get => gridBagVisibility;
            set
            {
                gridBagVisibility = value;
                NotifyOfPropertyChange(() => GridBagVisibility);
            }
        }

        public string TextString
        {
            get => textString;
            set
            {
                textString = value;
                NotifyOfPropertyChange(() => TextString);
            }
        }

        public string TextStringVisibility
        {
            get => textStringVisibility;
            set
            {
                textStringVisibility = value;
                NotifyOfPropertyChange(() => TextStringVisibility);
            }
        }

        public string GridStringVisibility
        {
            get => gridStringVisibility;
            set
            {
                gridStringVisibility = value;
                NotifyOfPropertyChange(() => GridStringVisibility);
            }
        }
        #endregion

        public MainViewModel()
        {
            Racquets = RacquetRepository.GetAll().ToList();
            Manufacturers = ManufacturerRepository.GetAll().ToList();
            Bags = BagRepository.GetAll().ToList();
            RacquetStrings = RacquetStringRepository.GetAll().ToList();
            InitializeCommandsForRacquets();
            InitializeCommandsForBags();
            InitializeCommandsForRacquetStrings();
        }

        #region Commands For Racquets
        public ICommand SortRacquetsByTitleCommand { get; set; }
        public ICommand SortRacquetsByTitleDescendingCommand { get; set; }
        public ICommand SortRacquetsByPriceCommand { get; set; }
        public ICommand SortRacquetsByPriceDescendingCommand { get; set; }
        public ICommand GetInfoRacquetCommand { get; set; }
        public ICommand FilterRacquetsByPriceCommand { get; set; }
        public ICommand ReturnRacquetsCommand { get; set; }
        public ICommand FilterRacquetsByManufacturerCommand { get; set; }
        public ICommand AddRacquetToCartCommand { get; set; }
        public ICommand RemoveRacquetFromCartCommand { get; set; }
        public ICommand ClearRacquetCartCommand { get; set; }
        #endregion

        #region Commands For Bags
        public ICommand SortBagsByTitleCommand { get; set; }
        public ICommand SortBagsByTitleDescendingCommand { get; set; }
        public ICommand SortBagsByPriceCommand { get; set; }
        public ICommand SortBagsByPriceDescendingCommand { get; set; }
        public ICommand EditBagCommand { get; set; }
        public ICommand GetInfoBagCommand { get; set; }
        public ICommand FilterBagsByPriceCommand { get; set; }
        public ICommand ReturnBagsCommand { get; set; }
        public ICommand FilterBagsByManufacturerCommand { get; set; }
        public ICommand AddBagToCartCommand { get; set; }
        public ICommand RemoveBagFromCartCommand { get; set; }
        public ICommand ClearBagCartCommand { get; set; }
        #endregion

        #region Commands For RacquetStrings
        public ICommand SortRacquetStringsByTitleCommand { get; set; }
        public ICommand SortRacquetStringsByTitleDescendingCommand { get; set; }
        public ICommand SortRacquetStringsByPriceCommand { get; set; }
        public ICommand SortRacquetStringsByPriceDescendingCommand { get; set; }
        public ICommand EditRacquetStringCommand { get; set; }
        public ICommand GetInfoRacquetStringCommand { get; set; }
        public ICommand FilterRacquetStringsByPriceCommand { get; set; }
        public ICommand ReturnRacquetStringsCommand { get; set; }
        public ICommand FilterRacquetStringsByManufacturerCommand { get; set; }
        public ICommand AddRacquetStringToCartCommand { get; set; }
        public ICommand RemoveRacquetStringFromCartCommand { get; set; }
        public ICommand ClearRacquetStringCartCommand { get; set; }
        #endregion

        private void InitializeCommandsForRacquets()
        {
            SortRacquetsByTitleCommand = new RelayCommand(SortRacquetsByTitle);
            SortRacquetsByTitleDescendingCommand = new RelayCommand(SortRacquetsByTitleDescending);
            SortRacquetsByPriceCommand = new RelayCommand(SortRacquetsByPrice);
            SortRacquetsByPriceDescendingCommand = new RelayCommand(SortRacquetsByPriceDescending);
            GetInfoRacquetCommand = new RelayCommand(RacquetInfo);
            racquetsCopy = Racquets;
            FilterRacquetsByPriceCommand = new RelayCommand(FilterRacquetsByPrice);
            ReturnRacquetsCommand = new RelayCommand(ReturnRacquets);
            FilterRacquetsByManufacturerCommand = new RelayCommand(FilterByRacquetsManufacturer);
            AddRacquetToCartCommand = new RelayCommand(AddRacquetToCart);
            RemoveRacquetFromCartCommand = new RelayCommand(RemoveRacquetFromCart);
            ClearRacquetCartCommand = new RelayCommand(ClearRacquetCart);
        }
        private void InitializeCommandsForBags()
        {
            SortBagsByTitleCommand = new RelayCommand(SortBagsByTitle);
            SortBagsByTitleDescendingCommand = new RelayCommand(SortBagsByTitleDescending);
            SortBagsByPriceCommand = new RelayCommand(SortBagsByPrice);
            SortBagsByPriceDescendingCommand = new RelayCommand(SortBagsByPriceDescending);
            FilterBagsByPriceCommand = new RelayCommand(FilterBagsByPrice);
            bagsCopy = Bags;
            ReturnBagsCommand = new RelayCommand(ReturnBags);
            GetInfoBagCommand = new RelayCommand(BagInfo);
            FilterBagsByManufacturerCommand = new RelayCommand(FilterBagsByManufacturer);
            AddBagToCartCommand = new RelayCommand(AddBagToCart);
            RemoveBagFromCartCommand = new RelayCommand(RemoveBagFromCart);
            ClearBagCartCommand = new RelayCommand(ClearBagCart);
        }
        private void InitializeCommandsForRacquetStrings()
        {
            SortRacquetStringsByTitleCommand = new RelayCommand(SortRacquetStringsByTitle);
            SortRacquetStringsByTitleDescendingCommand = new RelayCommand(SortRacquetStringsByTitleDescending);
            SortRacquetStringsByPriceCommand = new RelayCommand(SortRacquetStringsByPrice);
            SortRacquetStringsByPriceDescendingCommand = new RelayCommand(SortRacquetStringsByPriceDescending);
            racquetStringsCopy = RacquetStrings;
            ReturnRacquetStringsCommand = new RelayCommand(ReturnRacquetStrings);
            FilterRacquetStringsByPriceCommand = new RelayCommand(FilterRacquetStringsByPrice);
            GetInfoRacquetStringCommand = new RelayCommand(RacquetStringInfo);
            FilterRacquetStringsByManufacturerCommand = new RelayCommand(FilterRacquetStringsByManufacturer);
            AddRacquetStringToCartCommand = new RelayCommand(AddStringToCart);
            RemoveRacquetStringFromCartCommand = new RelayCommand(RemoveStringFromCart);
            ClearRacquetStringCartCommand = new RelayCommand(ClearStringCart);
        }

        #region Command Methods For Racquets
        void SortRacquetsByTitle(object parameter)
        {
            Racquets = new List<Racquet>(Racquets.OrderBy(x => x.Title));
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
        }

        void SortRacquetsByTitleDescending(object parameter)
        {
            Racquets = new List<Racquet>(Racquets.OrderByDescending(x => x.Title));
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
        }

        void SortRacquetsByPrice(object parameter)
        {
            Racquets = new List<Racquet>(Racquets.OrderBy(x => x.Price));
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
        }
        void SortRacquetsByPriceDescending(object parameter)
        {
            Racquets = new List<Racquet>(Racquets.OrderByDescending(x => x.Price));
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
        }

        void RacquetInfo(object parameter)
        {
            InfoView infoView = new InfoView();
            infoView.Show();
            (infoView.DataContext as InfoViewModel).CertainRacquet = SelectedRacquet;        
        }
        
        void FilterRacquetsByPrice(object parameter)
        {
            var predicate = PredicateBuilder.New<Racquet>(true);
            predicate.And(x => IsChecked1 == true);
            predicate.And(x => x.Price >= 0 && x.Price <= 150);
            var predicate1 = PredicateBuilder.New<Racquet>(true);
            predicate1.And(x => IsChecked2 == true);
            predicate1.And(x => x.Price > 150 && x.Price <= 200);
            predicate.Extend(predicate1);
            var predicate2 = PredicateBuilder.New<Racquet>(true);
            predicate2.And(x => IsChecked3 == true);
            predicate2.And(x => x.Price > 200 && x.Price <= 250);
            predicate.Extend(predicate2);
            var predicate3 = PredicateBuilder.New<Racquet>(true);
            predicate3.And(x => IsChecked4 == true);
            predicate3.And(x => x.Price > 250);
            predicate.Extend(predicate3);
            IsRadio1 = false;
            IsRadio2 = false;
            IsRadio3 = false;
            IsRadio4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
            if (RacquetRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextRacquet = "There isn't any suitable racquet";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextRacquet = "По заданному критерию не найдено ни одной ракетки";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодної ракетки";
                }
                TextRacquetVisibility = "Visible";
                GridRacquetVisibility = "Collapsed";
            }
            else
            {
                Racquets = RacquetRepository.FindBy(predicate).ToList();
            }
        }

        void ReturnRacquets(object parameter)
        {
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            IsRadio1 = false;
            IsRadio2 = false;
            IsRadio3 = false;
            IsRadio4 = false;
            SelectedComboBoxItem = -1;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
            Racquets = racquetsCopy;
        }

        void FilterByRacquetsManufacturer(object parameter)
        {
            var predicate = PredicateBuilder.New<Racquet>(true);
            predicate.And(x => SelectedComboBoxItem + 1 == x.ManufacturerId);
            IsRadio1 = false;
            IsRadio2 = false;
            IsRadio3 = false;
            IsRadio4 = false;
            IsChecked1 = false;
            IsChecked2 = false;
            IsChecked3 = false;
            IsChecked4 = false;
            GridRacquetVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
            if (RacquetRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextRacquet = "There isn't any suitable racquet";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextRacquet = "По заданному критерию не найдено ни одной ракетки";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодної ракетки";
                }
                TextRacquetVisibility = "Visible";
                GridRacquetVisibility = "Collapsed";
            }
            else
            {
                Racquets = RacquetRepository.FindBy(predicate).ToList();
            }
        }

        private void AddRacquetToCart(object parameter)
        {
            CartRacquet cart = RacquetLines.Where(x => x.Racquet.RacquetId == SelectedRacquet.RacquetId).FirstOrDefault();
            if (cart == null)
            {
                cart = new CartRacquet
                {
                    Racquet = SelectedRacquet,
                    RacquetQuantity = 1
                };
                RacquetLines.Add(cart);
            }
            else
            {
                cart.RacquetQuantity += 1;
            }
            NotifyOfPropertyChange(() => RacquetTotal);
            NotifyOfPropertyChange(() => RacquetQuantity);
            NotifyOfPropertyChange(() => Total);
        }

        private void RemoveRacquetFromCart(object parameter)
        {
            if(SelectedCartRacquet.RacquetQuantity > 1)
            {
                SelectedCartRacquet.RacquetQuantity -= 1;
            }
            else
            {
                RacquetLines.Remove(SelectedCartRacquet);
            }
            NotifyOfPropertyChange(() => RacquetTotal);
            NotifyOfPropertyChange(() => RacquetQuantity);
            NotifyOfPropertyChange(() => Total);
        }

        private void ClearRacquetCart(object parameter)
        {
            RacquetLines.Clear();
            NotifyOfPropertyChange(() => RacquetTotal);
            NotifyOfPropertyChange(() => RacquetQuantity);
            NotifyOfPropertyChange(() => Total);
        }
        #endregion

        #region Command Methods For Bags
        void SortBagsByTitle(object parameter)
        {
            Bags = new List<Bag>(Bags.OrderBy(x => x.Title));
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
        }

        void SortBagsByTitleDescending(object parameter)
        {
            Bags = new List<Bag>(Bags.OrderByDescending(x => x.Title));
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
        }

        void SortBagsByPrice(object parameter)
        {
            Bags = new List<Bag>(Bags.OrderBy(x => x.Price));
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
        }
        void SortBagsByPriceDescending(object parameter)
        {
            Bags = new List<Bag>(Bags.OrderByDescending(x => x.Price));
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
        }

        void FilterBagsByPrice(object parameter)
        {
            var predicate = PredicateBuilder.New<Bag>(true);
            predicate.And(x => IsChecked5 == true);
            predicate.And(x => x.Price >= 0 && x.Price <= 100);
            var predicate1 = PredicateBuilder.New<Bag>(true);
            predicate1.And(x => IsChecked6 == true);
            predicate1.And(x => x.Price > 100 && x.Price <= 150);
            predicate.Extend(predicate1);
            var predicate2 = PredicateBuilder.New<Bag>(true);
            predicate2.And(x => IsChecked7 == true);
            predicate2.And(x => x.Price > 150 && x.Price <= 200);
            predicate.Extend(predicate2);
            var predicate3 = PredicateBuilder.New<Bag>(true);
            predicate3.And(x => IsChecked8 == true);
            predicate3.And(x => x.Price > 200);
            predicate.Extend(predicate3);
            IsRadio5 = false;
            IsRadio6 = false;
            IsRadio7 = false;
            IsRadio8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
            if (BagRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextBag = "There isn't any suitable bag";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextBag = "По заданному критерию не найдено ни одной сумки";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодної сумки";
                }
                TextBagVisibility = "Visible";
                GridBagVisibility = "Collapsed";
            }
            else
            {
                Bags = BagRepository.FindBy(predicate).ToList();
            }
        }

        void ReturnBags(object parameter)
        {
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            IsRadio5 = false;
            IsRadio6 = false;
            IsRadio7 = false;
            IsRadio8 = false;
            SelectedComboBoxItem1 = -1;
            GridBagVisibility = "Visible";
            TextRacquetVisibility = "Collapsed";
            Bags = bagsCopy;
        }

        void BagInfo(object parameter)
        {
            BagInfoView infoView = new  BagInfoView();
            infoView.Show();
            (infoView.DataContext as BagInfoViewModel).CertainBag = SelectedBag;
        }

        void FilterBagsByManufacturer(object parameter)
        {
            var predicate = PredicateBuilder.New<Bag>(true);
            predicate.And(x => SelectedComboBoxItem1 + 1 == x.ManufacturerId);
            IsRadio5 = false;
            IsRadio6 = false;
            IsRadio7 = false;
            IsRadio8 = false;
            IsChecked5 = false;
            IsChecked6 = false;
            IsChecked7 = false;
            IsChecked8 = false;
            GridBagVisibility = "Visible";
            TextBagVisibility = "Collapsed";
            if (BagRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextBag = "There isn't any suitable bag";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextBag = "По заданному критерию не найдено ни одной сумки";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодної сумки";
                }
                TextBagVisibility = "Visible";
                GridBagVisibility = "Collapsed";
            }
            else
            {
                Bags = BagRepository.FindBy(predicate).ToList();
            }
        }

        private void AddBagToCart(object parameter)
        {
            CartBag cart = BagLines.Where(x => x.Bag.BagId == SelectedBag.BagId).FirstOrDefault();
            if (cart == null)
            {
                cart = new CartBag
                {
                    Bag = SelectedBag,
                    BagQuantity = 1
                };
                BagLines.Add(cart);
            }
            else
            {
                cart.BagQuantity += 1;
            }
            NotifyOfPropertyChange(() => BagTotal);
            NotifyOfPropertyChange(() => BagQuantity);
            NotifyOfPropertyChange(() => Total);
        }

        private void RemoveBagFromCart(object parameter)
        {
            if (SelectedCartBag.BagQuantity > 1)
            {
                SelectedCartBag.BagQuantity -= 1;
            }
            else
            {
                BagLines.Remove(SelectedCartBag);
            }
            NotifyOfPropertyChange(() => BagTotal);
            NotifyOfPropertyChange(() => BagQuantity);
            NotifyOfPropertyChange(() => Total);
        }

        private void ClearBagCart(object parameter)
        {
            BagLines.Clear();
            NotifyOfPropertyChange(() => BagTotal);
            NotifyOfPropertyChange(() => BagQuantity);
            NotifyOfPropertyChange(() => Total);
        }
        #endregion

        #region Command Methods For RacquetStrings
        void SortRacquetStringsByTitle(object parameter)
        {
            RacquetStrings = new List<RacquetString>(RacquetStrings.OrderBy(x => x.Title));
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
        }

        void SortRacquetStringsByTitleDescending(object parameter)
        {
            RacquetStrings = new List<RacquetString>(RacquetStrings.OrderByDescending(x => x.Title));
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
        }

        void SortRacquetStringsByPrice(object parameter)
        {
            RacquetStrings = new List<RacquetString>(RacquetStrings.OrderBy(x => x.Price));
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
        }
        void SortRacquetStringsByPriceDescending(object parameter)
        {
            RacquetStrings = new List<RacquetString>(RacquetStrings.OrderByDescending(x => x.Price));
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
        }

        void FilterRacquetStringsByPrice(object parameter)
        {
            var predicate = PredicateBuilder.New<RacquetString>(true);
            predicate.And(x => IsChecked9 == true);
            predicate.And(x => x.Price <= 100);
            var predicate1 = PredicateBuilder.New<RacquetString>(true);
            predicate1.And(x => IsChecked10 == true);
            predicate1.And(x => x.Price > 100 && x.Price <= 200);
            predicate.Extend(predicate1);
            var predicate2 = PredicateBuilder.New<RacquetString>(true);
            predicate2.And(x => IsChecked11 == true);
            predicate2.And(x => x.Price > 200 && x.Price <= 300);
            predicate.Extend(predicate2);
            var predicate3 = PredicateBuilder.New<RacquetString>(true);
            predicate3.And(x => IsChecked12 == true);
            predicate3.And(x => x.Price > 300);
            predicate.Extend(predicate3);
            IsRadio9 = false;
            IsRadio10 = false;
            IsRadio11 = false;
            IsRadio12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
            if (RacquetStringRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextString = "There isn't any suitable string";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextString = "По заданному критерию не найдено ни одной струны";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодних струн";
                }
                TextStringVisibility = "Visible";
                GridStringVisibility = "Collapsed";
            }
            else
            {
                RacquetStrings = RacquetStringRepository.FindBy(predicate).ToList();

            }
        }
        void ReturnRacquetStrings(object parameter)
        {
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            IsRadio9 = false;
            IsRadio10 = false;
            IsRadio11 = false;
            IsRadio12 = false;
            SelectedComboBoxItem2 = -1;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
            RacquetStrings = racquetStringsCopy;
        }

        void RacquetStringInfo(object parameter)
        {
            StringInfoView infoView = new StringInfoView();
            infoView.Show();
            (infoView.DataContext as RacquetStringInfoViewModel).CertainString = SelectedRacquetString;
        }

        void FilterRacquetStringsByManufacturer(object parameter)
        {
            var predicate = PredicateBuilder.New<RacquetString>(true);
            predicate.And(x => SelectedComboBoxItem2 + 1 == x.ManufacturerId);
            IsChecked9 = false;
            IsChecked10 = false;
            IsChecked11 = false;
            IsChecked12 = false;
            IsRadio9 = false;
            IsRadio10 = false;
            IsRadio11 = false;
            IsRadio12 = false;
            GridStringVisibility = "Visible";
            TextStringVisibility = "Collapsed";
            if (RacquetStringRepository.FindBy(predicate).Count() == 0)
            {
                if (CultureInfo.CurrentUICulture.Name == "en-US")
                {
                    TextString = "There isn't any suitable string";
                }
                else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                {
                    TextString = "По заданному критерию не найдено ни одной струны";
                }
                else
                {
                    TextRacquet = "За заданим критерієм не знайдено жодних струн";
                }
                TextStringVisibility = "Visible";
                GridStringVisibility = "Collapsed";
            }
            else
            {
                RacquetStrings = RacquetStringRepository.FindBy(predicate).ToList();
            }
        }

        private void AddStringToCart(object parameter)
        {
            CartString cart = StringLines.Where(x => x.String.StringId == SelectedRacquetString.StringId).FirstOrDefault();
            if (cart == null)
            {
                cart = new CartString
                {
                    String = SelectedRacquetString,
                    StringQuantity = 1
                };
                StringLines.Add(cart);
            }
            else
            {
                cart.StringQuantity += 1;
            }
            NotifyOfPropertyChange(() => StringTotal);
            NotifyOfPropertyChange(() => StringQuantity);
            NotifyOfPropertyChange(() => Total);

        }

        private void RemoveStringFromCart(object parameter)
        {
            if (SelectedCartString.StringQuantity > 1)
            {
                SelectedCartString.StringQuantity -= 1;
            }
            else
            {
                StringLines.Remove(SelectedCartString);
            }
            NotifyOfPropertyChange(() => StringTotal);
            NotifyOfPropertyChange(() => StringQuantity);
            NotifyOfPropertyChange(() => Total);
        }

        private void ClearStringCart(object parameter)
        {
            StringLines.Clear();
            NotifyOfPropertyChange(() => StringTotal);
            NotifyOfPropertyChange(() => StringQuantity);
            NotifyOfPropertyChange(() => Total);
        }
        #endregion
    }
}
