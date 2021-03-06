﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSharingApp.Model
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int PhotoID { get; set; }
        public virtual Photo Photo { get; set; }
    }
}