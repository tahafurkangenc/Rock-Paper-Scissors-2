using System.Collections;
using System.Runtime.InteropServices;

namespace TasKagitMakas
{
    public class Nesne
    {
        public String nesneadi;
        public double dayaniklilik=20.0;
        public int seviyePuani=0;
        public int keskinlik = 0, direnc = 0, nufus = 0, kalinlik = 0, katilik = 0, sicaklik = 0;
        public double a = 0.2;
        public Boolean evrimGecirdimi = false;
        //IDE bu oluşturucuların başına "protected" ekledi
        public Nesne()
        {
            this.keskinlik = 0;
            this.direnc = 0;
            this.nufus = 0;
            this.kalinlik = 0;
            this.katilik = 0;
            this.sicaklik = 0;
        }
        public Nesne(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik, int katilik , int sicaklik)
        {
            this.dayaniklilik = dayaniklilik;
            this.seviyePuani = seviyePuani;
            this.nesneadi = nesneadi;
            this.a = a;
            this.keskinlik=keskinlik;
            this.direnc= direnc;
            this.nufus=nufus;
            this.kalinlik=kalinlik;
            this.katilik=katilik;
            this.sicaklik=sicaklik;
        }
        // nesnePuaniGoster Methodu eklenecek
        /*Nesnelerin dayanıklılık ve seviye puanı ¨ozelliklerini oyunda g¨ostermek i¸cin nesnePuaniGoster
          metodu yazılmalıdır
         */
        public virtual double etkiHesapla(Nesne rakipnesne)
        {
            if (!evrimGecirdimi)//evrim geçirmediyse bu şekilde hesaplanır
            {
                if (nesneadi.Equals("makas"))
                {
                    return keskinlik / ((a * rakipnesne.nufus) + (1 - a) * rakipnesne.katilik);
                }

                else if (nesneadi.Equals("kagit"))
                {
                    return nufus / ((a * rakipnesne.katilik) + (1 - a) * rakipnesne.keskinlik);
                }

                else if (nesneadi.Equals("tas"))
                {
                    return katilik / ((a * rakipnesne.keskinlik) + (1 - a) * rakipnesne.nufus);
                }
                
                else
                {
                    return 0;
                }
            }
            else // eğer evrim geçirdiyse bu şekilde hesaplanır
            {
                if (nesneadi.Equals("makas"))
                {
                    return (keskinlik*direnc) / ((a * rakipnesne.nufus)*rakipnesne.kalinlik + (1 - a) * rakipnesne.katilik*rakipnesne.sicaklik);
                }

                else if (nesneadi.Equals("kagit"))
                {
                    return (nufus*katilik) / ((a * rakipnesne.katilik)*rakipnesne.sicaklik + (1 - a) * rakipnesne.keskinlik *rakipnesne.direnc);
                }

                else if (nesneadi.Equals("tas"))
                {
                    return (katilik*sicaklik) / ((a * rakipnesne.keskinlik)*rakipnesne.direnc + (1 - a) * rakipnesne.nufus *rakipnesne.kalinlik);
                }
                
                else
                {
                    return 0;
                }
            }
            
        }
        public override string ToString()
        {
            return "Nesne Adı: " + nesneadi + "\n" +
                   "Dayanıklılık: " + dayaniklilik + "\n" +
                   "Seviye Puanı: " + seviyePuani + "\n" +
                   "Keskinlik: " + keskinlik + "\n" +
                   "Direnç: " + direnc + "\n" +
                   "Nüfus: " + nufus + "\n" +
                   "Kalınlık: " + kalinlik + "\n" +
                   "Katılık: " + katilik + "\n" +
                   "Sıcaklık: " + sicaklik + "\n" +
                   "A: " + a + "\n" +
                   "Evrim Geçirdi mi?: " + evrimGecirdimi;
        }

    }

    public class TasClass : Nesne
    {
        public TasClass()
        {
            // // olanlar 2. constructorda parametre olan değişkenlerdir
            nesneadi = "Tas"; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 0; //
            direnc = 0; //
            nufus = 0; //
            kalinlik = 0; //
            katilik = 2; //
            sicaklik = 0; //
            a = 0.2; //
            evrimGecirdimi = false;
        }

        public TasClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik, 
            int katilik,int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = false;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Tas") || rakipnesne.nesneadi.Equals("Agir Tas"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi) 
            {
                return (katilik) / ((a * rakipnesne.keskinlik * rakipnesne.direnc) + ((1 - a) * rakipnesne.nufus * rakipnesne.kalinlik)); // onaylandı
            }
            else 
            {
                return katilik / ((a * rakipnesne.keskinlik) + ((1 - a) * rakipnesne.nufus)); // onaylandı
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }

    public class AgirTasClass : TasClass
    {
       public AgirTasClass()
       {
            nesneadi = "Agir Tas"; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 0; //
            direnc = 0; //
            nufus = 0; //
            kalinlik = 0; //
            katilik = 2; //
            sicaklik = 2; //
            a = 0.2; //
            evrimGecirdimi = true;
       }

        public AgirTasClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik, int katilik, int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = true;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Tas") || rakipnesne.nesneadi.Equals("Agir Tas"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi)  // rakip nesne evrim geçirdiyse
            {
                return (katilik * sicaklik) / ((a * rakipnesne.keskinlik* rakipnesne.direnc) + ((1 - a) * rakipnesne.nufus * rakipnesne.kalinlik));
            }
            else  // rakip nesne evrim geçirmemişse
            {
                return (katilik * sicaklik) / ((a * rakipnesne.keskinlik) + ((1 - a) * rakipnesne.nufus));
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }

    public class KagitClass : Nesne
    {
        public KagitClass()
        {
            // // olanlar 2. constructorda parametre olan değişkenlerdir
            nesneadi = "Kagit"; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 0; //
            direnc = 0; //
            nufus = 2; //
            kalinlik = 0; //
            katilik = 0; //
            sicaklik = 0; //
            a = 0.2; //
            evrimGecirdimi = false;
        }

        public KagitClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik,
            int katilik, int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = false;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Kagit") || rakipnesne.nesneadi.Equals("Ozel Kagit"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi) // rakip evrim geçirdiyse
            {
                return (nufus) / ((a * rakipnesne.katilik * rakipnesne.sicaklik) + ((1 - a) * rakipnesne.keskinlik * rakipnesne.direnc)); //onaylandı
            }
            else  // rakip normalse
            {
                return nufus / ((a * rakipnesne.katilik) + (1 - a) * rakipnesne.keskinlik); //onaylandı
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }

    public class OzelKagitClass : KagitClass
    {
        public OzelKagitClass()
        {
            nesneadi = "Ozel Kagit"; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 0; //
            direnc = 0; //
            nufus = 2; //
            kalinlik = 2; //
            katilik = 0; //
            sicaklik = 0; //
            a = 0.2; //
            evrimGecirdimi = true;
        }

        public OzelKagitClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik, int katilik, int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = true;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Kagit") || rakipnesne.nesneadi.Equals("Ozel Kagit"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi)  // rakip nesne evrim geçirdiyse
            {
                return (nufus * kalinlik) / ((a * rakipnesne.katilik * rakipnesne.sicaklik) + ((1 - a) * rakipnesne.keskinlik * rakipnesne.direnc));
            }
            else  // rakip nesne evrim geçirmemişse
            {
                return (nufus * kalinlik) / ((a * rakipnesne.katilik) + ((1 - a) * rakipnesne.keskinlik ));
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }


    public class MakasClass : Nesne
    {
        
        public MakasClass()
        {
            // // olanlar 2. constructorda parametre olan değişkenlerdir
            nesneadi = "Makas"; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 2; //
            direnc = 0; //
            nufus = 0; //
            kalinlik = 0; //
            katilik = 0; //
            sicaklik = 0; //
            a = 0.2; //
            evrimGecirdimi = false;
        }

        public MakasClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik,
            int katilik, int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = false;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Makas") || rakipnesne.nesneadi.Equals("Usta Makas"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi)
            {
                return (keskinlik) / ((a * rakipnesne.nufus * rakipnesne.kalinlik) + ((1 - a) * rakipnesne.katilik * rakipnesne.sicaklik)); //onaylandı
            }
            else
            {
                return keskinlik / ((a * rakipnesne.nufus) + ((1 - a) * rakipnesne.katilik)); // onaylandı
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }

    public class UstaMakasClass : Nesne
    {
        public UstaMakasClass()
        {
            // // olanlar 2. constructorda parametre olan değişkenlerdir
            nesneadi = "Usta Makas "; //
            dayaniklilik = 20.0; //
            seviyePuani = 0; //
            keskinlik = 2; //
            direnc = 2; //
            nufus = 0; //
            kalinlik = 0; //
            katilik = 0; //
            sicaklik = 0; //
            a = 0.2; //
            evrimGecirdimi = false;
        }

        public UstaMakasClass(double dayaniklilik, int seviyePuani, string nesneadi, double a, int keskinlik, int direnc, int nufus, int kalinlik,
            int katilik, int sicaklik) : base(dayaniklilik, seviyePuani, nesneadi, a, keskinlik, direnc, nufus, kalinlik, katilik, sicaklik)
        {
            evrimGecirdimi = false;
        }

        public override double etkiHesapla(Nesne rakipnesne)
        {
            if (rakipnesne.nesneadi.Equals("Makas") || rakipnesne.nesneadi.Equals("Usta Makas"))
            {
                return 0;
            }
            if (rakipnesne.evrimGecirdimi)
            {
                return (keskinlik*direnc) / ((a * rakipnesne.nufus * rakipnesne.kalinlik) + ((1 - a) * rakipnesne.katilik * rakipnesne.sicaklik)); //onaylandı
            }
            else
            {
                return (keskinlik*direnc) / ((a * rakipnesne.nufus) + ((1 - a) * rakipnesne.katilik)); // onaylandı
            }
            //return base.etkiHesapla(rakipnesne);
        }
    }

    internal static class Program
    {
        public static int degiskendeneme = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        public static Random random = new Random();

        public static List<Nesne> kullanicikartlariList = new List<Nesne>();
        public static List<Nesne> rakipkartlariList = new List<Nesne>();

        static void Main()
        {
            AllocConsole();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            TasClass tasClass = new TasClass();
            KagitClass kagitClass = new KagitClass();
            MakasClass makasClass = new MakasClass();
            AgirTasClass agirTasClass = new AgirTasClass();
            UstaMakasClass ustaMakasClass = new UstaMakasClass();
            OzelKagitClass ozelKagitClass = new OzelKagitClass();

            Console.WriteLine("Tas to kagit : " + tasClass.etkiHesapla(kagitClass));
            Console.WriteLine("Tas to makas : " + tasClass.etkiHesapla(makasClass));
            Console.WriteLine("Tas to ustamakas : " + tasClass.etkiHesapla(ustaMakasClass));
            Console.WriteLine("Tas to ozel kagit : " + tasClass.etkiHesapla(ozelKagitClass));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Kagit to tas : " + kagitClass.etkiHesapla(tasClass));
            Console.WriteLine("Kagit to makas : " + kagitClass.etkiHesapla(makasClass));
            Console.WriteLine("Kagit to ustamakas : " + kagitClass.etkiHesapla(ustaMakasClass));
            Console.WriteLine("Kagit to agirtas : " + kagitClass.etkiHesapla(agirTasClass));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Makas to tas : " + makasClass.etkiHesapla(tasClass));
            Console.WriteLine("Makas to kagit : " + makasClass.etkiHesapla(kagitClass));
            Console.WriteLine("Makas to ozelkagit : " + makasClass.etkiHesapla(ozelKagitClass));
            Console.WriteLine("Makas to agirtas : " + makasClass.etkiHesapla(agirTasClass));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Agir tas to makas : " + agirTasClass.etkiHesapla(makasClass));
            Console.WriteLine("Agir tas to kagit : " + agirTasClass.etkiHesapla(kagitClass));
            Console.WriteLine("Agir tas to ozelkagit : " + agirTasClass.etkiHesapla(ozelKagitClass));
            Console.WriteLine("Agir tas to ustaMakas : " + agirTasClass.etkiHesapla(ustaMakasClass));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Ozel Kagit to tas : " + ozelKagitClass.etkiHesapla(tasClass));
            Console.WriteLine("Ozel Kagit to makas : " + ozelKagitClass.etkiHesapla(makasClass));
            Console.WriteLine("Ozel Kagit to ustamakas : " + ozelKagitClass.etkiHesapla(ustaMakasClass));
            Console.WriteLine("Ozel Kagit to agirtas : " + ozelKagitClass.etkiHesapla(agirTasClass));
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Usta Makas to tas : " + ustaMakasClass.etkiHesapla(tasClass));
            Console.WriteLine("Usta Makas to kagit : " + ustaMakasClass.etkiHesapla(kagitClass));
            Console.WriteLine("Usta Makas to ozelkagit : " + ustaMakasClass.etkiHesapla(ozelKagitClass));
            Console.WriteLine("Usta Makas to agirtas : " + ustaMakasClass.etkiHesapla(agirTasClass));

            // Rakip kartların random seçilişi
            if (rakipkartlariList.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    int randomsayi = random.Next(3);
                    if (randomsayi == 0)// TAŞ 
                    {
                        rakipkartlariList.Add(new TasClass());
                    }
                    else if (randomsayi == 1) //KAĞIT
                    {
                        rakipkartlariList.Add(new KagitClass());
                    }
                    else if (randomsayi == 2) //MAKAS
                    {
                        rakipkartlariList.Add(new MakasClass());
                    }

                }
                if (rakipkartlariList.Count == 5)
                {
                    Console.WriteLine("Rakip Bilgisayar Rastgele Seçimleri");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(rakipkartlariList[i].ToString() + "\n------------------\n");

                    }
                }
                else
                {
                    Console.WriteLine("HATA : rakipkartlariList boyutu 5 değil.\n Program.rakipkartlariList.Count =" + rakipkartlariList.Count);
                }

            }
            else
            {
                Console.WriteLine("HATA : rakipkartlariList boyutu 0 değil.\n Program.rakipkartlariList.Count =" + rakipkartlariList.Count);
            }


            Application.Run(new Form1());
            //Application.Run(new GameForm());
        }
    }
}