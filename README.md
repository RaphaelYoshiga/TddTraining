# TDD training 

## TDD Rules

1. You shall not write production code other than to pass a failing test
1. You shall not write more of production code other than necessary to that failing test.
1. You shall not write more of the test than to make it fail for the right reason.

## Exercises

### Fizz Buzz

Write a method that receives an integer and returns the number as a string, but for multiples of three return "Fizz" instead of the number and for the multiples of five return "Buzz". For numbers which are multiples of both three and five return "FizzBuzz".

### Leap year

Write a function that returns true or false depending on whether its input integer is a leap year or not. A leap year is defined as one that is divisible by 4, but is not otherwise divisible by 100 unless it is also divisible by 400. For example, 2001 is a typical common year and 1996 is a typical leap year, whereas 1900 is an atypical common year and 2000 is an atypical leap year.

### Nth - Fibonacci

Write some code to generate the Fibonacci number for the nth position ex: 
int Fibonacci(int position)
First Fibonacci numbers in the sequence are: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

## Exercises 2

### String calculator

1.	Create a simple String calculator with a method int Add(string numbers)
2.	The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
3.	Allow the Add method to handle an unknown amount of numbers
4.	Allow the Add method to handle new lines between numbers (instead of commas).
a.	the following input is ok:  “1\n2,3”  (will equal 6)
b.	the following input is NOT ok:  “1,\n” (not need to prove it - just clarifying)
5.	Support different delimiters
1.	to change a delimiter, the beginning of the string will contain a separate line that looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ . The first line is optional. all existing scenarios should still be supported
2.	Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.if there are multiple negatives, show all of them in the exception message
