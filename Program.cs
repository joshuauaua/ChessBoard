using System;
using System.Linq;

// Initialize a game loop
bool play = true;
while (play)
{
 
//Gather boardSize information from user
 Console.WriteLine("How large of a board shall we create (enter a number) :");
 string size = Console.ReadLine();
 int sizeInt = Int32.Parse(size);

//Gather input for squares & piece
 Console.WriteLine("What character would you like to use for the black square?");
 string blackSquare = Console.ReadLine();
 Console.WriteLine("What character would you like to use for the white square?");
 string whiteSquare = Console.ReadLine();
 Console.WriteLine("What character would you like to use for the chess piece?");
 string chessPiece = Console.ReadLine();

//Gather input for piece location, save in array
 Console.WriteLine("Where should we place the piece? Enter in format (A1)");
 string piece = Console.ReadLine();
 char[] pieceArray = new char[2];

//Init an array of alphabets 
 char[] alphabet =
 {
  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
  'X', 'Y', 'Z'
 };

//Turn char into int 
 char position1 = pieceArray[0];
 int index = (Array.IndexOf(alphabet, position1)) + 1;
 int index1 = Convert.ToInt32(pieceArray[1]);

 Console.WriteLine(index);
 Console.WriteLine(index1);

 int[,] pieceLocation = new int[index, index1];

//Create a 2D array with rows and columns the size of boardSize
 int[,] boardSize = new int[sizeInt, sizeInt];

//Assigning a Row and Column size through nested forloop
 for (int i = 0; i < sizeInt; i++)
 {
  for (int j = 0; j < sizeInt; j++)
  {
   boardSize[i, j] = i + j;
  }
 }

//Printing squares using modulo (if even black, if odd white), if piece square, piece through nested for loop

 for (int i = 0; i < sizeInt; i++)
 {
  for (int j = 0; j < sizeInt; j++)
  {
   if (i == index && j == index1)
   {
    Console.Write("P");
   }
   else if (boardSize[i, j] % 2 == 0)
   {
    Console.Write("B");
   }
   else if (boardSize[i, j] % 2 != 0)
   {
    Console.Write("W");
   }
  }

  Console.WriteLine("");
 }

//Try again (?)
 Console.WriteLine("Go again? Answer Y/N");
 string response = Console.ReadLine();
 if (response.ToUpper() == "N")
 {
  play = false;
 }

}
