namespace SortMachine.Sorts;

public class SelectionSort : ISortAlgorithm
{
    public void Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minNumIndex = -1;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (minNumIndex == -1 ? numbers[i] > numbers[j] : numbers[minNumIndex] > numbers[j])
                {
                    minNumIndex = j;
                }
            }
            if (minNumIndex != -1)
            {
                (numbers[i], numbers[minNumIndex]) = (numbers[minNumIndex], numbers[i]);
            }
        }
    }
}