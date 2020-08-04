﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<string> tabLine = new List<string> { };
        private List<string> m_tab = new List<string> { };
        private List<List<string>> m_tabAccount = new List<List<string>>();
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
            string stmt = $"SELECT customer_id,customer_userName,customer_password FROM customers WHERE customer_userName = '{a}'";
            MySqlCommand cmd = new MySqlCommand(stmt, bdd);
            try
            {
                bdd.Open();
                

            }catch(Exception err)
            {
                bdd.Close();
                Console.WriteLine("error: " + err);
                return false;
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string line = reader.GetString(i);
                    tabLine.Add(line);
                }
            }
            if(tabLine.Count == 0)
            {
                return false;
            }
            else
            {
                if(tabLine[1] == a && tabLine[2] == b)
                {
                    return true;
                }
                else
                {
                return false;
                }
            }
        }
        public bool AddAccount(string a, string b, string c, string d, int e, string f,string g,string h,string i, string j,string k, string l)
        {
            MySqlConnection bdd = new MySqlConnection(m_inf);
            string stmt = "INSERT INTO accounts(account_type, account_userName, account_password, account_email, customer_id, account_tag, account_Q1, account_Q2, account_Q3, account_answer1, account_answer2, account_answer3) VALUES (@accountType, @userName, @password, @email,@userId ,@accountTag, @accountQ1, @accountQ2, @accountQ3, @answer1, @answer2, @answer3)";
            try
            {
                bdd.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(stmt, bdd);
                    cmd.Parameters.AddWithValue("@accountType",a);
                    cmd.Parameters.AddWithValue("@userName",b);
                    cmd.Parameters.AddWithValue("@password",c);
                    cmd.Parameters.AddWithValue("@email",d);
                    cmd.Parameters.AddWithValue("@userId",e);
                    cmd.Parameters.AddWithValue("@accountTag",f);
                    cmd.Parameters.AddWithValue("@accountQ1",g);
                    cmd.Parameters.AddWithValue("@accountQ2",h);
                    cmd.Parameters.AddWithValue("@accountQ3",i);
                    cmd.Parameters.AddWithValue("@answer1",j);
                    cmd.Parameters.AddWithValue("@answer2",k);
                    cmd.Parameters.AddWithValue("@answer3",l);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception err)
                {
                    Console.WriteLine("error: " + err);
                    return false;
                }
            }catch(Exception error)
            {
                Console.WriteLine("error: " + error);
                return false;
            }

        }
        public bool AddAccountList(int a)
        {
            MySqlConnection bdd = new MySqlConnection(m_inf);
            string stmt = $"SELECT account_id,account_type,account_userName,account_email,account_tag FROM accounts WHERE customer_id = {a}";
            try
            {
                bdd.Open();
            }
            catch (Exception err)
            {
                bdd.Close();
                Console.WriteLine("error: " + err);
                return false;
            }
            MySqlCommand cmd = new MySqlCommand(stmt, bdd);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                List<string> line = new List<string> { reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                m_tabAccount.Add(line);
            }
            if (m_tabAccount.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string>infoUser()
        {
            tabLine.RemoveAt(2);
            return tabLine;
        }
        public List<List<string>> tabAccount()
        {
            return m_tabAccount;
        }
    }
}
