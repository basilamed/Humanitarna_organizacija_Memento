namespace Domaci3Memento
{
    public class Memento
    {
        string name;
        string phone;
        string city;
        DateTime birthday;
        string email;

        public Memento(string name, string phone, string city, DateTime birthday, string email)
        {
            this.name = name;
            this.phone = phone;
            this.city = city;
            this.birthday = birthday;
            this.email = email;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}

