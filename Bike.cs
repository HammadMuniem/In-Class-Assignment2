using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Assignment
{
    class Bike : Vehicle
    {
        private string make;
        private string type;
        private int model_year;
        private int number_of_gears;
        public Bike()
        {
            make = " ";
            type = " ";
            model_year = 2020;
            number_of_gears = 6;
        }
        public void ChooseType(int _type)
        {
            if (_type == 1)
            {
                type = "Sport";
            }
            else if (_type == 2)
            {
                type = "Chopper";
            }
            else if (_type == 3)
            {
                type = "Quad";
            }
        }
        public string Get_type()
        {
            return type;
        }
    }
}
