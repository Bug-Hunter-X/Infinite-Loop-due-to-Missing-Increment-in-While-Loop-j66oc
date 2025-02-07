# Infinite Loop Bug in C#

This repository demonstrates a common coding error in C#: an infinite loop caused by forgetting to increment the loop counter variable.

## The Bug
The `bug.cs` file contains a `while` loop that intends to iterate 10 times. However, the loop counter variable `i` is never incremented, causing the loop to run indefinitely. This can lead to application crashes or freezes.

## The Solution
The `bugSolution.cs` file provides a corrected version of the code. The solution simply involves adding an increment statement (`i++`) within the loop body to ensure that the loop terminates correctly.

## How to Reproduce
1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the code. Observe the infinite loop.
4. Open `bugSolution.cs`. Observe the corrected implementation.
5. Run the corrected code; It will terminate successfully.