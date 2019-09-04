SoftUni Judge
Contests 
Feedback
Hello, kiril001!
Log out
Search
EN
BG
Home Submissions 11649763
Solution #11649763 by kiril001 for problem 01. Socks
Zero test #1 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.012 s
Memory used: 11.41 MB
Zero test #2 (Correct answer)
The zero tests are not included in the final result.
Time used: 0.028 s
Memory used: 11.43 MB
Test #1 (Correct answer)
Time used: 0.028 s
Memory used: 11.47 MB
Test #2 (Correct answer)
Time used: 0.028 s
Memory used: 11.47 MB
Test #3 (Correct answer)
Time used: 0.028 s
Memory used: 11.45 MB
Test #4 (Correct answer)
Time used: 0.028 s
Memory used: 11.44 MB
Test #5 (Correct answer)
Time used: 0.028 s
Memory used: 11.47 MB
Test #6 (Correct answer)
Time used: 0.028 s
Memory used: 11.40 MB
Test #7 (Correct answer)
Time used: 0.028 s
Memory used: 11.43 MB
Test #8 (Correct answer)
Time used: 0.043 s
Memory used: 11.44 MB
Test #9 (Correct answer)
Time used: 0.043 s
Memory used: 11.43 MB
Test #10 (Correct answer)
Time used: 0.043 s
Memory used: 11.41 MB
Source code
1
using System;
2
using System.Collections.Generic;
3
using System.Linq;
4
​
5
namespace Socks
6
{
7
    class Program
8
    {
9
        static void Main(string[] args)
10
        {
11
            int[] lefts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
12
            int[] rights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
13
            List<int> pairs = new List<int>();
14
​
15
            Stack<int> leftSocks = new Stack<int>(lefts);
16
            Queue<int> rightSocks = new Queue<int>(rights);
17
​
18
            while (leftSocks.Count!=0 && rightSocks.Count!=0)
19
            {
20
​
21
​
22
​
23
                int left = leftSocks.Peek();
24
                int right = rightSocks.Peek();
25
​
26
                if (left == right)
27
                {
28
                    leftSocks.Pop();
29
                    rightSocks.Dequeue();
30
                    leftSocks.Push(left + 1);
31
                }
32
                else if (left < right)
33
                {
34
                    leftSocks.Pop();
35
                }
36
                else if (left > right)
37
                {
38
                    pairs.Add(left + right);
39
                    leftSocks.Pop();
40
                    rightSocks.Dequeue();
41
                }
42
            }
43
            int highest = pairs.OrderByDescending(x => x).FirstOrDefault();
44
            Console.WriteLine(highest);
45
            Console.WriteLine(string.Join(" ",pairs));
46
        }
47
    }
48
}
49
​
Created on: 21/06/2019 00:37:54

© 2011-2019 - Open Judge System (OJS) 1.5.20150729.95737d0 - running on Windows. Open source project.
