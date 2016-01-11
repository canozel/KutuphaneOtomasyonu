using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    class BooksController : Dao {
        String TABLE_NAME = "book";
        String[] KEYS = { "ISBN", "name", "publised_date", "number_of_pages", "language", "description", "publisher_id", "author_id"}; //book tablosunun kolonları

        // Kitap ve kitap ile bağlantılı olan verileri gerekli tablolara kaydetme
        public String BookAdd(String isbn, String name, String publised, String pages, String language, String description, String publiser_id, String author_id) {
            // book tablosuna verilen değerleri ekleme
            return add(TABLE_NAME, KEYS, 
                        isbn, name, publised, pages, language, description, publiser_id, author_id );
        }

        // Aranacak kelimeye göre book tablosunun "name" kolonunda arama yapma 
        public DataTable BookFind(String name) {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT b.id,b.name as KitapAdı, b.ISBN , a.name as Yazar, b.language as Dil, b.number_of_pages as Sayfa,"+
	                                                   "b.publised_date as YayımTarihi, b.description as Açıklama " +
	                                                "FROM book b "+
	                                                "JOIN author a ON b.author_id = a.id "+
 	                                                "JOIN publisher p ON p.id = b.publisher_id where b.name like '%" + name + "%'", con);
            return runQuery(cmd);
        }

        // Kitapları yazar isimleri ile getirme.
        public DataTable getBooks() {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT b.id, b.name as KitapAdı, b.ISBN , a.name as Yazar, b.language as Dil, b.number_of_pages as Sayfa,"+
	                                                   "b.publised_date as YayımTarihi, b.description as Açıklama " +
	                                                "FROM book b "+
	                                                "JOIN author a ON b.author_id = a.id "+
 	                                                "JOIN publisher p ON p.id = b.publisher_id ", con);
            return runQuery(cmd);
        }

        // Tüm yazarları getirme.
        public DataTable getAuthors() {
            return select("author", "*");
        }

        // Yazar ekleme.
        public String AuthorAdd(String name) {
            String[] author_keys = {"name"};
            return add("author", author_keys , name);
        }

        // Yayınevi ekleme.
        public String PublisherAdd(String name) {
            String[] publisher_keys = { "name" };
            return add("publisher", publisher_keys, name);
        }

        // Tüm yayıncıları getir.
        public DataTable getPubliser() {
            return select("publisher", "*");
        }

        // Seçili kitabı güncelleme.
        public bool updateBook(String id, String isbn, String name, String publised, String pages, String language, String description, String publisher_id, String author_id) {
            return update(TABLE_NAME, id, KEYS, isbn, name, publised, pages, language, description, publisher_id, author_id);
        }

        // Şecili kitabı silme.
        public bool deleteBook(String id) {
            delete("deposit", "book_id", id);
            return delete(TABLE_NAME,"id", id);
        }
    }
}
