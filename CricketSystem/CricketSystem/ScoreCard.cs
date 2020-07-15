using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystem
{
    public class ScoreCard
    {
        public string Commentry { get; set; }
        public static int Run { get; set; }
        public static int Wicket { get; set; }
        public static int Over { get; set; }
        public static int Ball { get; set; }
        public string TotalOver { get; set; }
        public static bool IsNoBall { get; set; }
    }
}
