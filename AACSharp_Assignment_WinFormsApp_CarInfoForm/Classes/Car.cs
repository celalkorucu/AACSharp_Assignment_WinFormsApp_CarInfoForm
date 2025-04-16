using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_WinFormsApp_CarInfoForm.Classes
{
    public class Car
    {
        public string brand {  get; set; }
        public string model { get; set; }
        public string color { get; set; }

        public int doorCount { get; set; }
        public int windowCount { get; set; }
        public double fuelBurnedPer100 { get; set; }


    }
}
