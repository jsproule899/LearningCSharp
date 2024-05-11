using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

class CodeBreaker
{
    public static void Main(String[] args)
    {

        String input = "Joshua Sproule";

        String output = Encoder(input);

        Decoder(output);

    }

    private static String Encoder(string input)
    {
        String encoded = "";
        foreach (char c in input)
        {
            if (input.Last() == c)
            {
                encoded += (int)c ;
                Console.Write((int)c);
            }
            else
            {
                encoded += (int)c + ", ";
                Console.Write((int)c + ", ");
            }

        }
        Console.WriteLine();
        return encoded;
    }

    public static String Decoder(String s)
    {
        String decoded = "";
        String[] code = s.Split(",");
        foreach (String num in code)
        {

            int i = Int16.Parse(num.Trim());
            Console.Write((char)i);
            decoded += (char)i;
        }
        return decoded;
    }
}