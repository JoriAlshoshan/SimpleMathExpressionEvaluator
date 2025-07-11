using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ConsoleApps.TrainingApps.MathExpressionEvaluator
{
    public static class ExpressionParser
    {
        private const string MathSymbols = "+*/%^";
        public static MathExpression Parse(string input)
        {
            var expr = new MathExpression();
            string token = "";
            bool leftSideInitialized=false;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    token += currentChar;
                    if (i == input.Length - 1 && leftSideInitialized)
                    {
                        expr.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if (MathSymbols.Contains(currentChar))
                {
                    if (!leftSideInitialized)
                    {
                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                    }
                    expr.Operation = ParseMathOperation(currentChar.ToString());
                    token = "";
                }
                else if (currentChar == '-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Subtraction;
                        expr.LeftSideOperand = double.Parse(token);
                        leftSideInitialized = true;
                        token = "";
                    }
                    else 
                        token += currentChar;   
                }
                else if (char.IsLetter(currentChar))
                {
                    token+= currentChar;
                    leftSideInitialized = true;
                }
                else if (currentChar == ' ')
                {
                    if (!leftSideInitialized)
                    {
                        expr.LeftSideOperand= double.Parse(token);
                        leftSideInitialized= true;  
                        token = "";
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation= ParseMathOperation(token);
                        token = "";
                    }
                }
                else
                {
                    token+= currentChar;    

                }
            }

            return expr;    
        }

        private static MathOperation ParseMathOperation(string token)
        {
            switch (token.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                     return MathOperation.Sin;
                case "cos":
                     return MathOperation.Cos;
                case "tan":
                     return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }

        }

    }
}
