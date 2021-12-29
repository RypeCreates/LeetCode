using System;
namespace Problems
{
    public class RomanToInteger
    {
        public RomanToInteger()
        {

        }

        public static int RomanToInt(string s)
        {
            // M is 1000
            // D is 500
            // C is 100
            // L is 50
            // X is 10
            // V is 5
            // I is 1

            
            var romanArr = s.ToCharArray();
            var result = 0;
            var lastChar = ' ';
            for (int i = 0; i < romanArr.Length; i++)
            {
                switch(romanArr[i])
                {
                    case 'M':
                        result += 1000;

                        if(lastChar.Equals('C'))
                        {
                            result -= 200;
                        }
                        break;
                    case 'D':
                        result += 500;

                        if (lastChar.Equals('C'))
                        {
                            result -= 200;
                        }
                        break;
                    case 'C':
                        result += 100;

                        if (lastChar.Equals('X'))
                        {
                            result -= 20;
                        }
                        break;
                    case 'L':
                        result += 50;

                        if (lastChar.Equals('X'))
                        {
                            result -= 20;
                        }
                        break;
                    case 'X':
                        result += 10;

                        if (lastChar.Equals('I'))
                        {
                            result -= 2;
                        }
                        break;
                    case 'V':
                        result += 5;

                        if (lastChar.Equals('I'))
                        {
                            result -= 2;
                        }
                        break;
                    case 'I':
                        result++;
                        break;
                }

                lastChar = romanArr[i];
            }

            return result;
        }
    }
}
