using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02Logic
{
    public class Sort
    {
        public static Book[] SortMethod(Book[] books, IComparer<Book> comparator)
        {
            if (books == null)
            {
                throw new NullReferenceException();
            }

            if (comparator == null)
            {
                DefaultBookSort(books);
            }
            else
            {
                for (int i = 0; i < books.Length - 1; i++)
                {
                    for (int j = 0; j < books.Length - i - 1; j++)
                    {
                        if (comparator.Compare(books[j], books[j + 1]) == 1)
                        {
                            Swap(ref books[j], ref books[j + 1]);
                        }
                    }
                }
            }
            return books;
        }

        private static Book[] DefaultBookSort (Book[] books)
        {
            for (int i = 0; i<books.Length - 1; i++)
                {
                    for (int j = 0; j<books.Length - i - 1; j++)
                    {
                        if (books[j].CompareTo(books[j + 1]) == 1)
                        {
                            Swap(ref books[j], ref books[j + 1]);
                        }
                    }
                }
            return books;
        }

        private static void Swap(ref Book a, ref Book b)
        {
            Book temp = a;
            a = b;
            b = temp;
        }
    }
}
