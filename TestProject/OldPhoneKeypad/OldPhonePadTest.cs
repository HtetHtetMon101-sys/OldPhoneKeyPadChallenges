using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldPhoneKeyPad;

namespace TestProject.OldPhoneKeypad
{
    [TestClass]
    public class OldPhonePadTest
    {
        [DataTestMethod]
        [DataRow("222 2 22#", "CAB")]
        [DataRow("33#", "E")]
        [DataRow("227*#", "B")]
        [DataRow("4433555 555666#", "HELLO")]
        [DataRow("8 88777444666*664#", "TURING")]
        [DataRow(
            "844330778844422255022777666966033366699058867 7777066688833777084433055529999 999036664#",
            "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"
        )]
        public void PassExamples(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("#", "")]
        [DataRow("*#", "")]
        [DataRow("***#", "")]
        [DataRow("2*#", "")]
        [DataRow("2*3*#", "")]
        [DataRow("23**#", "")]
        [DataRow("2 2 22***3*#", "")]
        public void ReturnEmpty(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("1#", "&")]
        [DataRow("11#", "'")]
        [DataRow("111#", "(")]
        [DataRow("2 1 11 111#", "A&'(")]
        [DataRow("212211222111#", "A&B'C(")]
        public void ReturnPunctuation_InputsWith1(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("0#", " ")]
        [DataRow("20#", "A ")]
        [DataRow("20220222#", "A B C")]
        public void ReturnSpace_InputsWith0(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("2", "A")]
        [DataRow("2322 222", "ADBC")]
        public void HandleMissingHash(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("2#22344", "A")]
        [DataRow("2322 222#234567899", "ADBC")]
        public void HandleHashInMiddle(string input, string expected)
        {
            var output = OldPhoneKeyPad.OldPhoneKeyPad.OldPhonePad(input);
            Assert.AreEqual(expected, output);
        }
    }
}
