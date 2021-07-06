using gymManagement.common;
using gymManagement.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement.controller
{
    class OraController
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=GYM;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;
        public OraController()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
            Console.WriteLine("객체 생성");
        }
        //소멸자
        ~OraController()
        {
            dbClose();
            Console.WriteLine("객체 소멸");
        }
        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }

        public void errMsg(OracleException e)
        {
            Console.WriteLine("에러번호: " + e.Number + e.Message);
            Console.WriteLine(e.StackTrace);
        }
        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!");
            }
            catch (OracleException)
            {
                Console.WriteLine("오라클 접속 해제 에러!");
            }
        }
        public Login getLoginDb(string loginId, string loginPw)
        {
            Login login = new Login();
            //string query = string.Format("SELECT ADMIN_ID as ID, ADMIN_PW as PW FROM ADMIN_T WHERE ADMIN_ID = 'ADMIN' AND ADMIN_PW = '1234'");
            //string query = "SELECT ADMIN_ID as ID, ADMIN_PW as PW FROM ADMIN_T WHERE ADMIN_ID = 'ADMIN' AND ADMIN_PW = '1234'";
            string query = string.Format("SELECT ADMIN_ID as ID, ADMIN_PW as PW FROM ADMIN_T WHERE ADMIN_ID = '{0}' AND ADMIN_PW = '{1}'", loginId, loginPw);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    login = new Login(dr["ID"].ToString(), dr["PW"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }
            dr.Close();
            return login;
        }

        public void insertTrainerDb(Trainer trainer)
        {
            try
            {
                string query = "INSERT INTO TRAINER_T VALUES(TRAINER_T_SEQ.NEXTVAL, '박스쾃', '971214-124111', '010-0115-7415', '대구광역시 북구 동부로 1341', '정규직', '팀장', '3000')";
                //string query = string.Format("insert all into car_t values (CAR_T_SEQ.NEXTVAl, '{0}', '{1}', '{2}', '{3}')", receipt.Car.Model, receipt.Car.Number, receipt.Car.Cc, receipt.Car.Year);
                //query += string.Format("into customer_t values(CUSTOMER_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', CAR_T_SEQ.CURRVAL)", receipt.Cust.Name, receipt.Cust.Tel, receipt.Cust.Birth);
                //query += "select * from dual";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

               /* List<RepairItem> itemList = receipt.ItemList;
                for (int i = 0; i < itemList.Count; i++)
                {
                    RepairItem item = itemList[i];
                    string queryItem = string.Format("insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL, {0}, '{1}', {2}, car_t_SEQ.currval)", item.Idx, item.Repair, item.Price);
                    cmd.Connection = conn;
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }*/

               /* string queryReceipt = string.Format("insert into receipt_t values (receipt_t_SEQ.NEXTVAL, customer_t_seq.currval, '{0}', (select staff_t.staff_id from staff_t where staff_t.name = '{1}'), REPAIR_ITEM_T_SEQ.CURRVAL, {2})", receipt.InDate, receipt.StaffName, receipt.TotalPrice);
                cmd.Connection = conn;
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();*/
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }
        public List<Trainer> getTrainerDb()
        {
            List<Trainer> listTrainer = new List<Trainer>();
            try
            {
                string query = "SELECT * FROM TRAINER_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("트레이너 이름: " + dr["T_NAME"]);
                        Console.WriteLine("트레이너 주민등록번호: " + dr["T_RRN"]);
                        Console.WriteLine("트레이너 연락처: " + dr["T_TEL"]);
                        Console.WriteLine("트레이너 주소: " + dr["T_ADDRESS"]);
                        Console.WriteLine("고용형태: " + dr["T_JOB_TYPE"]);
                        Console.WriteLine("직급: " + dr["T_RANK"]);
                        Console.WriteLine("급여: " + dr["T_SALARY"]);
                        Console.WriteLine("============================================");
                        Trainer trainerVo = new Trainer(dr["T_NAME"].ToString(), dr["T_RRN"].ToString(), dr["T_TEL"].ToString(), dr["T_ADDRESS"].ToString(), dr["T_JOB_TYPE"].ToString(), dr["T_RANK"].ToString(), dr["T_SALARY"].ToString());
                        listTrainer.Add(trainerVo);
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다");
                    Console.WriteLine("=============================");
                }
                
            }
            catch(OracleException e)
            {
                errMsg(e);
            }
            return listTrainer;
        }
    }
}
