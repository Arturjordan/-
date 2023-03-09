
namespace zadanie1._1
{
    class Master : Student
    {
        string specialty;
        //Такое же св-во для доступа к закрытым полям
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        //Cоздаем конструктор класса магистр который принимает свой дополнительный параметр специальность и наследует два параметра из конструктора класса Студент
        public Master(string sp, string n, double r)
            : base(n, r)
        {
            Specialty = sp;
        }
        public double UpGrant(double g, double m)
        {
            double up = g + m;
            return up;
        }
    }
}
