using System.Text;

namespace OldPhoneKeyPad
{
    public static class OldPhoneKeyPad
    {
        private static readonly string[] KEY_MAP = new string[]
        {
            " ",        // 0
            "&'(",     // 1
            "ABC",     // 2
            "DEF",     // 3
            "GHI",     // 4
            "JKL",     // 5
            "MNO",     // 6
            "PQRS",    // 7
            "TUV",     // 8
            "WXYZ"     // 9
        };

        public static string OldPhonePad(string input)
        {
            var output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                // SEND
                if (currentChar == '#')
                    break;

                // BACKSPACE
                if (currentChar == '*')
                {
                    if (output.Length > 0)
                        output.Length--;

                    continue;
                }

                // DIGIT
                if (char.IsDigit(currentChar))
                {
                    int keyIndex = currentChar - '0';
                    int pressCount = 0;

                    while (i < input.Length && input[i] == currentChar)
                    {
                        pressCount++;
                        i++;
                    }

                    i--; // move back one index

                    int charIndex = (pressCount - 1) % KEY_MAP[keyIndex].Length;
                    output.Append(KEY_MAP[keyIndex][charIndex]);
                }
            }

            return output.ToString();
        }
    }
}
