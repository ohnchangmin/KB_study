using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210610_class_car.carApp.utill
{
    class RandData
    {
        string[] name = {"한지민", "한효주", "이병헌", "유아인", "신예은" };
        string[] tel = { "010-3484-3123", "010-7961-3549", "010-7635-1734", "010-7985-3548", "010-7635-1777" };
        string[] address = { "대구 동구 동부로 13", "부산 해운대구 해변길 24", "서울 강남구 가로수길 15", "경남 함양군 유동길 16", "대구 달서구 감삼길 17" };
        string[] model = { "R8", "랭글러", "EQ900", "파나메라 GTS", "마이바흐 S클래스" };
        string[] color = {"블랙", "레드", "블루", "화이트", "실버" };
        int[] year = {2016, 2017, 2018, 2019, 2020 };
        string[] brand = { "아우디", "벤츠", "포르쉐", "지프", "현대" };

        Random r = new Random();
        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];

        }

        public string getModel()
        {
            return model[r.Next(0, 5)];
        }

        public string getColor()
        {
            return color[r.Next(0, 5)];
        }

        public int getYear()
        {
            return year[r.Next(0, 5)];

        }

        public string getBrand()
        {
            return brand[r.Next(0, 5)];
        }
    }

   
}
