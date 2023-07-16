using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Models
{
    class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Title> Titles { get; set; }
        public Section()
        {
            this.Titles = new List<Title>();
        }
    }
}