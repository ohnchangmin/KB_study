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

                List<RepairItem> itemList = receipt.ItemList;
                for (int i = 0; i<itemList.Count; i++)
                {
                    RepairItem item = itemList[i];
                    string queryItem = string.Format("insert into REPAIR_ITEM_T values (REPAIR_ITEM_T_SEQ.NEXTVAL, {0}, '{1}', {2}, car_t_SEQ.currval)", item.Idx, item.Repair, item.Price);
                    cmd.Connection = conn;
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }

                string queryReceipt = string.Format("insert into receipt_t values (receipt_t_SEQ.NEXTVAL, customer_t_seq.currval, '{0}', (select staff_t.staff_id from staff_t where staff_t.name = '{1}'), REPAIR_ITEM_T_SEQ.CURRVAL, {2})", receipt.InDate, receipt.StaffName, receipt.TotalPrice);
                cmd.Connection = conn;
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }

        public void showDb()
        {
            string query = string.Format("select indate as 접수일, total_price as 총결제금액, (select customer_t.name from customer_t where customer_t.cust_id = receipt_t.cust_id) as 고객명, (select staff_t.staff_id from staff_t where staff_t.staff_id = receipt_t.staff_id) as 담당자 from receipt_t");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]);
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("============================================");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }

            string query2 = "select repair, price from repair_item_t where car_id = (select customer_t.cust_id from customer_t where customer_t.name = '홍길동')";
            cmd.Connection = conn;
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("============================================");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }
            dr.Close();
        }

        public List<ReceiptVO> getReceipt()
        {
            string query = string.Format("select indate as 접수일, total_price as 총결제금액, (select customer_t.name from customer_t where customer_t.cust_id = receipt_t.cust_id) as 고객명, (select staff_t.name from staff_t where staff_t.staff_id = receipt_t.staff_id) as 담당자 from receipt_t");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<ReceiptVO> listReceiptVO = new List<ReceiptVO>();
            int count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("접수날짜: " + dr["접수일"]);
                    //Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    //Console.WriteLine("고객명: " + dr["고객명"]);
                    //Console.WriteLine("담당자: " + dr["담당자"]);
                    //Console.WriteLine("============================================");
                    ReceiptVO receiptVO = new ReceiptVO(dr["접수일"].ToString(), Convert.ToInt32(dr["총결제금액"]), dr["고객명"].ToString(), dr["담당자"].ToString());
                    listReceiptVO.Add(receiptVO);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }
            dr.Close();
            return listReceiptVO;
        }

        public List<RepairItem> getRepairItem()
        {
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            string query2 = "select repair_item_id as 번호, repair as 수리항목, price as 수리비 from repair_item_t where car_id = (select customer_t.cust_id from customer_t where customer_t.name = '김쪼아')";
            cmd.Connection = conn;
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            List<RepairItem> items = new List<RepairItem>();
            count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("============================================");
                    count++;
                    RepairItem repairItem = new RepairItem(Convert.ToInt32(dr["번호"]), dr["수리항목"].ToString(), Convert.ToInt32(dr["수리비"]));
                    items.Add(repairItem);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }
            dr.Close();
            return items;
        }
        
        public List<RepairItem> getRepairItem(string custName)
        {
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            string query2 = string.Format("select repair_item_id as 번호, repair as 수리항목, price as 수리비 from repair_item_t where car_id = (select customer_t.cust_id from customer_t where customer_t.name = '{0}')", custName);
            cmd.Connection = conn;
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            List<RepairItem> items = new List<RepairItem>();
            count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("============================================");
                    count++;
                    RepairItem repairItem = new RepairItem(Convert.ToInt32(dr["번호"]), dr["수리항목"].ToString(), Convert.ToInt32(dr["수리비"]));
                    items.Add(repairItem);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다");
                Console.WriteLine("=============================");
            }
            dr.Close();
            return items;
        }

    }
}

