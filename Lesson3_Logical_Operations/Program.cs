using System;

namespace Lesson3_Logical_Operations
{
    public class Encrypt
    {
        // attributes
        private int encrypt; // value that must be encrypted
        private int decrypt; // value that must be encrypted
        private int _data; // value that must be encrypted
        private int _key;   // key for encrypt or decrypt hidden value


        // Methods
        public int Data{ private get => _data; set => _data = value; }
        public int Key{ private get => _key; set => _key = value; }

        
        public int Encryption(int key, int data)
        {
            encrypt = data ^ key;
            return encrypt;
        }
        public int Decryption(int key)
        {
            decrypt = encrypt ^ key;
            return decrypt;
        }

        //Constructors
        public Encrypt()
        {
            _data = 0;
            _key = 100;
        }
        
        
        public Encrypt(int data, int key)
        {
            _data = data;
            _key = key;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var value = 147;
            var key = 111;
            var encryption = value ^ key;

            /***************************************************/
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"Encrypted value: {encryption}");

            var decryption = encryption ^ key;

            Console.WriteLine($"Decrypted value: {decryption}");

            Console.WriteLine("Hello World!\n\n");

            /***************************************************/
            Encrypt enc = new Encrypt(25, 34);
            var al = enc.Key = 124;
            var ol = enc.Data = 124;


            Console.WriteLine(enc.Encryption(al, ol));
            Console.WriteLine(enc.Decryption(al));

            /***************************************************/

            byte a = 30;
            byte b = (byte)(a + 50);


        }
    }
}
