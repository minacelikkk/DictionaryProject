﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; } 
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(50)]
        public string SenderMail { get; set; }
        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [StringLength(30)]
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsRead { get; set; }
    }
}