using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace istanfind.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public double Score { get; set; }
        public string UserId { get; set; }
        public int PlaceId { get; set; }
        public string UserName { get; set; }
        public string PlaceType { get; set; }
    }
}
