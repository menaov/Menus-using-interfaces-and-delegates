namespace Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_Name;

        public MenuItem(string i_Name)
        {
            r_Name = i_Name;
        }

        public override string ToString()
        {
            return r_Name;
        }

        public abstract void Action(int i_Level);
    }
}
