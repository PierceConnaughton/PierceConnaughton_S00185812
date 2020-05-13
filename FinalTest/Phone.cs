using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Phone
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string  OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }

        public int IncreasePrice(int percentage)
        {
            percentage = percentage / 100;

            Price = Price * percentage;

            return Price;
        }
    }
}
