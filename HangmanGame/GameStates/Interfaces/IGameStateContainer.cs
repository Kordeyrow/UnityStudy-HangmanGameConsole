﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleHangmanGame.GameStates.Interfaces
{
    internal interface IGameStateContainer
    {
        IGameState GameState { get; }
    }
}
