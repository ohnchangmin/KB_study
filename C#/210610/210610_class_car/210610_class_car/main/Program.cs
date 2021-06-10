using _210610_class_car.carApp.model;
using _210610_class_car.carApp.utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_car.carApp.main
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rd = new RandData();
            Customer cu = new Customer(rd.getName(), rd.getTel(), rd.getAddress(), new Car(rd.getBrand(), rd.getModel(), rd.getColor(), rd.getYear()));

            cu.printCustomerInfo();
        }
    }
}
