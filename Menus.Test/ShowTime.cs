using Menus.Interfaces;

namespace Menus.Test
{
    public class ShowTime : MenuItem, IRunnable
    {
        private CollectionOfMethods m_Methods = new CollectionOfMethods();

        public ShowTime(string i_Name) : base(i_Name)
        {
        }

        public void Run()
        {
            m_Methods.ShowTime();
        }
    }
}
