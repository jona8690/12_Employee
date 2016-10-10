namespace _12_Employee
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Type { get; internal set; }
        public long Id { get; internal set; }

 


       
        public Employee(string Name, string Type, long Id)

        {
            this.Name = Name;
            this.Type = Type;
            this.Id = Id;

        }

        public Employee()
        {
        }
    }
}