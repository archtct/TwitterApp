using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwTwitter.Data.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public int MessageId { get; set; }
        public virtual User User { get; set; }
    }
}
