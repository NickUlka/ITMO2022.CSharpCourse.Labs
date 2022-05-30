

namespace ITMO.CSharp.Lab9._1
{
    internal sealed class LineStart
    {
        internal sealed class Token : ILineStartToken
        {
            internal Token(int number)
            {
                this.number = number;
            }

            public static Token operator ++(Token t)
            {
                t.number++;
                return t;
            }

            int ILineStartToken.Number()
            {
                return number;
            }

            private int number;
        }
    }
}
