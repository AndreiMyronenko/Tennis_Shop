using FinalProject.DAL.Models;
using FinalProject.DAL.Repositories;
using FinalProject.Infra;
using FinalProject.Models;
using FinalProject.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace FinalProject.ViewModels
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        #region Parameters
        private IService<RacquetDTO> racquetService;
        private IService<ManufacturerDTO> manufacturerService;
        private IService<BagDTO> bagService;
        private IService<RacquetStringDTO> racquetStringService;
        private NotifyCollection<RacquetDTO> racquets;
        private NotifyCollection<ManufacturerDTO> manufacturers;
        private NotifyCollection<BagDTO> bags;
        private NotifyCollection<RacquetStringDTO> racquetStrings;
        private RacquetDTO selectedRacquet;
        private ManufacturerDTO selectedManufacturer;
        private BagDTO selectedBag;
        private RacquetStringDTO selectedRacquetString;
        #endregion

        #region Properties
        public NotifyCollection<RacquetDTO> Racquets
        {
            get => racquets;
            set
            {
                racquets = value;
                Notify();
            }
        }

        public NotifyCollection<ManufacturerDTO> Manufacturers
        {
            get => manufacturers;
            set
            {
                manufacturers = value;
                Notify();
            }
        }

        public NotifyCollection<BagDTO> Bags
        {
            get => bags;
            set
            {
                bags = value;
                Notify();
            }
        }

        public NotifyCollection<RacquetStringDTO> RacquetStrings
        {
            get => racquetStrings;
            set
            {
                racquetStrings = value;
                Notify();
            }
        }

        public RacquetDTO SelectedRacquet
        {
            get => selectedRacquet;
            set
            {
                selectedRacquet = value;
                Notify();
            }
        }

        public ManufacturerDTO SelectedManufacturer
        {
            get => selectedManufacturer;
            set
            {
                selectedManufacturer = value;
                Notify();
            }
        }

        public BagDTO SelectedBag
        {
            get => selectedBag;
            set
            {
                selectedBag = value;
                Notify();
            }
        }

        public RacquetStringDTO SelectedRacquetString
        {
            get => selectedRacquetString;
            set
            {
                selectedRacquetString = value;
                Notify();
            }
        }

        public RacquetDTO Racquet { get; set; } = new RacquetDTO();
        public ManufacturerDTO Manufacturer { get; set; } = new ManufacturerDTO();
        public BagDTO Bag { get; set; } = new BagDTO();
        public RacquetStringDTO RacquetString { get; set; } = new RacquetStringDTO();
        #endregion

        public AdminViewModel(IService<RacquetDTO> racquetService,
                              IService<ManufacturerDTO> manufacturerService,
                              IService<BagDTO> bagService,
                              IService<RacquetStringDTO> racquetStringService)
        {
            this.racquetService = racquetService;
            this.manufacturerService = manufacturerService;
            this.bagService = bagService;
            this.racquetStringService = racquetStringService;
            Racquets = new NotifyCollection<RacquetDTO>(racquetService);
            Manufacturers = new NotifyCollection<ManufacturerDTO>(manufacturerService);
            Bags = new NotifyCollection<BagDTO>(bagService);
            RacquetStrings = new NotifyCollection<RacquetStringDTO>(racquetStringService);
            InitializeRacquetCommands();
            InitializeManufacturerCommands();
            InitializeBagCommands();
            InitializeRacquetStringCommands();
        }

        #region Commands For Racquets
        public ICommand DeleteRacquetCommand { get; private set; }
        public ICommand EditRacquetCommand { get; private set; }
        public ICommand AddRacquetCommand { get; private set; }
        public ICommand SelectRacquetImageCommand { get; private set; }
        public ICommand EditRacquetImageCommand { get; private set; }
        #endregion

        #region Commands For Manufacturers
        public ICommand DeleteManufacturerCommand { get; private set; }
        public ICommand EditManufacturerCommand { get; private set; }
        public ICommand AddManufacturerCommand { get; private set; }
        #endregion

        #region Commands For Bags
        public ICommand DeleteBagCommand { get; private set; }
        public ICommand EditBagCommand { get; private set; }
        public ICommand AddBagCommand { get; private set; }
        public ICommand SelectBagImageCommand { get; private set; }
        public ICommand EditBagImageCommand { get; private set; }
        #endregion

        #region Commands For RacquetStrings
        public ICommand DeleteRacquetStringCommand { get; private set; }
        public ICommand EditRacquetStringCommand { get; private set; }
        public ICommand AddRacquetStringCommand { get; private set; }
        public ICommand SelectRacquetStringImageCommand { get; private set; }
        public ICommand EditRacquetStringImageCommand { get; private set; }
        #endregion

        private void InitializeRacquetCommands()
        {
            DeleteRacquetCommand = new RelayCommand(DeleteRacquet);
            EditRacquetCommand = new RelayCommand(EditRacquet);
            AddRacquetCommand = new RelayCommand(AddRacquet);
            SelectRacquetImageCommand = new RelayCommand(SelectImage);
            EditRacquetImageCommand = new RelayCommand(EditRacquetImage);
        }

        private void InitializeManufacturerCommands()
        {
            DeleteManufacturerCommand = new RelayCommand(DeleteManufacturer);
            EditManufacturerCommand = new RelayCommand(EditManufacturer);
            AddManufacturerCommand = new RelayCommand(AddManufacturer);
        }

        private void InitializeBagCommands()
        {
            DeleteBagCommand = new RelayCommand(DeleteBag);
            EditBagCommand = new RelayCommand(EditBag);
            AddBagCommand = new RelayCommand(AddBag);
            SelectBagImageCommand = new RelayCommand(SelecttBagImage);
            EditBagImageCommand = new RelayCommand(EditBagImage);
        }

        private void InitializeRacquetStringCommands()
        {
            DeleteRacquetStringCommand = new RelayCommand(DeleteRacquetString);
            EditRacquetStringCommand = new RelayCommand(EditRacquetString);
            AddRacquetStringCommand = new RelayCommand(AddRacquetString);
            SelectRacquetStringImageCommand = new RelayCommand(SelectStringImage);
            EditRacquetStringImageCommand = new RelayCommand(EditStringImage);
        }

        #region Command Methods For Racquets
        private void DeleteRacquet(object parameter)
        {
            Racquets.Remove(SelectedRacquet);
        }

        private void EditRacquet(object parameter)
        {
            foreach (var racquet in Racquets)
                if (racquet.RacquetId == SelectedRacquet.RacquetId)
                {
                    SelectedRacquet.RacquetTitle = racquet.RacquetTitle;
                    SelectedRacquet.Price = racquet.Price;
                    SelectedRacquet.Photo = racquet.Photo;
                    SelectedRacquet.StringSurfaceArea = racquet.StringSurfaceArea;
                    SelectedRacquet.Weight = racquet.Weight;
                    SelectedRacquet.Balance = racquet.Balance;
                    SelectedRacquet.Available = racquet.Available;
                    SelectedRacquet.ManufacturerId = racquet.ManufacturerId;
                    Racquets.Update(SelectedRacquet);
                }
            Notify("SelectedRacquetManufacturerId");
        }

        private void AddRacquet(object parameter)
        {
            Racquets.Adding(Racquet);
        }

        private void SelectImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                Racquet.Photo = bitmapImage.ToString();
            }
        }

        private void EditRacquetImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                SelectedRacquet.Photo = bitmapImage.ToString();
            }
        }
        #endregion

        #region Command Methods For Manufacturers
        private void DeleteManufacturer(object parameter)
        {
            Manufacturers.Remove(SelectedManufacturer);
        }

        private void EditManufacturer(object parameter)
        {
            Manufacturers.Update(SelectedManufacturer);
        }

        private void AddManufacturer(object parameter)
        {
            Manufacturers.Adding(Manufacturer);
        }
        #endregion

        #region Command Methods For Bags
        private void DeleteBag(object parameter)
        {
            Bags.Remove(SelectedBag);
        }

        private void EditBag(object parameter)
        {
            foreach (var bag in Bags)
                if (bag.BagId == SelectedBag.BagId)
                {
                    SelectedBag.BagTitle = bag.BagTitle;
                    SelectedBag.Price = bag.Price;
                    SelectedBag.Photo = bag.Photo;
                    SelectedBag.Available = bag.Available;
                    SelectedBag.ManufacturerId = bag.ManufacturerId;
                    Bags.Update(SelectedBag);
                }
        }

        private void AddBag(object parameter)
        {
            Bag.ManufacturerId = SelectedManufacturer?.ManufacturerId;
            Bag.ManufacturerName = SelectedManufacturer?.ManufacturerName;
            Bags.Adding(Bag);
        }

        private void SelecttBagImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                Bag.Photo = bitmapImage.ToString();
            }
        }

        private void EditBagImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                SelectedBag.Photo = bitmapImage.ToString();
            }
        }
        #endregion

        #region Command Methods For RacquetStrings
        private void DeleteRacquetString(object parameter)
        {
            RacquetStrings.Remove(SelectedRacquetString);
        }

        private void EditRacquetString(object parameter)
        {
            foreach (var racquetString in RacquetStrings)
                if (racquetString.RacquetStringId == SelectedRacquetString.RacquetStringId)
                {
                    SelectedRacquetString.RacquetStringTitle = racquetString.RacquetStringTitle;
                    SelectedRacquetString.Price = racquetString.Price;
                    SelectedRacquetString.Photo = racquetString.Photo;
                    SelectedRacquetString.Longitude = racquetString.Longitude;
                    SelectedRacquetString.Color = racquetString.Color;
                    SelectedRacquetString.Thickness = racquetString.Thickness;
                    SelectedRacquetString.Available = racquetString.Available;
                    SelectedRacquetString.ManufacturerId = racquetString.ManufacturerId;
                    RacquetStrings.Update(SelectedRacquetString);
                }
        }

        private void AddRacquetString(object parameter)
        {
            RacquetString.ManufacturerId = SelectedRacquetString?.ManufacturerId;
            RacquetString.ManufacturerName = SelectedRacquetString?.ManufacturerName;
            RacquetStrings.Adding(RacquetString);
        }

        private void SelectStringImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                RacquetString.Photo = bitmapImage.ToString();
            }
        }

        private void EditStringImage(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                SelectedRacquetString.Photo = bitmapImage.ToString();
            }
        }
        #endregion

        #region Notify
        private void Notify([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
