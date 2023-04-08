using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Check_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                bool showGreetingOn;
                var file = new StreamReader("ShowGreeting");
                string stringShowGreetingOn = file.ReadLine();
                file.Close();
                showGreetingOn = Convert.ToBoolean(stringShowGreetingOn);
                if (showGreetingOn)
                {
                    MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                    "Группа: 414" + Environment.NewLine +
                                    "Вариант: 4",
                                    "Лемниската Бернулли");
                    Application.Run(new Form1());
                }
                if (!showGreetingOn)
                    Application.Run(new Form1());
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("В приложении произошла ошибка, настройки приложения были восстоновлены по умолчанию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var file = new StreamWriter("ShowGreeting", false);
                bool showGreetingOn = true;
                file.WriteLine(showGreetingOn);
                file.Close();
                MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                    "Группа: 414" + Environment.NewLine +
                                    "Вариант: 4",
                                    "Лемниската Бернулли");
                Application.Run(new Form1());

            }
            catch (FormatException)
            {
                MessageBox.Show("В приложении произошла ошибка, настройки приложения были восстоновлены по умолчанию!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var file = new StreamWriter("ShowGreeting", false);
                bool showGreetingOn = true;
                file.WriteLine(showGreetingOn);
                file.Close();
                MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                     "Группа: 414" + Environment.NewLine +
                                     "Вариант: 4",
                                     "Лемниската Бернулли");
                Application.Run(new Form1());
            }
        }
    }
}
