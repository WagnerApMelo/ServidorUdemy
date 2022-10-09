using ServidorUdemy.Models;
using ServidorUdemy.Models.Enums;

namespace ServidorUdemy.Data
{
    public class SeedingService
    {
        private ServidorUdemyContext _context;

        public SeedingService(ServidorUdemyContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronocs");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");


            Seller s1 = new Seller(1, "bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "alex@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 26), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 27), 25000.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 29), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 30), 1856.0, SaleStatus.Billed, s6);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 10, 01), 100.0, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 10, 05), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 11, 01), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 11, 08), 2300.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 12, 02), 5680.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 12, 13), 15656.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 12, 24), 1956.0, SaleStatus.Billed, s5);


            _context.Departament.AddRange(d1, d2, d3, d3);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);

            _context.SaveChanges();
        }
    }
}
