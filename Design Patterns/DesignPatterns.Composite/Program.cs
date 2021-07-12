namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer(100, "Uygar Keser", "Mid Developer"); // Leaf
            Developer dev2 = new Developer(101, "Bayram Eser", "Senior Developer"); // Leaf

            CompanyDirectory engDirectory = new CompanyDirectory();
            engDirectory.AddEmployee(dev1);
            engDirectory.AddEmployee(dev2);

            Manager man1 = new Manager(200, "Gözde Tursun", "Sales Manager"); // Leaf
            Manager man2 = new Manager(201, "Fatih Aydemir", "Marketing Manager"); // Leaf

            CompanyDirectory manDirectory = new CompanyDirectory();
            manDirectory.AddEmployee(man1);
            manDirectory.AddEmployee(man2);

            CompanyDirectory directory = new CompanyDirectory();
            directory.AddEmployee(engDirectory);
            directory.AddEmployee(manDirectory);
            directory.ShowEmployeeDetails();
        }
    }
}
