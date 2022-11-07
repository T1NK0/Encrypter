List<string> alphabet = new List<string> {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø", "Å"};

string userInput = Console.ReadLine();
List<string> originalInput = new List<string>();

for (int i = 0; i < userInput.Length; i++)
{
    originalInput.Add(userInput[i].ToString().ToUpper());
}

List<string> encrypt = new List<string>();
for (int i = 0; i < originalInput.Count; i++)
{
    int getOriginalInputCharPosition = alphabet.IndexOf(originalInput[i]);

    if (getOriginalInputCharPosition != alphabet.Count);
    {
        int getNewInputCharPosition = alphabet + 1;
    }

    Console.WriteLine(getOriginalInputCharPosition);
}