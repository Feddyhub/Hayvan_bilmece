

using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Animal
{
    public Animal(int a, int b, string c, int d)
    {
        height = a;
        weight = b;
        Color = c;
        
        int[] TEMP = { 0, 1, 2, 3, 4, 5 };
        if (d >= 0 && d < 6)
        {
            d = TEMP[d];
            Strength = d;
        }
        else
        {
            Console.WriteLine("Geçersiz güç indeksi. Lutfen 0-5 Araliginda giriniz.");
        }

    }

    int HEIGHT;
    int WEIGHT;
    string Color;
    int Strength;

    public  void ToString()
    {
        Console.WriteLine($"{this} Turleri Genel Bilgiler:  BOY:{height}  KILO: {weight}  RENK: {Color}  GUC: {Strength}");
    }
    public virtual void Sound()
    {
        Console.WriteLine("Hayvan Sesleri Farklidir.");
    }

   




    public int height
    { get 
        {
            return HEIGHT;
        }
        set 
        {
            if (value<0 || value>400)
            {
                Console.WriteLine("Lutfen Gecerli bir Boy giriniz (ABARTTIN)");
            }
            else
            {
                HEIGHT=value;
                
            }
        }
    }

    public int weight
    {
        get { return (WEIGHT); }
        set
        {
            if (value < 0 || value > 2000)
            {
                Console.WriteLine("Lutfen Gecerli bir Kilo giriniz (ABARTTIN) ");
            }
            else
            {
                WEIGHT = value;
            }
        }
    }

    


    }
    public class Lion:Animal
{
       public Lion(int _weight, int _height, String _color, int x) :base(_weight, _height, _color, x)
    { 
    }
    public void deneme()
    {
        Console.WriteLine("calisti");
    }
        public  override void Sound()
        {
            Console.WriteLine("Sound:   ROARRR\n");
        }
    }

    public class Start_Game{
    public static void Main(string[] args)

    {
        //Lion Family
        Lion Puma = new Lion(160, 250, "YELLOW", 5);
        Lion Cheetah = new Lion(200, 500, "BLACK-YELLOW", 5);
        Lion Panter = new Lion(122, 422, "PURE BLACK", 5);

        // Animal Sorting
        Animal Popular = new Animal(70, 25, "YELLOW", 3);
        Animal Fly = new Animal(1, 3, "YELLOW", 0);


        Console.WriteLine("Lutfen Sececeginiz Hayvanin Familyasini seciniz: (1-5)");
        Console.WriteLine("Lion (1)|| Fly(2)|| WILD (3)|| PET (4)|| Others (5)");
        string tahmin =Console.ReadLine();

        if(tahmin == "1")
        {
            Console.WriteLine("Aslan kabilesine giris yaptiniz.");
            Console.WriteLine("Bu Hayvanlarin hangi ozelligini merak ediyorsun ?");
            Console.WriteLine("INFO (1)|| SOUNDS (2)");
            string tahmin2 = Console.ReadLine();
            if (tahmin2 == "1")
            {
                
                Puma.ToString();
                Cheetah.ToString();
                Panter.ToString();
            }
            else 
            {
                Puma.Sound();
            }



        }

        //Fly Family






    }

}
