namespace eTeretane.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Teretane,
        Prisustva,
        Kuponi
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
