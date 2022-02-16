using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Randori._6_HanoiRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(5);
            Console.WriteLine("Hello World!");
        }
        
        public static int Hanoi(int disks)
        {
            //https://www.hackerearth.com/blog/developers/tower-hanoi-recursion-game-algorithm-explained/
            // return (int) Math.Pow(2, disks) - 1;;
            var a = new Stack<int>();
            
            for (int i =0 ; i <disks; i++)
            {
                a.Push(i);
            }
            
            var firstRod = new Stack<int>(a);
            var secondRod = new Stack<int>();
            var thirdRod = new Stack<int>();

            while (!thirdRod.Equals(a))
            {
                for (int x = 0; x < firstRod.Count; x++)
                {
                    var i = firstRod.Peek();
                    if (secondRod.TryPeek(out disks) == false || (secondRod.Peek() > i && secondRod.Peek() < thirdRod.Peek()) )
                    {
                        secondRod.Push(firstRod.Pop());
                    }
                    else if (thirdRod.TryPeek(out disks) == false || thirdRod.Peek() > i)
                    {
                        thirdRod.Push(firstRod.Pop());
                    }
                    else
                    {
                        for (int p = 0; p < thirdRod.Count; p++)
                        {
                            var o = thirdRod.Peek();
                            if (secondRod.TryPeek(out disks) == false || secondRod.Peek() > o)
                            {
                                secondRod.Push(thirdRod.Pop());
                            }
                            else if (firstRod.TryPeek(out disks) == false || firstRod.Peek() > o)
                            {
                                firstRod.Push(thirdRod.Pop());
                            }
                            else
                            {
                                for (int z = 0; z < secondRod.Count; z++)
                                {
                                    var y = secondRod.Peek();
                            
                                    if (thirdRod.TryPeek(out disks) == false || thirdRod.Peek() > y)
                                    {
                                        thirdRod.Push(secondRod.Pop());
                                    }
                                    else if (firstRod.TryPeek(out disks) == false || firstRod.Peek() > y)
                                    {
                                        firstRod.Push(secondRod.Pop());
                                    }
                                }
                            }
                        }
                       
                    }
                }
            }

            
            return 0;
        }
    }
}