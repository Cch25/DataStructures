namespace BinarySeachTrees
{
    public interface IBinarySearchTree<T>
    {
        void Traversal(TraverseType tt);
        void Insert(T data);
        void Delete(T data);
        T GetMaxValue();
        T GetMinValue();
    }
}
