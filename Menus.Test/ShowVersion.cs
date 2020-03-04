using Menus.Interfaces;

namespace Menus.Test
{
    public class ShowVersion : MenuItem, IRunnable
    {
        private CollectionOfMethods m_Methods = new CollectionOfMethods();

        public ShowVersion(string i_Name) : base(i_Name)
        {
        }

        public void Run()
        {
            m_Methods.ShowVersion();
        }
    }
}
