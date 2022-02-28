using System;

namespace Program
{
    interface ICipher
    {
        public String Encode(String openData, String key);

        public String Decode(String encryptedData, String key);
    }
}
