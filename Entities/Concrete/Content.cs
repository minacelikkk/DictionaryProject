﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        public int HeadingId { get; set; }
        public int? WriterId { get; set; }
        [StringLength(1000)]
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }
        public virtual Heading Heading { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
