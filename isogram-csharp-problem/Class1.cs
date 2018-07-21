using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public bool Isogramcheck(string Inputstring)
        {
            char[] set = Inputstring.ToCharArray();
            Array.Sort(set);

            for (int i = 0; i < set.Length - 1; i++)

            {
                if (char.IsLetter(set[i]))
                {
                    if (set[i] == set[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;

        }

    }
}
