using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telefonkönyv
{
    class Person
    {
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string ApaNeve { get; set; }
        public string AnyaNeve { get; set; }
        public long Telefonszam { get; set; }
        public string Neme { get; set; }
        public string Email { get; set; }
        public string SzemelyAzon { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Start();
        }

        static void Start()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\t\t**********Üdvözöllek a telefonkönyvben*************");
            Console.WriteLine("\n\n\t\t\t MENU\t\t\n\n");
            Console.WriteLine("\t1.Új hozzáadás\t2.Lista\t\t3.Kilépés\n\t4.Módosítás\t5.Keresés\t6.Törlés");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1: AddRecord(); break;
                case ConsoleKey.D2: ListRecord(); break;
                case ConsoleKey.D3: Environment.Exit(0); break;
                case ConsoleKey.D4: ModifyRecord(); break;
                case ConsoleKey.D5: SearchRecord(); break;
                case ConsoleKey.D6: DeleteRecord(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nCsak 1-től 6-ig adjon meg számot");
                    Console.WriteLine("\nNyomj meg egy billentyűt");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        static void AddRecord()
        {
            Console.Clear();
            Person p = new Person();

            Console.Write("\nÍrd be a nevet: ");
            p.Nev = Console.ReadLine();

            Console.Write("\nÍrd be a címet: ");
            p.Cim = Console.ReadLine();

            Console.Write("\nÍrd be az apa nevét: ");
            p.ApaNeve = Console.ReadLine();

            Console.Write("\nÍrd be az anya nevét: ");
            p.AnyaNeve = Console.ReadLine();

            Console.Write("\nÍrd be telefonszámot: ");
            p.Telefonszam = long.Parse(Console.ReadLine());

            Console.Write("\nÍrd be a nemet: ");
            p.Neme = Console.ReadLine();

            Console.Write("\nÍrd be e-mailt: ");
            p.Email = Console.ReadLine();

            Console.Write("\nÍrd be a személyazonosító számát: ");
            p.SzemelyAzon = Console.ReadLine();

            using (FileStream fs = new FileStream("project.dat", FileMode.Append, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(p.Nev);
                writer.Write(p.Cim);
                writer.Write(p.ApaNeve);
                writer.Write(p.AnyaNeve);
                writer.Write(p.Telefonszam);
                writer.Write(p.Neme);
                writer.Write(p.Email);
                writer.Write(p.SzemelyAzon);
            }

            Console.WriteLine("\nA rekord mentve.");
            Console.WriteLine("\n\nNyomj meg egy billentyűt");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ListRecord()
        {
            Console.Clear();
            if (!File.Exists("project.dat"))
            {
                Console.WriteLine("\nFájl megnyitási hiba a listázásnál");
                Environment.Exit(1);
            }

            using (FileStream fs = new FileStream("project.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    Person p = new Person
                    {
                        Nev = reader.ReadString(),
                        Cim = reader.ReadString(),
                        ApaNeve = reader.ReadString(),
                        AnyaNeve = reader.ReadString(),
                        Telefonszam = reader.ReadInt64(),
                        Neme = reader.ReadString(),
                        Email = reader.ReadString(),
                        SzemelyAzon = reader.ReadString()
                    };

                    Console.WriteLine("\n\n\n A REKORDOD\n\n ");
                    Console.WriteLine($"Név: {p.Nev}\nCím: {p.Cim}\nApa neve: {p.ApaNeve}\nAnya neve: {p.AnyaNeve}\nTelefonSzám: {p.Telefonszam}\nNeme: {p.Neme}\nEmail: {p.Email}\nSzemélyazonosító száma: {p.SzemelyAzon}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("\nNyomj meg egy billentyűt");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void SearchRecord()
        {
            Console.Clear();
            Console.WriteLine("Írd be a keresett személy nevét");
            string Nev = Console.ReadLine();

            bool found = false;

            if (!File.Exists("project.dat"))
            {
                Console.WriteLine("\nHiba a megnyitáskor.");
                Environment.Exit(1);
            }

            using (FileStream fs = new FileStream("project.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    Person p = new Person
                    {
                        Nev = reader.ReadString(),
                        Cim = reader.ReadString(),
                        ApaNeve = reader.ReadString(),
                        AnyaNeve = reader.ReadString(),
                        Telefonszam = reader.ReadInt64(),
                        Neme = reader.ReadString(),
                        Email = reader.ReadString(),
                        SzemelyAzon = reader.ReadString()
                    };

                    if (p.Nev.Equals(Nev, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"\n\tRészletes információ róla {Nev}");
                        Console.WriteLine($"Név: {p.Nev}\nCím: {p.Cim}\nApa neve: {p.ApaNeve}\nAnya neve: {p.AnyaNeve}\nTelefonSzám: {p.Telefonszam}\nNeme: {p.Neme}\nEmail: {p.Email}\nSzemélyazonosító száma: {p.SzemelyAzon}");
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("A fájl nem található.");
            }

            Console.WriteLine("\nNyomj meg egy billentyűt");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void DeleteRecord()
        {
            Console.Clear();
            Console.WriteLine("Írd be a kapcsolat nevét:");
            string Nev = Console.ReadLine();

            if (!File.Exists("project.dat"))
            {
                Console.WriteLine("A KAPCSOLAT ADATAI MÉG NEM LETTEK HOZZÁADVA");
            }
            else
            {
                bool found = false;
                string tempFileNev = "temp.dat";

                using (FileStream fs = new FileStream("project.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                using (FileStream tempFs = new FileStream(tempFileNev, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(tempFs))
                {
                    while (fs.Position < fs.Length)
                    {
                        Person p = new Person
                        {
                            Nev = reader.ReadString(),
                            Cim = reader.ReadString(),
                            ApaNeve = reader.ReadString(),
                            AnyaNeve = reader.ReadString(),
                            Telefonszam = reader.ReadInt64(),
                            Neme = reader.ReadString(),
                            Email = reader.ReadString(),
                            SzemelyAzon = reader.ReadString()
                        };

                        if (!p.Nev.Equals(Nev, StringComparison.OrdinalIgnoreCase))
                        {
                            writer.Write(p.Nev);
                            writer.Write(p.Cim);
                            writer.Write(p.ApaNeve);
                            writer.Write(p.AnyaNeve);
                            writer.Write(p.Telefonszam);
                            writer.Write(p.Neme);
                            writer.Write(p.Email);
                            writer.Write(p.SzemelyAzon);
                        }
                        else
                        {
                            found = true;
                        }
                    }
                }

                if (found)
                {
                    File.Delete("project.dat");
                    File.Move(tempFileNev, "project.dat");
                    Console.WriteLine("A REKORD SIKERESEN TÖRÖLVE.");
                }
                else
                {
                    File.Delete(tempFileNev);
                    Console.WriteLine("NINCS KAPCSOLATREKORD A TÖRLÉSHEZ.");
                }
            }

            Console.WriteLine("\nNyomj meg egy billentyűt");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static void ModifyRecord()
        {
            Console.Clear();
            Console.WriteLine("Írd be a kapcsolat nevét a módosításhoz:");
            string Nev = Console.ReadLine();
            bool found = false;

            if (!File.Exists("project.dat"))
            {
                Console.WriteLine("A KAPCSOLAT ADATAI MÉG NEM LETTEK HOZZÁADVA");
                Environment.Exit(1);
            }

            using (FileStream fs = new FileStream("project.dat", FileMode.Open, FileAccess.ReadWrite))
            using (BinaryReader reader = new BinaryReader(fs))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                while (fs.Position < fs.Length)
                {
                    long position = fs.Position;
                    Person p = new Person
                    {
                        Nev = reader.ReadString(),
                        Cim = reader.ReadString(),
                        ApaNeve = reader.ReadString(),
                        AnyaNeve = reader.ReadString(),
                        Telefonszam = reader.ReadInt64(),
                        Neme = reader.ReadString(),
                        Email = reader.ReadString(),
                        SzemelyAzon = reader.ReadString()
                    };

                    if (p.Nev.Equals(Nev, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("\nÍrd be a nevet: ");
                        p.Nev = Console.ReadLine();

                        Console.Write("\nÍrd be a címet: ");
                        p.Cim = Console.ReadLine();

                        Console.Write("\nÍrd be az apa nevét: ");
                        p.ApaNeve = Console.ReadLine();

                        Console.Write("\nÍrd be az anya nevét: ");
                        p.AnyaNeve = Console.ReadLine();

                        Console.Write("\nÍrd be telefonszámot: ");
                        p.Telefonszam = long.Parse(Console.ReadLine());

                        Console.Write("\nÍrd be a nemet: ");
                        p.Neme = GetInput();

                        Console.Write("\nÍrd be e-mailt: ");
                        p.Email = GetInput();

                        Console.Write("\nÍrd be a személyazonosító számát: ");
                        p.SzemelyAzon = GetInput();

                        // Move the file pointer to the correct position
                        fs.Seek(-(
                            sizeof(long) + // mble_no
                            sizeof(char) * (p.Nev.Length + p.Cim.Length + p.ApaNeve.Length + p.AnyaNeve.Length + p.Neme.Length + p.Email.Length + p.SzemelyAzon.Length + 7)), SeekOrigin.Current); // 7 for the number of strings

                        // Write the data to the file
                        writer.Write(p.Telefonszam);
                        writer.Write(p.Neme);
                        writer.Write(p.Email);
                        writer.Write(p.SzemelyAzon);

                        found = true;
                    }

                    if (found)
                    {
                        Console.WriteLine("\nAz adatok módosítva lettek");
                    }
                    else
                    {
                        Console.WriteLine("\nAz adatot nem találtuk");
                    }

                    Console.WriteLine("\nNyomjon meg egy billentyűt a folytatáshoz...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }

                string GetInput()
                {
                    int i = 0;
                    char c;
                    string input = string.Empty;

                    do
                    {
                        var key = Console.ReadKey(intercept: true);
                        c = key.KeyChar;

                        if (c != '\b' && c != '\r')
                        {
                            input += c;
                            Console.Write(c);
                            i++;
                        }
                        else if (c == '\b')
                        {
                            if (i > 0)
                            {
                                input = input.Substring(0, i - 1);
                                i--;
                                Console.Write("\b \b");
                            }
                        }
                    } while (c != '\r');

                    Console.WriteLine();
                    return input;
                }

            }
        }
    }
}
