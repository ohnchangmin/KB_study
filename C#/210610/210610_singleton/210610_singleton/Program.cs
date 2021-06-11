using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            
            for (int i = 0; i < 5; i++)
            {
                SingleTest st1 = new SingleTest(r);
                Console.WriteLine("인스턴스: " + st1.getData());
                Console.WriteLine("싱글톤: " + SingleTest.getInstance(r).getData());
            }
        }
    }
}
