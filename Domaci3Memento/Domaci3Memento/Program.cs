using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Domaci3Memento
{
    //Korisnik sacuva podatke o sebi i kasnije zeli da ih promeni,
    //ali se predomisli ili napusti stranicu sa formom bez cuvanja podataka.
    //Ako promenjeni podaci nisu sacuvani vraca se poslednje sacuvano stanje tih podataka.

    internal class Program
    {
        public static void Main(string[] args)
        {
            User s = new User();
            s.Name = "Basila Medjedovic";
            s.Phone = "065-461-42-94";
            s.City = "Novi Pazar";
            s.Birthday = new DateTime(2002, 11, 02);
            s.Email = "basilamedjedovic@gmail.com";

            // Store internal state
            UserMemory m = new UserMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Taha Medjedovic";
            s.Phone = "062-889-49-85";
            s.City = "Novi Pazar";
            s.Birthday = new DateTime(2000, 3, 4);
            s.Email = "taha@gmail.com";

            // Restore saved state
            s.RestoreMemento(m.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }
}

