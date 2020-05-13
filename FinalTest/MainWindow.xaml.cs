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

namespace FinalTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PhoneData db = new PhoneData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            loadDatabase();
        }

        public void loadDatabase()
        {

            //get all players from the page
            var query = from p in db.phones
                        select new
                        {
                            p.OS_Image,
                            p.Name
                        };


            //display them in a list
            lstBxPhones.ItemsSource = query.ToList();
        }

        public void selectedPhoneData(string name)
        {
            var query = from p in db.phones
                        where p.Name == name
                        select new
                        {
                            p.Price
                        };

            txtBlPrice.Text = query.ToString();

            var query2 = from p in db.phones
                         where p.Name == name
                         select new
                         {
                             p.Phone_Image
                         };

            imgPhone.Source = prop.p;
        }
    }
}
