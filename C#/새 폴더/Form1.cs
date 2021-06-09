using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 학생성적관리_210401
{
    public partial class Form1 : Form
    {
        private List<Student> listStudents = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
            Read_Student();
        }

        //xml 생성
        private void Make_Students()
        {
            string studentsOutput = "";
            studentsOutput += "<students>\n";
            foreach (var item in listStudents)
            {
                studentsOutput += "<student>\n";
                studentsOutput += "<name>" + item.Name + "</name>\n";
                studentsOutput += "<korean>" + item.Korean + "</korean>\n";
                studentsOutput += "<english>" + item.English + "</english>\n";
                studentsOutput += "<math>" + item.Math + "</math>\n";
                studentsOutput += "<social>" + item.Social + "</social>\n";
                studentsOutput += "<science>" + item.Science + "</science>\n";
                studentsOutput += "<sum>" + item.Sum + "</sum>\n";
                studentsOutput += "<average>" + item.Average + "</average>\n";
                studentsOutput += "</student>\n";
            }
            studentsOutput += "</students>";

            File.WriteAllText(@"./Students.xml", studentsOutput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Make_Students();
        }

        
        //xml 읽기
        private void Read_Student()
        {
            try
            {
                FileInfo fib = new FileInfo(@"./Students.xml");

                if (!fib.Exists)
                {
                    MessageBox.Show("Students.xml 파일이 존재하지 않습니다.");
                    return;
                }

                listStudents.Clear();

                XmlDocument xdocStudent = new XmlDocument();
                xdocStudent.Load(@"./Students.xml");
                XmlNodeList nodeStudents = xdocStudent.SelectNodes("/students/student");
                foreach (XmlNode student in nodeStudents)
                {
                    listStudents.Add(new Student()
                    {
                        Name = student.SelectSingleNode("name").InnerText,
                        Korean = int.Parse(student.SelectSingleNode("korean").InnerText),
                        English = int.Parse(student.SelectSingleNode("english").InnerText),
                        Math = int.Parse(student.SelectSingleNode("math").InnerText),
                        Social = int.Parse(student.SelectSingleNode("social").InnerText),
                        Science = int.Parse(student.SelectSingleNode("science").InnerText),
                        Sum = int.Parse(student.SelectSingleNode("sum").InnerText),
                        Average = double.Parse(student.SelectSingleNode("average").InnerText),
                    });
                }
            }
            catch (FileLoadException exception)
            {
                //파일이 없으면 예외 발생: 새로운 파일 생성
                Make_Students();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Read_Student();
        }

      
        //이름, 성적입력하기
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && 
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {

                listStudents.Add(new Student()
                {
                    Name = textBox1.Text,
                    Korean = int.Parse(textBox2.Text),
                    English = int.Parse(textBox3.Text),
                    Math = int.Parse(textBox4.Text),
                    Social = int.Parse(textBox5.Text),
                    Science = int.Parse(textBox6.Text),
                    Sum = int.Parse(textBox7.Text),
                    Average = double.Parse(textBox8.Text),
                });
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listStudents;
            textBox1.Text = ""; 
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        //보여주기
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listStudents;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //총점, 평균 계산
        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && 
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {

                int sum = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text)
                + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text);

                double avg = sum / 5.0;

                textBox7.Text = sum.ToString();
                textBox8.Text = avg.ToString();
            }
        }


        //석차계산
        private void Rank()
        {
            Int32 rows = dataGridView1.Rows.Count;
            int rank = 0;
            for(Int32 i = 0; i<rows; i++)
            {
                for (Int32 j = 0; j < rows; j++)
                {
                    Int32 value1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    Int32 value2 = Convert.ToInt32(dataGridView1.Rows[j].Cells[6].Value);

                    if (value1 > value2)
                    {
                        //listStudents.Insert(8, new Student() { Ranking = rank });
                        listStudents[i].Ranking = rank;
                    }

                    if(value1<= value2)
                    {
                        rank++;
                        //listStudents.Insert(8, new Student() { Ranking = rank });
                        listStudents[i].Ranking = rank;                    }
                }
                rank = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rank();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listStudents;
        }
    }

}
