using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Models
{
    internal class PostInfo
    {
        public int PostNumber { get; set; }
        public string Content { get; set; }
        public DateTime DateTimePosted { get; set; }

        public PostInfo(int postNumber, string content)
        {
            PostNumber = postNumber;
            Content = content;
            DateTimePosted = DateTime.Now;
        }
    }
}
