﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Data.Models.CustomModels
{
    public class NewsModel
    {
        public string Creator { get; set; }

        public string AvatarPictureUrl { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }



    }
}
