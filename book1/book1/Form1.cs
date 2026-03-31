namespace book1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbookbutton_Click(object sender, EventArgs e)
        {
            //очищаем список перед выводом
            listBox1.Items.Clear();

            //создаем три объекта book
            Book book1 = new Book();
            book1.title = "Война и мир";
            book1.pages = 1200;

            Book book2 = new Book();
            book2.title = "1984";
            book2.pages = 300;

            Book book3 = new Book();
            book3.pages = 500; //title останется "неизвестно" (значение по умолчанию)

            //добавляем информацию о книгах в listbox
            listBox1.Items.Add($"Книга: {book1.title}, страниц: {book1.pages}");
            listBox1.Items.Add($"Книга: {book2.title}, страниц: {book2.pages}");
            listBox1.Items.Add($"Книга: {book3.title}, страниц: {book3.pages}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //этот метод не используется в задании, можно оставить пустым
        }
    }
}