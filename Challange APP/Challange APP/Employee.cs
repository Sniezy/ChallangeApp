namespace Challange_APP
{
     class Employee
    {
        private List<int> employees = new List<int>();
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public int Result
        {
            get
            {
                return this.employees.Sum();
            }
        }

        public void AddScore(int Numbers)
        {
            this.employees.Add(Numbers);
        }
    }
}


