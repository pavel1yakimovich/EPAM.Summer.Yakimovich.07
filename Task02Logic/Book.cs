using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02Logic
{
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public int Pages { get; set; }

        public int Pictures { get; set; }

        public int YearOfPublishing { get; set; }

        public int CompareTo(Book other)
        {
            return this.Pages.CompareTo(other.Pages);
        }

        public bool Equals(Book other)
        {
            return (this.Author == other.Author && this.Title == other.Title);
        }
    }
}
