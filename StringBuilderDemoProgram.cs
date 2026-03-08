using System;
using System.Text;

class StringBuilderDemoProgram
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Hello ");
        sb.Append("World ");
        sb.Append("from C#");

        Console.WriteLine(sb.ToString());
    }
}