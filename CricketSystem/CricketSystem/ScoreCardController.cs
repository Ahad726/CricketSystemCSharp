using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystem
{
    public class ScoreCardController
    {
        private Commentry _comentry;
        private ScoreCard _scoreCard;
        private ScoreCardService _scoreCardService;

        public ScoreCardController()
        {
            _comentry = new Commentry();
            _scoreCard = new ScoreCard();
            _scoreCardService = new ScoreCardService();
        }

        public void CalculateScoreCard(int run)
        {
            _scoreCard.Commentry = _comentry.CommentryLoad(run);
            ScoreCard.Run += run;
            ScoreCard.Ball++;
            _scoreCard.TotalOver = _scoreCardService.CheckOverStatus();
            _scoreCardService.DesplayScore(_scoreCard);

        }
        public void CalculateScoreCard(int run, WicketEnum wicket, ExtrasEnum extra)
        {
            _scoreCard.Commentry = _comentry.CommentryLoad(wicket,extra);
            ScoreCard.Run += run;
            _scoreCardService.CheckExtrasGiven(extra);
            _scoreCardService.CheckWicket(wicket);
            _scoreCardService.previousBallCheck(extra);
            _scoreCard.TotalOver = _scoreCardService.CheckOverStatus();
            _scoreCardService.DesplayScore(_scoreCard);

        }
    }
}
