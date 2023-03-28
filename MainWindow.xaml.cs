using linq_basic.Class;
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

namespace linq_basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public partial class MainWindow : Window
    {
        List<clsdetails> listcl = new List<clsdetails>();
        public MainWindow()
        {
            InitializeComponent();
        }

        String sdetail;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sdetail = txtsreach.Text;
            var search = from det in listcl
                         where det.Ename == sdetail || det.EAge == sdetail  || det.Eemail == sdetail
                         || det.Ephone == sdetail || det.Estate == sdetail || det.ID == sdetail
                         select det;

            if(search != null)
            {
                listview.ItemsSource = search;
                listview.Items.Refresh();
               
            }
          //  else
          //  {
          //      MessageBox.Show("No Reacords found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
          //}

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clsdetails cls = new clsdetails();
            cls.EAge = txtAge.Text;
            cls.Eemail = txtMail.Text;
            cls.Ephone = txtnum.Text;
            cls.Estate = txtstate.Text;
            cls.ID = txtid.Text;
            cls.Ename= txtname.Text;

            listcl.Add(cls);

        MessageBoxResult result =    MessageBox.Show("Succesfully Saved", "SAVED", MessageBoxButton.OK,MessageBoxImage.Information);

            if(result == MessageBoxResult.OK)
            {
                txtname.Text = null; txtid.Text = null;
                txtstate.Text = null; txtMail.Text = null;
                txtnum.Text = null; txtAge.Text = null;
            }
        }

        private void listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          

        }
    }
}
