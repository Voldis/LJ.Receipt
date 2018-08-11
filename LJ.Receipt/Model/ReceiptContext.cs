using System.Data.Entity;

namespace LJ.Receipt.Model
{
    public class ReceiptContext : DbContext
    {
        public DbSet<Receipt> Receipts { get; set; }
    }
}
