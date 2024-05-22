using System;
class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 2;
    static int choice;
    static void Main()
    {

        bool isGameOver = false;
        do
        {
            Console.Clear();
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);

            if (board[0] == board[1] && board[1] == board[2] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8] ||
                board[0] == board[3] && board[3] == board[6] ||
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[0] == board[4] && board[4] == board[8] ||
                board[2] == board[4] && board[4] == board[6])
            {
                Console.WriteLine($"Игрок {player} победил!");
                isGameOver = true;
            }
            else if (board.All(c => c == 'X' || c == 'O'))
            {
                Console.WriteLine("Ничья!");
                isGameOver = true;
            }
            if (isGameOver)
            {
                Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
                Console.ReadKey();
                break;
            }
            if (player == 2)
                player = 1;
            else 
                player = 2;
            Console.WriteLine($"Игрок, {player} выберите ячейку: ");
            choice = int.Parse(Console.ReadLine());
            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                if (player == 1)
                    board[choice - 1] = 'X';
                else
                    board[choice - 1] = 'O';
            }
            else
            {
                Console.WriteLine("Ячейка уже занята. Выберите другую.");
                Console.ReadKey();
            }
        } while (!isGameOver);
    }
}