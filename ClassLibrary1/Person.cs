namespace ClassLibrary1
{
    public class Person
    {
        public string PersonName { set; get; }
        public string EmailAdd { set; get; }

        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            if (this.PersonName == p.PersonName && this.EmailAdd == p.EmailAdd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Person name: " + this.PersonName;
        }
    }
}