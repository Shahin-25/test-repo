using CrudApps.Data;
using CrudApps.Model;

namespace CrudApps.Service
{
    public class BookService
    {
        private readonly BookDbContext _context;

        public BookService(BookDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetActiveBooks()
        {
            return _context.Books.Where(b => b.IsActive && !b.IsDeleted).ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id && b.IsActive && !b.IsDeleted);
        }

        public void AddBook(Book book)
        {
            book.IsActive = true;
            book.IsDeleted = false;
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.Find(book.Id);

            if (existingBook == null || existingBook.IsDeleted)
                return;

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Pages = book.Pages;

            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);

            if (book != null)
            {
                book.IsDeleted = true;
                _context.SaveChanges();
            }
        }
    }
   

}
