using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class KeyArgumentException : ArgumentException
    {
        public KeyArgumentException(String massage) :
            base(massage)
        { 
        }
    }

    class OpenTextArgumentException : ArgumentException
    {
        public OpenTextArgumentException(String massage) :
            base(massage)
        {
        }
    }

    class EncryptedTextException : ArgumentException
    {
        public EncryptedTextException(String massage) :
            base(massage)
        {
        }
    }
}
