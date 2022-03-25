using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MyProperty mp = new MyProperty();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mp;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this._myUserControl.CollectionStart();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            this._myUserControl.CollectionStop();
        }
    }

    public class MyProperty : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string myproperty) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(myproperty));
    }

    
    
}
