using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_student.utill
{
    class RandData
    {
        private string[] name = { "한지민", "박효신", "한효주", "박보영", "유아인" };
        private int[] age = { 20, 25, 30, 40, 35 };
        private char[] gender = { '남', '여' };
        private string[] address = { "대구 동구 동부로 13", "부산 해운대구 해변길 24", "서울 강남구 가로수길 15", "경남 함양군 유동길 16", "대구 달서구 감삼길 17" };
        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public int getAge()
        {
            return age[r.Next(0, 5)];
        }

        public char getGender()
        {
            return gender[r.Next(0, 2)];
        }


        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }
    }
}
