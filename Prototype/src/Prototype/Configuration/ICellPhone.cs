namespace Prototype
{
    public interface ICellPhone
    {
        Battery Battery { get; }

        NetworkReceiver NetworkReceiver { get; }

        int InternalMemory { get; set; }
        
        PhoneBody Body { get; }
    }
}