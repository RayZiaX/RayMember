using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace RayMember
{
    class DBUse
    {
        private string m_inf = @"server=localhost;database=RayMember_data;port=3308;userid=root;password=";
        public bool Inscription(string a, string b, string c, string d, string e)
        {
            MySqlConnection bdd = new MySqlConnection(m_inf);
            string stmt = "INSERT INTO customers(customer_userName,customer_password,customer_email,customer_nationality,customer_gender) VALUES(@userName,@password,@email,@nationality,@gender)";

            try
            {
                bdd.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(stmt,bdd);
                    cmd.Parameters.AddWithValue("@userName", a);
                    cmd.Parameters.AddWithValue("@password", b);
                    cmd.Parameters.AddWithValue("@email", c);
                    cmd.Parameters.AddWithValue("@nationality", d);
                    cmd.Parameters.AddWithValue("@gender", e);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    return true;
                }catch(Exception err)
                {
                    bdd.Close();
                    Console.WriteLine("error: " + err);
                    return false;
                }
            }
            catch(Exception error)
            {
                bdd.Close();
                Console.WriteLine("error: "+ error);
                return false;
            }
        }
        public bool Auth(string a,string b)
        {
            MySqlConnection bdd = new MySqlConnection(m_inf);
            string stmt = $"SELECT customer_id,customer_userName,customer_password FROM customers WHERE customer_userName = {a} AND customer_password = {b}";
            try
            {
                bdd.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(stmt, bdd);
                    return true;
                }catch(Exception error)
                {
                    bdd.Close();
                    Console.WriteLine("error: " + error);
                    return false;
                }

            }catch(Exception err)
            {
                bdd.Close();
                Console.WriteLine("error: " + err);
                return false;
            }
        }

    }
}
