namespace Encrypt
{
    using Algorithm;
    using System;
    using System.Runtime.CompilerServices;

    public class ObjectEncryptor
    {
        public virtual string ObjectCryptography(string secretKey, string data, TransformType type, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            string str = null;
            switch (algType)
            {
                case AlgorithmType.None:
                    return str;

                case AlgorithmType.Rijndael:
                    this.Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                    return this.Encryptor.ObjectCryptography(data, type);

                case AlgorithmType.TripleDES:
                    this.Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                    return this.Encryptor.ObjectCryptography(data, type);

                case AlgorithmType.DES:
                    this.Encryptor = new AlgorithmDES(secretKey, algKeyType);
                    return this.Encryptor.ObjectCryptography(data, type);
            }
            return str;
        }

        protected Encrypt.Encryptor Encryptor { get; set; }
    }
}

