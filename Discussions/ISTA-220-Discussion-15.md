#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 15
#### Name: Jason Bergener
#### Date: August 30, 2017

1. What is an interface as the term is used in object-oriented programming? 
**You can define an interface that includes methods and specify that  classes implement this interface. In this way, an interface is similar to a contract. If a class implements an interface, the interface guarantees that the class contains all the methods specified in the interface.**
1. How do you define an interface?  
**Defining an interface is syntactically similar to defining a class, except that you use the interface keyword instead of the class keyword. For example, `interface IMyInterface`.**
1. Can an interface have variables, fields, or properties?  
**An interface cannot have variables, fields, or properties.**
1. How do you define a method in an interface?  
**Within the interface, you declare methods exactly as in a class or a structure, except that you never specify an access modifier (public, private, or protected). Additionally, the methods in an interface have no implementation; they are simply declarations, and all types that implement the interface must provide their own implementations. Consequently, you replace the method body with a semicolon. For example, `double ReturnsDoubleTakesInt(int i);`.**
1. Can you instantiate an object through an interface? Why or why not?  
**You cannot create an instance of an abstract class or interface. This is because the interface doesn't contain any functionality, only definitions where functionality will be added by classes that implement it.**
1. Using the new keyword, can you declare a reference to an interface?  
**Maybe I misunderstood the previous question, but this seems like it is asking the same thing with different words. You cannot create an instance of an abstract class or interface (which is what you do with the new keyword). However, you can reference an object by using a variable defined as an interface that the object’s class implements. For example:**  
    ```csharp
    MyClass testClass = new MyClass();
    IMyInterface testInterface = testClass;
    ```
1. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?  
**A class can have at most one base class, but it is allowed to implement an unlimited number of interfaces. If a structure or class implements more than one interface, you specify the interfaces as a comma-separated list. If a class also has a base class, the interfaces are listed after the base class.**
1. What does it mean to explicitly implement an interface?  
**To explicitly implement an interface is to include the interface name with the method definition. For example, `double IMyInterface.ReturnsDoubleTakesInt(int i)`. Also, you cannot specify the protection for methods that are part of an explicit interface implementation.**
1. What are the restrictions on interfaces?  
    - **An interface never contains any implementation.**
    - **You’re not allowed to define any fields in an interface, not even static fields. A field is an implementation detail of a class or structure.**
    - **You’re not allowed to define any constructors in an interface. A constructor is also considered to be an implementation detail of a class or structure.**
    - **You’re not allowed to define a destructor in an interface. A destructor contains the statements used to destroy an object instance.**
    - **You cannot specify an access modifier for any method. All methods in an interface are implicitly public.**
    - **You cannot nest any types (such as enumerations, structures, classes, or interfaces) inside an interface.**
    - **An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another interface. Structures and classes contain implementation; if an interface were allowed to inherit from either, it would be inheriting some implementation.**
1. What is the difference between an abstract class and an interface?  
**The differences between an abstract class and an interface are, an abstract class can use access modifiers like private, protected, public, and sealed. An abstract class can also define a method as abstract, virtual, override, or sealed override.**
1. What is an abstract method?  
**An abstract method is similar in principle to a virtual method, except that it does not contain a method body. A derived class must override this method.**
1. What is a sealed class?  
**You can use the sealed keyword to prevent a class from being used as a base class.**
1. What is a sealed method?  
**You can use the sealed keyword to declare that an individual method in an unsealed class is sealed. This means that a derived class cannot override this method. You can seal only a method declared with the override keyword, and you declare the method as sealed override.**