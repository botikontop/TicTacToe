char[] board =
{
    '0', '0', '0',
    '0', '0', '0',
    '0', '0', '0',
};

char currentPlayer = 'X';
int playerinput;
bool isValid;

Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
Console.WriteLine($"---+---+---");
Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
Console.WriteLine($"---+---+---");
Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");

while (board.Contains('0'))
{
    Console.WriteLine("Select a number from 1 to 9");
    isValid = int.TryParse(Console.ReadLine()!, out playerinput);

    while (!isValid || playerinput > 9 || playerinput < 1 || board[playerinput - 1] != '0')
    {
        Console.WriteLine("Invalid move. Enter a number from 1 to 9 in a free cell");
        isValid = int.TryParse(Console.ReadLine()!, out playerinput);
    }
    
    board[playerinput - 1] = currentPlayer;
    
    Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
    Console.WriteLine($"---+---+---");
    Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
    Console.WriteLine($"---+---+---");
    Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    
    if (board[0] == currentPlayer &&
        board[1] == currentPlayer &&
        board[2] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[3] == currentPlayer &&
        board[4] == currentPlayer &&
        board[5] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[6] == currentPlayer &&
        board[7] == currentPlayer &&
        board[8] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[0] == currentPlayer &&
        board[3] == currentPlayer &&
        board[6] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[1] == currentPlayer &&
        board[4] == currentPlayer &&
        board[7] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[2] == currentPlayer &&
        board[5] == currentPlayer &&
        board[8] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[0] == currentPlayer &&
        board[4] == currentPlayer &&
        board[8] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    if (board[2] == currentPlayer &&
        board[4] == currentPlayer &&
        board[6] == currentPlayer)
    {
        Console.WriteLine($"{currentPlayer} wins!");
        break;
    }
    
    if (!board.Contains('0'))
    {
        Console.WriteLine("Draw!");
        break;
    }
    
    if (currentPlayer == 'X')
    {
        currentPlayer = 'O';
    }
    else
    {
        currentPlayer = 'X';
    }
}