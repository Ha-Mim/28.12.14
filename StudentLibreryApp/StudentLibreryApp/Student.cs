using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibraryApp
{
    internal class Student
    {
        public string Name { set; get; }
        public string Id { set; get; }
        public string Department { set; get; }
        public Library LibrayAccount { set; get; }

        public List<string> StudentBook
        {
            get { return _studentBook; }
            set { _studentBook = value; }
        }

        private List<string> _studentBook = new List<string>();

        public void BorrowBook()
        {
            _studentBook.Add(Name);
            _studentBook.Add(Id);
            _studentBook.Add(Department);
            _studentBook.Add(LibrayAccount.BookNane);
            _studentBook.Add(LibrayAccount.Isbn);
            _studentBook.Add(LibrayAccount.AuthorName);
            _studentBook.Add(LibrayAccount.BorrowDate);

        }

        public List<string> SearchBook(string studentid)
        {
            if (_studentBook[1].ToLower().Contains(studentid.ToLower()))
            {
                return _studentBook;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
