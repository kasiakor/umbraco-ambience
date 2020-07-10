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
        public ActionResult RenderNewsList()
        {
            IPublishedContent newsPage = CurrentPage.AncestorsOrSelf("newsList").FirstOrDefault();
            List<NewsPreviewModel> model = new List<NewsPreviewModel>();

            foreach(IPublishedContent page in newsPage.Children.OrderByDescending(y => y.CreateDate))
            {
                string title = page.GetPropertyValue<string>("articleTitle");
                string intro = page.GetPropertyValue<string>("articleIntro");

                int imageId = page.GetPropertyValue<int>("articleImage");
                var mediaItem = Umbraco.Media(imageId);
                string imageUrl = mediaItem.Url;

                string linkUrl = page.Url;

                model.Add(new NewsPreviewModel(title, intro, imageUrl, linkUrl));
            }
            return PartialView(GetPathView("_Spotlight"), model);

        }
    }
}