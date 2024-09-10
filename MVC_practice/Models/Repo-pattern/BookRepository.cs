


// we dont need it now

//namespace MVC_practice.Models.Repo_pattern
//{
//    public class BookRepository : IGenericRepository<Book>
//    {
//        List<Book> Books = new List<Book>();
//        public void AddBook(Book book)
//        {
//            Books.Add(book);
//        }

//        public void DeleteBook(int id)
//        {
//            foreach (var Book in Books)
//            {
//                if ( Book.id== id )
//                {
//                    Books.Remove(Book);
//                }
//            }
//        }
//        IEnumerable<Book> IBookRepository.GetAll()
//        {
//            return Books.OrderBy(x => x.id).ToList();
//        }
//    }
//}
