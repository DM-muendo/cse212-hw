using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf (double number, int length)
    {
        // TODO Problem 1 Start
           // Create an array with size length.
    // Use a loop from index 0 to length - 1.
    // For each index, compute the next multiple as number * (index + 1).
    // Store that computed value in the array at the current index.
    // Return the filled array.
    // Example: if number is 4 and length is 5, the array should be {4, 8, 12, 16, 20}.

// 1. initialize an array of doubles with the specified length
        double[] multiples = new double[length];

// 2. loop through each index from 0 to length - 1
        for (int i = 0; i < length; i++)

// 3. compute the multiple (1st index becomes multiple 1, 2nd becomes multiple 2, etc.)
        {
            multiples[i] = number * (i + 1);
        }
// 4. return the filled array
        return multiples;        
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Determine which items from the end of data need to move to the front.
        // Save the last amount of items temporarily.
        // Shift the remaining items to make room at the front.
        // Place the saved items into the first positions.
        // Modify data directly because this function does not return a new list.
        // Example: if data is {1,2,3,4,5,6,7,8,9} and amount is 3, the result should be {7,8,9,1,2,3,4,5,6}.

        if (data == null || data.Count <= 1 || amount <= 0 || amount >= data.Count)
        {
            return;
        }

        amount %= data.Count;
        if (amount == 0)
        {
            return;
        }

        int splitIndex = data.Count - amount;
        List<int> temp = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, temp);
    }
}
