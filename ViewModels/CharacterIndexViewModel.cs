using assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;

namespace assignment2.ViewModels
{
    public class CharacterIndexViewModel
    {
       // public IPagedList<Product> Products { get; set; }

        public IPagedList<Character> Characters{ get; set; }
        public string Search { get; set; }
        public IEnumerable<DestinyWithCount> CatsWithCount { get; set; }
        public string Destiny { get; set; }
        public string SortBy { get; set; }

        public Dictionary<string, string> Sorts { get; set; }
        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.DestinyName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
    }
    public class DestinyWithCount
    {
        public int DestinyCount { get; set; }
        public string DestinyName { get; set; }
        public string CatNameWithCount
        {
            get
            {
                return DestinyName + " (" + DestinyCount.ToString() + ")";
            }
        }
    }
}