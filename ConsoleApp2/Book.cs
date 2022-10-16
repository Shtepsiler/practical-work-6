using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Book
    {
      protected string title;
      protected string author;
      protected double price;


        public string Author
        {
            get { return this.author; }
            set
            { //TODO validate value
              this.author = value;
              } }
public string Title
        {
            get { return this.title; }
            set
            { //TODO validate value
              //
              this.title = value;
              } }
public virtual double Price
        {
            get { return this.price; }
            set
            { //TODO validate value
              this.price = value;
              } }

                public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
    }
