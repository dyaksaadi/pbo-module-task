// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

class RunProgram
{
    static void Main(string[] args)
    {
        KebunBinatang kebunbinatang = new KebunBinatang();
        Singa singa = new Singa();
        Gajah gajah = new Gajah();
        Ular ular = new Ular();
        Buaya buaya = new Buaya();
        kebunbinatang.tambahHewan(singa);
        kebunbinatang.tambahHewan(gajah);
        kebunbinatang.tambahHewan(ular);
        kebunbinatang.tambahHewan(buaya);
        kebunbinatang.DaftarHewan();
        singa.Mengaum();
        System.Console.WriteLine(ular.Suara());
        System.Console.WriteLine(gajah.Suara());
        singa.nama = "viru";
        singa.umur = 2;
        singa.jumlahkaki = 4;
        System.Console.WriteLine(singa.infoHewan() + " Jumlah Kaki: " + singa.jumlahkaki);
        ular.Merayap();
        Reptil reptil = new Buaya();
        Console.WriteLine(reptil.Suara());
    }
}

class Hewan
{
    public string nama;
    public int umur;
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }
    public virtual string infoHewan()
    {
        return ("Nama: " + nama + " Umur: " + umur );
    }
}
class Mamalia : Hewan
{
    public int jumlahkaki;
    public override string Suara()
    {
        return null;
    }
    
}
class Reptil : Hewan
{
    public double panjangTubuh;
    public override string Suara()
    {
        return null;
    }
}

class Singa : Mamalia
{
    public override string Suara()
    {
        return "NGAUNGGGGG";
    }
    public void Mengaum()
    {
        System.Console.WriteLine($"Singa Mengaum: {Suara()}");
    }
}
class Gajah : Mamalia
{
    public override string Suara()
    {
        return "MEEEE MEEEEEE";
    }
}

class Ular : Reptil
{
    public override string Suara()
    {
        return "SSSSHHHHHH";
    }
    public void Merayap()
    {
        System.Console.WriteLine("Ular Merayap");
    }
}
class Buaya : Reptil
{
    public override string Suara()
    {
        return "RORRRRRRRRRRRRR";
    }
}
class KebunBinatang
{
    List<string> koleksiHewan = new List<string>();
    public void tambahHewan(Hewan hewan)
    {
        koleksiHewan.Add($"{hewan}");
    }
    public void DaftarHewan()
    {
        foreach (string hewan in koleksiHewan)
        {
            Console.WriteLine(hewan);
        }
    }
}

