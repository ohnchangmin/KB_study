using _210610_class_student.model;
using _210610_class_student.utill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_student.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            RandData rd = new RandData();
            
            for(int i=0; i<st.Length; i++)
            {                
                st[i] = new Student(rd.getName(), rd.getAge(), rd.getGender(), rd.getAddress());
            }
            st[9].Name = "전우치";
            st[9].Age = 24;
            st[9].Gender = '남';
            st[9].Address = "조선 한양인근 두메산골";

            for(int i=0; i<st.Length; i++)
            {
                Console.WriteLine(st[i]);
            }         
        }
    }
}
