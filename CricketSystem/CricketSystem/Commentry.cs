using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystem
{
    public class Commentry
    {
        public string CommentryLoad(int run)
        {
            if (run == 6) { return "WOW !!! What a Shot !! It's Maximum And Six"; }
            else if (run == 4) { return "What a boundry !! It's Four , Supeeer Shot !!"; }
            else if (run == 3) { return "Quick 3 Run !! Great running Between the wickets"; }
            else if (run == 2) { return "Good Running , Hurry Up For the double and it does !!"; }
            else if (run == 1) { return "Taken a Single , Good Running"; }
            else if (run == 0) { return "Good Bowling ! no Runs from that ball"; }
            else { return "No Commentry Added !!"; }
        }
        public string CommentryLoad(WicketEnum wicket, ExtrasEnum extras)
        {
            if (wicket == WicketEnum.CatchOut) { return "Plays a shot but Taken !! Whatta Catch !! "; }
            else if (wicket == WicketEnum.BoldOut) { return "Bold ! Stumps Flying Up !!  Whatta Delivery !"; }
            else if (wicket == WicketEnum.RunOut) { return "Running between the Wicket But Run Out !"; }
            else if (wicket == WicketEnum.LBW) { return "Howzat !! Finger Goes Up And he is gone. Out In LBW"; }
            else if (wicket == WicketEnum.Stumping) { return "Down the Ground and Stumps !! Whatta Stumping"; }
            else if (extras == ExtrasEnum.NoBall) { return "Call for NO ball and Free hit !!"; }
            else if (extras == ExtrasEnum.Wide) { return "It's a Wide ! an Extras for Batsman Side"; }
            else { return "No Commentry Added !!"; }
        }
    }
}
