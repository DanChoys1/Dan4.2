using System;
using System.Text;

namespace Program
{
    public class GammaXoring : ICipher
    {
        public String Encode(String openData, String key)
        {
            if (key.Length == 0)
            {
                throw new KeyArgumentException("Пароль долже быть длинее 0 символов");
            }

            if (key.Length > openData.Length)
            {
               throw new KeyArgumentException("Пароль долже быть меньше длины введенного текста");
            }

            Byte[] openDataByte = Encoding.UTF8.GetBytes(openData);

            Byte[] keyBytes = FillKeyBytes(openDataByte.Length, key);

            Byte[] encryptedDataByte = Coding(openDataByte, keyBytes);

            return BitConverter.ToString(encryptedDataByte, 0);
        }

        public String Decode(String encryptedData, String key)
        {
            if (key.Length == 0)
            {
                throw new KeyArgumentException("Пароль долже быть длинее 0");
            }

            Byte[] encryptedDataByte;

            try
            {
                encryptedDataByte = SplitStringIntoBytes(encryptedData);
            }
            catch (Exception)
            {
                throw new EncryptedTextException("Введены некорректные данные"); 
            }

            Byte[] keyBytes = FillKeyBytes(encryptedDataByte.Length, key);

            Byte[] openDataByte = Coding(encryptedDataByte, keyBytes);

            String openData = Encoding.UTF8.GetString(openDataByte);

            return openData;
        }

        private Byte[] Coding(Byte[] data, Byte[] key)
        {
            for(int i = 0; i < data.Length; i++)
            {
                data[i] ^= key[i];
            }

            return data;
        }

        private Byte[] FillKeyBytes(int lengthKey, String key)
        {
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            int differenceSize = lengthKey - keyBytes.Length;

            if (differenceSize > 0)
            {
                Byte[] newKeyBytes = new Byte[keyBytes.Length + differenceSize];

                keyBytes.CopyTo(newKeyBytes, 0);

                for (int i = 0; i < differenceSize; i++)
                {
                    newKeyBytes[keyBytes.Length + i] = keyBytes[i % keyBytes.Length];
                }

                keyBytes = newKeyBytes;
            }

            return keyBytes;
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
