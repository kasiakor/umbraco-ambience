using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoAmbience.Web.Models
{
    public class NewsPreviewModel 
    {
        public string Title { get; set; }
        public string Intro { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl{ get; set; }
        
        public NewsPreviewModel(string title, string intro, string imageUrl, string linkUrl)
        {
            Title = title;
            Intro = intro;
            ImageUrl = imageUrl;
            LinkUrl = linkUrl;
           

        }
    }
}