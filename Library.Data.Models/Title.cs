using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Data.Models
{
    class Title
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string type { get; set; }
        public string publisher { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public Section Section { get; set; }
        public ICollection<LibraryUnit> LibraryUnits { get; set; }
        public Title()
        {
            this.LibraryUnits = new List<LibraryUnit>();
        }
    }
}