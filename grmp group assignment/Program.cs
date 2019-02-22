using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grmp_group_assignment
{
    class Program
    {
        static void Main(string[] args)
        { }

    }
}
class assignment
{
    public assignment(string note, int dist)
    {
        villageName = note; distanceTraveled = dist;
        HowFarToGetBack = distanceTraveled;
    }
    public int HowFarToGetBack = 0;
    private string villageName;
    private int distanceTraveled;
    public int getDistanceWalked() { return distanceTraveled; }
    public string getVillageName() { return villageName; }
}

class Hugi
{
    private static assignment je;
    public static bool FoundAstrilde = false;

    public static List<assignment> HugiJournal = new List<assignment>();

    public static int CalculateDistanceWalked()
    {
        int DistanceWalked = 0;
        // walk over the List and add the distances
        foreach (var je in HugiJournal)
        {
            Console.WriteLine(" {0}  --   {1} *** --- {2} ", je.getDistanceWalked(), je.getVillageName(), je.HowFarToGetBack);
            DistanceWalked += je.getDistanceWalked() + je.HowFarToGetBack;
        }
        return DistanceWalked;
    }
}
