﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchFlix_Frontend.Models
{
        public class ShowDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Media_type { get; set; }
        public string Description { get; set; }
        public string Release_date { get; set; }
        public string Image_url { get; set; }

        public int Yes_Count { get; set; }
        public int No_Count { get; set; }
    }
}
