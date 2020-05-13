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
        List<Phone> phones = new List<Phone>();
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
            foreach (Phone phone in db.phones)
            {
                phones.Add(phone);
            }

            lstBxPhones.ItemsSource = phones;
        }

        
        private void lstBxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone SelectedPhone = lstBxPhones.SelectedItem as Phone;
           
            if (SelectedPhone != null)
            {
                string price = string.Format("{0:C}", SelectedPhone.Price.ToString());
                txtBlPrice.Text = price;

                Uri uri = new Uri(SelectedPhone.Phone_Image, UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                imgPhone.Source = imgSource;
            }
            else
            {
                MessageBox.Show("Nothing Selected");
            }

        }
    }
}
