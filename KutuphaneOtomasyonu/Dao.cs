using System;
using System.Data;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    class Dao{
        protected SqlConnection con;
        
        // Veritabını bağlantısı.
        protected Dao() {
            con = new SqlConnection("server=SALIHCAN;database =Library;Integrated Security = true");
        }

        // Veri tabanına, aldığı tablo adı, keyleri ve value parametrelerine göre ekleme yapma. 
        protected String add(String table_name, String[] key_params, params String[] value_params) {
            String keys = string.Join(",", key_params);
            String values = "";
            for (int i = 0; i < key_params.Length; i++ )
                values += "@" + key_params[i] + ",";

            values = values.Remove(values.Length - 1);
            SqlCommand cmd = new SqlCommand("insert into " + table_name + " (" + keys +") values (" + values + ") SELECT SCOPE_IDENTITY()", con);

            for (int i = 0; i< value_params.Length; i++ )
                cmd.Parameters.AddWithValue("@" + key_params[i], value_params[i]);

            return runScalar(cmd);
        }

        // Veritabanından, aldığı tablo adı ve kolon ismi parametrelerine göre sorgu yapma.
        protected DataTable select(String table_name, String column_name) {
            SqlDataAdapter cmd = new SqlDataAdapter("select " + column_name + " from " + table_name, con);
            return runQuery(cmd);
        }

        // Veritabanından, aldığı tablo adı, ve kolon ismine ve aranan isim parametrelerine göre arama yapma.
        protected DataTable find(String table_name, String column_name, String name) {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from " + table_name + " where " + column_name + " like '%" + name + "%'", con);
            return runQuery(cmd);
        }

        // Veri tabanını, aldığı tablo adı, keyleri ve value parametrelerine göre güncelleme yapma.
        protected bool update(String table_name, String id, String[] key_params, params String[] value_params) {
            String keys = "";
            foreach(String key in key_params){
                keys += key + " = " + "@" + key + ",";
            }
            keys = keys.Remove(keys.Length - 1);

            SqlCommand cmd = new SqlCommand("update " + table_name + " set " + keys + " where id = " + id , con);

            for (int i = 0; i< value_params.Length; i++)
                cmd.Parameters.AddWithValue("@" + key_params[i], value_params[i]);
            return runNonQuery(cmd);
        }

        // Veri tabanınından, aldığı tablo adı, ve id parametresine göre silme yapma.
        protected bool delete(String table_name, String column_name, String id) {
            SqlCommand cmd = new SqlCommand("delete from " + table_name + " where "+ column_name + " = " + id, con);
            return runNonQuery(cmd);
        }

        // Ekleme işlmeleri için kullanılan veritabanı işlemi
        protected String runScalar(SqlCommand cmd ) {
            String tmp = "";
            try{
                con.Open();
                tmp = cmd.ExecuteScalar().ToString();
            }catch (Exception){
            }
            finally{
                con.Close();
            }
            return tmp;
        }

        // Güncelleme ve Silme işlmeleri için kullanılan veritabanı işlemi
        protected bool runNonQuery(SqlCommand cmd) {
            bool tmp = false;
            try {
                con.Open();
                cmd.ExecuteNonQuery();
                tmp = true;
            } catch (Exception) {
                tmp = false;
            } finally {
                con.Close();
            }
            return tmp;
        }

        // Select sorgusu için veritabanı işlemi.
        protected DataTable runQuery(SqlDataAdapter cmd) {
            DataTable dt = new DataTable();
            try {
                con.Open();
                cmd.Fill(dt);
            } catch (Exception) {
            } finally {
                con.Close();
            }
            return dt;
        }
    }
}
