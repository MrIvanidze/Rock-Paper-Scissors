using System.Runtime.Versioning;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static int gamePlayed = 0;
        public static int scoreWin = 0;
        public static string nikname;
        public static int age;
        public static string frame = "===================================================================================================================================";

        public static void Hello()
        {
            Console.WriteLine("                        ________  ________  ________  ___  __                                               \r\n                       |\\   __  \\|\\   __  \\|\\   ____\\|\\  \\|\\  \\                                             \r\n                       \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\  \\/  /|_                                           \r\n                        \\ \\   _  _\\ \\  \\\\\\  \\ \\  \\    \\ \\   ___  \\                                          \r\n                         \\ \\  \\\\  \\\\ \\  \\\\\\  \\ \\  \\____\\ \\  \\\\ \\  \\                                         \r\n                          \\ \\__\\\\ _\\\\ \\_______\\ \\_______\\ \\__\\\\ \\__\\                                        \r\n                           \\|__|\\|__|\\|_______|\\|_______|\\|__| \\|__|                                        \r\n                                                                                                            \r\n                                                                                                            \r\n                                                                                                            \r\n                            ________  ________  ________  _______   ________                                \r\n                           |\\   __  \\|\\   __  \\|\\   __  \\|\\  ___ \\ |\\   __  \\                               \r\n                           \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\|\\  \\ \\   __/|\\ \\  \\|\\  \\                              \r\n                            \\ \\   ____\\ \\   __  \\ \\   ____\\ \\  \\_|/_\\ \\   _  _\\                             \r\n                             \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\___|\\ \\  \\_|\\ \\ \\  \\\\  \\|                            \r\n                              \\ \\__\\    \\ \\__\\ \\__\\ \\__\\    \\ \\_______\\ \\__\\\\ _\\                            \r\n                               \\|__|     \\|__|\\|__|\\|__|     \\|_______|\\|__|\\|__|                           \r\n                                                                                                            \r\n                                                                                                            \r\n                                                                                                            \r\n                            ________  ________  ___  ________   ________  ________  ________  ________      \r\n                           |\\   ____\\|\\   ____\\|\\  \\|\\   ____\\ |\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\     \r\n                           \\ \\  \\___|\\ \\  \\___|\\ \\  \\ \\  \\___|_\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|_    \r\n                            \\ \\_____  \\ \\  \\    \\ \\  \\ \\_____  \\\\ \\_____  \\ \\  \\\\\\  \\ \\   _  _\\ \\_____  \\   \r\n                             \\|____|\\  \\ \\  \\____\\ \\  \\|____|\\  \\\\|____|\\  \\ \\  \\\\\\  \\ \\  \\\\  \\\\|____|\\  \\  \r\n                               ____\\_\\  \\ \\_______\\ \\__\\____\\_\\  \\ ____\\_\\  \\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n                              |\\_________\\|_______|\\|__|\\_________\\\\_________\\|_______|\\|__|\\|__|\\_________\\\r\n                              \\|_________|             \\|_________\\|_________|                  \\|_________| \n");
        }
        public static void languageAndRules(string[] leng)
        {


            Console.WriteLine($"\n{frame} \n→ Welcome to the game \"rock, scissors, paper\"! \n{frame} \r\n→ Before you start playing, select the game language, just write \"Eng\" or \"Ua\":");
            Console.Write($"→ ");
            string GameLanguageNL = Console.ReadLine();
            string GameLanguage = GameLanguageNL.ToLower();

            Console.WriteLine(frame);

            if (GameLanguage == "eng")
            {
                Console.WriteLine("→Ем... ну тут така поблема... мої знання англiйської закiнчилися ще на монулiй строчцi =( \n→Ну, буду сподiватися, що ти розумiєш українську =)");
            }
            else if (GameLanguage == "ua")
            {
                Console.WriteLine("→Чудово! Мова обрана!");
            }
            else
            {
                Console.WriteLine($"→I don't know \"{GameLanguageNL}\" language :( \nCan you try again?");
                return;
            }

            Console.WriteLine(frame);

            Console.WriteLine("\n _____                                                  _____ \r\n( ___ )------------------------------------------------( ___ )\r\n |   |                                                  |   | \r\n |   | $$$$$$$\\            $$\\                          |   | \r\n |   | $$  __$$\\           $$ |                         |   | \r\n |   | $$ |  $$ |$$\\   $$\\ $$ | $$$$$$\\   $$$$$$$\\ $$\\  |   | \r\n |   | $$$$$$$  |$$ |  $$ |$$ |$$  __$$\\ $$  _____|\\__| |   | \r\n |   | $$  __$$< $$ |  $$ |$$ |$$$$$$$$ |\\$$$$$$\\       |   | \r\n |   | $$ |  $$ |$$ |  $$ |$$ |$$   ____| \\____$$\\ $$\\  |   | \r\n |   | $$ |  $$ |\\$$$$$$  |$$ |\\$$$$$$$\\ $$$$$$$  |\\__| |   | \r\n |   | \\__|  \\__| \\______/ \\__| \\_______|\\_______/      |   | \r\n |___|                                                  |___| \r\n(_____)------------------------------------------------(_____)");

            Console.WriteLine($"\n \n{frame} \n→Правила простi:\n" +
                              "\n→Доступна зброя:\r\n\r\n→Камiнь\r\n→Ножицi\r\n→Папiр\r\n\n→Папiр перемагає над камiнням, але програє ножицям.\r\n→Ножицi перемагають над папером, але програють камiнню.\r\n→Камiння перемагає ножицi, але програє паперу.\r\n\n→Вiдбувається старт битви. Проти нас грає ШI, який обирає один iз видiв зброї, пiсля чого по правилах вище обирається переможець раунду.\r\n\r\n→Раундiв у нас ТРИ.\r\n→Пiсля третього раунду визначається переможець битви.\r\n\r\n→Бал за перемогу користувачу нараховується тiльки у випадку двох перемог i одного програшу, або трьох перемог та нулю програшiв за битву.\n→Грати можна тiльки з 12 років. \n→Щоб почати грати потрiбно пройти реєстрацiю.");
            Console.WriteLine(frame + "\n\n");
        }
        public static void registration()
        {

            Console.WriteLine(frame);

            Console.Write("→Напишiть ваш нiкнейм: ");
            nikname = Console.ReadLine();
            Console.Write("→Напишiть свiй вiк: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine(frame + "\n\n");
            Console.WriteLine(frame);

            if (age < 12)
            {
                Console.WriteLine("→В цю гру можна грати тiльки з 12 рокiв!");
                Console.WriteLine($"→Коли підростеш сподіваюся ми зустрінемось. Бувай {nikname} :)");
                return;
            }
            else
            {
                Console.WriteLine($"→Нiк: {nikname}\r\n" +
                                  $"→Вiк: {age}\r\n" +
                                  $"→Кiлькiсть зiграних раундiв: {gamePlayed}\r\n" +
                                  $"→Кiлькiсть перемог: {scoreWin}");
                Console.WriteLine(frame);
            }

            Console.WriteLine("\n" + frame + "\n");
            Console.Write("→Готовi почати свою першу гру? (Yes|No) \n→");
            string WonnaPlay = Console.ReadLine();

            WonnaPlay = WonnaPlay.ToLower();

            if (WonnaPlay == "yes")
            {
                Console.WriteLine(frame);
                Console.WriteLine("Тодi починаємо!");
                Console.WriteLine(frame + "\n\n");
                Console.WriteLine("                 ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████          \r\n                ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███          \r\n                ███    █▀    ███    ███ ███   ███   ███   ███    █▀           \r\n               ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄              \r\n              ▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀              \r\n                ███    ███   ███    ███ ███   ███   ███   ███    █▄           \r\n                ███    ███   ███    ███ ███   ███   ███   ███    ███          \r\n                ████████▀    ███    █▀   ▀█   ███   █▀    ██████████          ");             
                Game();
            }
            else if (WonnaPlay == "no")
            {
                Console.WriteLine("\n\n" + frame);
                Console.WriteLine($"→Ех... Бувай {nikname} :(");
                Console.WriteLine(frame);
            }
        }

        public static void Game()
        {
            Random enemyWeapon = new Random;

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{frame} \n→Нагадую, що: 1 - Камiнь   2 - папiр   3 - ножицi \n {frame}");
                Console.Write("→То що ви оберете? \n→");

            }
        }


        static void Main(string[] args)
        {
            Hello();

            languageAndRules(args);

            registration();
        }
    }
}