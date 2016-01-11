using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu {
    class MemberController : Dao {
        String TABLE_NAME = "member";
        String[] KEYS = { "first_name", "last_name", "gender", "phone", "TC", "email", "address" }; //member tablosunun kolonları
        
        // Kitap ve kitap ile bağlantılı olan verileri gerekli tablolara kaydetme
        public String memberAdd(String first_name, String last_name, String gender, String phone, String TC, String email, String address) {
            // book tablosuna verilen değerleri ekleme
            return add(TABLE_NAME, KEYS,
                        first_name, last_name, gender, phone, TC, email, address);
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
    }
}
