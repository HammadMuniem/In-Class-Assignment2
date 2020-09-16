using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class_Assignment
{
    class Vehicle
    {
        private float registration_number;
        private string color;
        private string owner;

        public Vehicle()
        {
            registration_number = 1234;
            color = "white";
            owner = "None";
        }
        public void ChooseColor(int shade)
        {
            if (shade == 1)
            {
                color = "Red";
            }
            else if (shade == 2)
            {
                color = "Blue";
            }
            else if (shade == 3)
            {
                color = "Green";
            }
            else
            {
                color = "White";
            }
        } public void Change_owner(string new_owner)
        {
            new_owner = new_owner;
        }
        public string Get_color()
        {
            return color;
        }
    }
}
