using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace EbayCrawler
{
    public partial class Form1 : Form
    {

        List<Item> itemList;
        Dictionary<int, string> catagoryList;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void ebayQuery(string product, string catagory, string minPrice, string maxPrice, string results, params string[] condition)
        {
            itemList = new List<Item>();
            string url = "https://www.ebay.com/sch/i.html?_udlo=" + minPrice + "&_udhi=" + maxPrice + "&LH_ItemCondition=" + 
                condition + "&_mPrRngCbx=1&_ipg=" + results + "&_from=R40&_trksid=p2045573.m570.l1313.TR0.TRC0.H0.TRS0&_nkw=" +
                product + "&_sacat=" + catagory + "&LH_Sold=1";
         
            HtmlWeb page = new HtmlWeb();
            var doc = page.Load(url);

            var ProductsHtml = doc.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("ListViewInner")).ToList();

            var ProductListItems = ProductsHtml[0].Descendants("li")
                .Where(node => node.GetAttributeValue("id", "")
                .Contains("item")).ToList();

            string itemResults = doc.DocumentNode.SelectSingleNode("//*[@id='cbelm']/div[3]/h1/span[1]").InnerText;

            foreach (var ProductListItem in ProductListItems)
            {
                //ID
                string id = ProductListItem.GetAttributeValue("listingid", "");
                //Title
                string title = ProductListItem.Descendants("h3")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("lvtitle")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t').Replace("New listing", "").Replace("\r", "").Replace("\t", "");
                //Price
                string price = Regex.Match(ProductListItem.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("lvprice prc")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t'),
                    @"\d+.\d+").ToString();
                //Bids
                string bids = ProductListItem.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("lvformat")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t').Replace("bids", "").Replace("Buy It Now", "").Replace("or Best Offer", "").Replace("bid", "");
                //Links
                string link = ProductListItem.Descendants("a").FirstOrDefault().GetAttributeValue("href", "");
                //Image
                string imgLink = ProductListItem.Descendants("img").FirstOrDefault().GetAttributeValue("src", "");

                //create a new Item and add to the item list
                itemList.Add(new Item(title, id, price, link, bids, imgLink));

                ListViewItem lvi = new ListViewItem(id);
                lvi.SubItems.Add(title);
                lvi.SubItems.Add(price);
                lvi.SubItems.Add(bids);
                lvi.SubItems.Add(link);
                lvData.Items.Add(lvi);
                
                
            }
            label1.Text = lvData.Items.Count.ToString();
            lblItemResults.Text = "Total Results : " + itemResults;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // doSearch();
            //GetCatagoryPageLinks();
            //GetCatagoryLinks();
         
             GettNode();

        }

        private void doSearch()
        {
            catagoryList = new Dictionary<int, string>();

            if (catagoryList.Count < 1)
            {
                loadCatagories();
                var value = catagoryList.FirstOrDefault(x => x.Value == cboxCatagories.Text).Key;
                int num;

                if (txtProduct.Text.Length > 0 && !int.TryParse(txtProduct.Text, out num))
                {
                    if (rbNew.Checked)
                    {
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "1000");
                    }
                    else if (rbUsed.Checked)
                    {
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "3000");
                    }
                    else
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "10");
                }
                else
                {
                    MessageBox.Show("Product is required!", "INPUT ERROR", MessageBoxButtons.OK);
                    txtProduct.Text = "";

                }
            }
            else
            {
                var value = catagoryList.FirstOrDefault(x => x.Value == cboxCatagories.Text).Key;
                int num;

                if (txtProduct.Text.Length > 0 && !int.TryParse(txtProduct.Text, out num))
                {
                    if (rbNew.Checked)
                    {
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "1000");
                    }
                    else if (rbUsed.Checked)
                    {
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "3000");
                    }
                    else
                        ebayQuery(txtProduct.Text, value.ToString(), numMinRange.Text, numMaxRange.Text, numResults.Text, "10");
                }
                else
                {
                    MessageBox.Show("Product is required!", "INPUT ERROR", MessageBoxButtons.OK);
                    txtProduct.Text = "";

                }
            }
        }

        private void loadCatagories()
        {
            
            catagoryList.Add(0, "All Catagories");
            catagoryList.Add(20081, "Antiques");
            catagoryList.Add(550, "Art");
            catagoryList.Add(2984, "Baby");
            catagoryList.Add(267, "Books");
            catagoryList.Add(12576, "Business & Industrial");
            catagoryList.Add(625, "Cameras & Photo");
            catagoryList.Add(15032, "Cell Phones & Accessories");
            catagoryList.Add(11450, "Clothing, Shoes & Accessories");
            catagoryList.Add(11116, "Coins & Paper Money");
            catagoryList.Add(1, "Collectibles");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            MessageBox.Show("Listing with the most bids is : " + calculateMostBids(), "Most Bids", MessageBoxButtons.OK);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
            numMinRange.Text = "0.00";
            numMaxRange.Text = "0.00";
            numResults.Text = "0";
            cboxCatagories.SelectedIndex = -1;
            rbNew.Checked = false;
            rbUsed.Checked = false;
        }

        private string calculateMostBids()
        {
            Dictionary<string, int> bidsDict = new Dictionary<string, int>();
            string mostBids = "";
            int isInt;
            string bidtitle;
            int bid;

                for (int i = 0; i < itemList.Count; i++)
                {
                    if (itemList[i].bids.Length > 3 || itemList[i].bids == "")
                     {
                        bidtitle = itemList[i].title;
                        if (!bidsDict.ContainsKey(bidtitle))
                        {
                            bidsDict.Add(bidtitle, 0);

                        }
                        else
                        {

                        }
                      
                     }
                    else
                    {
                        bid = Convert.ToInt32(itemList[i].bids);
                        bidtitle = itemList[i].title;
                        if (!bidsDict.ContainsKey(bidtitle))
                        {
                            bidsDict.Add(bidtitle, bid);

                        }
                        else
                        {

                        }
                        
                    }
   
                }

            var MaximumValue = bidsDict.FirstOrDefault(x => x.Value.Equals(bidsDict.Values.Max()));
            var highestListing = MaximumValue.Key;

            return mostBids = highestListing;
        }

        private void RunCrawler()
        {
           
        }

        private List<string> GetCatagoryPageLinks()
        {
            List<string> pageLinks = new List<string>();
            string pageUrl = "https://pages.ebay.com/sitemap.html";

            HtmlWeb page = new HtmlWeb();
            var doc = page.Load(pageUrl);

            var parentNodes = doc.DocumentNode.SelectNodes("//*[@class='itemcols']/li/a");

            foreach (HtmlNode node in parentNodes)
            {
                string nodeItem = node.Attributes["href"].Value;
                pageLinks.Add(nodeItem);
            }

            return pageLinks;
        }

        private Dictionary<string, string> GetCatagoryLinks()
        {
            Dictionary<string, string> pageLinks = new Dictionary<string, string>();
            string pageUrl = "https://pages.ebay.com/sitemap.html";

            HtmlWeb page = new HtmlWeb();
            var doc = page.Load(pageUrl);

            var parentNodes = doc.DocumentNode.SelectNodes("//*[@class='itemcols']/li/a");
            var contentNode = doc.DocumentNode.SelectNodes("//*[@class='h3content']");


            foreach (HtmlNode node in parentNodes)
            {
                string nodeItemLink = node.Attributes["href"].Value;
                string nodeItemText = node.InnerText;
                if (!pageLinks.ContainsKey(nodeItemText))
                {
                   pageLinks.Add(nodeItemText, nodeItemLink);
                }
            }
                
            return pageLinks;
        }

        public void GettNode()
        {
           // Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            string url = "https://www.ebay.com/b/Animal-Collectibles/1335/bn_1853571?LH_Complete=1";
            itemList = new List<Item>();
            HtmlWeb page = new HtmlWeb();
            var doc = page.Load(url);

            var listingNode = doc.DocumentNode.SelectNodes("//*[@class='s-item__info clearfix']");
            int i = 0;
            for(int y = 0; y < listingNode.Count; y++)
            {
                
                string title = listingNode[y].ChildNodes[0].ChildNodes[0].InnerText;
                string price = listingNode[y].ChildNodes[2].ChildNodes[0].InnerText;
                //string soldDate = listingNode[y].ChildNodes[1].InnerText;
              //  string imgUrl = listingNode[y].ChildNodes[1].Attributes["src"].Value;
               // int index = soldDate.Length;
                //string titleFinal = title.Remove(0, 18);
                itemList.Add(new Item(title, "", price, "", "", ""));

                ListViewItem lvi = new ListViewItem(itemList[i].id);
                lvi.SubItems.Add(itemList[y].title);
                lvi.SubItems.Add(itemList[y].price);
                lvi.SubItems.Add("");
                lvi.SubItems.Add(itemList[y].imglink);
                lvData.Items.Add(lvi);
                i++;
            }
            //sw.Stop();
            //MessageBox.Show(sw.Elapsed.ToString(), "Counter", MessageBoxButtons.OK);

            //this is a test to see if the change is taken
           
        }

    }
    
}
