void PrintMessage(string message) => Console.WriteLine(message);
void PrintMessageInUpperCase(string message) => Console.WriteLine(message.ToUpper());
void PrintMessageInReverse(string message)
{
    char[] chars = message.Reverse().ToArray();
    String newStr = new String(chars);
    Console.WriteLine(newStr);
}

Print print = PrintMessage;
print += PrintMessageInUpperCase;
print += PrintMessageInReverse;

print("Salam");

delegate void Print(string str);