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
        //get the phone database
        PhoneData db = new PhoneData();

        //get a list of phones
        List<Phone> phones = new List<Phone>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            //load the database
            loadDatabase();
        }

        public void loadDatabase()
        {
            //foreach phone in the database add it too the phones list
            foreach (Phone phone in db.phones)
            {
                phones.Add(phone);
            }

            //display phones list
            lstBxPhones.ItemsSource = phones;
        }

        
        private void lstBxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get selectedPhone
            Phone SelectedPhone = lstBxPhones.SelectedItem as Phone;
           
            //if SelectedPhone is not equal too nothing
            if (SelectedPhone != null)
            {
                //dislay the price and the phone image
                string price = string.Format("{0:C}", SelectedPhone.Price);
                txtBlPrice.Text = price;

                Uri uri = new Uri(SelectedPhone.Phone_Image, UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                imgPhone.Source = imgSource;
            }
            else
            {
                //if nothing is selected display this message
                MessageBox.Show("Nothing Selected");
            }

        }
    }
}
