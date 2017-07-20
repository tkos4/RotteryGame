using System.Collections.Generic;
using System.ComponentModel;
using DrawGame.Domain.Model.Game;

namespace DrawGame.Domain.Game
{
    public interface IGameRepository
    {
       
        WizDrawGame GetWizDrawGameById2(int id);


        List<WizDrawGameInfo> GetAllWizDrawGameInfo();





    }
}
