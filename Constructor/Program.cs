using System;

namespace Audi
{ 
    class Car
    {
        public string name;
        protected int speed;
        protected double motor;
        protected string model;
        public int year;
        protected string Color;
        
        public string getModel
        {
            get { return model; }
            set { model = value; }
        }

        public int getSpeed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double getMotor
        {
            get { return motor; }
            set { motor = value; }
        }

        public string getColor
        {
            get { return Color; }
            set { Color = value; }
        }
        
    }

    class Bmw : Car
    {
        public Bmw()
        {
            speed = 310;
            motor = 6.4;
            model = "m5 e60";
            year = 2020;
            getColor = "red";
        }
    }

    class Mercedes : Car
    {
        public Mercedes()
        {
            speed = 360;
            motor = 1.6;
            model = "AMG ONE: hybrid system";
            year = 2024;
            Color = "yellow";
        }
    }

    class Audi : Car
    {
        public Audi(int speed)
        {
           speed = speed;
           model = "RS7";
           motor = 1.2;
           year = 2025;
           Color = "black";
        }
        public Audi()
        {
            speed = 300;
            motor = 6.3;
            model = "RS6";
            year = 2026;
            Color = "green";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Audi audi = new Audi();
            
            bmw.name = "BMW";
            mercedes.name = "Mercedes";
            Audi audi2 = new Audi();
            
            Console.WriteLine($"{bmw.name}");
            Console.WriteLine($"Speed: {bmw.getSpeed} km/h");
            Console.WriteLine($"Motor: {bmw.getMotor} L");
            Console.WriteLine($"Model: {bmw.getModel}");
            Console.WriteLine($"Year: {bmw.year}");
            Console.WriteLine($"Color: {bmw.getColor}");
            
            Console.WriteLine();

            Console.WriteLine($"{mercedes.name}");
            Console.WriteLine($"Speed: {mercedes.getSpeed} km/h");
            Console.WriteLine($"Motor: {mercedes.getMotor} L");
            Console.WriteLine($"Model: {mercedes.getModel}");
            Console.WriteLine($"Year: {mercedes.year}");
            Console.WriteLine($"Color: {mercedes.getColor}");
            Console.WriteLine();
            
            Console.WriteLine($"{audi.name}");
            Console.WriteLine($"Speed: {audi.getSpeed} km/h");
            Console.WriteLine($"Motor: {audi.getMotor} L");
            Console.WriteLine($"Model: {audi.getModel}");
            Console.WriteLine($"Year: {audi.year}");
            Console.WriteLine($"Color: {audi.getColor}");
            
            Audi audi3 = new Audi(10);
            
            
        }
    }
}
        
      