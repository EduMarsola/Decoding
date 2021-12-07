using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Code_for_Education
{
    public class Connection
    {
        string connectionString = "Persist Security info = false;database=decoding;server=127.0.0.1;user id='deco';Password='decosanti19';SSL Mode=None;";
        public MySqlConnection mcon = new MySqlConnection();
        public void insert(String code_func , String linguagem_func = "", String autor_func = "", String descri_func = "", String nome_func = "")
        {
            if(mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("addFuncoes", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_autor_func", autor_func);
            mcomma.Parameters.AddWithValue("_descri_func", descri_func);
            mcomma.Parameters.AddWithValue("_code_func", code_func);
            mcomma.Parameters.AddWithValue("_linguagem_func", linguagem_func);
            mcomma.Parameters.AddWithValue("_nome_func", nome_func);
            mcomma.ExecuteNonQuery();
            mcon.Close();
            mcon.Dispose();                 
        }

        public String SelectCode(int id_func)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewFuncoes", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_id_func", id_func);
            MySqlDataReader dr = mcomma.ExecuteReader();
            String a = "";
            while(dr.Read())
            {
                a = dr["code_func"].ToString();
            }
            dr.Close();
            mcon.Close();
            mcon.Dispose();
            return a;
        }

        public string[] SelectName(String word)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewByWordName", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_word", word);
            MySqlDataReader dr = mcomma.ExecuteReader();
            String a = "";
            dr.Read();
            String[] b = new string[3];
            b[0] = dr["nome_func"].ToString();
            b[1] = dr["code_func"].ToString();
            b[2] = dr["descri_func"].ToString();
            dr.Close();
            mcon.Close();
            mcon.Dispose();
            return b;
        }

        public String SelectAutor(int id_func)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewFuncoes", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_id_func", id_func);
            MySqlDataReader dr = mcomma.ExecuteReader();
            String a = "";
            while (dr.Read())
            {
                a = dr["autor_func"].ToString();
            }
            dr.Close();
            mcon.Close();
            mcon.Dispose();
            return a;
        }
        public String SelectByWordAutor(String word)
        {
            if(mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewByWordAutor", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_word", word);
            MySqlDataReader dr = mcomma.ExecuteReader();
            dr.Read();
            String a = dr["autor_func"].ToString();
            mcon.Close();
            mcon.Dispose();
            return a;
            
        }

        public String SelectByWordDescri(String word)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewByWordDescri", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_word", word);
            MySqlDataReader dr = mcomma.ExecuteReader();
            dr.Read();
            String a = dr["descri_func"].ToString();
            mcon.Close();
            mcon.Dispose();
            return a;
        }

        public String SelectByWordCode(String word)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            MySqlCommand mcomma = new MySqlCommand("viewByWordFunc", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_word", word);
            MySqlDataReader dr = mcomma.ExecuteReader();
            dr.Read();
            String a = dr["code_func"].ToString();
            mcon.Close();
            mcon.Dispose();
            return a;
        }


        public int SelectCount(String word)
        {
            if (mcon.State == System.Data.ConnectionState.Closed)
            {
                mcon.ConnectionString = connectionString;
                mcon.Open();
            }
            int i = 0;
            MySqlCommand mcomma = new MySqlCommand("viewCount", mcon);
            mcomma.CommandType = System.Data.CommandType.StoredProcedure;
            mcomma.Parameters.AddWithValue("_word", word);
            MySqlDataReader dr = mcomma.ExecuteReader();
            while (dr.Read())
            {
                i = Convert.ToInt32(dr["count(*)"]);
            }
            dr.Close();
            mcon.Close();
            mcon.Dispose();
            return i;
        }
    }       
}

