using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Models
{
    class LibraryUnit
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        public string Condition { get; set; }
        public string Career { get; set; }
        public string Storage { get; set; }
        public LibraryUnit() { }
    }
