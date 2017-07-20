using System;
using DrawGame.Domain.Model;
using DrawGame.Domain.Model.Game;

namespace DrawGame.Domain.Game
{
    public class Draw
    {

        public string OrderLineId { get; set; }

        public int BranchId { get; set; }

        public DateTime WheelDrawDateTime { get; set; }

        public bool Wins { get; set; }

        public string ProductCode { get; set; }

        public int OrderLineQuantityIndex { get; set; }

        public GameType GameType { get; set; }

        public int GameId { get; set; }



    }
}
