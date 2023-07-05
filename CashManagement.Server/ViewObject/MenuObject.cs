using Microsoft.AspNetCore.Components.Routing;

namespace CashManagement.Server
{
    public class MenuObject
    {
        public MenuObject(string displayName, string link, string icon, NavLinkMatch matchType)
        {
            DisplayName = displayName;
            Link = link;
            Icon = icon;
            MatchType = matchType;
        }
        public string DisplayName { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public NavLinkMatch MatchType { get; set; }
    }
}
