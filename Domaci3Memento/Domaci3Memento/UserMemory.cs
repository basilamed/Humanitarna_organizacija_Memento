namespace Domaci3Memento
{
    public class UserMemory
    {
        Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}

