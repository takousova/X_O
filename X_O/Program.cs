// See https://aka.ms/new-console-template for more information

    // Static Section


string[,] firstMtrx = new string[3, 3];
int k = 1;
int togle = 2;
string player = "Player 1 : X";
string xo = "X";
bool winChek = false;

Console.WriteLine("Player 1 : X");
Console.WriteLine("Player 2 : O");
Console.WriteLine("\t");


// Matrix Input
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        firstMtrx[i, j] = Convert.ToString(k);
        k++;
    };

}


    // Loop Section

while (winChek == false)
{

 
    Console.WriteLine("\t");
    Console.WriteLine(player);

    // Print Matrixt 
    for (int i = 0; i < firstMtrx.GetLength(0); i++)
    {
        for (int j = 0; j < firstMtrx.GetLength(1); j++)
        {
            Console.Write(firstMtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }


    Console.WriteLine("To Make a move enter number from matrix:");
    Console.WriteLine("\t");
    int intTemp = Convert.ToInt32(Console.ReadLine());
    Console.Write("You Entered X on psositon: ");
    Console.WriteLine(intTemp);


    for (int x = 0; x < 3; ++x)
    {
        for (int y = 0; y < 3; ++y)
        {
            if (firstMtrx[x, y].Equals(Convert.ToString(intTemp)))
            {
                Console.WriteLine("OK");
                firstMtrx[x, y] = xo;
            };
        }
    };


    // Win Chek
    if (
    (firstMtrx[0, 0].Equals(firstMtrx[0, 1]) & firstMtrx[0, 1].Equals(firstMtrx[0, 2]))
    ||
    (firstMtrx[1, 0].Equals(firstMtrx[1, 1]) & firstMtrx[1, 1].Equals(firstMtrx[1, 2]))
    ||
    (firstMtrx[2, 0].Equals(firstMtrx[2, 1]) & firstMtrx[2, 1].Equals(firstMtrx[2, 2]))
    ||
    (firstMtrx[0, 0].Equals(firstMtrx[2, 1]) & firstMtrx[2, 1].Equals(firstMtrx[2, 2]))
    ||
    (firstMtrx[0, 0].Equals(firstMtrx[1, 0]) & firstMtrx[1, 0].Equals(firstMtrx[2, 0]))
    ||
    (firstMtrx[1, 0].Equals(firstMtrx[1, 1]) & firstMtrx[1, 0].Equals(firstMtrx[2, 1]))
    ||
    (firstMtrx[2, 0].Equals(firstMtrx[2, 1]) & firstMtrx[2, 1].Equals(firstMtrx[2, 2]))
    ||
    (firstMtrx[0, 0].Equals(firstMtrx[1, 1]) & firstMtrx[1, 1].Equals(firstMtrx[2, 2]))
    ||
    (firstMtrx[2, 0].Equals(firstMtrx[1, 1]) & firstMtrx[1, 1].Equals(firstMtrx[0, 2]))

    )
    {
        Console.Clear();
        Console.WriteLine("Player");
        Console.Write(xo);
        Console.WriteLine(" Wins!");
        break;
    };


    if (togle % 2 == 0) { xo = "O"; player = "Player(O)  Please enter number: "; }
    else { xo = "X"; player = "Player(X)  Please enter number: "; };

        togle++;
    

    Console.Write("Togle: ");
    Console.WriteLine(togle % 2); 
    Console.WriteLine(winChek);
    Console.Clear();



};