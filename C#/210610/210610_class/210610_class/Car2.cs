using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class
{
    class Car2
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string brand;
        private string color;
        private string model;
        private string price;


        public Car2(string brand, string color, string model, string price)
        {
            this.brand = brand;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }

        public void printCarInfo()
        {
            Console.WriteLine("브랜드: " + brand);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);
        }

        public override string ToString()
        {
            string str = "브랜드: " + brand + "\n";
            str += "색상: " + color + "\n";
            str += "모델: " + model + "\n";
            str += "가격: " + price + "\n";

            return str;
        }
    }
}
