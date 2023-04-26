using System.Text.RegularExpressions;

namespace MathEvaluator;

public static class Program
{
    public static void Main(string[] args)
    {
        string[] tokens = GetTokens("1 + 2 * 3 - 4 / 5");
        Console.WriteLine("Tokens: ");
        Console.WriteLine(string.Join(",", tokens));


        string[] rpn = ToRpn(tokens);
        Console.WriteLine("Reverse polish notation:");
        Console.WriteLine(string.Join(",", rpn));

        double result = EvaluateRpn(rpn);
        Console.WriteLine(result);
    }

    private static double EvaluateRpn(string[] tokens)
    {
        Stack<double> stack = new Stack<double>();
        foreach (var token in tokens)
        {
            if (double.TryParse(token, out double number))
            {
                stack.Push(number);
            }
            else
            {
                double right = stack.Pop();
                double left = stack.Pop();

                switch (token)
                {
                    case "+": stack.Push(left + right); break;
                    case "-": stack.Push(left - right); break;
                    case "*": stack.Push(left * right); break;
                    case "/": stack.Push(left / right); break;
                    case "^": stack.Push(Math.Pow(left, right)); break;
                }
            }
        }

        return stack.Single();
    }

    private static string[] ToRpn(string[] tokens)
    {
        Queue<string> outputQueue = new Queue<string>();
        Stack<string> operatorStack = new Stack<string>();
        foreach (string token in tokens)
        {
            if (double.TryParse(token, out _)) outputQueue.Enqueue(token);
            if (token == "(") operatorStack.Push(token);

            if (token == ")")
            {
                while (true)
                {
                    var topOperator = operatorStack.Pop();
                    if (topOperator == "(") break; // out of the while(true) loop
                    outputQueue.Enqueue(topOperator);
                }
            }

            var mathOperators = new Dictionary<string, int>()
            {
                { "+", 1 },
                { "-", 1 },
                { "*", 2 },
                { "/", 2 },
                { "^", 3 },
            };

            if (mathOperators.ContainsKey(token))
            {
                while(operatorStack.Any())
                {
                    var topOperator = operatorStack.Peek();
                    if (topOperator == "(") break;

                    var topOperatorPrecedence = mathOperators[topOperator];
                    var tokenPrecedence = mathOperators[token];
                
                    if (topOperatorPrecedence < tokenPrecedence) break;

                    operatorStack.Pop();
                    outputQueue.Enqueue(topOperator);
                }
                
                operatorStack.Push(token);
            }
        }
        
        while(operatorStack.Any())
        {
            outputQueue.Enqueue(operatorStack.Pop());
        }

        return outputQueue.ToArray();
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
