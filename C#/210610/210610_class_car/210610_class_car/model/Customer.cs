using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_car.carApp.model
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        private Car car;
       
        public Customer(string name, string tel, string address, Car car)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        internal Car Car { get => car; set => car = value; }


 
        public void printCustomerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("연락처: " + tel);
            Console.WriteLine("주소: " + address);
            Car.printCarInfo();
            Console.WriteLine("===========================================\n");
        }
    }
}
