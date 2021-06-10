using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class
{
    class Car
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string brand;
        private string color;
        private string model;
        private string price;

        //객체를 생성할 때 사용되는 특수한 메소드라 생각하면 돼
        public Car()
        {
            brand = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        public Car(string brand, string color, string model, string price)
        {
            this.brand = brand;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarInfo()
        {
            Console.WriteLine("브랜드: " + brand);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);
        }

        public void setModel(string model) 
        {
            this.model = model;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }

        public string getPrice()
        {
            return price;
        }

        
    }
}
