class Program{
    static void Main(string[] args)
    {
        Kebun_Binatang kebun_Binatang = new Kebun_Binatang();
        Singa singa = new Singa();
        Gajah gajah = new Gajah();
        Ular ular = new Ular();
        Buaya buaya = new Buaya();
        kebun_Binatang.TambahHewan("Buaya");
        kebun_Binatang.TambahHewan("Singa");
        kebun_Binatang.TambahHewan("Ular");
        kebun_Binatang.TambahHewan("Gajah");
        kebun_Binatang.DaftarHewan();
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());
        singa.Mengaum();
        // Soal  1
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());

        // Soal 2
        singa.Mengaum();

        // Soal 3
        singa.InfoHewan();

        // Soal 4
        ular.Merayap();

        // Soal 5
        Reptil reptil = new Buaya();
        Console.WriteLine(reptil.Suara());;
    }
}

class Kebun_Binatang{
    List<string> KoleksiHewan = new List<string>();

    public void TambahHewan(string Hewan){
        this.KoleksiHewan.Add(Hewan);
    }

    public void DaftarHewan(){
        foreach(string x in this.KoleksiHewan){
            Console.WriteLine(x);
        }
    }
}

class Hewan{
    string name;
    int umur;

    public virtual string Suara(){
        return "Hewan ini bersuara";
    }

    public string InfoHewan(){
        return $"Nama Hewa : {this.name}\nUmur Hewan : {this.umur}";
    }
}

class Mamalia : Hewan {
    int jumlah_kaki;

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }
}

class Reptil : Hewan{
    double Panjang_Tubuh;

    public override string Suara()
    {
        return "Reptil ini bersuara";
    }
}

class Singa : Mamalia{
    public override string Suara(){
        return "Singa ini bersuara";
    }

    public void Mengaum(){
        Console.WriteLine("Singa ini mengaum");
    }
}

class Gajah : Mamalia{
    public override string Suara(){
        return "Gajah ini bersuara";
    }

}

class Ular : Reptil{
    public override string Suara(){
        return "Ular ini bersuara";
    }

    public void Merayap(){
        Console.WriteLine("Ular ini merayap");
    }
}

class Buaya : Reptil{
    public override string Suara(){
        return "Buaya ini bersuara";
    }
}