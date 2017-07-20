using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawGame.Domain.Model
{
    public class Branch
    {       
        public string BranchName { get; set; }

        public string BranchCode { get; set; }      

    }

    public class BranchGame
    {
        public int GameId { get; set; }

        public string BranchCode { get; set; }


    }
}
