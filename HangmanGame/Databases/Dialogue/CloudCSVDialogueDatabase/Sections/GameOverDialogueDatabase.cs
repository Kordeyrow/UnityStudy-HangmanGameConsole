﻿using CSharpConsoleHangmanGame.Databases.Dialogue.Interfaces;
using CSharpConsoleHangmanGame.GameSystems.Dialogue.Interfaces.DialogueUnitKeys;

namespace CSharpConsoleHangmanGame.Databases.Dialogue.CloudCSVDialogueDatabase.Sections
{
    internal class GameOverDialogueDatabase : IGameOverDialogueDatabase
    {
        readonly IGameOverDialogueUnitKeys gameOverDialogueUnitKeys;
        readonly Section section;

        internal GameOverDialogueDatabase(
            IGameOverDialogueUnitKeys gameOverDialogueUnitKeys,
            Section section)
        {
            this.gameOverDialogueUnitKeys = gameOverDialogueUnitKeys;
            this.section = section;
        }

        public string WinMessage => section.GetText(gameOverDialogueUnitKeys.WinMessage);
        public string LoseMessage => section.GetText(gameOverDialogueUnitKeys.LoseMessage);
        public string EndChoiceQuestion => section.GetText(gameOverDialogueUnitKeys.EndChoiceQuestion);
        public string EndChoicePlayAgainOption => section.GetText(gameOverDialogueUnitKeys.EndChoicePlayAgainOption);
        public string EndChoiceExitToMenuOption => section.GetText(gameOverDialogueUnitKeys.EndChoiceExitToMenuOption);
    }
}
