﻿using System;
using Crypter.Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crypter.Testing
{
    [TestClass]
    public class MixedLanguagesTest
    {
        const string punctuation = ".,?!-#'\";:()";
        const string mixedText = "бвг123bcd" + punctuation;
        const int step = 1;

        [TestMethod]
        public void TestRusDig()
        {
            CaesarCrypter crypter = new CaesarCrypter(new Alphabet(Languages.Russian), new Alphabet(Languages.Digits));

            CommonTestMethods.TestShift(crypter.Encrypt, mixedText, step, "вгд234bcd" + punctuation);
            CommonTestMethods.TestShift(crypter.Decrypt, mixedText, step, "абв012bcd" + punctuation);
        }

    }
}