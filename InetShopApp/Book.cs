using System;
using System.Collections.Generic;
using System.Text;

namespace InetShopApp
{
    public class Book
    {

        protected string nameAuthor;

        protected string title;

        protected double costRubles;

        protected int publicatioDate;

        //конструктор по умолчанию (без параметров)
        public Book()
        {
            NameAuthor = "No Name";
            title = "No Name";
            costRubles = 0.0;
            publicatioDate = 0;

        }

        override public string ToString() => nameAuthor + " - " + title + ". Price = " + costRubles + " rubles. Date: " + publicatioDate;



        public Book(string _nameAuthor, string _title, double _costRubles, int _publicatioDate)
        {
            nameAuthor = _nameAuthor;
            title = _title;
            costRubles = _costRubles;
            publicatioDate = _publicatioDate;

        }
        public Book(string _nameAuthor, int _publicatioDate)
        {
            nameAuthor = _nameAuthor;
            publicatioDate = _publicatioDate;

        }

        //деструктор класса - для уничтожения членов класса
        ~Book() { }

        //Свойства, которые осуществляют доступ к записи и чтения поля класса (геттеры и сеттеры)
        public string NameAuthor
        {
            get { return nameAuthor; }
            set { nameAuthor = value; }
        }

        //Автоматические свойства - используются, если нужно только прочитать или записать значение без предварительных манипуляций
        //public string Surname { get; set; }
        public string TitleBook
        {
            get { return title; }
            set { title = value; }
        }

        public double CostRubles
        {
            get { return costRubles; }
            set { costRubles = value; }
        }

        public int PublicatioDate
        {
            get { return publicatioDate; }
            set { publicatioDate = value; }
        }

        public int Pages { get; set; }

        public string HelloIAmAuthor()
        {
            return this.nameAuthor + " " + this.title;
        }

    }
}
