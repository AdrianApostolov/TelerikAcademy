## Data Structures, Algorithms and Complexity

1. What is the expected running time of the following C# code? Explain why. Assume the array's size is n.

    ```c#
        long Compute(int[] arr)
        {
            long count = 0;
        
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0, end = arr.Length - 1;
        
                while (start < end)
                {
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }
        
            return count;
        }   
    ``` 
        
    ### Algorithm Complexity: 
    * Approximately `O(N * (N - 1))`
    
    ### Explanation:
    * For each iteration of for-loop `(from 0 to N)`, while-loop will be executed exactly `N - 1` times. 

2. What is the expected running time of the following C# code? Assume the input matrix has size of `n` * `m`. Explain why.

    ```c#
        long CalcCount(int[,] matrix)
        {
            long count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] > 0)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    ``` 
        
    ### Algorithm Complexity: 
    * Average case (random numbers in 1st column): approximately `O((N / 2) * M)`
    * Best case (only odd numbers in 1st column): N executions of the outer loop, the inner loop won't be executed at all ⇛ approximately `O(N)`
    * Worst case (only even numbers in 1st column): N executions of the outer loop → M executions of the inner loop for each execution of the outer loop ⇛ approximately `О(N * M)`
   
3. \* What is the expected running time of the following C# code?  Assume the input matrix has size of `n` * `m`. Explain why.

    ```c#
        long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[row, col];
            }

            if (row + 1 < matrix.GetLength(1))
            {
                sum += this.CalcSum(matrix, row + 1);
            }

            return sum;
        }

        Console.WriteLine(CalcSum(matrix, 0));
    ``` 
        
    ### Algorithm Complexity: 
    * Approximately `O(N * M)` ⇛ with remark → `O(N ^ 2) because N = M`