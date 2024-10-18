# csharp-dotnet-interview-questions-jr-level
C# .NET Essential Interview Questions (Junior Level)

### 1. What is the Common Intermediate Language?

The Common Intermediate Language is a programming language that all .NET compatible languages like C#, Visual Basic or F# get compiled to.

When the source code is written in .NET compatible languages gets compiled, it is transformed into code written in CIL. When the application is started, the Common Language Runtime's JIT Compiler translates the CIL Code to binary code.

#### 1.1. How is it possible that a C# class can derive from, for instance, an F# class?

It is possible because both those languages are .Net compatible and they get compiled to the Common Intermediate Language.

#### 1.2. Does C# compiler compile C# source code directly to binary code?

No, it is compiled to the Intermediate Language, which is compiled to binary code by the Just In Time compiler in runtime.

#### 1.3. How can you see the CIL code a project got compiled to?

Some tools can decompile a .dll file and read the CIL code. One of those tools is ildasm.

#### 1.4. What is the Just In Time compiler?

Just-In-Time compiler is a feature of the Common Language Runtime (CLR) which translates the Common Intermediate Language code to binary code during the program execution.

----

### 2. What is the Common Language Runtime (CLR)?

The Common Language Runtime is a runtime environment that manages the execution of the .NET applications. 

The CLR stands between the actual operating system and the application. 

The CLR is responsible for many operations essential for any .NET application to work:

- JIT compilation -> the compilation of the Common Intermediate Language to the binary code.
- Memory Management -> CLR allocates the memory needed for every object created within the application. CLR includes also the Garbage Collector which is responsible for releasing and defragmenting the memory.
- Exception handling -> when the exception is thrown, the CLR makes sure the code execution is redirected to the proper catch clause.
- Thread Management -> CLR manages the execution of the multi threaded applications
- Type Safety -> part of the CLR is the Common Type System which defines the standard for all .NET compatible languages. 

#### 2.1. What is the difference between CLR, CLI and CIL?

Common Language Runtime is an implementation of the Common Language Infrastructure. CIL is Common Intermediate Language to which all .NET compatible languages get compiled.

#### 2.2. What is the CTS?

CTS is the Common Type System which is a standardized type system for all .NET compatible languages which makes them interoperable. (e.g. we can have a C# class derived from an F# class)

#### 2.3. Is the CLR the only implementation of the CIL?

No, Anyone can create their implementation of the CIL. (e.g. Mono Runtime)

----

### 3. What is the difference between C# and .NET?

C# is a programming language and .NET is a framework that supports applications written in C# as well as in other .NET compatible languages.

- C# is a programming language. Nothing more. You can develop a C# compiler that will translate the .cs file into a binary code that can be run at any platform without using .NET. 
- .NET is a framework that enables running of applications written in C# and other languages compatible with it. 

So, what's the role of C#?

It provides the execution environment called Common Language Runtime which is responsible for things like processing the Intermediate Language, managing the memory, providing error handling and more.

It provides also a set of standard libraries (which can be found in the System namespace).

#### 3.1. What is the difference between .NET and .NET Framework?

.NET is a succesor of .NET Framework. .NET was originally named .NET Core and it was renamed to .NET since version 5.0

----

