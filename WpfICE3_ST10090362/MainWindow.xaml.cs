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

//pheagane ramosa ST10090362
//password = password and email = email@gmail.com
namespace WpfICE3_ST10090362
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if(passwordBOX.Password !=""&& emailtxt1.Text !="")
            {
                if(passwordBOX.Password=="password" && emailtxt1.Text == "email@gmail.com")
                { MessageBox.Show("successful login!");
                }
            }
        }

        private void emailtxt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
