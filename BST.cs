using GC = System.GC;
using IndexOutOfRangeException = System.IndexOutOfRangeException;
using treeNode;

namespace bst {
    class BST<T> {
        treeNode<T> head;

        public BST(T[] data) {
            addNode(data);
        }

        /// <summary>
        /// Inserts a new node to the tree.
        /// </summary>
        /// <param name="data">new node to insert afters.</param>
        public void addNode(T[] data) {
            treeNode<T>[] temp = new treeNode<T>[data.Length];
            for(int i = 0; i < data.Length; ++i) {
                temp[i] = new treeNode<T>(data[i]);
            }
            for (int i = 0; i < data.Length / 2; ++i) {
                try {
                    temp[i].left = temp[2 * i + 1];
                    temp[i].right = temp[2 * i + 2];
                }
                catch(IndexOutOfRangeException) {
                    break;
                }
            }
            head = temp[0]; 
        }
    }
}
