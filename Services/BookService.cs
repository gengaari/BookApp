using BookApp.Models;

namespace BookApp.Services
{
    public class BookService
    {
        private readonly List<Book> _books;
        private int _nextId = 1;

        public BookService()
        {
            _books = new List<Book>
            {
                new Book { Id = _nextId++, Title = "Кобзар", Author = "Тарас Шевченко", Genre = "Поезія", Year = 1840 },
                new Book { Id = _nextId++, Title = "Мартін Іден", Author = "Джек Лондон", Genre = "Роман", Year = 1909 }
            };
        }

        public List<Book> GetBooks() => _books;

        public void AddBook(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
        }
    }
}
