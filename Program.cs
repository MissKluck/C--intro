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

        // en character det er en datatype som inneholder én karakter, den representerer tegn i UTF-16 encoding.
        /*
        UTF-16 encoding
        */

        char a = 'A';

        char b = 'B';

        Console.WriteLine(a + b);

        float z = 3.14f;

        Console.WriteLine(z * 2);
        // boolean det er en datatype som inneholder en boolsk tilstand(looooool); dette betyr at du bare sjekker om noe er sant eller usant.
        bool isOnline = false; // denne er false, når vi bruker ! sier vi egentlig "not false" som da vil si at den blir true
        Console.WriteLine(!isOnline);

        /*
        int -> inneholder 4 bytes
        long -> inneholder 8 bytes 

        int kan bare ta tall opp til en hvis størrelse, så om vi skal bruke store tall, eller vet at det kommer til å vokse til store tall gjennom å bruke det i løkker så bør vi bruke long

        float -> kan holde på desimantall med en presisjon på rundt seks til syv desimaler
        couble -> kan holde på desimaltall med en presisjon på rundt femten desimaler
        */

        long myNumber = 120000;

        Console.WriteLine(myNumber);

        // så lenge variabelen er innenfor static void, så kan man slå de sammen eller regne med de, basically de kan interacte med hverandre
    }
}
