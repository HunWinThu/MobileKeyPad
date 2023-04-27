using System;
using System.Text;

class Program
{
    // Function to convert a string of numbers and asterisks
    // into the corresponding text on an old phone pad
    public static void OldPhonePad(string S)
    {
        // Define an array of strings to represent the letters
        // associated with each number key on an old phone pad
        string[] nums = { " ", "&'(", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        // Convert the input string into an array of characters
        char[] str = S.ToCharArray();

        // Initialize a counter variable i to keep track of our position
        // in the input string
        int i = 0;

        // Initialize a StringBuilder object to store the output text
        StringBuilder output = new StringBuilder();

        // Loop through each character in the input string
        while (i < str.Length)
        {
            // Ignore spaces
            if (str[i] == ' ')
            {
                i++;
                continue;
            }

            // Stop processing the string if we encounter a pound sign (#)
            if (str[i] == '#')
                break;

            // Handle backspace functionality
            if (str[i] == '*')
            {
                // Count the number of asterisks in a row
                int backspaces = 1;
                i++;
                while (i < str.Length && str[i] == '*')
                {
                    backspaces++;
                    i++;
                }

                // If we have more asterisks than characters in the output
                // string, clear the output string
                if (backspaces > output.Length)
                {
                    output.Clear();
                }
                // Otherwise, remove the last n characters from the output string
                else
                {
                    output.Remove(output.Length - backspaces, backspaces);
                }
                continue;
            }

            // Count the number of times a key is pressed in a row
            int count = 0;
            while (i + 1 < str.Length && str[i] == str[i + 1])
            {
                // Maximum of 3 letters for keys 2, 3, 4, 5, 6, 8
                if (count == 2 && ((str[i] >= '2' && str[i] <= '6') || (str[i] == '8')))
                    break;

                // Maximum of 4 letters for keys 7 and 9
                else if (count == 3 && (str[i] == '7' || str[i] == '9'))
                    break;

                count++;
                i++;

                // Handle the end condition
                if (i == str.Length)
                    break;
            }

            // Determine which key was pressed and which letter(s) it corresponds to
            if (str[i] == '7' || str[i] == '9')
            {
                int index = str[i] - 48;
                
                    output.Append(nums[index][count % 4]);
                
            }
            else
            {
                int index = str[i] - 48;
                
                    output.Append(nums[index][count % 3]);
                
            }
            i++;
        }

        // Print the output string
        Console.WriteLine(output.ToString());

}


    // Driver Code
    public static void Main(string[] args)
    {
        string str = "44883336**6647778777**999#";
        OldPhonePad(str);
    }
}

// This code is contributed by ukasp.
