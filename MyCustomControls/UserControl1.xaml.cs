using System;
using System.Collections.Generic;
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

namespace MyCustomControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {


        public int Dt
        {
            get { return (int)GetValue(DtProperty); }
            set { SetValue(DtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DtProperty =
            DependencyProperty.Register("Dt", typeof(int), typeof(UserControl1), new PropertyMetadata(0));


        public UserControl1()
        {
            ClockWatchViewModel cwVM = (ClockWatchViewModel)Resources["ClockWatchViewModel"]; ;
            InitializeComponent();
        }

    }
}
