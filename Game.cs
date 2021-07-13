using System;

namespace C_RPC
{
  class Game
  {
    private int _computerChoice = 0;
    private int _playerChoice = 0;
    private bool _playing = true;
    public void Start()
    {
      var r = new Random();
      _computerChoice = r.Next(1, 4);

      Console.WriteLine("pick: Rock, Paper or Scissors");
      PlayGame();
    }

    public void PlayGame()
    {
      while (_playing)
      {
        var userInput = Console.ReadLine();
        if (userInput == "q")
        {
          _playing = false;
          Console.WriteLine("goodbye");
          return;
        }
        if (userInput == "Rock")
        {
          _playerChoice = 1;
        }
        if (userInput == "Paper")
        {
          _playerChoice = 2;
        }
        if (userInput == "Scissors")
        {
          _playerChoice = 3;
        }
        switch (_computerChoice)
        {
          case 1:
            if (_playerChoice == 1)
            {
              Console.WriteLine("Computer chooses Rock, its a tie");
            }
            else if (_playerChoice == 2)
            {
              Console.WriteLine("Computer chooses Rock, you win");
            }
            else if (_playerChoice == 3)
            {
              Console.WriteLine("Computer chooses Rock, You lose");
            }
            break;
          case 2:
            if (_playerChoice == 1)
            {
              Console.WriteLine("Computer chooses Paper, you lose");
            }
            else if (_playerChoice == 2)
            {
              Console.WriteLine("Computer chooses Paper, its a tie");
            }
            else if (_playerChoice == 3)
            {
              Console.WriteLine("Computer chooses Paper, You win");
            }
            break;
          case 3:
            if (_playerChoice == 1)
            {
              Console.WriteLine("Computer chooses Scissors, you win");
            }
            else if (_playerChoice == 2)
            {
              Console.WriteLine("Computer chooses Scissors, you lose");
            }
            else if (_playerChoice == 3)
            {
              Console.WriteLine("Computer chooses Scissors, its a tie");

            }
            break;
        }
        Console.WriteLine("Want to Play again?? ...... Y or N ");
        var playAgain = Console.ReadLine().ToUpper();
        if (playAgain == "N")
        {
          _playing = false;
          Console.WriteLine("Thanks for Playing!!! Goodbye.");
          return;
        }
        if (playAgain == "Y")
        {
          Console.Clear();
          Start();
        }
      }
    }
  }
}