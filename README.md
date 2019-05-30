# C# Algorithms and Data Structures
This is a learning repository for the Udemy course Algorithms and Data Structures in C#: Complete Tutorial.

## Abstract Data Type vs. Data Structure
An abstract data type is a general term used to describe how data is organized and what operations can be performed on that data.

Data structures are the concrete implementations of a specific abstract data type.  For example, a _stack_ is a term used to 
describe an abstract data type which holds a list of values and can perform push, pop, and peek operations.  The Data Structure for 
how the data is stored and how those functions perform are what turns it into a data structure.

## Primitive Data Types
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
![Array Complexity](res/ArrayTimeComplexityTable.PNG)

## Algorithm Analysis
To infer growth of running time depending on the input size as a plot.  Large number require the use of log-log plots.  Input sizes are on the x-axis and running time is on the y-axis. 99% of the time we do not care of smaller terms compared to the larger terms.  We can trim smaller terms due to the nature of large inputs weighting more heavily on larger terms, i.e. N^3 has a much larger impact than N as input size grows larger.

We care mainly about two major factors: 
* Cost of executing each statement in a given program : rely heavily on external factors such as OS, execution environment, etc.  In today's computing environment this is not as prevelant.
* Frequency of execution of each statement in a given program : this has a larger impact on performance.

Order of growth falls into the following from largest to smallest:

|Type | Notation | Example |
| ---- | -------- | -------------------------------------------------- |
| Exponential | 2<sup>n</sup> | Time complexity of breaking a password|
| Cubic | N<sup>3</sup> | Three nested loops |
| Quadratic | N<sup>2</sup> | Two nested loops |
| Linearithmic | N log N | Commonly seen with divide and conquer approaches |
| Linear | N | Single loops |
| Logarithmic | log N | Binary search trees |
| Constant | 1 | Operations such as addition and subtraction |

## Big-O Notation (Asymptotic Notation)
Depending on the input, an algorithm can demonstrate the best, worst, and average cases.  We generally want to know the worst case running scenario to establish the minimal running time a program will spend performing an algorithm.

## Sorting

### Bubble Sort
Most likely you will never see the use of bubble sort since it does not have great performance.  Bubble sort works by tracking 3 things the ith elemnent, the i+1th element, and the wall which denotes sorted vs. unsorted.  Each loop of the array will compare the ith and i+1th element and leave the highest number in the correct place to the right.  Bubble sort is an in-place sorting method - this means that no additional storage (except the iterator) is needed for the calculation.  Bubble sort is a _Stable_ algorithm.  Stable means it does not change the relative order of the items - a number with the same value but smaller index will always be placed before the same value with a higher index.  Bubble sort has a quadractic time complexity, O(n<sup>2</sup>).  This means that performance degrades quickly.

### Selection Sort
In selection sort, we select either the largest or smallest value in each pass.  In each pass, we search for the largest value, and store the index of it.  At the end of the pass, we swap the biggest element with the last one.  Selection-sort is an in-place aglorithm.  The algorithm is Unstable.  This algorithm runs in O(n<sup>2</sup>) time complexity.  The algorithm degrades quickly, yet slower than Bubble Sort.

### Insertion Sort
Insertion sort works similarly to how you would sort cards in your hand. All the elements to the left of the wall are considered sorted with the wall starting to the right of the first element.  We save the initial value being sorted in a new value.  