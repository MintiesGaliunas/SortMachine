namespace SortMachine.Sorts;

public class BubbleSort : ISortAlgorithm
{
    public void Sort(int[] numbers)
    {
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                }
            }
        }
    }
}