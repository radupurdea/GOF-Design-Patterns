using System.Collections.Generic;

namespace Prototype
{
    public class PhoneConfiguration
    {
        public PhoneConfiguration()
        {
            this.PurchasedApps = new List<App>();
        }

        public int InternalMemory { get; set; }

        public Color BodyColor { get; set; }

        public string EngravedMessage { get; set; }

        public IList<App> PurchasedApps { get; }
    }
}
