using System;

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
