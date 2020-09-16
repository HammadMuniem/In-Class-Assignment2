using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace In_Class_Assignment
{
    class Car : Vehicle
    {
        private string make;
        private string type;
        private int model_year;
        private int number_of_doors;

        public Car()
        {
            make = " ";
            type = " ";
            model_year = 2020;
            number_of_doors = 4;
        }
        public void ChooseMake(int _make)
        {
            if (_make == 1)
            {
                make = "Honda";
            }
            else if (_make == 2)
            {
                make = "Toyota";
            }
            else if (_make == 3)
            {
                make = "Nissan";
            }
            else if (_make==4)
            {
                make = "Lamborghini";
            }
        }
        public string Get_make()
        {
            return make;
        }
    }
}
