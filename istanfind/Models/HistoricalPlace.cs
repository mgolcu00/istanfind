using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace istanfind.Models
{
    public class HistoricalPlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteUrl { get; set; }
        public string Adress { get; set; }
        public string AdressUrl { get; set; }
        public double Score { get; set; }
        public string DataText { get; set; }
        public string TitleText { get; set; }
        public string ImageUrl { get; set; }
    }
}
