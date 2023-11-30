﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleHangmanGame.Dialogue.Interfaces
{
    internal interface IDialogueOptionData
    {
        string Text { get; }
        Action Action { get; }
    }
}