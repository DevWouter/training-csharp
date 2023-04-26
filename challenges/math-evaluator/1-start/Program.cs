using System.Text.RegularExpressions;

namespace MathEvaluator;

public static class Program
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

    private static Regex InfixMathExpression() =>
        new Regex("" +
                  "([0-9]+(?:\\.[0-9]+)?)" + // Numbers
                  "|(\\+)" +                 // + operator
                  "|(-)" +                   // - operator 
                  "|(\\*)" +                 // * operator
                  "|(\\/)" +                 // / operator
                  "|(\\^)" +                 // ^ operator
                  "|(\\()" +                 // Open parenthesis
                  "|(\\))"                   // Close parenthesis
        );
}