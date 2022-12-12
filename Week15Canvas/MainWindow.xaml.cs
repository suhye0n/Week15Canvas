using System;
using System.Collections.Generic;
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

namespace Week15Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public double PosX { get; set; }
        public double PosY { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            PosX = 200;
            PosY = 200;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string proportyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(proportyName));
        }
    }
}
