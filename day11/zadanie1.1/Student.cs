namespace zadanie1._1
{
    class Student
    {
        string name;
        double avg_rating;
        //создаем свойства для доступа к закрытым полям класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Avg_rating
        {
            get { return avg_rating; }
            set { avg_rating = value; }
        }

        //Создаем конструктор класса используя в нем открытые свойства
        public Student(string n, double r)
        {
            Name = n;
            Avg_rating = r;

        }
        public double Grant(double g)
        {
            return g;
        }
    }
}
