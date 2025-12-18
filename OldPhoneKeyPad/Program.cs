using System;

namespace OldPhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhoneKeyPad.OldPhonePad("33#"));                // E
            Console.WriteLine(OldPhoneKeyPad.OldPhonePad("227*#"));              // B
            Console.WriteLine(OldPhoneKeyPad.OldPhonePad("4433555 555666#"));     // HELLO
            Console.WriteLine(OldPhoneKeyPad.OldPhonePad("8 88777444666*664#"));  

            Console.ReadLine(); // keep console open
        }
    }
}
