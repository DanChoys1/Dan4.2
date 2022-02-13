using System;
using System.Collections.Generic;
using System.Text;

namespace Dan4._2
{
    interface ICipher
    {
        public Byte[] Encode(String openData, String key);

        public String Decode(Byte[] encryptedData, String key);
    }
}
