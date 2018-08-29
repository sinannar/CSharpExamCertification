

namespace Chapter4.Obj5
{
    public static class Listing_4_083
    {
        public static void RunMain()
        {

        }

        public interface IList<T> : ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            T this[int index] { get; set; }
            int IndexOf(T item);
            void Insert(int index, T item);
            void RemoveAt(int index);
        }
        public interface ICollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            int Count { get; }
            bool IsReadOnly { get; }
            void Add(T item);
            void Clear();
            bool Contains(T item);
            void CopyTo(T[] array, int arrayIndex);
            bool Remove(T item);
        }
    }
}