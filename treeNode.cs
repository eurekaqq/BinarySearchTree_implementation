using Exception = System.Exception;


namespace treeNode {
    class treeNode<T> {
        private T _data;
        private treeNode<T> _left = null;
        private treeNode<T> _right = null;
        public T data {
            get {
                try {
                    return _data;
                }
                catch (Exception) {
                    throw new Exception("null");
                }
            }
            set {
                _data = value;
            }
        }

        public treeNode<T> left {
            get {
                return _left;
            }
            set {
                _left = value;
            }
        }
        public treeNode<T> right {
            get {
                return _right;
            }
            set {
                _right = value;
            }
        }

        public treeNode() : this(default(T)) {

        }

        public treeNode(T data) {
            this.data = data;
        }
    }
}
