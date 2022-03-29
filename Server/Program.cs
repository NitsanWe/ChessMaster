﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Ai.Minmax(new Board(), 1, true, true);
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000.0);
        Console.WriteLine(Ai.count);
    }

    /*public static int MinMax(Branch b, int depth)
    {
        if (depth == 0 || Branch.IsEmptyList(b.next))
            return Chess.Score(b.board);
        if (b.isMax)
        {
            int value = int.MinValue;6
            foreach (Branch child in b.next)
            {
                Console.WriteLine(MinMax(child, depth - 1));
                value = Math.Max(value, MinMax(child, depth - 1));
            }
            return value;
        }
        else
        {
            int value = int.MaxValue;
            foreach (Branch child in b.next)
                value = Math.Min(value, MinMax(child, depth - 1));
            return value;
        }
    }

    public static void OldMain()
    {
        Branch mainBranch = new Branch("123");

        Console.WriteLine(mainBranch);
        Console.WriteLine(MinMax(mainBranch, 1));
    }*/

    /*public static void NewMain()
    {
        Board board = new Board();
        Console.WriteLine(board.GetFen());

        foreach (Board b in board.GetNextGen())
        {
            Console.WriteLine(b.GetFen());
        }
    }*/


}
