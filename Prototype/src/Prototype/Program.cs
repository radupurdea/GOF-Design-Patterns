namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var smartPhonePrototype = new SmartPhone();
            var smartPhoneMaker = new SmartphoneMaker(smartPhonePrototype);

            var redPhone = smartPhoneMaker.Configure(new PhoneConfiguration()
            {
                BodyColor = Color.Red,
                EngravedMessage = "Red is a nice color.",
                InternalMemory = 512
            });

            redPhone.Ship();
            
            var greenPhone = smartPhoneMaker.Configure(new PhoneConfiguration()
            {
                BodyColor = Color.Green,
                EngravedMessage = "Green is even nicer!",
                InternalMemory = 1024
            });

            greenPhone.Ship();

            var bluePhoneConfiguration = new PhoneConfiguration()
            {
                BodyColor = Color.Blue,
                EngravedMessage = "Blue makes me feel happy."
            };

            bluePhoneConfiguration.PurchasedApps.Add(new App("Garage Band"));
            bluePhoneConfiguration.PurchasedApps.Add(new App("Movies"));

            var bluePhone = smartPhoneMaker.Configure(bluePhoneConfiguration);

            bluePhone.Ship();
        }
    }
}
