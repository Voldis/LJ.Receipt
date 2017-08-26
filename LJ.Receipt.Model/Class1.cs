using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJ.Receipt.Model
{
    /// <summary>
    /// Manages the receipt sqlite database.
    /// </summary>
    public class ReceiptDatabase
    {
        private const string name = "ReceiptDatabase.sqlite";
        SQLiteConnection connectionString;

        public ReceiptDatabase()
        {

        }


        private void CreateDatabase()
        {
            SQLiteConnection.CreateFile(name);
        }
    }
}
