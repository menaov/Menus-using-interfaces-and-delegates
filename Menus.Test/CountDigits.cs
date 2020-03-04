using Menus.Interfaces;

namespace Menus.Test
{
    public class CountDigits : MenuItem, IRunnable
    {
        private CollectionOfMethods m_Methods = new CollectionOfMethods();

        public CountDigits(string i_Name) : base(i_Name)
        {
        }

        public void Run()
        {
            m_Methods.CountDigits();
        }
    }
}
