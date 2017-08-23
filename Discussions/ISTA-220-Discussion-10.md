#### MSSA Cohort 3
#### Course: ISTA-220
#### Lesson Plan: 10
#### Name: Jason Bergener
#### Date: August 23, 2017

1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
    ```csharp
    enum Enlisted
    {
      REC, PVT, PV2, PFC, SPC, CPL = SPC, SGT,
      SSG, SFC, MSG, FSG = MSG, SGM, CSM = SGM
    }
    ```
1. Using the Ranks enum, assign a rank to yourself or a friend.  
`Enlisted Jason = Enlisted.SSG;`
1. Determine the numeric index of particular ranks, using the Ranks enum.  
**The following code `Console.WriteLine((int)Jason);` returns the index integer of 6**
1. How do you select the type of an enum?  
`enum Enlisted : short { REC, ... CSM = SGM}`
1. Are structs stored on the stack or on the heap? What about enums?  
**Structs and enums are both value types and are thus stored on the stack.**
1. Declare a struct named DOD with four branches.  
    ```csharp
    struct DoD
    {
      private string army, airforce, navy, coastguard;
    }
    ```
1. Why can't you create a default constructor for a struct?  
**The reason you can’t declare your own default constructor for a structure is that the compiler always generates one.**
1. What is CIL? What does the CLR do to the CIL?  
**When you compile a C# application, the compiler converts your C# code into a set of instructions using a pseudo-machine code called the Common Intermediate Language (CIL). These are the instructions that are stored in an assembly. When you run a C# application, the CLR takes responsibility for converting the CIL instructions into real machine instructions that the processor on your computer can understand and execute.**