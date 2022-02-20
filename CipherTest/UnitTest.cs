using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Program;

namespace CipherTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GostEncodingTest()
        {
            // Arrange
            String openText = "It is encoding string! GOST 28147 - 89!";

            String expectedEncriptedText =  "24-53-CE-08-44-AB-EE-A0-EB-ED-FF-75-59-0D-A0-B8-8F-C3-45-43-E4-" +
                                            "16-1B-22-46-6D-37-98-05-9E-AA-A0-02-46-A3-26-CC-7A-61-44";

            String key = "this_is_256_bits_key_for_GOST!!!";

            // Act
            Gost28147_89 gost28147_89 = new Gost28147_89();
            String resultEncriptedText = gost28147_89.Encode(openText, key);

            // Assert
            Assert.AreEqual(expectedEncriptedText, resultEncriptedText);
        }

        [TestMethod]
        public void GostDecodingTest()
        {
            // Arrange
            String expectedOpenText = "It is decoding string! GOST 28147 - 89!\0";

            String encriptedText =  "74-9F-06-5F-67-B6-AF-5C-EB-ED-FF-75-59-0D-A0-B8-8F-" +
                                    "C3-45-43-E4-16-1B-22-46-6D-37-98-05-9E-AA-A0-02-46-A3-26-CC-7A-61-44";

            String key = "this_is_256_bits_key_for_GOST!!!";

            // Act
            Gost28147_89 gost28147_89 = new Gost28147_89();
            String resultDecriptedText = gost28147_89.Decode(encriptedText, key);

            // Assert
            Assert.AreEqual(expectedOpenText, resultDecriptedText);
        }

        [TestMethod]
        public void GammaXoringEncodingTest()
        {
            // Arrange
            String openText = "It is dencoding string! GammaXoring!";

            String expectedEncriptedText =  "1F-3F-56-5A-2A-16-1E-38-29-09-33-56-2F-26-5A" +
                                    "-46-3E-05-15-50-40-15-41-1C-7B-26-25-2D-40-30-47-29-11-0B-5A-7C";

            String key = "VKv3Y6z]Gj\\2FH=fMqg9.r`<<GH@!h([xe=]";

            // Act
            GammaXoring gammaXoring = new GammaXoring();
            String resultEncriptedText = gammaXoring.Encode(openText, key);

            // Assert
            Assert.AreEqual(expectedEncriptedText, resultEncriptedText);
        }

        [TestMethod]
        public void GammaXoringDecodingTest()
        {
            // Arrange
            String expectedOpenText = "It is decoding string! GammaXoring!";

            String encriptedText =  "2D-1A-01-24-03-4A-17-38-31-23-50-1E-24-1D-4D-" +
                                    "32-51-30-46-1E-0D-03-54-1C-5C-42-16-42-3D-41-12-55-0A-09-00";

            String key = "dn!Mpjs]RL4wJzmA%B/pj\"t[=/{#e.`<";

            // Act
            GammaXoring gammaXoring = new GammaXoring();
            String resultDecriptedText = gammaXoring.Decode(encriptedText, key);

            // Assert
            Assert.AreEqual(expectedOpenText, resultDecriptedText);
        }
    }
}
