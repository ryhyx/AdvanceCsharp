namespace MVC_practice.Models.Repo_pattern
{
    public interface IBookRepository
    {
        public void AddBook(Book Book);
        public void DeleteBook(int id);
        IEnumerable<Book> GetAll();
    }
}
