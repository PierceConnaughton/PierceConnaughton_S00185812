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
        public int PhoneID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string  OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

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
        public int IncreasePrice(double percentage)
        {
            
            //Price = Price * (1 + (percentage / 100));


            return Price;
        }

        #endregion Methods
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("PhoneDetails") { }
        public DbSet<Phone> phones { get; set; }
    }
}
