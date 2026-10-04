namespace ConsoleProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关");
            Console.WriteLine("123123");
            //string str = Console.ReadLine();
            //char c = Console.ReadKey(true).KeyChar;
            //控制台其他方法
            //Console.Clear();
            //Console.SetWindowSize(100, 30);
            //Console.SetBufferSize(1000, 1000);
            Console.SetCursorPosition(10, 10);//y=2x
            Console.WriteLine("测试光标位置");
            //文字颜色
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("红色字体");
            //背景颜色
            Console.BackgroundColor = ConsoleColor.Black;
            //重置背景颜色过后，需要clear一次，才能把整个背景颜色改变
            //Console.Clear();
            //光标显隐
            Console.CursorVisible = false;
            //关闭控制台
            Environment.Exit(0);
        }
    }
}
