namespace tringle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showtringle_Click(object sender, EventArgs e)
        {
            //очищаем список перед выводом
            listBox1.Items.Clear();

            //создаем два треугольника
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(1, 2, 4);

            //выводим информацию о первом треугольнике
            listBox1.Items.Add(triangle1.PrintSides());
            listBox1.Items.Add($"Существует: {triangle1.IsValid()}");
            listBox1.Items.Add(""); //пустая строка для разделения

            //выводим информацию о втором треугольнике
            listBox1.Items.Add(triangle2.PrintSides());
            listBox1.Items.Add($"Существует: {triangle2.IsValid()}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}