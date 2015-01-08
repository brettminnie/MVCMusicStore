using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public partial class Genre
    {
        public int GenreId { get; set; }

        [DisplayName("Genre")]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public List<Album> Albums { get; set; }
    }
}