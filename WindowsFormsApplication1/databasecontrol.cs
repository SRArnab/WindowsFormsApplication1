using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class databasecontrol
    {
      
        public MySqlConnection DBconnection()
        {
            string ConnectionString = "datasource = localhost; username  = root;password=;database = testdatabase; convert zero dateTime=true";
             MySqlConnection dbconnect = new MySqlConnection(ConnectionString);
            try
            {
                dbconnect.Open();
                return dbconnect;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return dbconnect;
            }
        }

        public int InsertIntoEquipments(string v1, string v2, int v3, int v4,DateTime v5 , string v6, string v7)
        {

            MySqlConnection con =   DBconnection();
            string query = "insert into equipments(itemname,type,quantity,damaged,date,roomno,facultyid) values('"+v1+"','"+v2+"','"+v3+"','"+v4+"','"+v5.ToString("yyyy-MM-dd")+"','"+v6+"','"+v7+"')";
            MySqlCommand cmd =new MySqlCommand(query,con);
            int results = cmd.ExecuteNonQuery();
            con.Close();
            return results;
            
        }


        public int UpdateToEquipment(string name,string type,int quantity,int damaged,string roomno,string facultyid)
        {
            MySqlConnection con = DBconnection();
            string query = "update equipments set quantity='"+quantity+"',damaged='"+damaged+"',roomno='"+roomno+"',facultyid='"+facultyid+"' where itemname='"+name+"' and type = '"+type+"' ";
            MySqlCommand cmd = new MySqlCommand(query,con);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            UpdateDamagedNumber(name,type,damaged);
            return result;

        }

       
        public int FindQuantity(string itemname , string itemtype) 
        {
            MySqlConnection con = DBconnection();
            string query = "select * from tools where itemname = '"+itemname+"' and itemtype = '"+itemtype+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                int quantity = mdr.GetInt32("quantity");
                con.Close();
                return quantity;
                
            }
            else 
            {
                con.Close();
                return 0;
                
            }
            
        }

        public int FindDamaged(string itemname, string itemtype)
        {
            MySqlConnection con = DBconnection();
            string query = "select * from tools where itemname = '" + itemname + "' and itemtype = '" + itemtype + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                int damaged = mdr.GetInt32("damaged");
                con.Close();
                return damaged;

            }
            else
            {
                con.Close();
                return 0;

            }

        }

        public int UpdateDamagedNumber(string itemname, string itemtype , int damage) 
        {
            MySqlConnection con = DBconnection();
            string query = "select * from tools where itemname = '" + itemname + "' and itemtype = '" + itemtype + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                int damaged = mdr.GetInt32("damaged");
                int totalDamage = damaged + damage;
                con.Close();
                MySqlConnection con1 = DBconnection();
                string query1 = "update tools set damaged='" + totalDamage + "'  where itemname='" + itemname + "' and itemtype ='" + itemtype + "' ";
                MySqlCommand cmd1 = new MySqlCommand(query1, con1);
                int result = cmd1.ExecuteNonQuery();
                con1.Close();
                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else 
            {
                return 0;
            }
           
        }
        public void EmptyEquipmentsTable() 
        {
            MySqlConnection con = DBconnection();
            string query = "delete from equipments";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable getAll() 
        {
            MySqlConnection con = DBconnection();
            string query = "select * from tools";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
       

        public DataTable searchItemFromTools(string name) 
        {
            MySqlConnection con = DBconnection();
            string query = "select * from tools where itemname = '"+name+"' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public int updateToTools(int id,string name,string type,int quantity,int damaged) 
        {
                MySqlConnection con = DBconnection();
                string query1= "update tools set itemname = '"+name+"',itemtype = '"+type+"',quantity='"+quantity+"',damaged='"+damaged+"' where id = '"+id+"'";
                MySqlCommand cmd1 = new MySqlCommand(query1,con);
                cmd1.ExecuteNonQuery();
                con.Close();
                return 1;
            
        }
        public int InsertIntoTools(string name , string type , int quantity , int damaged) 
        {
            MySqlConnection con = DBconnection();
            string query1 = "select * from tools where itemname ='"+name+"'and itemtype = '"+type+"' ";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            MySqlDataReader mdr = cmd1.ExecuteReader();
            if (mdr.Read())
            {
                con.Close();
                return 0;
            }
            else 
            {
                con.Close();
                MySqlConnection con1 = DBconnection();
                string query2 = "insert into tools(itemname,itemtype,quantity,damaged) values('"+name+"','"+type+"','"+quantity+"','"+damaged+"')";
                MySqlCommand cmd2 = new MySqlCommand(query2,con1);
                int result=cmd2.ExecuteNonQuery();
                if (result > 0)
                {
                    con1.Close();
                    return 1;
                }
                else 
                {
                    con1.Close();
                    return 3;
                }
                
               
              
            }
            
        }
    }
}
