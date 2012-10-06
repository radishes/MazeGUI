using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Mazes.Algorithms
{
    public class GTBraided : BaseAlgorithm
    {
        bool initialized = false;
        List<Point> visitedCells = new List<Point>();

        public static string name = "GT Braided";
        public static List<string> variants = new List<string>() { "1-A" };

        public GTBraided(Func<Point, bool> PeekFunc, Func<Rect, Boolean> NukeFunc)
            : base(PeekFunc, NukeFunc)
        { // I think this is how to call the base constructor, but check back if not
        }

        public override MazeState Step(MazeData md)
        {
            if (!initialized)
            {
                Point start = md.startCoords;
                if (md.TestCellInMaze(start))
                {
                    NukeFunc(new Rect(md.startCoords, new Point(md.tunnelWidth, md.tunnelWidth)));
                    visitedCells.Add(start);
                    md.tunnelling.Add(start);
                    initialized = true;
                    return new MazeState(1, String.Format("New maze initiated at ({0},{1})", start.X, start.Y));
                }
                else
                {
                    return new MazeState(-1, String.Format("Starting point ({0},{1}) not within maze boundary.", start.X, start.Y));
                }
            } // end initialization block

            if (visitedCells.Count > 0)
            {
                Point p;
                switch (md.variant)
                {
                    case 1: // random cell
                        p = visitedCells[md.rng.Next(0, visitedCells.Count())];
                        break;
                    case 2: // last or random
                        double randomChance = 0.25; // 0.1 = 10% chance to pick a random cell
                        double dice = md.rng.NextDouble();
                        if (dice <= randomChance)
                            p = visitedCells[md.rng.Next(0, visitedCells.Count())];
                        else
                            p = visitedCells.Last();
                        break;
                    case 3: // first cell
                        p = visitedCells.First();
                        break;
                    case 4: // middle cell
                        p = visitedCells[(int)Math.Ceiling((float)(visitedCells.Count / 2))];
                        break;
                    default: // last cell / recursive backtracker
                        p = visitedCells.Last();
                        break;
                }

                md.lastCell = p;


                List<int> rndDirs = new List<int>(new int[] { 0, 1, 2, 3 });
                MazeTools.Shuffle(rndDirs, md.rng);

                foreach (int d in rndDirs)
                {
                    Point p2 = MazeTools.MoveCell(p, md.dirs[d]);
                    if (md.TestCellInMaze(p2) && this.PeekFunc(p2))
                    {
                        Rect rect = md.MakeOffset(p2, d);
                        this.NukeFunc(rect);
                        visitedCells.Add(p2);
                        md.tunnelling.Add(p2);
                        md.lastCell = p2;
                        return new MazeState(4, String.Format("Maze in progress; currently at ({0},{1}).", p2.X, p2.Y));
                    }
                    else
                    {

                        if (d == rndDirs.Last()) // if no directions were tunnel-able
                        {
                            visitedCells.Remove(p); // remove this cell from the list
                            break; // shouldn't matter but just in case
                        }
                    }
                } //end directions foreach loop
                
                return new MazeState(2, String.Format("Maze in progress; currently at ({0},{1}).", p.X, p.Y));
            }
            else
            {
              //  if ()
                {
                    return new MazeState(8, "Maze completed.");
                }
            }



        }
    }
}
