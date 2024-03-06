namespace SortMachine.Sorts;

public class Tree
{
    public int? Value { get; set; }
    public Tree? Left { get; set; }
    public Tree? Right { get; set; }
}

public class HeapSort : ISortAlgorithm
{
    private Tree? _tree;
    private List<int>? _orderedList;

    public void Sort(int[] numbers)
    {
        _tree = new();
        _orderedList = new();
        foreach (var number in numbers)
        {
            FillTree(number, _tree);
        }
        ReadTree(_tree);

        foreach (var (value, i) in _orderedList.Select((value, i) => (value, i)))
        {
            numbers[i] = value;
        }
    }

    private static Tree FillTree(int number, Tree tree)
    {
        if (tree.Value is null)
        {
            tree.Value = number;
        }
        else if (tree.Value > number)
        {
            tree.Left = FillTree
            (number, tree.Left ?? new Tree());
        }
        else if (tree.Value <= number)
        {
            tree.Right = FillTree
            (number, tree.Right ?? new Tree());
        }
        return tree;
    }

    private void ReadTree(Tree tree)
    {
        if (tree.Left != null)
        {
            ReadTree(tree.Left);
        }
        if (tree.Value != null)
        {
            _orderedList?.Add((int)tree.Value);
        }
        if (tree.Right != null)
        {
            ReadTree(tree.Right);
        }
    }
}