using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Draft
    { 
        [Key]
        public int DraftId { get; set; }
        [StringLength(50)]
        public string  Subject { get; set; }
        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [StringLength(30)]
        public string DraftContent { get; set; }
        public DateTime DraftDate { get; set; }
    }
}
