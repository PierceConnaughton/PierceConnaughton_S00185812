using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;


namespace FinalTest
{
    public class Phone
    {
        #region properties
        //phoneId property needed for database
        public int PhoneID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string  OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

        //creates a virtual list for all of the phones
        public virtual List<Phone> Phones { get; set; }

        #endregion properties

        #region constructors
        public Phone()
        {

        }

        public Phone(string name,int price, string operatingSystem, string osImage,string phoneImage)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = osImage;
            Phone_Image = phoneImage;

        }

        #endregion constructors

        #region Methods
        public double IncreasePrice(double percentage)
        {
            //increase price method which creates a double that gets price multiplys it by 1 + (percentage divided by 100) too get the new price 
            double newPrice = (Price * (1 + (percentage / 100)));

            Price = (int)newPrice;
            return Price;
        }

        #endregion Methods
    }

    
    public class PhoneData : DbContext
    {
        //creates the database
        public PhoneData() : base("PhoneDetails") { }

        //Creates the Phones table
        public DbSet<Phone> phones { get; set; }
    }
}
