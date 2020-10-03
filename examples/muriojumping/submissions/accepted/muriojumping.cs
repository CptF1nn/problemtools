using System;

namespace muriojumping
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split( ' ' ,StringSplitOptions.None);
            int r = int.Parse(s[0]), c = int.Parse(s[1]), h = int.Parse(s[2]), f = int.Parse(s[3]);
            int curHeight = 0;
            bool done = false;
            for (int x = 0; x < r; x++)
            {
                char[] ch = Console.ReadLine().ToCharArray();
                for (int y = 0; y < c; y++)
                {
                    if (ch[y] == '.'){
                        if (y >= curHeight)
                        { 
                            if (curHeight + h >= y){
                                curHeight = y;
                                y = c;
                                break;
                            } else
                            {
                                Console.WriteLine(x+1);
                                done = true;
                                break;
                            }
                        } else{
                            if (curHeight - f >= y){
                                curHeight = y;
                                y = c;
                                break;
                            } else
                            {
                                Console.WriteLine(x+1);
                                done = true;
                                break;
                            }
                        }
                    }
                }
                if (done)
                    break;
            }
            if (!done)
                Console.WriteLine("Wahoo!");
        }
    }
}
