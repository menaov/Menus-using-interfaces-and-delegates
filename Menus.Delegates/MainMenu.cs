namespace Menus.Delegates
{
    public class MainMenu
    {
        internal const int k_FirstLevel = 1;
        private readonly PrefixMenu r_Menu;

        public MainMenu(string i_Name)
        {
            r_Menu = new PrefixMenu(i_Name, k_FirstLevel);
        }

        public void Show()
        {
            r_Menu.ShowLevel(k_FirstLevel);
        }

        public void Add(params MenuItem[] i_ItemsToAdd)
        {
            r_Menu.AddMenuItems(i_ItemsToAdd);
        }
    }
}
