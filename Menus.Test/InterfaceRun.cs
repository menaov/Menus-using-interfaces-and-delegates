using Menus.Interfaces;

namespace Menus.Test
{
    public class InterfaceRun
    {
        private const int k_First = 1;

        public void Run()
        {
            MainMenu mainMenu = new MainMenu("Main Menu");
            PrefixMenu dateTimeMenu = new PrefixMenu("Show Date / Time", k_First);
            PrefixMenu versionAndCountDigitsMenu = new PrefixMenu("Version and Digits", k_First);
            ShowTime showTime = new ShowTime("Show Time");
            ShowDate showDate = new ShowDate("Show Date");
            CountDigits countDigits = new CountDigits("Count Digits");
            ShowVersion showVersion = new ShowVersion("Show Version");

            mainMenu.Add(dateTimeMenu, versionAndCountDigitsMenu);
            dateTimeMenu.AddMenuItems(showTime, showDate);
            versionAndCountDigitsMenu.AddMenuItems(countDigits, showVersion);
            mainMenu.Show();
        }
    }
}
