namespace SortMachine.Sorts;

public class InsertionSort : ISortAlgorithm
{
    public void Sort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            int rightNumberindex = i;
            for (int j = i - 1; j >= 0; j--)
            {
                if (numbers[j] > numbers[rightNumberindex])
                {
                    int save = numbers[rightNumberindex];
                    numbers[rightNumberindex] = numbers[j];
                    numbers[j] = save;
                    rightNumberindex = j;
                }
            }
        }

        return;
    }
}