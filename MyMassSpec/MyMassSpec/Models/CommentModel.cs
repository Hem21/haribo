using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMassSpec.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public int MassSpecId { get; set; }
        public string Body { get; set; }
    }
}
