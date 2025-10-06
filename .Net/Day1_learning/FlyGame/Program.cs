public enum mapPoint { 
    block,
    boom,
    timepass,
    timestop,
    luckroll
}

class Program {
     static int maxLength = 100;
     static int[] map = new int[maxLength];
     static int[] playpos = new int[2];
    static string player1 = "";
    static string player2 = "";
    static bool[] flags = new bool[2];
    static void Main(String[] args) {
        loadTitle();
        string level = null;
        Console.WriteLine("Please enter hard level you want try");
        level = Console.ReadLine();
        Console.WriteLine("");

        getUserInfo();
        // after user input then clean the screen 
        Console.Clear();
        loadTitle();
        Console.WriteLine("{0} player shows by A", player1);
        Console.WriteLine("{0} player shows by B", player2);

        initMap(level);
        DrawMap();

        playLogic();

        Console.ReadKey();

    }

    private static void playLogic() {
        //停止条件
        
        while (playpos[0] < 99 && playpos[1] < 99) {
            if (flags[0] == false)
            {
                playGame(0);
            }
            else { 
                flags[0] = false;
            }
            if (flags[1] == false)
            {
                playGame(1);
            }
            else {
                flags[1] = false;
            }
            
            
        }

        Console.ReadKey();

    }

    public static void playGame(int playerID) {
        string player = "";
        string watcher = "";
        if (playerID == 0)
        {
            player = player1;
            watcher = player2;
        }
        else { 
            player = player2;
            watcher = player1;
        }

        Console.WriteLine("{0} start tose the dise", player);
        Console.ReadKey(true);
        Random r = new Random();
        int n = r.Next(1, 7);
        Console.WriteLine("{0} have showed a {1}", player, n);
        playpos[playerID] += n;
        Console.ReadKey(true);
        Console.WriteLine("{0} pres any key to move", player);
        Console.ReadKey(true);
        Console.WriteLine("{0} is now finished", player);
        Console.ReadKey(true);

        if (playpos[playerID] == playpos[1 - playerID])
        {
            Console.WriteLine("Player{0} hit on Player {1}. So Player{2} return 6 block", player, watcher, watcher);
            playpos[1 - playerID] -= 6;
            Console.ReadKey(true);
        }
        else
        {

            int blockId = map[playpos[playerID]];
            switch (blockId)
            {
                case 0:
                    Console.WriteLine("Nothing happen, Player {0} is on a block", player);
                    Console.ReadKey(true);
                    break;
                case 1:
                    Console.WriteLine("Player {0} is on a boom, return 4 block", player);
                    playpos[playerID] -= 4;
       
                    Console.ReadKey(true);
                    break;
                case 2:
                    Console.WriteLine("Player {0} is on a TimePass, Move 10 block", player);
                    playpos[playerID] += 10;
                    Console.ReadKey(true);
                    break;
                case 3:
                    Console.WriteLine("Player {0} is on a LuckRoll, Choose 1: switch with other player. 2 boom other player", player);
                    string ans = Console.ReadLine();
                    while (true)
                    {
                        if (ans == "1")
                        {
                            Console.WriteLine("Player{0} switch with Player {1}", player, watcher);
                            Console.ReadKey(true);
                            int temp = playpos[playerID];
                            playpos[playerID] = playpos[1 - playerID];
                            playpos[1 - playerID] = temp;
                            Console.WriteLine("Switch finished!!");
                            Console.ReadKey(true);
                            break;
                        }
                        else if (ans == "2")
                        {
                            Console.WriteLine("Player {0} boomming Player {1}", player, watcher);
                            Console.ReadKey(true);
                            playpos[1 - playerID] -= 4;
                            Console.ReadKey(true);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Plese Enter 1 or 2");
                            ans = Console.ReadLine();
                        }

                    }
                    Console.ReadKey(true);
                    break;
                case 4:
                    Console.WriteLine("Player{0} stop for 1 round", player);
                    flags[playerID] = true;
                    Console.ReadKey(true);


                    break;

            }
        }

        Console.Clear();
        changePos();
        DrawMap();
    }

    private static void changePos() {
        if (playpos[0] < 0) { 
            playpos[0] = 0;
        }
        if (playpos[0] > 99) {
            playpos[0] = 99;
        }
        if (playpos[1] < 0)
        {
            playpos[1] = 0;
        }
        if (playpos[1] > 99)
        {
            playpos[1] = 99;
        }
    }

    private static void getUserInfo()
    {
        Console.WriteLine("Please Enter Player 1 name");
        player1 = Console.ReadLine();
        bool pass1 = false;
        while (!pass1) {
            if (player1 == null || player1 == "")
            {
                Console.WriteLine("Please Re-Enter Player 1 name, The name should not be empty");
                player1 = Console.ReadLine();
            }
            else { 
                pass1 = true;
            }
        }


        bool pass2 = false;
        Console.WriteLine("Please Enter Player 2 name");
        player2 = Console.ReadLine();
        while (!pass2)
        {
            if (player2 == null || player2 == "")
            {
                Console.WriteLine("Please Re-Enter Player 2 name, The name should not be empty");
                player2 = Console.ReadLine();
            }
            else if (player2 == player1)
            {
                Console.WriteLine("Please Re-Enter Player 2 name, The name should different than Player 1");
                player2 = Console.ReadLine();
            }
            else
            {
                pass2 = true;
            }
        }
    }

    public static void loadTitle() {
        //Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("**********************************************");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**********************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("**********************************************");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("*********** test fly game show ***************");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("**********************************************");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("**********************************************");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("**********************************************");
    }

    public static void initMap(string level)
    {
        int boom, timepass, luckroll, timestop;
        switch (level.ToLower())
        {
            case "hard":
                boom = 25; timepass = 3; luckroll = 3; timestop = 15;
                break;
            case "mid":
                boom = 15; timepass = 6; luckroll = 6; timestop = 10;
                break;
            default:
                boom = 10; timepass = 10; luckroll = 10; timestop = 5;
                break;
        }

        Random r = new Random();

        var boomBlock = PlaceBlocks(boom, 1, r, map);
        var timepassBlock = PlaceBlocks(timepass, 2, r, map);
        var luckrollBlock = PlaceBlocks(luckroll, 3, r, map);
        var timestopBlock = PlaceBlocks(timestop, 4, r, map);



    }

    public static int[]  PlaceBlocks(int count, int value, Random r, int[] map)
    {
        int[] blockPositions = new int[count];

        for (int i = 0; i < count; i++) {
            int pos = r.Next(0, map.Length);
            while (map[pos] != 0) { 
                pos = r.Next(0, map.Length);
            }
            map[pos] = value;
            blockPositions[i] = pos;
        }

        return blockPositions;
    }

    private static void DrawMap() {
        DrawMapTop();


        //第一横行
        for (int i = 0; i < 30; i++) {
            Console.Write(DrawLine(i));
        }
        Console.WriteLine();

        //第一竖行
        for (int i = 30; i < 35; i++) {
            for (int j = 0; j <= 28; j++) { 
                Console.Write("  ");
            }
            Console.Write(DrawLine(i));
            Console.WriteLine();
        }

        // 第二横行
        for (int i = 64; i >= 35; i--) { 
            Console.Write(DrawLine(i));
        }
        Console.WriteLine();

        //第二竖行
        for (int i = 65; i <= 69; i++) {
            Console.WriteLine(DrawLine(i));
        }
        Console.WriteLine();

        //第三横行
        for (int i = 70; i <= 99; i++)
        {
            Console.Write(DrawLine(i));
        }
        Console.WriteLine();

    }

    private static void DrawMapTop() { 
        Console.WriteLine("Icon is: Boom:＊ ; TimePass:@ ; LuckRoll:^ ; TimeStop:※    ");
    }

    private static string DrawLine(int i) {
        string str = "";
        if (playpos[0] == playpos[1] && playpos[1] == i)
        {
            str = "<>";
        }
        else if (playpos[0] == i)
        {
            str = "A";
        }
        else if (playpos[1] == i)
        {
            str = "B";
        }
        else
        {
            switch (map[i])
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    str = "[]";
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    str = "＊";
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    str = "@";
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    str = "^";
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    str = "※";
                    break;

            }
        }

        return str;
    }
}