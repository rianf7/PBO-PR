class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string merk, string tipe) : base("Intel", tipe)
    {

    }
}

class amd : Processor
{
    public amd(string merk, string tipe) : base("AMD", tipe)
    {

    }
}

class Corei3 : Intel
{
    public Corei3(string merk, string tipe) : base(merk, "Core i3")
    {

    }
}

class Corei5 : Intel
{
    public Corei5(string merk, string tipe) : base(merk, "Core i5")
    {

    }
}

class Corei7 : Intel
{
    public Corei7(string merk, string tipe) : base(merk, "Core i7")
    {

    }
}

class Ryzen : amd
{
    public Ryzen(string merk, string tipe) : base(merk, "RYZEN")
    {

    }
}

class Athlon : amd
{
    public Athlon(string merk, string tipe) : base(merk, "ATHLON")
    {

    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {

    }
}

class AMD : Vga
{
    public AMD() : base("AMD")
    {

    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala.");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati.");
    }
}

class ASUS : Laptop
{
    public ASUS(string merk, string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    {

    }
}

class ACER : Laptop
{
    public ACER(string merk, string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    {

    }
}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {

    }
}

class ROG : ASUS
{
    public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, "ROG", vga, processor)
    {

    }
}

class Vivobook : ASUS
{
    public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Vivobook", vga, processor)
    {

    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Swift : ACER
{
    public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Swift", vga, processor)
    {

    }
}

class Predator : ACER
{
    public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Predator", vga, processor)
    {

    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game.");
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, "IdeaPad", vga, processor)
    {

    }
}

class Legion : Lenovo
{
    public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Legion", vga, processor)
    {

    }
}

namespace PR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vga Vga1 = new Vga("Nvidia");
            Processor processor1 = new Processor("Intel", "Core i5");
            Laptop laptop1 = new Vivobook("ASUS", "Vivobook", Vga1, processor1);
            Vga Vga2 = new Vga("AMD");
            Processor processor2 = new Processor("AMD", "Ryzen");
            Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", Vga2, processor2);
            Processor processor3 = new Processor("Intel", "Core i7");
            Predator predator = new Predator("ACER", "Predator", Vga2, processor3);


            //Soal 1
            Console.WriteLine("Soal 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //Soal 2
            Console.WriteLine("\nSoal 2");
            //laptop1.Ngoding();

            //Soal 3
            Console.WriteLine("\nSoal 3");
            Console.WriteLine($"{Vga1.merk} {processor1.merk} {processor1.tipe}");

            ////Soal 4
            Console.WriteLine("\nSoal 4");
            predator.BermainGame();

            ////Soal 5
            Console.WriteLine("\nSoal 5");
            //ACER acer = new Predator();
            //acer.BermainGame();
        }
    }
}

