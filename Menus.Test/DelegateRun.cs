using Menus.Delegates;

namespace Menus.Test
{
    public class DelegateRun
    {
        private const int k_First = 1;

        public void Run()
        {
            DelegateTest delegateTest = new DelegateTest();
            MainMenu mainMenu = new MainMenu("Main Menu");
            PrefixMenu dateTimeMenu = new PrefixMenu("Show Date / Time", k_First);
            PrefixMenu versionAndCountDigitsMenu = new PrefixMenu("Version and Digits", k_First);
            Operation showTime = new Operation("Show Time");
            Operation showDate = new Operation("Show Date");
            Operation countDigits = new Operation("Count Digits");
            Operation showVersion = new Operation("Show Version");

            mainMenu.Add(dateTimeMenu, versionAndCountDigitsMenu);
            dateTimeMenu.AddMenuItems(showTime, showDate);
            versionAndCountDigitsMenu.AddMenuItems(countDigits, showVersion);
            showTime.OperationChoosen += delegateTest.CollectionOfMethods_ShowTime;
            showDate.OperationChoosen += delegateTest.CollectionOfMethods_ShowDate;
            countDigits.OperationChoosen += delegateTest.CollectionOfMethods_CountDigits;
            showVersion.OperationChoosen += delegateTest.CollectionOfMethods_ShowVersion;
            mainMenu.Show();
        }
    }
}
