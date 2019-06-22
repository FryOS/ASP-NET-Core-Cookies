using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Создайте класс Book, описывающий книгу.  
Каждая книга содержит: автора, название, стоимость в рублях и год издания. 
Создайте для каждого атрибута книги закрытую переменную - поле класса соответствующего типа. 
Конструктор по умолчанию должен создавать книгу с параметрами: «Не определено», «Не определено», 
0.0, 0. 
Второй конструктор должен принимать все 4 параметра: автора, название, стоимость в рублях и год издания. 
Напишите третий конструктор, который имеет 2 параметра: автора и год издания. Для каждого атрибута 
создайте свойства 
получения и установки значения. Создать деструктор. Создать метод, который формирует строку из автора и 
названия. 
*/

namespace Book
{
    class Book
    {
        private string nameAuthhor;
        private string nameBook;
        private int costBook;
        private int yearBook;
        static void Main(string[] args)
        {
        }

        public Book() {
        }
        public Book(string _nameAuthhor, string _nameBook, int _costBook, int _yearBook)
        {
            this.nameAuthhor = _nameAuthhor;
            this.nameBook = _nameBook;
            this.costBook = _costBook;
            this.yearBook = _yearBook;

        }
    }
}
