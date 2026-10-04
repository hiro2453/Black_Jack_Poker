namespace BJ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //バージョン表記のルールは https://semver.org/lang/ja/ を参考
            ApplicationConfiguration.Initialize();
            Console.WriteLine("Copyright (c) Hiroto Nagamizo. All rights reserved.");
            Console.WriteLine("当ソフトウェアの著作権は制作者に帰属します。");
            Console.WriteLine("事前の許諾なく、プログラムの複製、解析、改変、再配布を行うことを固く禁じます。");
            Console.WriteLine("Ver.0.1.0");
            /*
            Console.WriteLine("==================");
            Console.WriteLine("どこからデバックしますか？");
            Console.WriteLine("1.タイトル画面から");
            Console.WriteLine("2.チップ確定画面から");
            Console.WriteLine("3.ゲーム画面から（チップは100固定）");
            string? Num= Console.ReadLine();
            switch (Num)
            {
                case "1": Application.Run(new Title());break;
                case "2": Application.Run(new Chip()); break;
                case "3": int a = 100; Application.Run(new Game(a)); break;
                default:
                    Console.WriteLine("提示した選択肢内に含まれていない為、タイトルから開始します。");
                    Application.Run(new Title()); break;
            }*/
            int a = 100;
            Application.Run(new Game(a));

        }
    }
}