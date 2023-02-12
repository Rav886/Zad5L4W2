namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, adress, birthplace, namedad, namemam, surnamemam, education, employment, mail, number;
            int height;
            double wight;

            Console.WriteLine("Witaj w programie pobierającym Twoje dane");
            
            Console.WriteLine("Podaj swoje imie");            
            name = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            surname = Console.ReadLine();

            Console.WriteLine("Podaj swoj adres");
            adress = Console.ReadLine();

            Console.WriteLine("Podaj swoje miejsce urodzenia");
            birthplace = Console.ReadLine();

            Console.WriteLine("Podaj imie ojca");
            namedad = Console.ReadLine();

            Console.WriteLine("Podaj imie matki");
            namemam = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko panieńskie matki");
            surnamemam = Console.ReadLine();

            Console.WriteLine("Podaj swoje wykrztałcenie");
            education = Console.ReadLine();

            Console.WriteLine("Podaj swoje miejsce zatrudnienia");
            employment = Console.ReadLine();

            Console.WriteLine("Podaj swoj adres mail");
            mail = Console.ReadLine();

            Console.WriteLine("Podaj swoj numer telefonu");
            number = (Console.ReadLine());

            Console.WriteLine("Podaj swoj wzrost");
            height = int.Parse(Console.ReadLine());


            Console.WriteLine("Podaj swoją wage");
            wight = double.Parse(Console.ReadLine());


        }
    }
}