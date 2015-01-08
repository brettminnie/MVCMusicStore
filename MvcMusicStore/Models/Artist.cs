﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [DisplayName("Artist Name")]
        public string Name { get; set; }
    }
}