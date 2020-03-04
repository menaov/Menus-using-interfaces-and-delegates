using System;
using System.Collections.Generic;

namespace Menus.Delegates
{
    public class PrefixMenu : MenuItem
    {
        private const int k_BackOrExit = 0;
        private const string k_Exit = "Exit";
        private const string k_Back = "Back";
        private readonly Dictionary<int, MenuItem> r_Options = new Dictionary<int, MenuItem>();
        private readonly int r_Level;
        private bool m_IsMain;
        private int m_CurrentOptionIndex = 1;

        public PrefixMenu(string i_Name, int i_Level) : base(i_Name)
        {
            r_Level = i_Level;
            r_Options.Add(k_BackOrExit, null);
        }

        public void ShowLevel(int i_Level)
        {
            int inputChoice;

            m_IsMain = i_Level == MainMenu.k_FirstLevel ? true : false;
            do
            {
                printMenu(i_Level);
                inputChoice = getChoice();
                Console.Clear();
                if (r_Options[inputChoice] != null)
                {
                    r_Options[inputChoice].Action(i_Level + 1);
                }
            }
            while (inputChoice != k_BackOrExit);
        }

        public override void Action(int i_Level)
        {
            this.ShowLevel(i_Level);
        }

        public void AddMenuItems(params MenuItem[] i_Items)
        {
            foreach (MenuItem i in i_Items)
            {
                r_Options.Add(m_CurrentOptionIndex++, i);
            }
        }

        private int getChoice()
        {
            string inputStr;
            int input;

            inputStr = Console.ReadLine();

            while (!int.TryParse(inputStr, out input) || !r_Options.ContainsKey(input))
            {
                Console.WriteLine("Invalid input! Try again.");
                inputStr = Console.ReadLine();
            }

            return input;
        }

        private void printCurrentLevelTopic(int i_CurrectLevel)
        {
            Console.WriteLine("The current level is: {0}", i_CurrectLevel);
            Console.WriteLine(ToString());
            for (int i = 0; i < ToString().Length; i++)
            {
                Console.Write("-");
            }

            Console.Write(Environment.NewLine);
        }

        private void printMenu(int i_Level)
        {
            printCurrentLevelTopic(i_Level);
            foreach (int i in r_Options.Keys)
            {
                if (i == k_BackOrExit)
                {
                    printBackOrExit(i_Level);
                }
                else
                {
                    Console.WriteLine("{0}. {1}", i, r_Options[i].ToString());
                }
            }

            Console.WriteLine("Please choose your option:");
        }

        private void printBackOrExit(int i_Level)
        {
            if (m_IsMain == true)
            {
                Console.WriteLine("{0}. {1}", k_BackOrExit, k_Exit);
            }
            else
            {
                Console.WriteLine("{0}. {1}", k_BackOrExit, k_Back);
            }
        }
    }
}
