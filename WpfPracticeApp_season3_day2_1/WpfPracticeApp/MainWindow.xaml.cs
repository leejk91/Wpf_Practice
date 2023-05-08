using System;
using System.Collections;
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

namespace WpfPracticeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lbx.ItemsSource = GetSamples();
        }

        private IEnumerable GetSamples()
        {
            List<User> users = new();
            users.Add(new User().GenData("Lee","Seoul"));
            users.Add(new User().GenData("Lee2","Busan"));
            users.Add(new User().GenData("Lee3","Paris"));
            users.Add(new User().GenData("Lee4","Home"));

            return users;
        }
    }
}
