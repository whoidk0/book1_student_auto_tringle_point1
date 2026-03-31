namespace point1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showcoordinate_Click(object sender, EventArgs e)
        {
            //очищаем список перед выводом
            listBox1.Items.Clear();

            //создаем объект point с координатами (10, 20)
            Point point1 = new Point(10, 20);

            //используя деконструктор, получаем координаты в отдельные переменные
            (int x, int y) = point1;

            //выводим полученные координаты
            listBox1.Items.Add($"первая точка: x={x}, y={y}");
            listBox1.Items.Add(""); //пустая строка для разделения

            //создаем второй объект point с координатами (5, 7)
            Point point2 = new Point(5, 7);

            //используя деконструктор, получаем только координату y (x игнорируем)
            (_, int yOnly) = point2;

            //выводим только y
            listBox1.Items.Add($"вторая точка: y={yOnly}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}