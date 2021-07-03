namespace Encrypt
{
    using Algorithm;
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public abstract class Encryptor
    {
        public Encryptor(string secretKey, AlgorithmKeyType AlgType)
        {
            this.GenerateKey(secretKey, AlgType);
        }

        public string Decrypt(string data)
        {
            string str;
            try
            {
                if (data.Length > 0)
                {
                    byte[] buffer = Convert.FromBase64String(data);
                    return Encoding.UTF8.GetString(this.Transform(buffer, TransformType.DECRYPT));
                }
                str = null;
            }
            catch (CryptographicException exception1)
            {
                throw exception1;
            }
            return str;
        }

        public string Encrypt(string data)
        {
            string str;
            try
            {
                if (data.Length > 0)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(data);
                    return Convert.ToBase64String(this.Transform(bytes, TransformType.ENCRYPT));
                }
                str = null;
            }
            catch (CryptographicException exception1)
            {
                throw exception1;
            }
            return str;
        }

        public abstract void GenerateKey(string secretKey, AlgorithmKeyType type);
        public string ObjectCryptography(string data, TransformType type)
        {
            string str = null;
            try
            {
                if (data.Length <= 0)
                {
                    return str;
                }
                if (type != TransformType.ENCRYPT)
                {
                    if (type != TransformType.DECRYPT)
                    {
                        return str;
                    }
                }
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(data);
                    return Convert.ToBase64String(this.Transform(bytes, TransformType.ENCRYPT));
                }
                byte[] buffer2 = Convert.FromBase64String(data);
                str = Encoding.UTF8.GetString(this.Transform(buffer2, TransformType.DECRYPT));
            }
            catch (CryptographicException exception1)
            {
                throw exception1;
            }
            return str;
        }

        public byte[] ObjectCryptography(byte[] data, TransformType type)
        {
            byte[] buffer = null;
            try
            {
                if ((data == null) || (data.Length == 0))
                {
                    return buffer;
                }
                if (type != TransformType.ENCRYPT)
                {
                    if (type != TransformType.DECRYPT)
                    {
                        return buffer;
                    }
                }
                else
                {
                    return this.Transform(data, TransformType.ENCRYPT);
                }
                buffer = this.Transform(data, TransformType.DECRYPT);
            }
            catch (CryptographicException exception1)
            {
                throw exception1;
            }
            return buffer;
        }

        public abstract byte[] Transform(byte[] data, TransformType type);
    }
}

