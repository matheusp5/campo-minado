
using CampoMinado.Helper;
using CampoMinado.Helpers;
using CampoMinado.Models;


Screen.Home();

Console.Write(" Qual vai ser a largura do campo? -> ");
int width = int.Parse(Console.ReadLine());

Console.Write(" Qual vai ser a altura do campo? -> ");
int height = int.Parse(Console.ReadLine());

Game game = new Game(width, height);
while (true)
{
    if(game.IsWinner())
    {
        Screen.Win(game.StartedTime);
        break;
    }
    Console.Clear();
    Console.WriteLine();
    Renderer.ShowGame(game);
    Console.WriteLine();
    Console.Write(" Qual será sua jogada? (responda com x.y) -> ");
    string[] play = Console.ReadLine().Split(".");

    int x = int.Parse(play[0]);
    int y = int.Parse(play[1]);
    Console.WriteLine();
    Console.Write("1 - Dedução. 2 - Bandeira -> ");
    int choose = int.Parse(Console.ReadLine());
    
    if(choose == 1)
    {
        if (game.IsBomb(x, y))
        {
            Screen.Finish(game.StartedTime);
            break;
        }
        else
        {
            game.SetPoint(x, y);
        }
    } else
    {
        game.SetFlag(x, y);
    }

}


