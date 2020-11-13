namespace Prototype
{
    public struct Battery
    {
        public string Capacity { get; }

        public string SerialNumber { get; }

        public Battery(string capacity)
        {
            this.Capacity = "120mA";
            this.SerialNumber = "13.2.3/2020";
        }
    }
}