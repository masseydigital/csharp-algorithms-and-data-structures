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
Insertion sort works similarly to how you would sort cards in your hand. All the elements to the left of the wall are considered sorted with the wall starting to the right of the first element.  We save the initial value being sorted in a new value.  Insertion sort is an in-place, stable algorithm.  It runs in quadratic, O(n<sup>2</sup>) time.  It degrades quickly - if the input is already sorted, the running time will be linear.

#### Recursion
A recursive function is a function that calls itself.  A recursive function has a base case terminates recursive calls chain at the simplest unit of the algorithm. i.e. factorial - multiplication of numbers counting down from n to 1.  Recursive calls are slower due to memory allocation.  The depth of recursion is bound for recursive functions wheereas the iterative version is not.

Example:

```csharp
//Recursive Factorial
private static int RecursiveFactorial(int n){
    if(n==0)
        return 1;
    
    return n * RecursiveFactorial(n-1);
}
```

### Shell Sort
Shell sort is based on Insertion Sort.  Insertion sort runs fast on pre-sorted arrays.  Pre-sort the input and switch to Insertion Sort.  Gap is used for pre-sorting (swapping distant elements).  It starts with a large gap and gradually reduces it.  Once gap = 1, Insertion Sort finishes the sorting process.  Shell sort depends on a concrete gap value.   It 99% of cases can use a universal sequence of gap values. The goal of the gaps is to reduce the number of swaps that Insertion Sort needs to perform.  Shell sort is an in-place algorithm.  It is unstable. The running time is dependent on gap value that is used.  i.e. worst-case O(n^<sup>3/2</sup>) if sequence is (1/2(3<sup>k</sup>)-1).  On average will be O(n<sup>6/5</sup>).

1. Calculate max gap < N/3 where N is length of array.
2. Reduce the gap at the end of each step of the outer loop.

### Merge Sort
Merge sort belongs to the group of divide and conquer sorting solutions.  Two phases: splitting and merging.  Splitting provides an organized way to sequence the merges. Sibling arrays are split arrays with a size of 1.  *Not* an in-place algorithm, uses much memory (depending on n).  Merge sort is stable in the classic implementation.  Merge sort runs in O(nlogn) time complexity (linearithmic).

Steps:
1. Split the array (if array is odd, one will be bigger)
2. Continue splitting until each unit only has 1 elmenet.
3. Merge the array with the lowest value to the left and the larget to the right.
4.  Continue merging with comparisons from both of the arrays.

### Quick Sort
Quick sort is one of the best modern sorting algorithms.  It is another divide and conquer algorithm which is recursive.  Quick sort has 2 iterators i,j and a pivot, P.  Quick-sort is an in-place agorithm.  It runs in O(nlogn) time complexity (linearithmic).  The extremely rare case is that the data is reverse sorted in which it would run in O(n<sup>2</sup>) time complexity.  It is also unstable.

1. Increment J until we find an element that is less than P.
2. Increment I and swap elements i and j.
3. Repeat until j reaches the end of the array.
4. Exchange element P with element i.
5. Split array into two sub-arrays.
**The elements to the left of the pivot will be less that the pivot and the elements to the right will be greater than the pivot.**
6. Replay the algorithm recursively for each new sub-array.

### Lists
Lists are similar to arrays.  They live in the System.Collections.Generic namespace.  They have a bunch of methods that can be used to alter the lists.  Count and capacity are two of these values.  Count lists the number of items in the list, while capacity is the total number of items that can currently be in the list.  This means that the size of the list is dynamic.  Resizing is an expensive operation - that is why each time the list resizes, it doubles.  Removing items from an array does _not_ remove size from the list.  TrimExcess method can be used to decrease memory size.  The sort method sorts by descending values by default.  To sort by other member properties, you can use a lambda expresssion.  List sort calls Array sort internally.  If T is primitive, calls the TrySZSort().  If T is reference type, then check .net core and framework greater than 4.5 then run IntroSort() else run DepthLimitedQuickSort() unless 32 recursion depth, then run HeapSort().  Array.sort on average demonstrate linearithmic growth except in extremely rare cases where it could be quadratic.

List methods provide the following time complexities.

| Type | Complexity | Notes |
| ---- | -------- | -------------------------------------------------- |
| Add | O(1) if enough space, O(N) if not enough | |
| Remove | O(N) | Searching |
| RemoveAt | O(N) | Shifting |
| Reverse | O(N) | |
| ToArray | O(N) | based on Array.Copy |
| Contains, IndexOf, etc. | O(N) | Traversal of N elements |
| Sorting | O(nlogn) | O(n<sup>2</sup>) rare worst case |

### Node Chains
A node serves two functions - 1) the function of the data container.  2) funcion of a pointer.  Connected nodes are called a node chain.

### Linked Lists
Linked lists are abstract data types which contains a reference to the head node, tail node, and supports Add, Remove, Find, and Enumerate.

#### Singly Linked List
_AddFirst_ - Adding a first node makes the head and tail point to the same location.  If adding a second node, shift the previous head node to the tail node and the new node to the head node.  Every time after that, shift the head node to the new node.

_AddLast_ - Adding a first node makes the head and tail point to the same location.  Adding a second node shift the previous node to the head node and the new node to the tail node.  Every addition after that shifts the tail node, and makes the new node the tail node.

**Both these operations are constant**

_RemoveLast_ - shift all the nodes back and make the last node the tail node.
_RemoveFirst_ - Bring all nodes back, making the new first node the head node.

**A drawback of linkedlists is that we cannot access intermediate nodes directly**

#### Doubly Linked List
A doubly linked list helps the problem of linear time complexity for removing items.  It does this by storing a reference to the previous and the next node.  The drawback of a doubly linked list is that is takes up twice as much memory since it holds both a next and previous link to a node.  Doubly linked lists can be circular by connecting the tail node to the head node.  The time complexity is the same as the single lined list, but the RemoveLast method is constant.

.Net BCL provides an implementation of LinkedList.  The .Net linked list is circular interally, but has null on the ends facing the client.

## Searching

### Linear Search
Linear search refers to the traditional for loop approach to searching for items in a collection.  Time complexity is O(N).

### Binary Search
Approaches the searching problem by utilizing divide and conquer.  It requires data to be sorted in order to use.  Takes the element in the middle and compares it to the search value.  If equal, we are done!  If element > value, search the left half; else, search the right half.  The time complexity of binary search is O(n log n).  Once you sort the input, keep it sorted!  As you add new inputs, insert them in the right place.

## Symbol Tables

Fast access to information is a required condition for data transfer nowadays.  _Symbol tables_ allow us to add a value using a key and then retrieve the data using the key.   We also refer to symbol tables as _dictionaries_.  Keys do not need to be integers.  Symbol tables can be devided into _ordered_ and _unordered_ variations.  

They should support the following api: 
1) a default constructor and a constructor which allows a client to pass a custom key comparer.  
2) bool TryGet(TKey key) returns true if a value was found, otherwise false.  
3) Add(TKey, key, TValue, value) inserts a key-value pair into a table. 
4) bool Remove(TKey) explicitly removes a key-value pair. 
5) bool Contains(TKey key) checks if a certain key is presented in a table. 
6) int Count() returns the number of key-value pairs in the table, 
7) IEnumerable<TKey> Keys() returns all the keys from a table.

Symbol tables that are ordered have advantages over unordered symbol tables.  The following api is more efficient when run on ordered symbol tables than unordered symbol tables: 
1) TKey Min() - the least key, 
2) TKey Max() - the greatest key, 
3) void RemoveMin() - remove the least key, 
4) void RemoveMax() - remove the greatest key, 
5) TKey Floor(TKey key) - get the greatest key which is less or equals the requested key.  
6) TKey Ceiling(TKey key) - get the least key which is greater or equals the requested key.  
7) int Rank (TKey key) - counts the number of keys which are less than the requested key.  
8) TKey Select(int k) - searches for a key with a specific rank.  
9) int Range(TKey a, TKey b) - allows to quickly get the number of keys between a and b -> [a..b]

Sequential Search ST Time Complexity
Searching and Inserting (Get and Add operations) - O(N)
Searching - O(N/2)
Doesn't support ordered operations

Binary Search ST Time Complexity 
Searching - O(log N) 
Insertion - O(N)

## Hash Tables
_Hash Functions_ allow to map data of arbitrary size to a fixed size.  In the context of hash tables, we apply hash functions to map keys to indexes at which we insert corresponding data.  Hash functions guaranteed to generate the same output for the same input.  In cryptography, they only map one way, i.e. SHA encryption.

"abcdef"  ----------->   1

| Key | Hash | Value |
| ---- | -------- | -------------------------------------------------- |
| a | 1 | quick |
| b | 3 | brown |
| c | 0 | fox |
| d | 2 | jumps |
| e | 3 | lazy |    **generates a collision for hash, there is already a 3**

Need to solve major problems for hash tables:
1) Find a hashing algorithm which generates different indexes for different keys in such a way that collisions rarely occur
2) Find an algorithm of resolving collisions which will occur anyway

Hash functions significantly depend on the type of key used.  Hashes can be integers, strings, floats, custom value types/structure, custom reference types/classes.  All the types inherit from the object type.  Custom types are based on primitives with override GetHashCode.

Best practices for hash codes:
1) hash codes should never be used outside of the application domain in which they were created
2) string hashes should never be used as key fields in a collection; hash codes are not guaranteed to be stable across applications, versions, app domains.
3) hash codes should never be persisted
4) hash codes should be fast
5) Well distributed across the space of 32-bit integers for the given distribution of inputs
6) Do not use hash codes as a unique key for an object; probabily of collision is extremely high
7) Do not use hash codes for a digital signature or password equivalent

Best practices for GetHashCode:
1) GetHashCode is useful for only one thing: putting an object in a hash table
2) Equal items should have equal hashes
3) The integer returned by GetHashCode must never change while the object is contained in a data structure that depends on the hash code remaining stable (immutable)
4) GetHashCode must never throw an exception and must return

_Collisions_ occur when two keys try to map to the same index.  There are two approaches for resolving collisions (each approach can have different implementations):
1) Separate Chaining: creating a linked list at the index of collision and looping through it for the value
2) Open addressing: finding an open index to place a collision
