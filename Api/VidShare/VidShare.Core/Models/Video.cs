﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidShare.Core.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string ?Title { get; set; }
        public string ?Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UploadDate { get; set; }= DateTime.Now;
        public int CategoryId { get;set; }
        public string ?NameTalk { get; set; }
        public required string VideoUrl { get; set; }
        public int UserId { get; set; } 
        public User ?User { get; set; }
        public Category ?Category { get; set; }    
    }
}
