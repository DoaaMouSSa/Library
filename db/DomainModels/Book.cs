using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.DomainModels
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        [NotMapped]
        public IFormFile image_file { get; set; }
        public string image_path { get; set; }
    }
}
