using Menus.Interfaces;

namespace Menus.Test
{
    public class ShowDate : MenuItem, IRunnable
    {
        private CollectionOfMethods m_Methods = new CollectionOfMethods();

        public ShowDate(string i_Name) : base(i_Name)
        {
        }

        public void Run()
        {
            m_Methods.ShowDate();
        }
    }
}
