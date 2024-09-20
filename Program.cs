class Program{
    static void Main(string[] args)
    {
        Kebun_Binatang kebun_Binatang = new Kebun_Binatang();
        Singa singa = new Singa(4,10);
        Gajah gajah = new Gajah(4,5);
        Ular ular = new Ular(0,2);
        Buaya buaya = new Buaya(4,6);
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
        Console.WriteLine(singa.InfoHewan());;

        // Soal 4
        ular.Merayap();

        // Soal 5
        Reptil reptil = new Buaya(4,8);
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
    internal string name;
    internal int umur;

    public Hewan(string name,int umur){
        this.name = name;
        this.umur = umur;
    }

    public virtual string Suara(){
        return "Hewan ini bersuara";
    }

    public string InfoHewan(){
        return $"Nama Hewa : {this.name}\nUmur Hewan : {this.umur}";
    }
}

class Mamalia : Hewan {
    public Mamalia(int jumlah_kaki,string name,int umur):base(name,umur){
        this.jumlah_kaki = jumlah_kaki;
    }
    public int jumlah_kaki;

    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }
}

class Reptil : Hewan{
    public Reptil(double Panjang_Tubuh,string name,int umur):base(name,umur){
        this.Panjang_Tubuh = Panjang_Tubuh;
    }
    public double Panjang_Tubuh;

    public override string Suara()
    {
        return "Reptil ini bersuara";
    }
}

class Singa : Mamalia{
    public Singa(int jumlah_kaki,int umur):base(jumlah_kaki,"Singa",umur){

    }
    public override string Suara(){
        return "Singa ini bersuara";
    }

    public void Mengaum(){
        Console.WriteLine("Singa ini mengaum");
    }
}

class Gajah : Mamalia{

    public Gajah(int jumlah_kaki,int umur):base(jumlah_kaki,"Gajah",umur){

    }
    public override string Suara(){
        return "Gajah ini bersuara";
    }

}

class Ular : Reptil{
    public Ular(int jumlah_kaki,int umur):base(jumlah_kaki,"Ular",umur){}
    public override string Suara(){
        return "Ular ini bersuara";
    }

    public void Merayap(){
        Console.WriteLine("Ular ini merayap");
    }
}

class Buaya : Reptil{
    public Buaya(int jumlah_kaki,int umur):base(jumlah_kaki,"Buaya",umur){

    }
    public override string Suara(){
        return "Buaya ini bersuara";
    }
}