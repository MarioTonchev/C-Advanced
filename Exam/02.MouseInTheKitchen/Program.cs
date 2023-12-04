int[] dimensions = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

int n = dimensions[0];
int m = dimensions[1];

string[,] matrix = new string[n, m];

int row = 0;
int col = 0;
int cheeseToEat = 0;

for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		matrix[i, j] = input[j].ToString();
		if (matrix[i, j] == "M")
		{
			row = i;
			col = j;
			matrix[i, j] = "*";
		}
		if (matrix[i,j] == "C")
		{
			cheeseToEat++;
		}
	}
}


string command;

while ((command = Console.ReadLine()) != "danger")
{
	if (isOut())
	{
        Console.WriteLine("No more cheese for tonight!");
		Print();
		return;
    }

	Move();

	if (cheeseToEat == 0)
	{
        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
		Print();
		return;
    }
	if (matrix[row, col] == "T")
	{
        Console.WriteLine("Mouse is trapped!");
		Print();
		return;
    }
}

Console.WriteLine("Mouse will come back later!");
Print();


void Move()
{
    if (command == "up")
    {
		row -= 1;
		if (matrix[row, col] == "@")
		{
			row += 1;
		}
		else if (matrix[row, col] == "C")
		{
			matrix[row, col] = "*";
			cheeseToEat--;
		}
    }
    else if (command == "down")
    {
		row += 1;
		if (matrix[row, col] == "@")
		{
			row -= 1;
		}
		else if (matrix[row, col] == "C")
		{
            matrix[row, col] = "*";
            cheeseToEat--;
		}
    }
    else if (command == "left")
    {
		col -= 1;
        if (matrix[row, col] == "@")
        {
            col += 1;
        }
        else if (matrix[row, col] == "C")
        {
            matrix[row, col] = "*";
            cheeseToEat--;
        }
    }
    else if (command == "right")
    {
		col += 1;
        if (matrix[row, col] == "@")
        {
            col -= 1;
        }
        else if (matrix[row, col] == "C")
        {
            matrix[row, col] = "*";
            cheeseToEat--;
        }
    }
}

bool isOut()
{
	if (command == "up" && row - 1 < 0)
	{
		return true;
	}
	else if (command == "down" && row + 1 > n - 1)
	{
		return true;
	}
	else if (command == "left" && col - 1 < 0)
	{
		return true;
	}
	else if (command == "right" && col + 1 > n - 1)
	{
		return true;
	}
	return false;
}

void Print()
{
	matrix[row, col] = "M";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			Console.Write(matrix[i,j]);
        }
        Console.WriteLine();
    }
}