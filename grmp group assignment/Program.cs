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
        class assignment1
        {
            public assignment1(string note, int dist)
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
    }
    }

