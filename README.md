# MobileKeyPad

This is a C# program that converts a string of numbers and asterisks into the corresponding text on an old phone pad. The program defines an array of strings to represent the letters associated with each number key on an old phone pad. Then, the input string is converted into an array of characters.

The program ignores spaces and stops processing the string if it encounters a pound sign (#). Backspace functionality is handled by counting the number of asterisks in a row and either clearing the output string or removing the last n characters from the output string.

The program counts the number of times a key is pressed in a row and determines which key was pressed and which letter(s) it corresponds to. It also handles the maximum number of letters for each key.

Finally, the output string is printed.

#Usage 

The program contains a Main method that can be used to call the OldPhonePad method with a sample string of numbers and asterisks.

public static void Main(string[] args)
{
    string str = "44883336**6647778777**999#";
    OldPhonePad(str);
}


To use the program with a different input string, simply change the value of the str variable.
