using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMassSpec.Models
{
    public class MassSpecModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}