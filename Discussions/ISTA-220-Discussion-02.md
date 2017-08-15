#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 02
#### Name: Jason Bergener
#### Date: August 8, 2017

1. What is a statement?
    - **A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to a user.**
1. What is an identifier?
    - **Identifiers are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.**
1. What is a variable?
    - **A variable is a storage location that holds a value.**
1. Are primitive types and value types the same thing? See page 177.
    - **Most of the primitive types built into C#, such as int, float, double, and char (but not string) are collectively called value types. These types have a fixed size, and when you declare a variable as a value type, the compiler generates code that allocates a block of memory big enough to hold a corresponding value.**
1. How are arithmetic operators and variable types related?
    - **Not all operators are applicable to all data types. The operators that you can use on a value depend on the value’s type. For example, you can use all the arithmetic operators on values of type char, int, long, float, double, or decimal. However, with the exception of the plus operator (+), you can’t use the arithmetic operators on values of type string, and you cannot use any of them with values of type bool.**
1. How do you turn an integer into a string?
    - **Use integer’s ToString method to turn an integer into a string.**
1. How do you turn a string into an integer?
    - **Use integers Parse method (int.Parse()) to turn a string into an integer.**
1. What is the difference between precedence and associativity?
    - **Precedence governs the order in which an expression’s operators are evaluated. Associativity is the direction (left or right) in which the operands of an operator are evaluated.**
1. How are the prefix and postfix increment and decrement operators evaluated differently?
    - **The prefix forms of increment and decrement operate on the variable before the value is returned. The postfix forms of increment and decrement operate on the variable after the value is returned.**
1. What is string interpolation?
    - **The $ symbol at the start of the string indicates that it is an interpolated string and that any expressions between the { and } characters should be evaluated and the result substituted in their place. String interpolation is more efficient than using the + operator.**
1. What does the var keyword do?
    - **The var keyword causes the compiler to deduce the type of the variables from the types of the expressions used to initialize them.**
