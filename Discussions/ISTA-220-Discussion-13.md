#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 13
#### Name: Jason Bergener
#### Date: August 28, 2017

1. How do you define a method that takes an arbitrary number of arguments?  
**Using a params array, you can pass a variable number of arguments to a method. You indicate a params array by using the params keyword as an array parameter modifier when you define the method parameters. For example: `public static int Example(params int[] paramList)`.**   
1. How do you call a method that takes an arbitrary number of arguments?  
**The effect of the params keyword is that it allows you to call the method by using any number of integer arguments without worrying about creating an array. For example: `int ex = Example(int1, int2);`**
1. Why can't you use an array to pass an arbitrary number of arguments to a method?  
**You can't use an array to pass an arbitrary number of arguments to a method that contains a value type params array because when the method is called, the compiler just counts the number of arguments, creates an array of that size, fills the array with the arguments, and then calls the method by passing the single array parameter. If you passed an array as an argument, it would only be considered one argument (the memory address pointer). You can however pass an array if the method is defined with an object type params array.**
1. How many parameters can a method have?  
**Methods can only contain one params array, and it must be the last parameter.**
1. Do parameter arguments have to have the same type?  
**Parameter arguments must be the same type as the defined params array. However, if the params array is an object type, it will wrap value types (boxing) and allow you to use different types.**
1. What is the difference between a method that takes a parameter argument and one that takes optional arguments?  
**A method that takes optional parameters still has a fixed parameter list, and you cannot pass an arbitrary list of arguments. The compiler generates code that inserts the default values onto the stack for any missing arguments before the method runs, and the method is not aware of which of the arguments are provided by the caller and which are compiler-generated defaults. A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value. Furthermore, the method can determine exactly how many arguments the caller provided.**
1. How do you define a method that takes different (and arbitrary) types of arguments?  
**To define a method that takes different and arbitrary types of arguments, you use the object type params array. For example: `public static void Example(params object[] paramList)`**   
