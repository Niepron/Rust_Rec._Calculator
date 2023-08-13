using System;

namespace Rust_Calculator
{
    class Program
    {

        static void Main()
        {
            int złom = 0;
            int metal = 0;
            int HQ = 0;
            int lina = 0;
            int tka = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Kalkulator Rust");
            Console.WriteLine("");
            Console.WriteLine("Zasady działania - wpisz 'Info' ");
            Console.WriteLine("");
            Console.WriteLine("Wejście do kalkulatora - 'Calc' ");
            Console.WriteLine("");
            Console.WriteLine("Wyjście - 'exit' ");
            Console.WriteLine("");
            Console.WriteLine("To change language - write 'eng' ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "Info" or "info" or "INFO":
                    Info();
                    break;
                case "Calc" or "CALC" or "calc":
                    CALC(złom,metal,HQ,lina,tka);
                    break;
                case "exit" or "EXIT" or "Exit":
                    System.Environment.Exit(0);
                    break;
                case "eng" or "ENG" or "Eng":
                    MainA();
                    break;
                default:
                    Main();
                    break;
            }

        }
        static void Info()
        {
            Console.Clear();
            Console.WriteLine("Witaj w informacji na temat programu!");
            Console.WriteLine("");
            Console.WriteLine("Kalkulator oblicza ci ilość rzeczy którą dostaniesz po przerobieniu ich w przerabiarce.");
            Console.WriteLine("W programie wpisujesz numerek odpowiadającemu itemu, a następnie ilość.");
            Console.WriteLine("Program zapisze ilość rzeczy którą dostaniesz, następnie możesz dodać kolejny przedmiot.");
            Console.WriteLine("Program przyjmuje ujemne wartości w celu odejmowania przedmiotów.");
            Console.WriteLine("Żeby wyjść wciśnij Enter.");
            Console.WriteLine("Krótkie przypomnienie jaki item co daje: ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Electric Fuse - 20 złomu");
            Console.WriteLine("2 - Empty Propane Tank - 1 złom + 50 frag. metalu");
            Console.WriteLine("3 - Gears - 10 złomu + 13 frag. metalu");
            Console.WriteLine("4 - Metal Blade - 2 złomu + 15 frag. metalu");
            Console.WriteLine("5 - Metal Pipe - 5 złomu + 1 HQ");
            Console.WriteLine("6 - Metal Spring - 10 złomu + 1 HQ");
            Console.WriteLine("7 - Rifle Body - 25 złomu + 2 HQ");
            Console.WriteLine("8 - Road Signs - 5 złomu + 1 HQ");
            Console.WriteLine("9 - Rope - 15 tkaniny");
            Console.WriteLine("10 - SMG Body - 15 złomu + 2 HQ");
            Console.WriteLine("11 - Semi Automatic Body - 15 złomu + 2 HQ + 75 frag. metalu");
            Console.WriteLine("12 - Sewing Kit - 10 tkaniny + 2 liny");
            Console.WriteLine("13 - Sheet Metal - 8 złomu + 100 frag. metalu + 1 HQ");
            Console.WriteLine("14 - Tarp - 50 tkaniny");
            Console.WriteLine("15 - Tech Trash - 20 złomu + 1 HQ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string opcja1 = Console.ReadLine();
            
            switch (opcja1)
            {
                default:
                    Main();
                    break;
            }
        }

        static void CALC(int złom, int metal, int HQ, int lina, int tka)
        {
            Console.Clear();
            Console.WriteLine("1 - Electric Fuse");
            Console.WriteLine("2 - Empty Propane Tank");
            Console.WriteLine("3 - Gears");
            Console.WriteLine("4 - Metal Blade");
            Console.WriteLine("5 - Metal Pipe");
            Console.WriteLine("6 - Metal Spring");
            Console.WriteLine("7 - Rifle Body");
            Console.WriteLine("8 - Road Signs");
            Console.WriteLine("9 - Rope");
            Console.WriteLine("10 - SMG Body");
            Console.WriteLine("11 - Semi Automatic Body");
            Console.WriteLine("12 - Sewing Kit");
            Console.WriteLine("13 - Sheet Metal");
            Console.WriteLine("14 - Trap");
            Console.WriteLine("15 - Tech Trash");
            Console.WriteLine("16 - Wyjście");
            Console.WriteLine("");
            Console.WriteLine("ILOŚĆ ZŁOMU: " + złom);
            Console.WriteLine("ILOŚĆ METALU: " + metal);
            Console.WriteLine("ILOŚĆ HQ: " + HQ);
            Console.WriteLine("ILOŚĆ LIN: " + lina);
            Console.WriteLine("ILOŚĆ TKANINY: " + tka);
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Wpisz item do przerobienia");
                Console.Write(">");
                string opcja3 = Console.ReadLine();
                if (opcja3 == "16")
                {
                    Main();
                }
                Console.WriteLine("Podaj ilość");
                Console.Write(">");
                int ilosc = Convert.ToInt32(Console.ReadLine());

                switch (opcja3)
                {
                    case "1":
                        złom = złom + (20 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "2":
                        złom = złom + (1 * ilosc);
                        metal = metal + (50 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "3":
                        złom = złom + (10 * ilosc);
                        metal = metal + (13 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "4":
                        złom = złom + (2 * ilosc);
                        metal = metal + (15 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "5":
                        złom = złom + (5 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "6":
                        złom = złom + (10 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "7":
                        złom = złom + (25 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "8":
                        złom = złom + (5 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "9":
                        tka = tka + (15 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "10":
                        złom = złom + (15 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "11":
                        złom = złom + (15 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        metal = metal + (75 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "12":
                        tka = tka + (10 * ilosc);
                        lina = lina + (2 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "13":
                        złom = złom + (8 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        metal = metal + (100 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "14":
                        tka = tka + (50 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    case "15":
                        złom = złom + (20 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALC(złom, metal, HQ, lina, tka);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji!");
                        break;
                }
            }
        }
        // wersja po angielsku ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        static void MainA()
        {
            int złom = 0;
            int metal = 0;
            int HQ = 0;
            int lina = 0;
            int tka = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rust Calculator");
            Console.WriteLine("");
            Console.WriteLine("Rules - 'Info' ");
            Console.WriteLine("");
            Console.WriteLine("Program - 'Calc' ");
            Console.WriteLine("");
            Console.WriteLine("Exit- 'exit' ");
            Console.WriteLine("");
            Console.WriteLine("To polish language - 'pl' ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "Info" or "info" or "INFO":
                    InfoA();
                    break;
                case "Calc" or "CALC" or "calc":
                    CALCA(złom, metal, HQ, lina, tka);
                    break;
                case "exit" or "EXIT" or "Exit":
                    System.Environment.Exit(0);
                    break;
                case "pl" or "PL" or "Pl":
                    Main();
                    break;
                default:
                    MainA();
                    break;
            }

        }
        static void InfoA()
        {
            Console.Clear();
            Console.WriteLine("Welcome into program information!");
            Console.WriteLine("");
            Console.WriteLine("This is a calculator which calculate how many materials will you get from.");
            Console.WriteLine("In Calc write material that you want rec. and quantity.");
            Console.WriteLine("Program save your option, you can add more items.");
            Console.WriteLine("Program accpets negativ values for remove items.");
            Console.WriteLine("To exit click Enter.");
            Console.WriteLine("Fast reminder which item gives:");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Electric Fuse - 20 scrap");
            Console.WriteLine("2 - Empty Propane Tank - 1 scrap + 50 frag. steel");
            Console.WriteLine("3 - Gears - 10 scrap + 13 frag. steel");
            Console.WriteLine("4 - Metal Blade - 2 scrap + 15 frag. steel");
            Console.WriteLine("5 - Metal Pipe - 5 scrap + 1 HQ");
            Console.WriteLine("6 - Metal Spring - 10 scrap + 1 HQ");
            Console.WriteLine("7 - Rifle Body - 25 scrap + 2 HQ");
            Console.WriteLine("8 - Road Signs - 5 scrap + 1 HQ");
            Console.WriteLine("9 - Rope - 15 cloth");
            Console.WriteLine("10 - SMG Body - 15 scrap + 2 HQ");
            Console.WriteLine("11 - Semi Automatic Body - 15 scrap + 2 HQ + 75 frag. steel");
            Console.WriteLine("12 - Sewing Kit - 10 cloth + 2 rope");
            Console.WriteLine("13 - Sheet Metal - 8 scrap + 100 frag. steel + 1 HQ");
            Console.WriteLine("14 - Tarp - 50 cloth");
            Console.WriteLine("15 - Tech Trash - 20 scrap + 1 HQ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string opcja1 = Console.ReadLine();

            switch (opcja1)
            {
                default:
                    MainA();
                    break;
            }
        }
        static void CALCA(int złom, int metal, int HQ, int lina, int tka)
        {
            Console.Clear();
            Console.WriteLine("1 - Electric Fuse");
            Console.WriteLine("2 - Empty Propane Tank");
            Console.WriteLine("3 - Gears");
            Console.WriteLine("4 - Metal Blade");
            Console.WriteLine("5 - Metal Pipe");
            Console.WriteLine("6 - Metal Spring");
            Console.WriteLine("7 - Rifle Body");
            Console.WriteLine("8 - Road Signs");
            Console.WriteLine("9 - Rope");
            Console.WriteLine("10 - SMG Body");
            Console.WriteLine("11 - Semi Automatic Body");
            Console.WriteLine("12 - Sewing Kit");
            Console.WriteLine("13 - Sheet Metal");
            Console.WriteLine("14 - Trap");
            Console.WriteLine("15 - Tech Trash");
            Console.WriteLine("16 - Wyjście");
            Console.WriteLine("");
            Console.WriteLine("SCRAP: " + złom);
            Console.WriteLine("METAL FRAG.: " + metal);
            Console.WriteLine("HQ: " + HQ);
            Console.WriteLine("ROPE: " + lina);
            Console.WriteLine("CLOTH: " + tka);
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Choose item to rec.");
                Console.Write(">");
                string opcja3 = Console.ReadLine();
                if (opcja3 == "16")
                {
                    MainA();
                }
                Console.WriteLine("amount");
                Console.Write(">");
                int ilosc = Convert.ToInt32(Console.ReadLine());

                switch (opcja3)
                {
                    case "1":
                        złom = złom + (20 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "2":
                        złom = złom + (1 * ilosc);
                        metal = metal + (50 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "3":
                        złom = złom + (10 * ilosc);
                        metal = metal + (13 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "4":
                        złom = złom + (2 * ilosc);
                        metal = metal + (15 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "5":
                        złom = złom + (5 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "6":
                        złom = złom + (10 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "7":
                        złom = złom + (25 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "8":
                        złom = złom + (5 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "9":
                        tka = tka + (15 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "10":
                        złom = złom + (15 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "11":
                        złom = złom + (15 * ilosc);
                        HQ = HQ + (2 * ilosc);
                        metal = metal + (75 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "12":
                        tka = tka + (10 * ilosc);
                        lina = lina + (2 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "13":
                        złom = złom + (8 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        metal = metal + (100 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "14":
                        tka = tka + (50 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    case "15":
                        złom = złom + (20 * ilosc);
                        HQ = HQ + (1 * ilosc);
                        CALCA(złom, metal, HQ, lina, tka);
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            }
        }

    }
}