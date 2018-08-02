using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaintext_Ciphertext
{
    /*PLAINTEXT TO CIPHERTEXT
    AND
    CIPHERTEXT TO PLAINTEXT*/

    class PlainOrCipher
    {
        public void PToC()
        {
            int a, PV, CV;
            char Ciphertext;

            Console.WriteLine("Enter your letter:");
            string Plaintext = Console.ReadLine();
            Console.WriteLine("Enter your key:");
            int Key = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Ciphertext: ");
            for (int i = 0; i < Plaintext.Length; i++)
            {
                a = (int)Plaintext[i];
                if (a >= 65 && a <= 90) //FIND CAPITAL ALPHABET COMPARE WITH ASCII
                {
                    PV = a - 64;
                    CV = PV + Key; //VALUE of CIPHERTEXT

                    if (CV > 26)
                    {
                        CV = CV % 26;
                        if(CV != 0)
                        {
                            CV = CV + 64;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                        else
                        {
                            CV = 26 + 64;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        } 
                    }
                    else
                    {
                        CV = CV + 64;
                        Ciphertext = (char)CV; //CONVERT INT TO LETTER

                        Console.Write(Ciphertext);
                    }
                }
                else if (a >= 97 && a <= 122) //FIND SMALL ALPHABET COMPARE WITH ASCII
                {
                    PV = a - 96;
                    CV = PV + Key; //VALUE of CIPHERTEXT

                    if (CV > 26)
                    {
                        CV = CV % 26;
                        if (CV != 0)
                        {
                            CV = CV + 96;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                        else
                        {
                            CV = 26 + 96;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                    }
                    else
                    {
                        CV = CV + 96;
                        Ciphertext = (char)CV; //CONVERT INT TO LETTER

                        Console.Write(Ciphertext);
                    }
                }
            }
        }

        public void CToP()
        {
            int a, CV, PV;
            char Plaintext;

            Console.WriteLine("\n\nEnter your letter:");
            string Ciphertext = Console.ReadLine();
            Console.WriteLine("Enter your key:");
            int Key = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Plaintext: ");
            for (int i = 0; i < Ciphertext.Length; i++)
            {
                a = (int)Ciphertext[i];
                if (a >= 65 && a <= 90) //FIND CAPITAL ALPHABET COMPARE WITH ASCII
                {
                    CV = a - 64;
                    PV = CV - Key; //VALUE of PLAINTEXT

                    if (PV < 0 && PV < -26)
                    {
                        int MPV = PV * -1;
                        int D = MPV / 26;
                        D = D + 1;
                        int Temp = 26 * D;
                        PV = Temp + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if(PV < 0 && PV >= -26)
                    {
                        PV = 26 + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if(PV > 0 && PV < 26)
                    {
                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                }
                else if (a >= 97 && a <= 122) //FIND SMALL ALPHABET COMPARE WITH ASCII
                {
                    CV = a - 96;
                    PV = CV - Key; //VALUE of PLAINTEXT

                    if (PV < 0 && PV < -26)
                    {
                        int MPV = PV * -1;
                        int D = MPV / 26;
                        D = D + 1;
                        int Temp = 26 * D;
                        PV = Temp + PV;

                        PV = PV + 96;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV < 0 && PV >= -26)
                    {
                        PV = 26 + PV;

                        PV = PV + 96;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV > 0 && PV < 26)
                    {
                        PV = PV + 96;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                }
            }
        }
    }

    class OneTimePAD
    {
        public void PToC()
        {
            int a, k, PV, KV, CV;
            char Ciphertext;

            Console.WriteLine("Enter your letter:");
            string Plaintext = Console.ReadLine();
            Console.WriteLine("Enter your key:");
            string Key = Console.ReadLine();

            char[] Plaintexts = new char[100];
            char[] Keys = new char[100];

            for (int i = 0; i < Plaintext.Length; i++)
            {
                Plaintexts[i] = Plaintext[i]; //STORE PLAINTEXT
            }
            for (int j = 0; j < Key.Length; j++)
            {
                Keys[j] = Key[j]; //STORE KEY
            }

            Console.WriteLine("Your Ciphertext: ");
            for (int arr = 0; arr < Plaintext.Length; arr++)
            {
                a = (int)Plaintexts[arr];
                k = (int)Keys[arr];
                
                if (a >= 65 && a <= 90 && k >= 65 && k <= 90) //FIND CAPITAL ALPHABET COMPARE WITH ASCII
                {
                    PV = a - 64;
                    KV = k - 64;
                    CV = PV + KV; //VALUE of CIPHERTEXT

                    if (CV > 26)
                    {
                        CV = CV % 26;
                        if (CV != 0)
                        {
                            CV = CV + 64;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                        else
                        {
                            CV = 26 + 64;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                    }
                    else
                    {
                        CV = CV + 64;
                        Ciphertext = (char)CV; //CONVERT INT TO LETTER

                        Console.Write(Ciphertext);
                    }
                }
                else if (a >= 97 && a <= 122 && k >= 97 && k <= 122) //FIND SMALL ALPHABET COMPARE WITH ASCII
                {
                    PV = a - 96;
                    KV = k - 96;
                    CV = PV + KV; //VALUE of CIPHERTEXT

                    if (CV > 26)
                    {
                        CV = CV % 26;
                        if (CV != 0)
                        {
                            CV = CV + 96;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                        else
                        {
                            CV = 26 + 96;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                    }
                    else
                    {
                        CV = CV + 96;
                        Ciphertext = (char)CV; //CONVERT INT TO LETTER

                        Console.Write(Ciphertext);
                    }
                }
            }
        }

        public void CToP()
        {
            int a, k, CV, KV, PV;
            char Plaintext;

            Console.WriteLine("\n\nEnter your letter:");
            string Ciphertext = Console.ReadLine();
            Console.WriteLine("Enter your key:");
            string Key = Console.ReadLine();

            char[] Ciphertexts = new char[100];
            char[] Keys = new char[100];

            for (int i = 0; i < Ciphertext.Length; i++)
            {
                Ciphertexts[i] = Ciphertext[i]; //STORE CIPHERTEXT
            }
            for (int j = 0; j < Key.Length; j++)
            {
                Keys[j] = Key[j]; //STORE KEY
            }

            Console.WriteLine("Your Plaintext: ");
            for (int arr = 0; arr < Ciphertext.Length; arr++)
            {
                a = (int)Ciphertexts[arr];
                k = (int)Keys[arr];

                if (a >= 65 && a <= 90 && k >= 65 && k <= 90) //FIND CAPITAL ALPHABET COMPARE WITH ASCII
                {
                    CV = a - 64;
                    KV = k - 64;
                    PV = CV - KV; //VALUE of PLAINTEXT

                    if (PV < 0 && PV < -26)
                    {
                        int MPV = PV * -1;
                        int D = MPV / 26;
                        D = D + 1;
                        int Temp = 26 * D;
                        PV = Temp + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV < 0 && PV >= -26)
                    {
                        PV = 26 + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV > 0 && PV < 26)
                    {
                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                }
                else if (a >= 97 && a <= 122 && k >= 97 && k <= 122) //FIND SMALL ALPHABET COMPARE WITH ASCII
                {
                    CV = a - 96;
                    KV = k - 96;
                    PV = CV - KV; //VALUE of PLAINTEXT

                    if (PV < 0 && PV < -26)
                    {
                        int MPV = PV * -1;
                        int D = MPV / 26;
                        D = D + 1;
                        int Temp = 26 * D;
                        PV = Temp + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV < 0 && PV >= -26)
                    {
                        PV = 26 + PV;

                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                    else if (PV > 0 && PV < 26)
                    {
                        PV = PV + 64;
                        Plaintext = (char)PV; //CONVERT INT TO LETTER

                        Console.Write(Plaintext);
                    }
                }
            }
        }
    }

    class HillCipher
    {
        public int a;

        public void PToC()
        {
            int PV, CV;
            char Ciphertext;

            int[] Plaintexts = new int[4];
            int[,] Key = new int[2, 2];
            int[,] CiphertextValue = new int[2, 2];

            Console.WriteLine("Enter your letter:");
            string Plaintext = Console.ReadLine();
            
            Console.WriteLine("Enter your key:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Key[i, j] = int.Parse(Console.ReadLine()); //INPUT KEY 2*2 ARRAY
                }
            }

            Console.WriteLine("Your Ciphertext: ");
            for (int i = 0; i < Plaintext.Length; i++)
            {
                a = (int)Plaintext[i];
                if (a >= 65 && a <= 90)
                {
                    PV = a - 65; //HERE A = 0 AND Z = 25
                    Plaintexts[i] = PV; //STORE PLAINTEXT
                }
                else if (a >= 97 && a <= 122)
                {
                    PV = a - 97; //HERE a = 0 AND z = 25
                    Plaintexts[i] = PV; //STORE PLAINTEXT
                }
            }

            //MATRIX INTO
            CiphertextValue[0, 0] = (Key[0, 0] * Plaintexts[0]) + (Key[0, 1] * Plaintexts[1]);
            CiphertextValue[0, 1] = (Key[1, 0] * Plaintexts[0]) + (Key[1, 1] * Plaintexts[1]);
            CiphertextValue[1, 0] = (Key[0, 0] * Plaintexts[2]) + (Key[0, 1] * Plaintexts[3]);
            CiphertextValue[1, 1] = (Key[1, 0] * Plaintexts[2]) + (Key[1, 1] * Plaintexts[3]);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (a >= 65 && a <= 90)
                    {
                        if (CiphertextValue[i, j] > 26)
                        {
                            CV = CiphertextValue[i, j] % 26;
                            if (CV != 0)
                            {
                                CV = CV + 65;
                                Ciphertext = (char)CV; //CONVERT INT TO LETTER

                                Console.Write(Ciphertext);
                            }
                            else
                            {
                                CV = 25 + 65;
                                Ciphertext = (char)CV; //CONVERT INT TO LETTER

                                Console.Write(Ciphertext);
                            }
                        }
                        else
                        {
                            CV = CiphertextValue[i, j] + 65;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                    }
                    else if (a >= 97 && a <= 122)
                    {
                        if (CiphertextValue[i, j] > 26)
                        {
                            CV = CiphertextValue[i, j] % 26;
                            if (CV != 0)
                            {
                                CV = CV + 97;
                                Ciphertext = (char)CV; //CONVERT INT TO LETTER

                                Console.Write(Ciphertext);
                            }
                            else
                            {
                                CV = 25 + 97;
                                Ciphertext = (char)CV; //CONVERT INT TO LETTER

                                Console.Write(Ciphertext);
                            }
                        }
                        else
                        {
                            CV = CiphertextValue[i, j] + 97;
                            Ciphertext = (char)CV; //CONVERT INT TO LETTER

                            Console.Write(Ciphertext);
                        }
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*PlainOrCipher pc = new PlainOrCipher();
            pc.PToC();
            pc.CToP();

            OneTimePAD op = new OneTimePAD();
            op.PToC();
            op.CToP();

            HillCipher hc = new HillCipher();
            hc.PToC();*/

            Console.ReadKey();
        }
    }
}
