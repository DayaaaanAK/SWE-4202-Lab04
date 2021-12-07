using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask04
{
    internal class Book
    {
        protected int id;
        protected int quantity;
        protected string author;
        protected string publisher;
        protected string title;

        public int getID()
        {
            return this.id;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public string getName()
        {
            return this.title;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public string getPublisher()
        {
            return this.publisher;
        }

        public void setID(int id)
        {
            this.id = id;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        public void decrease()
        {
            this.quantity--;
        }
    }
}
