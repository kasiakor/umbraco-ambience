using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoAmbience.Web.Models;

namespace UmbracoAmbience.Web.Controllers
{
    public class NewsController : SurfaceController
    {
        public string GetPathView(string name)
        {
            return $"/Views/Partials/News/{name}.cshtml";
        }
        public ActionResult RenderNewsList(int itemsToShow)
        {
           
            List<NewsPreviewModel> model = new List<NewsPreviewModel>();
            IPublishedContent newsPage = CurrentPage.AncestorsOrSelf("newsList").FirstOrDefault();
            if(newsPage !=null && newsPage.Children.Any())
            {
                foreach (IPublishedContent page in newsPage.Children.OrderByDescending(y => y.GetPropertyValue<DateTime>("articleDate")).Take(itemsToShow))
                {
                    string title = page.GetPropertyValue<string>("articleTitle");
                    string intro = page.GetPropertyValue<string>("articleIntro");

                    int imageId = page.GetPropertyValue<int>("articleImage");
                    var mediaItem = Umbraco.Media(imageId);
                    string imageUrl = mediaItem.Url;

                    string linkUrl = page.Url;

                    //string articleDate = umbraco.library.FormatDateTime(page.GetPropertyValue("articleDate").ToString(), "dd-MM-yyyy");
                    string articleDate = page.GetPropertyValue<string>("articleDate");

                    model.Add(new NewsPreviewModel(title, intro, imageUrl, linkUrl, articleDate));

                }
            }
            return PartialView(GetPathView("_Spotlight"), model);

        }
    }
}