# RMSTest
Test project written for RMS telephone interview

The test called for a class that would implement the interface:

public interface IGridProductCalculator 
{     
    long LargestProductOfNAdjacentIntegers(int[][] searchGrid, int adjacentIntegers); 
}

This is purportedly to calculate the largest product of n adjacent numbers in a given two-dimensional grid.  

However, as written the inteferface is incorrect c#.  Specifying the parameter searchGrid as int[][] is in fact saying that searchGrid is an array of arrays, which could well be jagged.  Correct c# would be int [,].  This would specify a two-dimensional array, which is what the problem is describing.

It is possible to implement the answer as an array of arrays, and my solution does so, but it does not check that each array in the array has the same size.  Instead, I provided a second function, that used a two-dimensional array properly.

