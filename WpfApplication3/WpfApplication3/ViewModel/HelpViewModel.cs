using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication3.ViewModel
{
    public class HelpViewModel : ViewModelBase
    {
        public int Id { get; set; }

        private string info;

        public string Info
        {
            get { return info; }
            set { Set("Info", ref info, value); }
        }

        public ICommand GetInfoCommand { get; set; }

        public ICommand LoadDataCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public HelpViewModel()
        {
            Info = "Help Info";
            GetInfoCommand = new RelayCommand(GetInfo);
            LoadDataCommand = new RelayCommand(LoadData);
        }

        private void LoadData()
        {
            Info = Info + "LoadData Init Execute !";
        }

        private void GetInfo()
        {
            MessageBox.Show(Info);
        }
    }
}
