using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.printCarInfo();
            Console.WriteLine();
            Car car2 = new Car("AUDI", "블랙", "R8", "2억 5천만원");
            car2.setPrice("2억 6천만원");
            car2.printCarInfo();
            Console.WriteLine("가격표: " + car2.getPrice());

            Car2 car3 = new Car2("JEEP", "빨강", "랭글러", "5천 6백만원");
            Console.WriteLine("가격표: " + car3.Price);
            Console.WriteLine(car3.ToString());
        }
    }
}
