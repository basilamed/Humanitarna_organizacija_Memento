namespace Domaci3Memento
{
    public class User
    {
        string name;
        string phone;
        string city;
        DateTime birthday;
        string email;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                Console.WriteLine("Name:   " + name);
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                Console.WriteLine("Phone:  " + phone);
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                Console.WriteLine("City: " + city);
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                Console.WriteLine("Birthday: " + birthday);
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                Console.WriteLine("Email: " + email);
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(name, phone, city, birthday, email);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            City = memento.City;
            Birthday = memento.Birthday;
            Email = memento.Email;
        }
    }
}

