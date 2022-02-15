﻿using System;
using System.Text;

namespace Program
{
    class GammaXoring : ICipher
    {
        public Byte[] Encode(String openData, String key)
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

            Byte[] keyBytes = FillKeyBytes(openDataByte, key);

            Byte[] encryptedDataByte = Coding(openDataByte, keyBytes);

            return encryptedDataByte;
        }

        public String Decode(Byte[] encryptedData, String key)
        {
            if (key.Length == 0)
            {
                throw new KeyArgumentException("Пароль долже быть длинее 0");
            }

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
