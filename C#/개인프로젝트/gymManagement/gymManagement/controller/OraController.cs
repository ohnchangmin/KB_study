using gymManagement.common;
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
            catch (OracleException e)
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
    }
}
