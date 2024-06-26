﻿using System.Runtime.Versioning;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static int gamePlayed = 0;
        public static int scoreWin = 0;
        public static string nickname;
        public static int age;
        public static string frame = "===================================================================================================================================";

        static void Main(string[] args)
        {
            Hello();

            LanguageAndRules(args);

            Registration();
        }

        public static void Hello()
        {
            Console.WriteLine("                        ________  ________  ________  ___  __                                               \r\n                       |\\   __  \\|\\   __  \\|\\   ____\\|\\  \\|\\  \\                                             \r\n                       \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|\\ \\  \\/  /|_                                           \r\n                        \\ \\   _  _\\ \\  \\\\\\  \\ \\  \\    \\ \\   ___  \\                                          \r\n                         \\ \\  \\\\  \\\\ \\  \\\\\\  \\ \\  \\____\\ \\  \\\\ \\  \\                                         \r\n                          \\ \\__\\\\ _\\\\ \\_______\\ \\_______\\ \\__\\\\ \\__\\                                        \r\n                           \\|__|\\|__|\\|_______|\\|_______|\\|__| \\|__|                                        \r\n                                                                                                            \r\n                                                                                                            \r\n                                                                                                            \r\n                            ________  ________  ________  _______   ________                                \r\n                           |\\   __  \\|\\   __  \\|\\   __  \\|\\  ___ \\ |\\   __  \\                               \r\n                           \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\|\\  \\ \\   __/|\\ \\  \\|\\  \\                              \r\n                            \\ \\   ____\\ \\   __  \\ \\   ____\\ \\  \\_|/_\\ \\   _  _\\                             \r\n                             \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\___|\\ \\  \\_|\\ \\ \\  \\\\  \\|                            \r\n                              \\ \\__\\    \\ \\__\\ \\__\\ \\__\\    \\ \\_______\\ \\__\\\\ _\\                            \r\n                               \\|__|     \\|__|\\|__|\\|__|     \\|_______|\\|__|\\|__|                           \r\n                                                                                                            \r\n                                                                                                            \r\n                                                                                                            \r\n                            ________  ________  ___  ________   ________  ________  ________  ________      \r\n                           |\\   ____\\|\\   ____\\|\\  \\|\\   ____\\ |\\   ____\\|\\   __  \\|\\   __  \\|\\   ____\\     \r\n                           \\ \\  \\___|\\ \\  \\___|\\ \\  \\ \\  \\___|_\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___|_    \r\n                            \\ \\_____  \\ \\  \\    \\ \\  \\ \\_____  \\\\ \\_____  \\ \\  \\\\\\  \\ \\   _  _\\ \\_____  \\   \r\n                             \\|____|\\  \\ \\  \\____\\ \\  \\|____|\\  \\\\|____|\\  \\ \\  \\\\\\  \\ \\  \\\\  \\\\|____|\\  \\  \r\n                               ____\\_\\  \\ \\_______\\ \\__\\____\\_\\  \\ ____\\_\\  \\ \\_______\\ \\__\\\\ _\\ ____\\_\\  \\ \r\n                              |\\_________\\|_______|\\|__|\\_________\\\\_________\\|_______|\\|__|\\|__|\\_________\\\r\n                              \\|_________|             \\|_________\\|_________|                  \\|_________| \n");
        }
        public static void LanguageAndRules(string[] leng)
        {


            Console.WriteLine($"\n{frame} \n→ Welcome to the game \"rock, scissors, paper\"! \n{frame} \r\n→ Before you start playing, select the game language, just write \"Eng\" or \"Ua\":");

            Console.WriteLine(frame);

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"→ ");
                string GameLanguageNL = Console.ReadLine();
                string GameLanguage = GameLanguageNL.ToLower();

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
                    Console.WriteLine($"→I don't know \"{GameLanguageNL}\" language :( \n→Can you try again?");
                    i--;
                }
            }

            Console.WriteLine(frame);

            Console.WriteLine("\n _____                                                  _____ \r\n( ___ )------------------------------------------------( ___ )\r\n |   |                                                  |   | \r\n |   | $$$$$$$\\            $$\\                          |   | \r\n |   | $$  __$$\\           $$ |                         |   | \r\n |   | $$ |  $$ |$$\\   $$\\ $$ | $$$$$$\\   $$$$$$$\\ $$\\  |   | \r\n |   | $$$$$$$  |$$ |  $$ |$$ |$$  __$$\\ $$  _____|\\__| |   | \r\n |   | $$  __$$< $$ |  $$ |$$ |$$$$$$$$ |\\$$$$$$\\       |   | \r\n |   | $$ |  $$ |$$ |  $$ |$$ |$$   ____| \\____$$\\ $$\\  |   | \r\n |   | $$ |  $$ |\\$$$$$$  |$$ |\\$$$$$$$\\ $$$$$$$  |\\__| |   | \r\n |   | \\__|  \\__| \\______/ \\__| \\_______|\\_______/      |   | \r\n |___|                                                  |___| \r\n(_____)------------------------------------------------(_____)");

            Console.WriteLine($"\n \n{frame} \n→Правила простi:\n" +
                              "\n→Доступна зброя:\r\n\r\n→Камiнь\r\n→Ножицi\r\n→Папiр\r\n\n→Папiр перемагає над камiнням, але програє ножицям.\r\n→Ножицi перемагають над папером, але програють камiнню.\r\n→Камiння перемагає ножицi, але програє паперу.\r\n\n→Вiдбувається старт битви. Проти нас грає ШI, який обирає один iз видiв зброї, пiсля чого по правилах вище обирається переможець раунду.\r\n\r\n→Раундiв у нас ТРИ.\r\n→Пiсля третього раунду визначається переможець битви.\r\n\r\n→Бал за перемогу користувачу нараховується тiльки у випадку двох перемог i одного програшу, або трьох перемог та нулю програшiв за битву.\n→Грати можна тiльки з 12 рокiв. \n→Щоб почати грати потрiбно пройти реєстрацiю.");
            Console.WriteLine(frame + "\n\n");
        }
        public static void Registration()
        {

            Console.WriteLine(frame);

            int nicknameScore = 0;

            do
            {
                if (nicknameScore == 0)
                {
                    Console.Write("→Напишiть ваш нiкнейм: ");
                    nickname = Console.ReadLine();
                }
                else if (nicknameScore >= 1)
                {
                    Console.Write("→Напишiть ваш нiкнейм коректно: ");
                    nickname = Console.ReadLine();
                }
                nicknameScore++;
            }
            while (string.IsNullOrEmpty(nickname));
            
            var ageVar = "";
            int ageScore = 0;

            do
            {
                if (ageScore == 0)
                {
                    Console.Write("→Напишiть свiй вiк: ");
                    ageVar = Console.ReadLine();
                }
                else if (ageScore >= 1) 
                {
                    Console.Write("→Напишiть свiй вiк коректно: ");
                    ageVar = Console.ReadLine();
                }
                ageScore++;
            }
            while (string.IsNullOrEmpty(ageVar));
            age = int.Parse(ageVar);

            Console.WriteLine(frame + "\n\n");
            Console.WriteLine(frame);

            if (age < 12)
            {
                Console.WriteLine("→В цю гру можна грати тiльки з 12 рокiв!");
                Console.WriteLine($"→Коли пiдростеш сподiваюся ми зустрiнемось. Бувай {nickname} :)");
                return;
            }
            else if (age >= 100) 
            {
                Console.WriteLine("→Ого! А можете розказати свiй секрет довголiття? :)");

                Console.WriteLine(frame + "\n\n");

                Console.WriteLine(frame);
                Console.WriteLine($"→Нiк: {nickname}\r\n" +
                                  $"→Вiк: {age}\r\n" +
                                  $"→Кiлькiсть зiграних раундiв: {gamePlayed}\r\n" +
                                  $"→Кiлькiсть перемог: {scoreWin}");
                Console.WriteLine(frame);
            }
            else
            {
                Console.WriteLine($"→Нiк: {nickname}\r\n" +
                                  $"→Вiк: {age}\r\n" +
                                  $"→Кiлькiсть зiграних раундiв: {gamePlayed}\r\n" +
                                  $"→Кiлькiсть перемог: {scoreWin}");
                Console.WriteLine(frame);
            }

            Console.WriteLine("\n" + frame + "\n");
            Console.Write("→Готовi почати свою першу гру? (Yes|No) \n→");
            string WonnaPlay = Console.ReadLine();

            WonnaPlay = WonnaPlay.ToLower();

            if (WonnaPlay == "yes" || WonnaPlay == "y")
            {
                Console.WriteLine(frame);
                Console.WriteLine("→Тодi починаємо!");
                Console.WriteLine(frame + "\n\n");
                Console.WriteLine("                 ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████          \r\n                ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███          \r\n                ███    █▀    ███    ███ ███   ███   ███   ███    █▀           \r\n               ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄              \r\n              ▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀              \r\n                ███    ███   ███    ███ ███   ███   ███   ███    █▄           \r\n                ███    ███   ███    ███ ███   ███   ███   ███    ███          \r\n                ████████▀    ███    █▀   ▀█   ███   █▀    ██████████          ");             
                Game();
            }
            else if (WonnaPlay == "no" || WonnaPlay == "n")
            {
                Console.WriteLine("\n\n" + frame);
                Console.WriteLine($"→Ех... Бувай {nickname} :(");
                Console.WriteLine(frame);
            }
        }

        public static void Game()
        {
            string win = " /$$     /$$ /$$$$$$  /$$   /$$       /$$      /$$  /$$$$$$  /$$   /$$\r\n|  $$   /$$//$$__  $$| $$  | $$      | $$  /$ | $$ /$$__  $$| $$$ | $$\r\n \\  $$ /$$/| $$  \\ $$| $$  | $$      | $$ /$$$| $$| $$  \\ $$| $$$$| $$\r\n  \\  $$$$/ | $$  | $$| $$  | $$      | $$/$$ $$ $$| $$  | $$| $$ $$ $$\r\n   \\  $$/  | $$  | $$| $$  | $$      | $$$$_  $$$$| $$  | $$| $$  $$$$\r\n    | $$   | $$  | $$| $$  | $$      | $$$/ \\  $$$| $$  | $$| $$\\  $$$\r\n    | $$   |  $$$$$$/|  $$$$$$/      | $$/   \\  $$|  $$$$$$/| $$ \\  $$\r\n    |__/    \\______/  \\______/       |__/     \\__/ \\______/ |__/  \\__/";
            string lost = " /$$     /$$                        /$$                       /$$    \r\n|  $$   /$$/                       | $$                      | $$    \r\n \\  $$ /$$//$$$$$$  /$$   /$$      | $$  /$$$$$$   /$$$$$$$ /$$$$$$  \r\n  \\  $$$$//$$__  $$| $$  | $$      | $$ /$$__  $$ /$$_____/|_  $$_/  \r\n   \\  $$/| $$  \\ $$| $$  | $$      | $$| $$  \\ $$|  $$$$$$   | $$    \r\n    | $$ | $$  | $$| $$  | $$      | $$| $$  | $$ \\____  $$  | $$ /$$\r\n    | $$ |  $$$$$$/|  $$$$$$/      | $$|  $$$$$$/ /$$$$$$$/  |  $$$$/\r\n    |__/  \\______/  \\______/       |__/ \\______/ |_______/    \\___/  ";
            string draw = " /$$$$$$$                                  \r\n| $$__  $$                                 \r\n| $$  \\ $$  /$$$$$$  /$$$$$$  /$$  /$$  /$$\r\n| $$  | $$ /$$__  $$|____  $$| $$ | $$ | $$\r\n| $$  | $$| $$  \\__/ /$$$$$$$| $$ | $$ | $$\r\n| $$  | $$| $$      /$$__  $$| $$ | $$ | $$\r\n| $$$$$$$/| $$     |  $$$$$$$|  $$$$$/$$$$/\r\n|_______/ |__/      \\_______/ \\_____/\\___/ ";
            
            Random enemyWeapon = new Random();
            
            EnumWeapon EnemyWeapon;
            EnumWeapon Weapon;

            int WonRaunds = 0;
            int LostRaunds = 0;
            int DrawRaunds = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"\n\n{frame}\n\n                ROUND {i} \n");

                int RundomWeapon = enemyWeapon.Next(1, 4);

                Console.WriteLine($"{frame}\n→Нагадую, що: 1 - Камiнь   2 - папiр   3 - ножицi \n{frame}");
                Console.Write("→То що ви оберете? \n→ ");
                int heroWeapon = int.Parse(Console.ReadLine());

                if (heroWeapon > 3 || heroWeapon < 1)
                {
                    Console.WriteLine("→Спробуйте ще раз, будь ласка.");
                    i--;
                    continue;
                }
                else 
                {
                    Weapon = (EnumWeapon)heroWeapon;
                }
                Console.WriteLine($"→Отже ваша зброя: {Weapon}" );
                EnemyWeapon = (EnumWeapon)RundomWeapon;
                Console.WriteLine($"→Зброя ШI: {EnemyWeapon}\n\n");

                if (heroWeapon == 1 && RundomWeapon == 2)
                {
                    Console.WriteLine(lost);
                    LostRaunds++;
                }
                else if (heroWeapon == 2 && RundomWeapon == 3)
                {
                    Console.WriteLine(lost);
                    LostRaunds++;
                }
                else if (heroWeapon == 1 && RundomWeapon == 3)
                {
                    Console.WriteLine(win);
                    WonRaunds++;
                }
                else if (heroWeapon == 2 && RundomWeapon == 1)
                {
                    Console.WriteLine(win);
                    WonRaunds++;
                }
                else if (heroWeapon == 3 && RundomWeapon == 1)
                {
                    Console.WriteLine(lost);
                    LostRaunds++;
                }
                else if (heroWeapon == 3 && RundomWeapon == 2)
                {
                    Console.WriteLine(win);
                    WonRaunds++;
                }
                else if (heroWeapon == RundomWeapon) 
                {
                    Console.WriteLine(draw);
                    DrawRaunds++;
                }
            }

            gamePlayed++;

            Console.WriteLine("\n\n" + frame);

            if (WonRaunds > LostRaunds)
            {
                Console.WriteLine($"\n\n /$$     /$$ /$$$$$$  /$$   /$$       /$$      /$$  /$$$$$$  /$$   /$$                 \r\n|  $$   /$$//$$__  $$| $$  | $$      | $$  /$ | $$ /$$__  $$| $$$ | $$                 \r\n \\  $$ /$$/| $$  \\ $$| $$  | $$      | $$ /$$$| $$| $$  \\ $$| $$$$| $$                 \r\n  \\  $$$$/ | $$  | $$| $$  | $$      | $$/$$ $$ $$| $$  | $$| $$ $$ $$                 \r\n   \\  $$/  | $$  | $$| $$  | $$      | $$$$_  $$$$| $$  | $$| $$  $$$$                 \r\n    | $$   | $$  | $$| $$  | $$      | $$$/ \\  $$$| $$  | $$| $$\\  $$$                 \r\n    | $$   |  $$$$$$/|  $$$$$$/      | $$/   \\  $$|  $$$$$$/| $$ \\  $$                 \r\n    |__/    \\______/  \\______/       |__/     \\__/ \\______/ |__/  \\__/                 \r\n                                                                                       \r\n                                                                                       \r\n                                                                                       \r\n /$$$$$$$$ /$$   /$$ /$$$$$$  /$$$$$$         /$$$$$$   /$$$$$$  /$$      /$$ /$$$$$$$$\r\n|__  $$__/| $$  | $$|_  $$_/ /$$__  $$       /$$__  $$ /$$__  $$| $$$    /$$$| $$_____/\r\n   | $$   | $$  | $$  | $$  | $$  \\__/      | $$  \\__/| $$  \\ $$| $$$$  /$$$$| $$      \r\n   | $$   | $$$$$$$$  | $$  |  $$$$$$       | $$ /$$$$| $$$$$$$$| $$ $$/$$ $$| $$$$$   \r\n   | $$   | $$__  $$  | $$   \\____  $$      | $$|_  $$| $$__  $$| $$  $$$| $$| $$__/   \r\n   | $$   | $$  | $$  | $$   /$$  \\ $$      | $$  \\ $$| $$  | $$| $$\\  $ | $$| $$      \r\n   | $$   | $$  | $$ /$$$$$$|  $$$$$$/      |  $$$$$$/| $$  | $$| $$ \\/  | $$| $$$$$$$$\r\n   |__/   |__/  |__/|______/ \\______/        \\______/ |__/  |__/|__/     |__/|________/");
                scoreWin++;
            }
            else if (WonRaunds < LostRaunds)
            {
                Console.WriteLine($"\n\n /$$     /$$ /$$$$$$  /$$   /$$       /$$        /$$$$$$   /$$$$$$  /$$$$$$$$          \r\n|  $$   /$$//$$__  $$| $$  | $$      | $$       /$$__  $$ /$$__  $$|__  $$__/          \r\n \\  $$ /$$/| $$  \\ $$| $$  | $$      | $$      | $$  \\ $$| $$  \\__/   | $$             \r\n  \\  $$$$/ | $$  | $$| $$  | $$      | $$      | $$  | $$|  $$$$$$    | $$             \r\n   \\  $$/  | $$  | $$| $$  | $$      | $$      | $$  | $$ \\____  $$   | $$             \r\n    | $$   | $$  | $$| $$  | $$      | $$      | $$  | $$ /$$  \\ $$   | $$             \r\n    | $$   |  $$$$$$/|  $$$$$$/      | $$$$$$$$|  $$$$$$/|  $$$$$$/   | $$             \r\n    |__/    \\______/  \\______/       |________/ \\______/  \\______/    |__/             \r\n                                                                                       \r\n                                                                                       \r\n                                                                                       \r\n /$$$$$$$$ /$$   /$$ /$$$$$$  /$$$$$$         /$$$$$$   /$$$$$$  /$$      /$$ /$$$$$$$$\r\n|__  $$__/| $$  | $$|_  $$_/ /$$__  $$       /$$__  $$ /$$__  $$| $$$    /$$$| $$_____/\r\n   | $$   | $$  | $$  | $$  | $$  \\__/      | $$  \\__/| $$  \\ $$| $$$$  /$$$$| $$      \r\n   | $$   | $$$$$$$$  | $$  |  $$$$$$       | $$ /$$$$| $$$$$$$$| $$ $$/$$ $$| $$$$$   \r\n   | $$   | $$__  $$  | $$   \\____  $$      | $$|_  $$| $$__  $$| $$  $$$| $$| $$__/   \r\n   | $$   | $$  | $$  | $$   /$$  \\ $$      | $$  \\ $$| $$  | $$| $$\\  $ | $$| $$      \r\n   | $$   | $$  | $$ /$$$$$$|  $$$$$$/      |  $$$$$$/| $$  | $$| $$ \\/  | $$| $$$$$$$$\r\n   |__/   |__/  |__/|______/ \\______/        \\______/ |__/  |__/|__/     |__/|________/");
            }
            else if (DrawRaunds == 3 || WonRaunds == LostRaunds) 
            {
                Console.WriteLine($"\n\n /$$$$$$$  /$$$$$$$   /$$$$$$  /$$      /$$  /$$$$        /$$   /$$  /$$$$$$  /$$      /$$  /$$$$ \r\n| $$__  $$| $$__  $$ /$$__  $$| $$  /$ | $$ /$$  $$      | $$  | $$ /$$__  $$| $$  /$ | $$ /$$  $$\r\n| $$  \\ $$| $$  \\ $$| $$  \\ $$| $$ /$$$| $$|__/\\ $$      | $$  | $$| $$  \\ $$| $$ /$$$| $$|__/\\ $$\r\n| $$  | $$| $$$$$$$/| $$$$$$$$| $$/$$ $$ $$    /$$/      | $$$$$$$$| $$  | $$| $$/$$ $$ $$    /$$/\r\n| $$  | $$| $$__  $$| $$__  $$| $$$$_  $$$$   /$$/       | $$__  $$| $$  | $$| $$$$_  $$$$   /$$/ \r\n| $$  | $$| $$  \\ $$| $$  | $$| $$$/ \\  $$$  |__/        | $$  | $$| $$  | $$| $$$/ \\  $$$  |__/  \r\n| $$$$$$$/| $$  | $$| $$  | $$| $$/   \\  $$   /$$        | $$  | $$|  $$$$$$/| $$/   \\  $$   /$$  \r\n|_______/ |__/  |__/|__/  |__/|__/     \\__/  |__/        |__/  |__/ \\______/ |__/     \\__/  |__/  ");
            }

            Console.WriteLine("\n\n" + frame);
            Console.Write("→Бажаєте зiграти ще раз? (Yes|No) \n→");
            string again = Console.ReadLine();
            again = again.ToLower();

            if (again == "yes" || again == "y")
            {
                Console.WriteLine("→Чудово! Отже починаємо! \n\n" + frame);
                Game();
            }
            else 
            {
                Console.WriteLine(frame);
                Console.WriteLine($"→Ну тодi бувайте {nickname} \n" +
                    $"→Ваша статистика:\n\n" +
                    $"→Нiк: {nickname}\r\n" +
                    $"→Вiк: {age}\r\n" +
                    $"→Кiлькiсть зiграних раундiв: {gamePlayed}\r\n" +
                    $"→Кiлькiсть перемог: {scoreWin}");
                Console.WriteLine(frame);
            }

        }

    }
}