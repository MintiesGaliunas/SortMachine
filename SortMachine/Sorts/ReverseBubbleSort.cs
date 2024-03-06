namespace SortMachine.Sorts;

public class ReverseBubbleSort : ISortAlgorithm
{
    public void Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                }
            }
        }
    }
}