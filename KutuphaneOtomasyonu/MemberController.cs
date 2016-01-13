using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu {
    class MemberController : Dao {

        public static  Dictionary<string, string> current_user = new Dictionary<string, string>();

        String TABLE_NAME = "member";
        String[] KEYS = { "first_name", "last_name", "gender", "phone", "TC", "email", "address", "password" }; //member tablosunun kolonları
        
        // Kitap ve kitap ile bağlantılı olan verileri gerekli tablolara kaydetme
        public bool memberAdd(String first_name, String last_name, String gender, String phone, String TC, String email, String address) {
            // book tablosuna verilen değerleri ekleme
            return add(TABLE_NAME, KEYS,
                        first_name, last_name, gender, phone, TC, email, address, "12345");
        }

        // Aranacak kelimeye göre book tablosunun "name" kolonunda arama yapma 
        public DataTable memberFind(String name) {
            return find(TABLE_NAME, "first_name", name);
        }

        // Kitapları yazar isimleri ile getirme.
        public DataTable getMembers() {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from member", con);
            return runQuery(cmd);
        }

        // Seçili kitabı güncelleme.
        public bool updateMember(String id, String first_name, String last_name, String gender, String phone, String TC, String email, String address) {
            return update(TABLE_NAME, id, KEYS, first_name, last_name, gender, phone, TC, email, address);
        }

        // Şecili kitabı silme.
        public bool deleteMember(String id) {
            delete("deposit", "member_id", id);
            return delete(TABLE_NAME, "id", id);
        }

        public bool passwordControl(String TC, String password) {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from member where TC = '" + TC + "' and password = '" + password + "'", con);
            DataTable dt = runQuery(cmd);
            if (dt.Rows.Count == 0) {
                current_user.Clear();
                current_user.Add("id", "");
                current_user.Add("first_name", "");
                current_user.Add("TC", "");
            } else{
                current_user.Clear();
                current_user.Add("id", dt.Rows[0]["id"].ToString());
                current_user.Add("first_name", dt.Rows[0]["first_name"].ToString());
                current_user.Add("TC", dt.Rows[0]["TC"].ToString());
                return true;
            }
            return false;
        }

        public bool updatePassword(String password){
            String[] keys = { "password" };
            return update(TABLE_NAME,MemberController.current_user["id"],keys, password );
        }
    }
}
