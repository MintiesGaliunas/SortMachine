namespace SortMachine.Sorts;

public class BubbleSort: ISortAlgorithm
{
    public void Sort(int[] nums)
    {
        for(int i = nums.Length-1; i > 0; i--){
            for (int j = 0; j < nums.Length -1; j++)
            {
                if(nums[j] > nums[j+1])
                {
                    var save = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = save;
                }
            }
        }
    }
}
