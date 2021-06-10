using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_car.carApp.model
{
    class Car
    {
        private string brand;
        private string model;
        private string color;
        private int year;

        public Car()
        {
        }

        public Car(string brand, string model, string color, int year)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }

        public void printCarInfo()
        {
            Console.WriteLine("브랜드: " + brand);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연식: " + year);
        }
    }
}
