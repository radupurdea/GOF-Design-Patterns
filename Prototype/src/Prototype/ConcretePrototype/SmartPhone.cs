using System;
using System.Collections.Generic;

namespace Prototype
{
    public class SmartPhone : Prototype, IProduct, ICellPhone, IHeadset, IShippable
    {
        public SmartPhone()
        {
            this.Code = "SKU-123-MODEL-T";
            this.TradeName = "iPhone 11";
            this.Battery = new Battery();
            this.NetworkReceiver = new NetworkReceiver();
            this.InternalMemory = 64;
            this.JackSize = double.NaN;
            this.Body = new PhoneBody();
            this.FactoryInstalledApps = new List<App>()
            {
                new App("Calendar"),
                new App("Contacts"),
                new App("Notes"),
                new App("Voice Memos")
            };
        }

        public string Code { get; }

        public string TradeName { get; }

        public Battery Battery { get; }
        
        public NetworkReceiver NetworkReceiver { get; set; }

        public int InternalMemory { get; set; }

        public double JackSize { get; }

        public PhoneBody Body { get; }

        public List<App> FactoryInstalledApps { get; }
        
        public override Prototype Clone()
        {
            return this.DeepClone();
        }

        public void Ship()
        {
            Console.WriteLine("A new phone has been shipped! See below it's configuration:");
            Console.WriteLine("Details:");
            Console.WriteLine("Name: {0} ({1}), Internal memory: {2}, Network type: {3}, Color: {4}", this.TradeName, this.Code, this.InternalMemory, this.NetworkReceiver.Type, this.Body.Color.Name);
            Console.WriteLine("With an engraved message: \"{0}\".", this.Body.EngravedMessage);
            Console.WriteLine("Factory installed apps:");

            foreach(var app in this.FactoryInstalledApps)
            {
                Console.WriteLine("     {0}", app.Name);
            }
        }
    }
}
