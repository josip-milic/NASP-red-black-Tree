using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeProject
{
    class RBTreeNode
    {
        public int value;
        public RBTreeNode leftNode = null;
        public RBTreeNode rightNode = null;
        public RBTreeNode parentNode = null;
        public bool isRed;
        public bool isNullLeaf;

        public RBTreeNode(int value, bool isRed)
        {
            this.value = value;
            this.isRed = isRed;
            isNullLeaf = false;
        }



        public override string ToString()
        {
            if (isRed)
            {
                return "[" + value + "]";
            }
            else
            {
                return "(" + value + ")";
            }
        }



    }
}
