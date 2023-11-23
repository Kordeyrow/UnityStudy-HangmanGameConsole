﻿using CSharpConsoleHangmanGame.DialogueSystem.Interfaces;
using CSharpConsoleHangmanGame.GameStatesSystem.Interfaces;

namespace CSharpConsoleHangmanGame.GameStatesSystem.States
{
    internal class MenuState : IGameState
    {
        readonly IDialogueController dialogueController;
        readonly IDialogueDatabase dialogueDatabase;

        public MenuState(IDialogueController dialogueController, IDialogueDatabase dialogueDatabase)
        {
            this.dialogueController = dialogueController;
            this.dialogueDatabase = dialogueDatabase;
        }

        public void StartGame()
        {
            /*dialogueController.ShowMessage("StartGame()");*/
        }

        public void ExitGame()
        {
            /*dialogueController.ShowMessage("ExitGame()");*/
        }

        public void Enter()
        {
            /*dialogueController.ShowMessage("Enter()");*/
        }

        public void Exit()
        {
            /*dialogueController.ShowMessage("Exiting Menu State.");*/
        }

        public IGameState? Update()
        {
            IGameState? returnState = this;
            dialogueDatabase.MenuDialogueDatabase().AskUserOptionStartGameOrExitGame(
                () => {
                    StartGame();
                    returnState = new InGameState(dialogueController, dialogueDatabase);
                },
                () => {
                    ExitGame();
                    returnState = null;
                }
            );

            return returnState;
        }
    }
}