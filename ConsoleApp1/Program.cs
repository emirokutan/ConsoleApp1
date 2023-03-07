using ConsoleApp1;
using ConsoleApp1.EF6Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Firma;

namespace ConsoleApp1
{

    public class Firma
    {
        [Key]
        public int firmaıd { get; set; }
        public string firmaisim { get; set; }
        public DateTime? sprsızınblngc { get; set; }
        public DateTime? sprsızınbts { get; set; }
        public AggregateException onaydrm { get; set; }

        public ICollection<Urun> Uruns { get; set; }


        public class Urun
        {
            [Key]
            public int urunıd { get; set; }
            public int firmaıd { get; set; }
            public string urunad { get; set; }
            public int stokadet { get; set; }
            public int urunfyt { get; set; }

            public ICollection<Sıparıs> sıparıs { get; set; }
        }
        public class Sıparıs
        {
            [Key]
            public int sıparısıd { get; set; }
            public int firmaıd { get; set; }
            public int urunıd { get; set; }
            public string sprsvrnad { get; set; }
            public DateTime? sprstrh { get; set; }

            public ICollection<Sıparıs> Sıparısler { get; set; }
        }
    }

    namespace EF6Console
    {
        public class FirmaContext : DbContext
        {
            public FirmaContext() : base()
            {

            }

            public DbSet<Firma> Firmalar { get; set; }
            public DbSet<Urun> Uruns { get; set; }
            public DbSet<Sıparıs> Siparisler { get; set; }

            
        }
    }
    

}

    namespace EF6Console
    {
        class Program
        {
            static void Main(string[] args)
            {

                using (var ctx = new FirmaContext())
                {
                    var frm = new Firma() { firmaisim = "Eti" };
                    var urn = new Urun() { urunad = "Bisküvi"};
                    var sprs = new Sıparıs() { sıparısıd = 1 };


                FirmaContext veri = new FirmaContext();
                veri.Database.Create;



                  /*  ctx.Firmalar.Add(frm);
                    ctx.Uruns.Add(urn);
                    ctx.SaveChanges();
                  */
                }
                Console.ReadLine();
            }
            
        }
    }


