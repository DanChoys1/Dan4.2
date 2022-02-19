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
            String expectedEncriptedText =  "24-53-CE-08-44-AB-EE-A0-EB-ED-FF-75-59-0D-A0-B8-8F-C3" +
                                    "-45-43-E4-16-1B-22-46-6D-37-98-05-9E-AA-A0-8E-41-BE-63-38-47-F5-64";

            Byte[] expectedEncriptedByte = SplitStringIntoBytes(expectedEncriptedText);

            String key = "this_is_256_bits_key_for_GOST!!!";

            // Act
            Gost28147_89 gost28147_89 = new Gost28147_89();
            Byte[] resultEncriptedText = gost28147_89.Encode(openText, key);

            // Assert
            Assert.AreEqual(expectedEncriptedByte, resultEncriptedText);
        }

        private Byte[] SplitStringIntoBytes(String data)
        {
            String[] splitData = new String[data.Length];

            int byteIndex = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '-')
                {
                    byteIndex++;
                    continue;
                }

                splitData[byteIndex] += data[i];
            }

            Byte[] dataByte = new Byte[++byteIndex];

            for (int i = 0; i < byteIndex; i++)
            {
                dataByte[i] = byte.Parse(splitData[i], System.Globalization.NumberStyles.HexNumber);
            }

            return dataByte;
        }
    }
}
