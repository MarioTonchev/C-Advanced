Queue<int> tools = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> substances = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
List<int> challenges = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (tools.Any() && substances.Any())
{
    int product = tools.Peek() * substances.Peek();

	if (challenges.Contains(product))
	{
		tools.Dequeue();
		substances.Pop();
		challenges.Remove(product);
	}
	else
	{
		tools.Enqueue(tools.Dequeue() + 1);
		int elementToDecrease = substances.Pop() - 1;
		if (elementToDecrease > 0)
		{
			substances.Push(elementToDecrease);
		}
	}
}

if (challenges.Any())
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}
if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}