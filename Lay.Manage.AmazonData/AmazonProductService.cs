using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Lay.Manage.Products;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using HtmlAgilityPack;

namespace Lay.Manage.AmazonData
{
    public class AmazonProductService : IAmazonProductService
    {
        private WebClient client = new WebClient();

        public Product GetProduct(string urlOrAsin)
        {
            if (urlOrAsin.IndexOf("/") > 0)
            {
                return GetProductFormUrl(urlOrAsin);
            }
            else
            {
                return GetProductFormAsin(urlOrAsin);
            }
        }

        private Product GetProductFormAsin(string asin)
        {
            return null;
        }

        private Product GetProductFormUrl(string url)
        {
            string mainData = Encoding.UTF8.GetString(client.DownloadData(url));
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(mainData);

            HtmlNode rootNode = htmlDoc.DocumentNode;

            HtmlNode titleNode = rootNode.SelectSingleNode("//span[@id='productTitle']");
            HtmlNode asinNode = rootNode.SelectSingleNode("//input[@id='ASIN']");
            HtmlNode pictureNode = rootNode.SelectSingleNode("//img[@id='landingImage']");

            Product product = new Product();

            if (titleNode != null & asinNode != null & pictureNode != null)
            {
                var title = titleNode.InnerHtml;
                var asin = asinNode.Attributes["value"].Value;
                var picture = pictureNode.Attributes["src"].Value;
                
                product.Name = title;
                product.Pic = picture;
                product.Asin = asin;
               
            }
            return product;


        }
    }

    public interface IAmazonProductService
    {
        Product GetProduct(string urlOrAsin);
    }
}
