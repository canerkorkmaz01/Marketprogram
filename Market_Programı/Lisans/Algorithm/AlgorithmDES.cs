namespace Algorithm
{
    using Encrypt;
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;

    public class AlgorithmDES : Encryptor
    {
        public AlgorithmDES(string secretKey, AlgorithmKeyType AlgType) : base(secretKey, AlgType)
        {
        }

        public override void GenerateKey(string secretKey, AlgorithmKeyType type)
        {
            this.Key = new byte[8];
            this.IV = new byte[8];
            byte[] bytes = Encoding.UTF8.GetBytes(secretKey);
            switch (type)
            {
                case AlgorithmKeyType.None:
                    break;

                case AlgorithmKeyType.SHA1:
                {
                    using (SHA1Managed managed = new SHA1Managed())
                    {
                        managed.ComputeHash(bytes);
                        byte[] hash = managed.Hash;
                        for (int i = 0; i < 8; i++)
                        {
                            this.Key[i] = hash[i];
                        }
                        for (int j = 0x13; j > 11; j--)
                        {
                            this.IV[0x13 - j] = hash[j];
                        }
                        break;
                    }
                }
                case AlgorithmKeyType.SHA256:
                {
                    using (SHA256Managed managed2 = new SHA256Managed())
                    {
                        managed2.ComputeHash(bytes);
                        byte[] buffer4 = managed2.Hash;
                        for (int k = 0; k < 8; k++)
                        {
                            this.Key[k] = buffer4[k];
                        }
                        for (int m = 0x1f; m >= 0x18; m--)
                        {
                            this.IV[0x1f - m] = buffer4[m];
                        }
                        break;
                    }
                }
                case AlgorithmKeyType.SHA384:
                {
                    using (SHA384Managed managed3 = new SHA384Managed())
                    {
                        managed3.ComputeHash(bytes);
                        byte[] buffer5 = managed3.Hash;
                        for (int n = 0; n < 8; n++)
                        {
                            this.Key[n] = buffer5[n];
                        }
                        for (int num8 = 0x2f; num8 > 0x27; num8--)
                        {
                            this.IV[0x2f - num8] = buffer5[num8];
                        }
                        break;
                    }
                }
                case AlgorithmKeyType.SHA512:
                    using (SHA512Managed managed4 = new SHA512Managed())
                    {
                        managed4.ComputeHash(bytes);
                        byte[] buffer6 = managed4.Hash;
                        for (int num9 = 0; num9 < 8; num9++)
                        {
                            this.Key[num9] = buffer6[num9];
                        }
                        for (int num10 = 0x3f; num10 > 0x37; num10--)
                        {
                            this.IV[0x3f - num10] = buffer6[num10];
                        }
                    }
                    break;

                case AlgorithmKeyType.MD5:
                {
                    using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
                    {
                        provider.ComputeHash(bytes);
                        byte[] buffer2 = provider.Hash;
                        for (int num = 0; num < 8; num++)
                        {
                            this.Key[num] = buffer2[num];
                        }
                        for (int num2 = 15; num2 >= 8; num2--)
                        {
                            this.IV[15 - num2] = buffer2[num2];
                        }
                        break;
                    }
                }
                default:
                    return;
            }
        }

        public override byte[] Transform(byte[] data, TransformType type)
        {
            MemoryStream stream = null;
            ICryptoTransform transform = null;
            byte[] buffer;
            DES des = DES.Create();
            try
            {
                stream = new MemoryStream();
                des.Key = this.Key;
                des.IV = this.IV;
                if (type == TransformType.ENCRYPT)
                {
                    transform = des.CreateEncryptor();
                }
                else
                {
                    transform = des.CreateDecryptor();
                }
                if ((data != null) && (data.Length != 0))
                {
                    CryptoStream stream1 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                    stream1.Write(data, 0, data.Length);
                    stream1.FlushFinalBlock();
                    return stream.ToArray();
                }
                buffer = null;
            }
            catch (CryptographicException exception1)
            {
                throw new CryptographicException(exception1.Message);
            }
            finally
            {
                if (des != null)
                {
                    des.Clear();
                }
                if (transform != null)
                {
                    transform.Dispose();
                }
                stream.Close();
            }
            return buffer;
        }

        private byte[] IV { get; set; }

        private byte[] Key { get; set; }
    }
}

