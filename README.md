# SimpleMathExpressionEvaluator
This project is a simple C# console application that allows the user to enter a math expression like:  
3 + 5
10 * 2
sin 30

The program parses the input expression to extract the numbers and the mathematical operation, then evaluates the result and displays it.

---

## Project Idea

The program reads the input string (math expression) from the user, then analyzes it to identify the left operand, the operation (such as addition or multiplication), and the right operand or function argument. After parsing, it performs the calculation and shows the output.

Supported operations include:

- Addition (+)  
- Subtraction (-)  
- Multiplication (*)  
- Division (/)  
- Modulus (%)  
- Power (^ or pow)  
- Trigonometric functions:  
  - Sine (sin)  
  - Cosine (cos)  
  - Tangent (tan)  

---

## Program Features

1. The program accepts expressions with or without spaces, and will handle them correctly.  
   Examples:  
   - `5+3`  
   - `5 + 3`  
   - `sin 30`  

2. The program displays details of the parsed expression:  
   - Left operand  
   - Operation  
   - Right operand  
   - Then it shows the final evaluated result.

---

## Project Goal

This project is designed to teach fundamental C# concepts such as:

- String parsing  
- Using enums to represent operations  
- Performing math calculations programmatically  
- Building simple interactive console applications

