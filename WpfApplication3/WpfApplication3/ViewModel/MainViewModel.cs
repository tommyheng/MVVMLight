using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;

namespace WpfApplication3.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { Set("Title", ref title, value); }
        }

        public ICommand ChangeTitleCommand { get; set; }

        public ICommand NavigationCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Title = "Hello World";
            ChangeTitleCommand = new RelayCommand(ChangeTitle);
            NavigationCommand = new RelayCommand(Navigation);
        }

        private void ChangeTitle()
        {
            Title = "Hello MvvmLight";
        }

        private void Navigation()
        {
            Messenger.Default.Send("我就是传递过来的消息！", "ShowHelpView");
        }
    }
}