using System;
using System.Collections.Generic;
using System.Text;

namespace Dan4._2
{
    class GammaXoring : ICipher
    {
        public Byte[] Encode(String openData, String key)
        {
            Byte[] openDataByte = Encoding.UTF8.GetBytes(openData);

            Byte[] keyBytes = FillKeyBytes(openDataByte, key);

            Byte[] encryptedDataByte = Coding(openDataByte, keyBytes);

            return encryptedDataByte;
        }

        public String Decode(Byte[] encryptedData, String key)
        {
            Byte[] keyBytes = FillKeyBytes(encryptedData, key);

            Byte[] openDataByte = Coding(encryptedData, keyBytes);

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

        private Byte[] FillKeyBytes(Byte[] dataByte, String key)
        {
            Byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            int differenceSize = dataByte.Length - keyBytes.Length;

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
    }
}
