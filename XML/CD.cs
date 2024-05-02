using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    internal class CD
    {
        //Propierties

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }


        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }


        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        //Constructor 
        public CD() 
        {
            Title = "";
            Artist = "";
            Country = "";
            Company = "";
            Price = 0;
            Year = 0;
        }

        public CD(string title, string artist, string country,string company, double price, int year)
        { 
            this.title = title;
            this.artist = artist;
            this.country = country;
            this.company = country;
            this.price = price;
            this.year = year;
        }


       public override string ToString() 
        {
            return "\nTitle:"+ title + "\nArtist:"+ artist + "\nCountry:" + artist;
        }
    }
}
