

namespace zadanieEmployee
{
    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }


        private List<int> score = new List<int>();

        public void AddScore(int nummer)
        {
            this.score.Add(nummer);
        }

        public int Result
        {
            get { return score.Sum(); }
        }

        public void zmianaImienia(string noweImie)
        {
            this.Name = noweImie;
        }
    }
}
