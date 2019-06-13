using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Clinic
{
    class DB
    {
        public static String DBFileName = "dent.db";
        // وكده بعمل كونكشن وكوماند بعمل منهم اوبجكتات اشتغل عليها بعد كده 
        public static SQLiteConnection conn = new SQLiteConnection("Data Source="+DBFileName);
        public static SQLiteCommand cmd = new SQLiteCommand("", conn);
        //دى مش هنستخدمها اوى بس دى لو شغال على اكر من داتا بيز او لما بتيجى تاخد نسخه احتياطيه وكده وتعمل باكاب فمش هنستخدمها الوقتى 
        public static void changDBFileName(string newDBFileName)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = "Data source="+newDBFileName;
            }
        }
        //بندها والفورم بتفتح علشان افتح الداتا بيز 
        public static void open()
        {

            if (conn.State == ConnectionState.Closed) conn.Open();

        }
        //دى الى  بندهها والفورم بتقفل علشان اقفل الداتا بيز 
        public static void close()
        {

            if (conn.State == ConnectionState.Open) conn.Close();
        }
        // دى بتنفزلى جمله سليكت وترجعلى بيها فى داتا تابل اللى هوا جدول وهمى 
        public  DataTable getData(string select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }
        //بتنفز كويرى من غير ما ترجعلى حاجه 
        public  void run(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public static DataTable GetData(string Select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = Select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }

        //بملى التابل اللى فى الفورم من الداتا بيز باستخدام حاجه اسمها داتا ادابتر دى بتجيبلى البيانات من الداتا بيز وتملى بيها الجدول الوهمى اللى هوا الداتا تابل وبعدين من الداتا تابل بملى الجدول بتاعى 
        //الداتا ادابتر ده بياخد جمله سيلكت واسم الداتا بيز اللى هيشتغل عليها وبعد كده عرفت داتا تابل وقلتله يملاه وخليت الميثود دى ترجعلى الداتا تابل 

        public  DataTable fillTable(string select ,DataTable tbl)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(select, "Data Source=" + DBFileName);


            adapter.Fill(tbl);
            return tbl;
        }
    }
}

