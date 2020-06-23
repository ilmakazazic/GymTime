using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Teretane,
        Prisustva
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
