using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 학생성적관리_210401
{
    class Student
    {
        public string Name { get; set; }
        public int Korean { get; set; }
        public int English { get; set; } 
        public int Math { get; set; }
        public int Social { get; set; }
        public int Science { get; set; }      
        public int Sum { get; set; }
        public double Average { get; set; } 
        public int Ranking { get; set; }
    }
}
