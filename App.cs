using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ConsoleApps.TrainingApps.MathExpressionEvaluator
{
    public static class App
    {



        public static void Run(string[] args)
        {
          while(true)
            {
                Console.Write("Please Enter Math Expression: ");
                var input=Console.ReadLine();   
                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"Left Side = {expr.LeftSideOperand}, Operation = {expr.Operation}, Right Side = {expr.RightSideOperand}");    
                Console.WriteLine($"{input} = {EvaluateExpression(expr)}");
            }
        }


        private static object EvaluateExpression(MathExpression expr)
        {
            switch (expr.Operation)
            {
                case MathOperation.Addition:
                    return expr.LeftSideOperand + expr.RightSideOperand;
                case MathOperation.Subtraction:
                    return expr.LeftSideOperand - expr.RightSideOperand;
                case MathOperation.Multiplication:
                    return expr.LeftSideOperand * expr.RightSideOperand;
                case MathOperation.Division:
                    return expr.LeftSideOperand / expr.RightSideOperand;
                case MathOperation.Modulus:
                    return expr.LeftSideOperand % expr.RightSideOperand;
                case MathOperation.Power:
                    return Math.Pow(expr.LeftSideOperand, expr.RightSideOperand);
                case MathOperation.Sin:
                    return Math.Sin(expr.RightSideOperand);
                case MathOperation.Cos:
                    return Math.Cos(expr.RightSideOperand);
                case MathOperation.Tan:
                    return Math.Tan(expr.RightSideOperand);
                default:return 0;
            }
        }
    }
}
