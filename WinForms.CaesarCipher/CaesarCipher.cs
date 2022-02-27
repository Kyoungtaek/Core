using System;

namespace WinForms.CaesarCipher
{
    public class CaesarCipher
    {
        private int key;
        public string Encode(string text, int shiftKey)
        {
            char[] temp = text.ToCharArray();
            key = shiftKey;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!Char.IsLetter(temp[i]))
                {
                    continue;
                }
                else
                {
                    //Uppercase
                    if (Char.IsUpper(temp[i]))
                    {
                        temp[i] = (char)(temp[i] + key);

                        if (temp[i] > 'Z')
                        {
                            temp[i] = (char)(temp[i] - 26);
                        }
                    }
                    else
                    {
                        temp[i] = (char)(temp[i] + key);

                        if (temp[i] > 'z')
                        {
                            temp[i] = (char)(temp[i] - 26);
                        }
                    }
                }
            }

            return new string(temp);
        }

        public string Decode(string text, int shiftKey)
        {
            char[] temp = text.ToCharArray();
            key = shiftKey % 26;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!Char.IsLetter(temp[i]))
                {
                    continue;
                }
                else
                {
                    if (Char.IsUpper(temp[i]))
                    {
                        temp[i] = (char)(temp[i] - key);

                        if (temp[i] < 'A')
                        {
                            temp[i] = (char)(temp[i] + 26);
                        }
                    }
                    else
                    {
                        temp[i] = (char)(temp[i] - key);

                        if (temp[i] < 'a')
                        {
                            temp[i] = (char)(temp[i] + 26);
                        }
                    }
                }
            }

            return new string(temp);
        }
    }
}
