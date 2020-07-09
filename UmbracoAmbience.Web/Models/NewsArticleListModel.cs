using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoAmbience.Web.Models;

namespace UmbracoAmbience.Web.Models
{
    public class NewsArticleListModel
    {
        public List<NewsArticleModel> Items { get; set; }
        public bool HasItems => Items != null && Items.Count > 0;
        public int ItemsCount => HasItems ? Items.Count : 0;
    }
}
