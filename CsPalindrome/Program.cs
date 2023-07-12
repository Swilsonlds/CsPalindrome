// See https://aka.ms/new-console-template for more information
bool keepGoing = true;

Console.WriteLine("This application will determine whether or not the string received from the user is a palindrome.");
Console.WriteLine(" ");

do{
    Console.Write("Please enter a word: ");
    string word = Console.ReadLine().ToUpper();

    if (IsPalindrome(word)){
        Console.WriteLine($"{word} is a palindrome.");
    }

    else {
        Console.WriteLine($"{word} is not a palindrome.");
    }

    Console.Write("Would you like to test another String (Y/N)? ");
    string decisionToKeepGoing = Console.ReadLine();
    Console.WriteLine(" ");

    if (decisionToKeepGoing.ToUpper() == "Y") {
        keepGoing = true;
    }

    else if (decisionToKeepGoing.ToUpper() == "N") {
        keepGoing = false;
    }

} while (keepGoing);

bool IsPalindrome(string word){

    string wordWithoutBlanks = "";

    foreach (char i in word) {
        if (!Char.IsWhiteSpace(i) && !Char.IsPunctuation(i)) {
            wordWithoutBlanks += i;
        }

        else {
            continue;
        }
    }

    char[] stringArray = wordWithoutBlanks.ToCharArray();
    Array.Reverse(stringArray);
    string reversedString = new string(stringArray);

    return (wordWithoutBlanks == reversedString);
}


