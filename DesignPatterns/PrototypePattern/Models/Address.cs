namespace PrototypePattern.Models
{
    public class Address : DeepCopyable<Address>
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override Address DeepCopy()
        {
            return (Address)MemberwiseClone();
        }
    }
}
