using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_singleton
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        static Random r = new Random();

        public SingleTest(Random r)
        {
            
            data = r.Next(1,100);
        }

        public static SingleTest getInstance(Random r)
        {
            if(inst == null)
            {
                inst = new SingleTest(r);
            }
            return inst;
        }

        public int getData()
        {
            return data;
        }
    }
}
