string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

string newsentence = string.Empty;

for (int i = 0; i < words.Length; i++)
{
	for (int j = words[i].Length-1; j >= 0; j--)
	{
		newsentence += words[i][j];
	}
	newsentence += ' ';
}

Console.Write(newsentence);