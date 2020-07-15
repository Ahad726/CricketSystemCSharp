using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystem
{
    public class ScoreCardService
    {
        public void DesplayScore(ScoreCard scoreCard)
        {
            Console.WriteLine($"Commentry : {scoreCard.Commentry} \nRun = {ScoreCard.Run}\nWicket = {ScoreCard.Wicket}");
            Console.WriteLine($"Total Score : {ScoreCard.Run}/{ScoreCard.Wicket} {scoreCard.TotalOver} Overs");
        }
        public string CheckOverStatus()
        {
            if (ScoreCard.Ball == 6)
            {
                ScoreCard.Over++;
                ScoreCard.Ball = 0;
            }
            return  $"{ScoreCard.Over}.{ScoreCard.Ball}";
        }
        public void CheckExtrasGiven(ExtrasEnum extrasEnum)
        {
            if (extrasEnum == ExtrasEnum.NoExtras)
            {
                ScoreCard.Ball++;
            }
            else
            {
                ScoreCard.Run++;
            }
        }
        public void CheckWicket(WicketEnum wicket)
        {
            // If run out or (not no ball and out) then out.
            if ( wicket == WicketEnum.RunOut ||( ScoreCard.IsNoBall == false && wicket != WicketEnum.NotOut))
                ScoreCard.Wicket++;
        }

        public void previousBallCheck(ExtrasEnum extra)
        {
            // if no ball OR previous ball is no ball and now this free hit is wide then IsNoBall true 
            if (extra == ExtrasEnum.NoBall || (ScoreCard.IsNoBall == true && extra == ExtrasEnum.Wide))
                ScoreCard.IsNoBall = true;

            // Otherwise IsNoBall is false 
            else
                ScoreCard.IsNoBall = false;
        }

    }
}
