namespace Menus.Test
{
   

    public class Program
    {
        public static void Main()
        {
            InterfaceRun interfaceRun = new InterfaceRun();
            DelegateRun delegateRun = new DelegateRun();
            interfaceRun.Run();
            delegateRun.Run();
        }
    }
}
