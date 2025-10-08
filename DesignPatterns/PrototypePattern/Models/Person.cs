namespace PrototypePattern.Models
{
    public class Person : DeepCopyable<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override Person DeepCopy()
        {
            return new Person((string[])Names.Clone(), Address.DeepCopy());
        }
    }
}
