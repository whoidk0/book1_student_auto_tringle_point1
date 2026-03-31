namespace student
{
    public class Student
    {
        public string name;
        public int age;

        //конструктор без параметров
        public Student() : this("Иван", 18)
        {
        }

        //конструктор с одним параметром
        public Student(string name) : this(name, 18)
        {
        }

        //конструктор с двумя параметрами
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //метод вывода информации
        public string PrintInfo()
        {
            return $"Имя: {name}, Возраст: {age}";
        }
    }
}