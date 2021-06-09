using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //출력
            Console.Write("안녕하세요");
            Console.WriteLine("헬로우 씨샵");

            //입력
            Console.Write("이름을 입력: ");
            string name = Console.ReadLine();
            Console.WriteLine("이름: " + name);
            Console.Write("나이 입력: ");
            //string age = Console.ReadLine();
            //int nAge = Convert.ToInt32(age);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("나이: {0}", age);
            Console.WriteLine("나이: {0}, 이름 {1}", age, name);
            string str = string.Format("이름: {0}, 나이: {1}", name, age);
            Console.WriteLine(str);


        }
    }
}
