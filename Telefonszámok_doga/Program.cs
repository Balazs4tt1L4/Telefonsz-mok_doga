namespace Telefonszámok_doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> telefonszamok = new List<string>();
            telefonszamok.Add("+36202275895");
            telefonszamok.Add("06203568987");
            telefonszamok.Add("(06)20/2558222");
            telefonszamok.Add("203568978+");
            telefonszamok.Add("nullahat202289578548");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Összes telefonszám");
                Console.WriteLine("2 Számjegyeket tartalmazók");
                Console.WriteLine("3 12 karakter hosszúak");
                Console.WriteLine("4 Számjegyeket és + jelet tartalmazók");
                Console.WriteLine("5 Azok amiben 6-os szám van");
                Console.WriteLine("6 Számjegy és + jel, de csak elől lehet a + jel");
                Console.WriteLine("7 Csak 06-tal kezdődő");
                Console.WriteLine("8 ( és vagy ) jel van benne");
                string valaszt = Console.ReadLine();

                if (valaszt == "0")
                {
                    return;
                }
                else if (valaszt == "1")
                {
                    Console.Clear();
                    //Mindent megjelenít
                    foreach (var telefonsz in telefonszamok)
                    {
                        Console.WriteLine(telefonsz);
                    }
                }
                else if (valaszt == "2")
                {
                    //Számjegyeket tartalmazókat írja ki
                    Console.Clear();
                    foreach (var telefonsz in telefonszamok)
                    {
                        bool szamjegy = true;
                        foreach (var karakt in telefonsz)
                        {
                            if (!char.IsDigit(karakt))
                            {
                                szamjegy = false;
                            
                            }
                        }
                        if (szamjegy)
                        {
                            Console.WriteLine(telefonsz);
                        }
                    }
                }
                else if (valaszt == "3")
                {
                    //3
                }
                else if (valaszt == "4")
                {
                    //4
                }
                else if (valaszt == "5")
                {
                    //5
                }
                else if (valaszt == "6")
                {
                    //6
                }
                else if (valaszt == "7")
                {
                    //7
                }
                else if (valaszt == "8")
                {
                    //8
                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs!");
                }
                Console.ReadKey();
            }
        }
    }
}
