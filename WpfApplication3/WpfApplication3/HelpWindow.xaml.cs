using System.Windows;

namespace WpfApplication3
{
    /// <summary>
    /// HelpWindow.xaml 的交互逻辑
    /// </summary>
    public partial class HelpWindow
    {
        //public string Msg { get; set; }
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //txtInfo.Text = Msg;
        }
    }
}
