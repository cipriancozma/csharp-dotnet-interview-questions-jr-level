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


