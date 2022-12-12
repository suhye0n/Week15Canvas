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
        //public double PosX { get; set; }
        //public double PosY { get; set; }

        public Point _pos;

        public Point Pos
        {
            get { return _pos; }
            set
            {
                _pos = value;
                OnPropertyChanged(nameof(Pos));
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            //PosX = 200;
            //PosY = 200;
            Pos = new Point(200, 200);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string proportyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proportyName));
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("마우스 버튼 클릭");

            //PosX = e.GetPosition(this).X;
            //PosY = e.GetPosition(this).Y;
            //OnPropertyChanged(nameof(PosX));
            //OnPropertyChanged("PosY");

            Pos = e.GetPosition(this);
        }
    }
}
