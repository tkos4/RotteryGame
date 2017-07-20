using System.Collections.Generic;
using DrawGame.Domain.Model.Core;

namespace DrawGame.Domain.Model.Game
{
    public interface IWheelGame : IGame
    {
        List<WizDrawGameItem> GameItems { get; }
    }
}