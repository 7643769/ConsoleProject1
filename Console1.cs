using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject1
{
    internal class Console1
    {
        static void Main(string[] args)
        {
            //改背景颜色
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //改变字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = true;

            //移动
            int x = 0, y = 0;
            Console.Write("□");

            while (true)
            {
                Console.SetCursorPosition(x, y);

                char c = Console.ReadKey(true).KeyChar;
                //第一种清除
                Console.Clear();
                //第二种清除
                //Console.Write("    ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        y--;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.Write("□");
                        break;
                    case 'S':
                    case 's':


                        y++;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }

                        Console.SetCursorPosition(x, y);
                        Console.Write("□");
                        break;
                    case 'A':
                    case 'a':
                        x -= 2;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.Write("□");
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.Write("□");
                        break;
                }
            }


        }
    }
}
