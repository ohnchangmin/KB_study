using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("새로운 main");

            //1차원 배열 초기화1
            int[] arrInt = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i] + " ");
                string str = string.Format("1차원 배열[{0}]:{1}", i, arrInt[i]);
                Console.WriteLine(str);
            }

            Console.WriteLine("================================================");
            //1차원 배열 초기화2
            char[] arrCh = new char[4]
            {
                '박', '김', '이', '최'
            };
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
                string str = string.Format("1차원 배열[{0}]:{1}", i, arrCh[i]);
                Console.WriteLine(str);
            }

            Console.WriteLine("================================================");
            //2차원 배열 초기화1
            int[,] arrInt2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)     //행
            {
                for (int j = 0; j < 3; j++) //열
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("================================================");
            //2차원 배열 초기화2
            string[][] arrStr = new string[2][];
            arrStr[0] = new string[] { "김범수", "나얼", "박효신" };
            arrStr[1] = new string[] { "한지민", "한효주" };

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < arrStr[i].Length; j++)
                {
                    Console.Write(arrStr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("================================================");
            //2차원 배열 초기화3
            int[][] arrInt3 = new int[3][];
            for (int i = 0; i < arrInt3.Length; i++)
            {
                arrInt3[i] = new int[i + 1];
                for (int j = 0; j < arrInt3[i].Length; j++)
                {
                    arrInt3[i][j] = 10 + j;
                    Console.Write(arrInt3[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("================================================");
            //foreach 1차원
            int[] arrEach = { 10, 20, 30, 40, 50 };
            foreach (int s in arrEach)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n================컬렉션 클래스===================");
            //foreach 2차원

            string[,] arrEach2 = { { "김길동", "홍길동" }, { "전우치", "박우치" } };
            foreach (string s in arrEach2)
            {
                Console.Write(s + " ");
            }

            //컬렉션 클래스
            //List == 자바의 어레이 리스트

            List<string> list = new List<string>();
            list.Add("한지민");
            list.Add("한효주");
            list.Add("박보영");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            list.RemoveAt(0); //index 0번째 데이터 삭제
            list.Remove("박길동");
            list.Insert(0, "전우치");
            for (int i = 0; i < list.Count; i++) //index 0번째 "전우치" 추가
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            //hash table(key, value)
            Hashtable hTable = new Hashtable();
            hTable.Add(1, "홍길동");
            hTable.Add(2, "김길동");

            if(hTable.Contains(1))
            {
                Console.WriteLine(hTable[1]);
            }

            //딕셔너리
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "한지민");
            dic.Add("key2", "박보영");
            dic.Add("key3", "한효주");
            Console.WriteLine("값:{0}", dic["key2"]);

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("key:{0}-value:{1}", item.Key, item.Value);
            }

            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(string val in dic.Values)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("=================EXAM1================");
            int[] arrExam1 = { 20, 34, 22, 14, 36, 23, 67 };
            int sum = 0;
            for(int i=0; i<arrExam1.Length; i++)
            {
                sum += arrExam1[i];
            }
            int average = sum / arrExam1.Length;
            Console.WriteLine("합: {0}", sum);
            Console.WriteLine("평균: {0}", average);

            Console.WriteLine("=================EXAM2================");

            int[] arrExam2 = new int[100];
            for(int i=0; i<arrExam2.Length; i++)
            {
                arrExam2[i] = i+1;
                //Console.Write(arrExam2[i] + " ");
                
                if((i+1)%5 == 0)
                {
                   Console.Write(arrExam2[i] + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("=================EXAM3================");
            int[] arrExam3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };



            Console.WriteLine("=================EXAM4================");
            int[][] arrExam4 = new int[5][];
            arrExam4[0] = new int[] {1, 2};
            arrExam4[1] = new int[] { 2, 4, 6 };
            arrExam4[2] = new int[] { 3, 6 };
            arrExam4[3] = new int[] { 4,8,10,12 };
            arrExam4[4] = new int[] { 10};

            for (int i = 0; i < arrExam4.Length; i++)
            {
                for(int j = 0; j < arrExam4[i].Length; j++)
                {
                    Console.Write("arrExam4[{0}][{1}] = {2}   ", i, j ,arrExam4[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("=================EXAM5================");
            int[,] arrExam5_1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arrExam5_2 = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int[][] arrExam5_result = new int[3][];

            for(int i = 0; i<arrExam5_result.Length; i++)
            {
                arrExam5_result[i] = new int[i];
                for(int j=0; j<arrExam5_result[i].Length; j++)
                {
                    arrExam5_result[i][j] = arrExam5_1[i,j] + arrExam5_2[i,j];
                    Console.Write(arrExam5_result[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
