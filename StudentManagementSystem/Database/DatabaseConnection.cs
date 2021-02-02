using ADOX;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Database {
    class DatabaseConnection {
        private OleDbConnection connection;

        public DatabaseConnection() {
            connection = null;
        }

        public void openConnection() {
            try {
                closeConnection();
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath + @"\smsdatabase.accdb;" + 
                                        "Persist Security Info = False;";
                conn.Open();
                connection = conn;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public OleDbConnection getConnection() {
            return connection;
        }

        public void closeConnection() {
            try {
                if (connection != null) {
                    connection.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Failed to close database connection!");
            }
        }

        /*
         * Following source code obtained from (Microsoft Application.StartupPath Property & Catalog Object (ADOX)).
         * 
         * Create accdb file if the file not exist in that path.
         */
        public bool createDatabaseFile() {
            var fileinfo = new System.IO.FileInfo(Application.StartupPath + @"\smsdatabase.accdb");
            if (!fileinfo.Exists) {
                Catalog catalog = new Catalog();
                catalog.Create(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\smsdatabase.accdb;");
                catalog = null;
                return true;
            }
            return false;
        }

    }
}
