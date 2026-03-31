namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showstudent_Click(object sender, EventArgs e)
        {
            //очищаем список перед выводом
            listBox1.Items.Clear();

            //создание трех студентов, используя разные конструкторы
            Student student1 = new Student();                    //конструктор без параметров
            Student student2 = new Student("Мария");             //конструктор с одним параметром
            Student student3 = new Student("Петр", 25);          //конструктор с двумя параметрами

            //добавляем информацию о студентах в listbox
            listBox1.Items.Add(student1.PrintInfo());
            listBox1.Items.Add(student2.PrintInfo());
            listBox1.Items.Add(student3.PrintInfo());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}