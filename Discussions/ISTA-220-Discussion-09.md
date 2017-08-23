#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 09
#### Name: Jason Bergener
#### Date: August 21, 2017

1. What is the difference between deep copy and shallow copy?  
**Deep and shallow copy is in reference to using an object's clone method to create a distinct copy of the object. When an object being cloned contains fields that are reference types, if the referenced types have a clone method this is considered a deep copy. If the referenced type does not have a clone method, then only the references are copied and this is considered a shallow copy.**
1. What is the value of a reference after you declare and initialize it?  
**The value of a reference type after it has been declared and initialized is a memory address.**
1. How do you declare a value type?  
**You declare a value type by providing the type and a variable name.**
1. How do you declare a reference type?  
**You declare a reference type by providing the type and a variable name.**
1. Does C# allow you to assign NULL to a value type?  
**By default, C# does not allow you to assign NULL to a value type. However, C# defines the ? modifier that you can use to declare that a variable is a nullable value type. For example: `int? i = null;`.**
1. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?  
**You cannot assign a nullable value type to a non-nullable variable of the same type because a nullable value type might contain null and the non-nullable variable cannot contain null.**
1. What is the difference between the stack and the heap?  
**Stack memory is organized like a stack of boxes piled on top of one another. When a method is called, each parameter is put in a box that is placed on top of the stack. Each local variable is likewise assigned a box, and these are placed on top of the boxes already on the stack. When a method finishes, you can think of the boxes being removed from the stack. Heap memory is like a large pile of boxes strewn around a room rather than stacked neatly on top of one another. Each box has a label indicating whether it is in use. When a new object is created, the runtime searches for an empty box and allocates it to the object. The reference to the object is stored in a local variable on the stack. The runtime keeps track of the number of references to each box. (Remember that two variables can refer to the same object.) When the last reference disappears, the runtime marks the box as not in use, and at some point in the future it will empty the box and make it available.**
1. What does it mean when we say that all classes are specialized types?  
**Types refer to how the stored data is interpreted by the computer. The binary code equivalent of the double 65 is not the same as the binary code equivalent for the integer 65. Although String is considered a primitive type, it is actually a class System.String. All classes are specialized types of the System.Object class and they all store data in a unique way.**
1. What does ref do?  
**If you prefix a parameter with the ref keyword, the C# compiler generates code that passes a reference to the actual argument rather than a copy of the argument.**
1. What does out do?  
**The out keyword is syntactically similar to the ref keyword. You can prefix a parameter with the out keyword so that the parameter becomes an alias for the argument. As when using ref, anything you do to the parameter, you also do to the original argument. When you pass an out parameter to a method, the method must assign a value to it before it finishes or returns. The key difference between ref and out are that ref variables must be initialized before they are passed as arguments and out variables do not need to be because they must be assigned a value in the method.**
1. Describe boxing and unboxing in your own words.  
**Boxing is assigning a the value from a value type to a field in an object. Unboxing is assigning the value from the field of an object to a value type. This is useful for passing data as method arguments because a value type argument will create a local copy that has no affect on the original, whereas an object is a reference type and the reference is passed as the argument so that all actions inside the method affect the original object.**
1. What does cast do?  
**Cast is an operation that checks whether converting an item of one type to another is safe before actually making the copy. You prefix the object variable with the name of the type in parentheses.**