using System;

namespace book1
{
    public class Book
    {
        // Публичные поля
        public string title = "Неизвестно";  // значение по умолчанию
        public int pages;

        // Метод вывода информации
        public void GetInfo()
        {
            Console.WriteLine($"Книга: {title}, страниц: {pages}");
        }
    }
}