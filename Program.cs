class Program{
    static void Main(string[] args)
    {
        Kebung_Binatang ragunan = new();
    }
}

class Kebung_Binatang{
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