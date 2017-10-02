using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayCrawler
{
    class Item
    {

        public string title { get; set; }
        public string id { get; set; }
        public string price { get; set; }
        public string pagelink { get; set; }
        public string bids { get; set; }
        public string imglink { get; set; }

        public Item(string title, string id, string price, string pagelink, string bids, string imglink)
        {
            this.title = title;
            this.id = id;
            this.price = price;    
            this.pagelink = pagelink;
            this.bids = bids;
            this.imglink = imglink;
        }

    }
}
