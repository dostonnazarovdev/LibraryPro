﻿namespace LibraryPro
{
    public class LibraryManagment
    {
        private List<Book> bookList = new List<Book>();
        private List<Student> studenetList = new List<Student>();
        int generalId = 1;
        // kitob kiritish
        public void addNewBook(string title, string author, DateTime publishYear)
        {
            Book book = new Book(generalId++,title, author, publishYear);
            Book exist = getBookByTitle(title);
            if (exist != null)
            {
                Console.WriteLine("Sorry book's title does not uniqe!");
                return;
            }
            bookList.Add(book);
        }

        // nomi bo'yicha kitobbi qaytaring
        public Book getBookByTitle(string title)
        {
            foreach (var book in bookList)
            {
                if (book != null && book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }

        // aftorni barcha kitoblarini qaytaring
        public List<Book> getAuthorBooks(string author)
        {
            List<Book> authorBookList = new List<Book>();
            foreach (var book in bookList)
            {
                if (book != null && book.Author == author)
                {
                    authorBookList.Add(book);
                }
            }
            return authorBookList;
        }

        // bor kitoblar sonini son qo'shish agar kitob bo'lmasa -1 return qiling.
        // agar  bo'lsa  uni sonini ko'paytirib xosil bo'lgan sonni return qiling
        public int addAvailableBook(string title, int count)
        {
            Book book = getBookByTitle(title);
            if (book == null)
            {
                return -1;
            }

            book.addBookCount(count);
            return book.count;

        }

        // shu  kitobdan nechta borligini return qiling
        public int getAvailableBook(string title)
        {
            Book book = getBookByTitle(title);
            if (book == null) 
            {
                return -1; 
            }
            return book.count;
        }

        //  berilgan aftor ni  kitoblar sonini return qiling
        public int getAvailableBookByAuthor(string author)
        {
            int count = 0;
            foreach (var item in bookList)
            {
                if(item!=null && item.Author.Equals(author))
                {
                    count += item.count;
                }
            }

            return count;
        }

        public Student addStudent(string name, string surname, string phone, int level)
        {
            Student student = new Student(generalId++,name,surname,phone,level);
            Student exest = getStudentByName(name);
            if(exest != null)
            {
                return null;
            }
            studenetList.Add(student);
            return student;  
        }

         private Student getStudentByName(string name)
        {
            foreach (var item in studenetList)
            {
                if(item!=null && item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        // bu method studentga  kitob berish uchun ishlatiladi.
        // agar berilgan student yokiy kitob bo'lmasa false return qiling.
        // agar student da uje olingan kitoblar soni 5 da bo'lsa false ruturn qiling.
        // (Bitta student bir vaqtni o'zida 5ta kitob olga bo'lishi mumkin)
        // agar ok bo'lsa  shu kitobni shu student oldi deb yozib qo'yish kerak (qayerdadir)

        public bool takeBook(int studentId, string title)
        {
            return false;
        }

        // bu metod berilgan kitobni qaytarish uchun ishlatiladi.
        // agar berilgan student yokiy kitob bo'lmasa -1 return qiling
        // agar hammasi ok bo'lsa student kitobni topshirsin.
        // va studentni olib xali qaytarmagan kitoblar sonini qaytaring.
        // returnBook
        public int returnTakenBook(int studentId, string title)
        {
            return 0;
        }

        // bu metod studentni qolidagi kitoblar sonini return qiladi (xali qaytarmagan kitoblar sonini)
        // agar student bo'lmasa -1 return qiling
        public int getStudentTookBookCount(string studentId)
        {
            return -1;
        }

        // bu metod olib xali qaytarilmagan kitoblar sonini return qiladi
        public int booksOnHand()
        {
            return 0;
        }

        // bu metod barcha kitob olgan studentlar sonini return qiladi.
        // bitta student birmarta xisoblansin
        public int studentCountWhichTookABook()
        {
            return 0;
        }

        // berilgan kitob nechi marta olingam?
        public int bookTookCount(string title)
        {
            return 0;
        }

        // berilgan kurs o'qidigan studentlar ning qolida nechta kitob bor?
        public int bookOnHandCountByLevel(int level)
        {
            return 0;
        }

    }
}
