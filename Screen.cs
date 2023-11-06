
namespace DataEntryConsole
{
    public static class Screen
    {
        public static void DisplayMenu()
        {
            var holdbckcolor = Console.BackgroundColor;
            var holdfgcolor = Console.ForegroundColor;
            
            var centerCount = (Console.WindowWidth-40)/2;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;;
            Console.WriteLine("  v - View Bar Code Transactions".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  L - Show Inventor List".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  C - Delete All Transactions".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("  W - Write Transactions to Database".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  U - Look up Inventoy Item".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  X - Exit".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
            Console.Write(" ".PadLeft(centerCount));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ".PadRight(40));
            Console.BackgroundColor = holdbckcolor;
            Console.ForegroundColor = holdfgcolor;
        }
        public static void DisplayBanner(string ip,string port)
        {
            var holdbckcolor=Console.BackgroundColor;
            var holdfgcolor=Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for(int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            var txt = "Configuration              IpAddress:" + ip.PadRight(15) + "       Port:" + port.PadRight(5);
            var centerCount = (Console.WindowWidth-txt.Length)/2;
            Console.Write( "*".PadRight(centerCount));
            Console.Write(txt);
            Console.Write("*".PadLeft(centerCount+1));
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            Console.BackgroundColor=holdbckcolor;
            Console.ForegroundColor=holdfgcolor;
        }
        //goes through the entire loaded Inventor table and 
        //displays the code, id, and description 
        public static void ShowInventory(Inventor inv)
        {
            Console.Write(inv.Code+"  |  ");
            Console.Write(inv.InventorId + "  |  ");
            Console.WriteLine(inv.Description);
        }
        public static void ShowBarCodeTrans(BarCodeTrans trans)
        {
            Console.WriteLine(trans.EffDate);
        }

    }
}
