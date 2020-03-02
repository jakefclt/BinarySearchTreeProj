using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T>
    {
        int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
       
    
        public Node root;


        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }

           
            while(node != null)
            {
                if(temp.data > node.data)
                {
                    temp = temp.linkLeft;
                }
                
            }

            
        }
    }
}
