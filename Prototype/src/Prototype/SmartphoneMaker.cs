using System;

namespace Prototype
{
    public class SmartphoneMaker
    {
        private SmartPhone prototype;

        public SmartphoneMaker(SmartPhone prototype)
        {
            if (prototype == null) throw new ArgumentNullException();

            this.prototype = prototype;
        }

        public SmartPhone Configure(PhoneConfiguration configuration)
        {
            var phone = (SmartPhone)this.prototype.Clone();

            phone.Body.Color = configuration.BodyColor;
            phone.Body.EngravedMessage = configuration.EngravedMessage;

            if (configuration.InternalMemory > 64)
            {
                phone.InternalMemory = configuration.InternalMemory;
            }

            phone.FactoryInstalledApps.AddRange(configuration.PurchasedApps);

            return phone;
        }
    }
}
