namespace C__intro;

class Program
{
    static void Main(string[] args)
    {
        // alle variabler må ha et ord som definerer hva slags variabel det er først, som string eller int, pluss et navn. 
        // en string det er en datatype som inneholder tekst.
        string helloWorld = "Hello World!";
        Console.WriteLine(helloWorld);

        // en integer det er en datatype som inneholder heltall, både positive og negative.
        int x = 10;
        Console.WriteLine(x * 2);

        // en double det er en datatype som inneholder desimaltall, og de må skrives med . ikke med , - samtidig kan du også skrive heltall med double, men ikke desimaltall med int
        double y = 13.4;
        Console.WriteLine(y + x);

        // en character det er en datatype som inneholder én karakter
        /*
        UTF-16 encoding
        */

        char a = 'A';
        Console.WriteLine(a);

        // så lenge variabelen er innenfor static void, så kan man slå de sammen eller regne med de, basically de kan interacte med hverandre
    }
}
