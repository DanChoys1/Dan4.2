using System;
using System.Text;

namespace Program
{
   public class Gost28147_89 : ICipher
    {
        private readonly Byte[,] replacementBlock;

        public Gost28147_89()
        {
            replacementBlock = new Byte[8, 16] {
                                                {0xF, 0xC, 0x2, 0xA, 0x6, 0x4, 0x5, 0x0, 0x7, 0x9, 0xE, 0xD, 0x1, 0xB, 0x8, 0x3},
                                                {0xB, 0x6, 0x3, 0x4, 0xC, 0xF, 0xE, 0x2, 0x7, 0xD, 0x8, 0x0, 0x5, 0xA, 0x9, 0x1},
                                                {0x1, 0xC, 0xB, 0x0, 0xF, 0xE, 0x6, 0x5, 0xA, 0xD, 0x4, 0x8, 0x9, 0x3, 0x7, 0x2},
                                                {0x1, 0x5, 0xE, 0xC, 0xA, 0x7, 0x0, 0xD, 0x6, 0x2, 0xB, 0x4, 0x9, 0x3, 0xF, 0x8},
                                                {0x0, 0xC, 0x8, 0x9, 0xD, 0x2, 0xA, 0xB, 0x7, 0x3, 0x6, 0x5, 0x4, 0xE, 0xF, 0x1},
                                                {0x8, 0x0, 0xF, 0x3, 0x2, 0x5, 0xE, 0xB, 0x1, 0xA, 0x4, 0x7, 0xC, 0x9, 0xD, 0x6},
                                                {0x3, 0x0, 0x6, 0xF, 0x1, 0xE, 0x9, 0x2, 0xD, 0x8, 0xC, 0x4, 0xB, 0xA, 0x5, 0x7},
                                                {0x1, 0xA, 0x6, 0x8, 0xF, 0xB, 0x0, 0x4, 0xC, 0x3, 0x5, 0x9, 0x7, 0xD, 0x2, 0xE},
                                               };
        }

        public Byte[] Encode(String openData, String key)
        {
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            const int countBytesInKey = 32;

            if (keyBytes.Length != countBytesInKey)
            {
                throw new KeyArgumentException("Пароль долже быть 256 битным");
            }

            const int countKeyStorage = 8;
            UInt32[] keyStorage = new UInt32[countKeyStorage];

            for (int i = 0; i < countKeyStorage; i++)
            {
                keyStorage[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            Byte[] openDataByte = Encoding.UTF8.GetBytes(openData);

            int differenceSize = openDataByte.Length - openData.Length;

            if ((differenceSize > 0) || (openData.Length % 8 != 0))
            {
                int numberAappendCharacters = 8 - openDataByte.Length % 8;

                Byte[] newOpenDataByte = new Byte[openDataByte.Length + numberAappendCharacters];
                openDataByte.CopyTo(newOpenDataByte, 0);

                Char[] nullChar = { '\0' };
                Byte[] nullByte = Encoding.UTF8.GetBytes(nullChar);

                while (numberAappendCharacters > 0)
                {
                    newOpenDataByte[newOpenDataByte.Length - numberAappendCharacters] = nullByte[0];
                    numberAappendCharacters--;
                }

                openDataByte = newOpenDataByte;
            }

            Byte[] encryptedDataByte = Coding(openDataByte, keyStorage, true);

            return encryptedDataByte;
        }

        public String Decode(Byte[] encryptedData, String key)
        {
            if (encryptedData.Length % 8 != 0)
            {
                throw new EncryptedTextException("Шифр должен быть кратен 8");
            }

            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            const int countBytesInKey = 32;

            if (keyBytes.Length != countBytesInKey)
            {
                throw new KeyArgumentException("Пароль долже быть 256 битным");
            }

            const int countKeyStorage = 8;
            UInt32[] keyStorage = new UInt32[countKeyStorage];

            for (int i = 0; i < countKeyStorage; i++)
            {
                keyStorage[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            Byte[] openDataByte = Coding(encryptedData, keyStorage, false);

            String openData = Encoding.UTF8.GetString(openDataByte);

            return openData;
        }

        private Byte[] Coding(Byte[] data, UInt32[] keyStorage, bool isEncoding)
        {
            Byte[] encryptedDataByte = new Byte[data.Length];

            const int sizeBlock = 8;

            for (int i = 0; i < data.Length; i += sizeBlock)
            {
                UInt32 leftBlock = BitConverter.ToUInt32(data, i);
                UInt32 rightBlock = BitConverter.ToUInt32(data, i + sizeof(UInt32));

                int countIteretion = 32;

                UInt32 result = new UInt32();

                for (int j = 0; j < countIteretion; j++)
                {
                    result = SumFromMod_2_Degree_32(leftBlock, keyStorage, j, isEncoding);

                    result = SubstitutionBlock(result);

                    result = ShiftingRegister(result);

                    result = SumFromMod_2(result, rightBlock);

                    if (j != (countIteretion - 1))
                    {
                        rightBlock = leftBlock;
                        leftBlock = result;
                    }
                }

                rightBlock = result;

                Byte[] leftBlockBytes = BitConverter.GetBytes(leftBlock);
                Byte[] rightBlockBytes = BitConverter.GetBytes(rightBlock);

                for (int j = 0; j < sizeBlock / 2; j++)
                {
                    encryptedDataByte[i + j] = leftBlockBytes[j];
                }

                for (int j = 0; j < sizeBlock / 2; j++)
                {
                    encryptedDataByte[i + j + sizeBlock / 2] = rightBlockBytes[j];
                }
            }

            return encryptedDataByte;
        }

        private UInt32 SumFromMod_2_Degree_32(UInt32 block, UInt32[] keyStorage, int numberIteration, bool isEncoding)
        {
            int countDirectCoding;

            if (isEncoding == true)
            {
                countDirectCoding = 24;
            }
            else
            {
                countDirectCoding = 8;
            }

            if (numberIteration < countDirectCoding)
            {
                block = (block + keyStorage[numberIteration % keyStorage.Length]) % UInt32.MaxValue;
            }
            else
            {
                block = (block + keyStorage[(keyStorage.Length - 1) -
                            numberIteration % keyStorage.Length]) % UInt32.MaxValue;
            }

            return block;
        }

        private UInt32 SubstitutionBlock(UInt32 block)
        {
            Byte[] splitBlock = new Byte[8];

            for (int i = 0; i < 8; i++)
            {
                splitBlock[i] = (Byte)block;
                splitBlock[i] &= 0b0000_1111;
                block >>= 4;
            }

            for (int i = 7; i >= 0; i--)
            {
                block <<= 4;
                block |= replacementBlock[i, splitBlock[i]];
            }

            return block;
        }

        private UInt32 ShiftingRegister(UInt32 block)
        { 
            UInt32 safe = block;
            safe >>= 21;

            block <<= 11;
            block |= safe;

            return block;
        }

        private UInt32 SumFromMod_2(UInt32 block, UInt32 rightBlock)
        {
            return block ^ rightBlock;
        }
    }
}
