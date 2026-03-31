namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showauto_Click(object sender, EventArgs e)
        {
            //очищаем список перед выводом
            listBox1.Items.Clear();

            //создаем три объекта car, используя инициализаторы объектов
            Car car1 = new Car() { brand = "Toyota", model = "Camry", year = 2020 };
            Car car2 = new Car() { brand = "BMW", model = "X5", year = 2022 };
            Car car3 = new Car() { brand = "Lada", model = "Vesta" }; //год остается 2000

            //добавляем информацию об автомобилях в listbox
            listBox1.Items.Add($"Марка: {car1.brand}, Модель: {car1.model}, Год: {car1.year}");
            listBox1.Items.Add($"Марка: {car2.brand}, Модель: {car2.model}, Год: {car2.year}");
            listBox1.Items.Add($"Марка: {car3.brand}, Модель: {car3.model}, Год: {car3.year}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}