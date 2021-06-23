using _210611_carFixMgr.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class OraHandler
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=CARCENTER;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        public OraHandler()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
            Console.WriteLine("객체 생성");
        }

        //소멸자
        ~OraHandler()
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
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 해제 에러!");
            }
        }

        /*public void insertDB()
        {
            string model = "R8";
            string cc = "2500cc 초과";
            string number = "50나 5701";
            string caryear = "2020년식";

            string query = string.Format("insert into car_t values(null, '{0}', '{1}', '{2}', '{3}')", model, number, cc, caryear);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }*/


        public void insertDB(Receipt receipt)
        {
            try
            {
                string query = string.Format("insert all into car_t values (CAR_T_SEQ.NEXTVAl, '{0}', '{1}', '{2}', '{3}')", receipt.Car.Model, receipt.Car.Number, receipt.Car.Cc, receipt.Car.Year);
                query += string.Format("into customer_t values(CUSTOMER_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', CAR_T_SEQ.CURRVAL)", receipt.Cust.Name, receipt.Cust.Tel, receipt.Cust.Birth);
                query += "select * from dual";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                for (int i = 0; receipt.ItemList.Count < 3; i++)
                {
                    string queryItem = string.Format("insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL, {0}, '{1}', {2}, car_t_SEQ.currval)", receipt.ItemList.);
                    cmd.Connection = conn;
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }

                string queryReceipt = string.Format("insert into receipt_t values (receipt_t_SEQ.NEXTVAL, customer_t_seq.currval, '{0}', (select staff_t.staff_id from staff_t where staff_t.name = '{1}'), REPAIR_ITEM_T_SEQ.CURRVAL, {2})");
                cmd.Connection = conn;
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errMsg(e);                
            }
        }
    }
}

