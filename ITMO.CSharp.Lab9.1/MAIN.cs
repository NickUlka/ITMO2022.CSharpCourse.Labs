using System;


namespace ITMO.CSharp.Lab9._1
{
    internal class MAIN
    {
        public static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }
        }

        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);

            HTMLTokenVisitor visitor = new HTMLTokenVisitor();
            source.Accept(visitor);
        }
    }
}

