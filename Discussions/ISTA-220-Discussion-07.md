#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 07
#### Name: Jason Bergener
#### Date: August 16, 2017

1.	What is a class? According to the book, what does a class ”arrange?"  
**A class systematically arranges information and behavior into a meaningful entity.**
1.	What are the two purposes of encapsulation?  
**The two purposes of encapsulation are:**  
    - **To combine methods and data within a class; in other words, to support classification.**  
    - **To control the accessibility of the methods and data; in other words, to control the use of the class.**
1.	How do you instantiate an instance of a class? How do you access that instance?  
**To instantiate an instance of a class, you create a variable specifying the class as its type, and then you initialize the variable with some valid data. For example, `Homework h;` declares the variable h with Homework as its type. `h = new Homework();` initializes a new instance of Homework and assigns it to the variable h. You access the instance by calling the variable it is assigned to (h in this example).**
1.	What is the default access of the fields and methods of a class? How do you change the default?  
**By default, the fields and methods of a class are private and inaccessible to code outside the class, but you can use the public keyword to expose fields and methods to the outside world.**
1.	What is the syntax for writing a constructor?  
**The syntax for writing a constructor is a public method that does not return a value (not even void) and has the same name as the class. For example, the constructor with no parameters for the Homework class would look like: `public Homework()`**
1.	What is the difference between class fields and methods, and instance fields and methods? How do you create class fields and methods?  
**Class fields and methods provide a useful function that is independent of any specific class instance. If you declare a method or a field as static, you can call the method or access the field by using the name of the class. No instance is required.**
1.	How do you bring a static class in scope? Why would you want to bring a static class in scope?  
**Static using statements enable you to bring a class into scope and omit the class name when accessing static members. They operate in much the same way as ordinary using statements that bring namespaces into scope. This could be helpful if static methods from a specific class are called often throughout the code (like Math.Sqrt or Math.PI)**
1.	Can you think of a good reason to create an anonymous class? What is it?  
**An anonymous class is a class that does not have a name. Anonymous classes can be useful when using query expressions.**
1.	What is polymorphism as this term is used in computer science? This is not in the book.  
**Polymorphism is often referred to as the third pillar of object-oriented programming, after encapsulation and inheritance. Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:**
    1. **At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this occurs, the object's declared type is no longer identical to its run-time type.**
    1. **Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method. Thus in your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.**
1.	What is message passing as this term is used in computer science? This is not in the book.  
**In computer science, message passing sends a message to a process (which may be an actor or object) and relies on the process and the supporting infrastructure to select and invoke the actual code to run. Message passing differs from conventional programming where a process, subroutine, or function is directly invoked by name.**
1.	What was the first object-oriented programming language?  
**Simula 67 (1967) was the first programming language designed that had the notion of objects, classes, inheritance, etc. in it. Smalltalk (1970s), influenced by Simula 67, was the first programming language designed with the actual idea of "object-oriented programming" in mind.**
1. Consider this quote by Alexander Stepanov:
    > I find OOP technically unsound. It attempts to decompose the world in terms of interfaces that vary on a single type. To deal with the real problems you need multisorted algebras - families of interfaces that span multiple types. I find OOP philosophically unsound. It claims that everything is an object. Even if it is true it is not very interesting - saying that everything is an object is saying nothing at all.

    Who is Alexander Stephanov?  
**Alexander Stephanov is a Russian computer programmer, best known as an advocate of generic programming and as the primary designer and implementer of the C++ Standard Template Library, which he started to develop around 1992 while employed at HP Labs. He had earlier been working for Bell Labs close to Andrew Koenig and tried to convince Bjarne Stroustrup to introduce something like Ada generics in C++. He is credited with the notion of concept.**  
   What do you think about this quote?  
**While this quote may have been true about OOP back when it was new, OOP has come a long way and includes implementation of interfaces that span multiple types. Adding specificity to data groups is only a problem with limited resources (which was a big problem back then). But now, the phone in my pocket has an Adreno 540 GPU capable of 567 GFLOPS, which is more powerful than any supercomputer in the world prior to 1997. After reading some of his responses to other questions in the interview this quote comes from, I get the feeling that Stephanov is an elitist. He refers to OOP as uninteresting and technically unsound, but doesn't take into consideration how much easier it is to implement than generic programming. This might not make for interesting code, but it enables developers that fall short of his mathematical expertise to develop simple solutions to complex problems.**  
![Haters](https://tenor.com/view/haters-hatersgonnahate-gonna-hate-taylor-gif-5239136.gif)
