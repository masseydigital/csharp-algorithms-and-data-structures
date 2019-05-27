# C# Algorithms and Data Structures
This is a learning repository for the Udemy course Algorithms and Data Structures in C#: Complete Tutorial.

## Abstract Data Type vs. Data Structure
An abstract data type is a general term used to describe how data is organized and what operations can be performed on that data.

Data structures are the concrete implementations of a specific abstract data type.  For example, a _stack_ is a term used to 
describe an abstract data type which holds a list of values and can perform push, pop, and peek operations.  The Data Structure for 
how the data is stored and how those functions perform are what turns it into a data structure.

##Primitive Data Types
Primitive data types are the building blocks of larger data structures.  They consist of basic data types such as int, string, etc.

## Algorithm
An algorithm is defined as a computational procedure which has an input and an output.  An algorithm is correct for any input that produces a correct output.  They are often defined in psudeo-code and consumed by concrete programming languages.

To be complete, an algorithm includes:
* description of a correct input
* full description of the computation steps
* description of the correct output

## Time Complexity 
Most common operations:
* Accessing an element either directly or through a search process
* Adding an element; i.e. to the end or beginning
* Update an element
* Remove an element 

Array Time Complexity Table
![Image]("https://github.com/masseydigital/csharp-algorithms-and-data-structures/res/Array Time Complexity Table.PNG")

## Algorithm Analysis
To infer growth of running time depending on the input size as a plot.  Large number require the use of log-log plots.  Input sizes are on the x-axis and running time is on the y-axis. 99% of the time we do not care of smaller terms compared to the larger terms.  We can trim smaller terms due to the nature of large inputs weighting more heavily on larger terms, i.e. N^3 has a much larger impact than N as input size grows larger.

We care mainly about two major factors: 
* Cost of executing each statement in a given program : rely heavily on external factors such as OS, execution environment, etc.  In today's computing environment this is not as prevelant.
* Frequency of execution of each statement in a given program : this has a larger impact on performance.

Order of growth falls into the following from largest to smallest:
Type | Notation | Example
---- | -------- | -------
Exponential | 2<sup>n</sup> | Time complexity of breaking a password
Cubic | N<sup>3</sup> | Three nested loops
Quadratic | N<sup>2</sup> | Two nested loops
Linearithmic | N log N | Commonly seen with divide and conquer approaches
Linear | N | Single loops
Logarithmic | log N | Binary search trees
Constant | 1 | Operations such as addition and subtraction

## Big-O Notation (Asymptotic Notation)
Depending on the input, an algorithm can demonstrate the best, worst, and average cases.  We generally want to know the worst case running scenario to establish the minimal running time a program will spend performing an algorithm.

