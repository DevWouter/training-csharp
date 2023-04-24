using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator;

public static partial class Program
{
    public static void Main(string[] args)
    {
        // string[] tokens = GetTokens("1 + 2 * 3 - 4 / 5");
        // string[] rpn = ToRpn(tokens);
        // double result = EvaluateRpn(rpn);
        // Console.WriteLine(result);
    }

    private static string[] GetTokens(string input)
    {
        return InfixMathExpression()
            .Matches(input)
            .Select(x => x.Value.Trim())
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();
    }


    [GeneratedRegex("" +
                    "([0-9]+(?:\\.[0-9]+)?)" + // Numbers (including decimals)
                    "|(\\+)" +                 // + operator
                    "|(-)" +                   // - operator 
                    "|(\\*)" +                 // * operator
                    "|(\\/)" +                 // / operator
                    "|(\\^)" +                 // ^ operator
                    "|(\\()" +                 // Open parenthesis
                    "|(\\))"                   // Close parenthesis
    )]
    private static partial Regex InfixMathExpression();
}