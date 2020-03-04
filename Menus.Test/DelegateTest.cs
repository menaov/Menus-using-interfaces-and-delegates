namespace Menus.Test
{
    public class DelegateTest
    {
        private readonly CollectionOfMethods r_Methods = new CollectionOfMethods();

        public void CollectionOfMethods_ShowDate()
        {
            r_Methods.ShowDate();
        }

        public void CollectionOfMethods_ShowTime()
        {
            r_Methods.ShowTime();
        }

        public void CollectionOfMethods_ShowVersion()
        {
            r_Methods.ShowVersion();
        }

        public void CollectionOfMethods_CountDigits()
        {
            r_Methods.CountDigits();
        }
    }
}
