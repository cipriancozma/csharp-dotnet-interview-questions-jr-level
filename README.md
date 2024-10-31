# csharp-dotnet-interview-questions-jr-level
C# .NET Essential Interview Questions (Junior Level)

## 1. What is the Common Intermediate Language?

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

## 2. What is the Common Language Runtime (CLR)?

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

## 3. What is the difference between C# and .NET?

C# is a programming language and .NET is a framework that supports applications written in C# as well as in other .NET compatible languages.

- C# is a programming language. Nothing more. You can develop a C# compiler that will translate the .cs file into a binary code that can be run at any platform without using .NET. 
- .NET is a framework that enables running of applications written in C# and other languages compatible with it. 

So, what's the role of C#?

It provides the execution environment called Common Language Runtime which is responsible for things like processing the Intermediate Language, managing the memory, providing error handling and more.

It provides also a set of standard libraries (which can be found in the System namespace).

#### 3.1. What is the difference between .NET and .NET Framework?

.NET is a succesor of .NET Framework. .NET was originally named .NET Core and it was renamed to .NET since version 5.0

----

## 4. What is the difference between value types and reference types?

|  | Value Types   | Reference Types    |
|   :---:   | :---:                  |  :---:                       |
|  | Inherit from System.ValueType   | Inherit from System.Object   |
|  | Passed by copy   | Passed by reference   |
|  | On assignment, a variable of a value type is copied   | For reference types, only a reference is copied   |
|  | Value Types are stored on the stack  | Reference Types are stored on the heap   |

The fundamental difference is that the a reference type variable holds a reference to the actual data, while the value type variable holds the actual data.

Value Types are stored on the stack whereas reference types are stored on the heap (only the reference itself is stored on the stack)

The value of the value type variable is cleaned out from the stack when the code execution leaves the scope this variable lived in. 

For reference types it is not the case, the object addressed by the reference will be cleaned up by the Garbage Collector and the exact time of that is unknown.

#### 4.1. What will happen if you pass an integer to a method and you increase it by one in the method's body? Will the variable you passed to the method be incremented?

The number will be increased in the scope of the method's body, but the variable outside this method will stay unmodified.

#### 4.2. Assuming you want the modification to the integer parameter to affect the variable that was passed to a method, how would you achieve that?

By using ref parameter.

----

## 5. What is boxing and unboxing?

Boxing is the process of wrapping a value type into an instance of a type System.Object. Unboxing is the opposite, the process of converting the boxed value back to a value type.

When the value is boxed, it is wrapped inside an instance of the System.Object class and stored on the heap.

As we know, value types are stored on the stack while reference types are stored on the heap. Only the reference itself (an adress or pointer to the object stored on the heap) is stored on the stack. 

```
int number = 5;

string word = "abc";
```

In this situation the following data is stored in the memory:

On the stack - the value of number (5) as an integer is a value type and the reference to the word variable stored on the heap as string is a reference type

On the heap - the value of the word variable ("abc")

Boxing the value of the number variable:

```
int number = 5;

object boxedNumber = number;
```

A new variable of type object is created. Object is a reference type, so its value is stored on the heap. Let's see the state of the stack and the heap now:

On the stack:

1. The value of number variable (5) as an integer is a value type
2. The reference to the word variable stored on the heap
3. The reference to the boxedNumber variable stored on the heap

On the heap:

1. The value of the word variable ("abc")
2. The value of the boxedNumber variable (5)

Boxing is done implicitly, on the other hand, the unboxing must be done using a cast.

```
int number = 5;
object boxedNumber = number;
int unboxedNumber = (int)boxedNumber;
```

Unboxing unwraps the original value from the object and assigns it to a value type variable.

The unboxing requires the exact type match. The next example will throw an error because integer is not the same as short.

```
// this will throw
// int unboxedShortNumber = (int)boxedShortNumber;

short otherShortNumber = 3;

// this will work fine -  no boxing or unboxing here 
int otherShortNumberCastToInt = (int)otherShortNumber;

```

Boxing and unboxing come with a performance penalty. Boxing requires the creation of a new object and allocating memory on the heap for it. The unboxing requires a cast which is also computationally expensive.

Boxing an Unboxing are necessary for providing an unified type system. 

#### 5.1. What is the penalty for using boxing and unboxing?

The main penalty is performance. Boxing requires a new object that must be created and allocating memory for it. The unboxing requires a cast which is also expensive from the performance point of view.

#### 5.2. Is assigning a string to a variable of type object boxing?

No, because string is not a value type. The point of boxing is to wrap a value type into an object (which is a reference type).

----

## 6. What are the three main types of errors?

1. Compilation Errors - known as syntax errors, reported by the compiler
2. Runtime Errors - thrown during program execution
3. Logical Errors - occuring when the program works without crashing but it does not produce a correct result

#### 6.1. What type of errors do unit tests protect us from?

Both, runtime and logical errors.

#### 6.2. What's the C# mechanism for handling runtime errors?

Exceptions, used to handling runtime errors.

----

## 7. How are exceptions handled in C#?

Exceptions are handled by try-catch-finally blocks. 

Exceptional Situations:

1. System errors, like running out of memory - OutOfMemoryException is thrown

2. Numeric Errors, when trying to increment an int that has the maximum int value assigned, OverflowException is thrown

3. Parsing Errors, trying to parse "hello" to an integer, FormatException is thrown

4. Operation Errors, trying to remove the first element from an empty list,  ArgumentOutOfRangeException is thrown

In C# every exception type derives from class Exception.

<b>Note<b>:

In case of multiple catch blocks, when the exception is thrown it will be caught by the first catch block that handles the matching exception type.

Because of that, we should always write catch blocks from the most specific to the most generic. 

#### 7.1. Is it possible to have multiple catch blocks after a try block?

Yes. You can catch any number of exceptions. It is important to catch the more specific and then the more generic.

#### 7.2. How to ensure some piece of code will be called, even if an exception was thrown?

Using finally block.

#### 7.3. What is the base type for all exceptions in C#?

System.Exception

----

## 8. What are the types of access modifiers in C#?

|  | Access Modifiers   |     |
|   :---:   | :---: |  :---: |
|  |  Public  |  The type or member can be used by any other type from any assembly  |
|  |  Internal | The type or member can be used by any other type from the same assembly it is defined in |
|  |  Protected Internal | Within the same assembly, it works as internal, so it can be used by all other types. Outside this assembly, it works as protected -  it can be used only by types inheriting from this class |
|  |  Protected |  |



---

## Optional

#### The Stack

It tracks method calls and it contains frames which hold parameters, return address and local variables for each method call.

A stack frame is removed when returning from a method. All local variables go out of scope at this point.

If you call too many methods, the stack will fill up completely and .NET throws a StackOverflow exception.

#### The Heap

The new keyword creates objects on the heap. When variables on the stack go out of scope, their coresponding objects on the heap are dereferenced, not destroyed.

#### The Garbage Collector

