Console.WriteLine("Type your message here");
string userInput = Console.ReadLine();

string encryptedMessage = Encrypter.Encrypt.Encipher(userInput);
string decryptedMessage = Encrypter.Encrypt.Decipher(encryptedMessage);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nEncrypted text: \n" + encryptedMessage);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nDecrypted text: \n" + decryptedMessage);

Console.ForegroundColor= ConsoleColor.White;
Console.ReadKey();