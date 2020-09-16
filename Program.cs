using System;

namespace In_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int input2;
            int input3;
            Console.WriteLine("What color do you want your vehicle?");
            Console.WriteLine("Type 1 for Red, Type 2 for Blue, Type 3 for Green");
            Console.WriteLine("Press any other key if you want the default white color");
            Vehicle Vehicle1 = new Vehicle(); 
            input = Console.ReadLine();
            Vehicle1.ChooseColor(int.Parse(input));
            Console.WriteLine("The color you have chosen for your vehicle is "+ Vehicle1.Get_color());
            Console.WriteLine("Please choose the kind of vehicle you want");
            Console.WriteLine("Press 1 for car, Press 2 for bike");
            input2 = int.Parse(Console.ReadLine());
            if (input2==1)
            {
                Console.WriteLine("Type 1 for Honda, Type 2 for Toyota, Type 3 for Nissan and type 4 for Lamborghini");
                input3 = int.Parse(Console.ReadLine());
                Car Car1 = new Car();
                Car1.ChooseMake(input3);
                Console.WriteLine("Congratulations on your " + Car1.Get_make());
            }
            else if (input2==2)
            {
                Console.WriteLine("Type 1 for Sport, Type 2 for Chopper and Type 3 for Quad");
                input3 = int.Parse(Console.ReadLine());
                Bike bike1 = new Bike();
                bike1.ChooseType(input3);
                Console.WriteLine("Congratulations on your " + bike1.Get_type()+"bike");
            }
        }
    }
}
