﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        List<string> Authors { get; set; }
        public Book(string title, int year,params string[]authors)
        {
            this.Title = title;
            this.Year = year;
            //this.Authors = new List<string>();
            //this.Authors.AddRange(authors);
            this.Authors = new List<string>(authors);
            Console.WriteLine("sadfasdasdada");
        }
    }
}
