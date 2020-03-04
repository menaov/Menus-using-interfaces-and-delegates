using System;

namespace Menus.Test
{
    public class CollectionOfMethods
    {
        public void ShowDate()
        {
            string dateMessage = string.Format(
@"The current date is: {0}
",
DateTime.Today.ToString("dd/MM/yyyy"));

            Console.WriteLine(dateMessage);
        }

        public void ShowTime()
        {
            string timeMessage = string.Format(
@"The current time is: {0}
",
DateTime.Now.ToString("HH:mm:ss"));

            Console.WriteLine(timeMessage);
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 19.2.4.32" + Environment.NewLine);
        }

        private int getCountDigits(string i_ToCheck)
        {
            int digitsCounter = 0;
            foreach (char c in i_ToCheck)
            {
                if (char.IsDigit(c) == true)
                {
                    digitsCounter++;
                }
            }

            return digitsCounter;
        }

        private string getSentence()
        {
            string input;
            Console.WriteLine("Please enter your sentence:");
            input = Console.ReadLine();

            return input;
        }

        public void CountDigits()
        {
            string sentence = getSentence();
            string message = string.Format(
@"The amount of digits in the sentence is: {0}
",
getCountDigits(sentence));

            Console.WriteLine(message);
        }
    }
}
