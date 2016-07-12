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

        public int Published { get; set; }

        public int CompareTo(Book other)
        {
            return this.Pages.CompareTo(other.Pages);
        }

        public bool Equals(Book other)
        {
            if (other == null) throw new NullReferenceException();
            return (this.Author == other.Author && this.Title == other.Title && this.Pages == other.Pages
                && this.Published == other.Published);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Book)) throw new ArgumentException();
            return this.Equals((Book) obj);
        }

        public override string ToString()
        {
            return $"Author: {this.Author}; Title: {this.Title}; Number of pages: {this.Pages}; Year of publishing: {this.Published}";
        }

        public override int GetHashCode()
        {
            int hashcode = Author.GetHashCode();
            hashcode = 31*hashcode + Title.GetHashCode();
            hashcode = 31*hashcode + Pages.GetHashCode();
            hashcode = 31*hashcode + Published.GetHashCode();
            return hashcode;
        }
    }
}
