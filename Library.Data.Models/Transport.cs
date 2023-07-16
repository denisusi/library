using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Models
{
    class Transport
    {
        public int ID { get; set; }
        public float Date { get; set; }
        public float ReturnDate { get; set; }
        public string Reader { get; set; }
        public string Librarian { get; set; }
        public string Condition { get; set; }
        public Transport()
        {

        }
    }
}