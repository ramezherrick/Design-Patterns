namespace PrototypePattern.Models
{
    public class Employee : Person
    {
        public int Salary;

        public Employee(string[] names, Address address, int salary)
            : base(names, address)
        {
            Salary = salary;
        }

        public override Employee DeepCopy()
        {
            return new Employee((string[])Names.Clone(), Address.DeepCopy(), Salary);
        }
    }
}
