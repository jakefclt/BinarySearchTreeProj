using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }

            Node temp = root;

            while (true)
            {
                if (data < temp.data)
                {
                    if (temp.linkLeft == null)
                    {
                        temp.linkLeft = node;
                        return;
                    }
                    else
                    {
                        temp = temp.linkLeft;
                    }
                }
                else if (data > temp.data)
                {
                    if (temp.linkRight == null)
                    {
                        temp.linkRight = node;
                        return;
                    }
                    else
                    {
                        temp = temp.linkRight;
                    }
                }
            }
        }
        public void Search(int data)
        {
            //pass data and compare with the root

            Node temp = root;
            while (true)
            {
                if (data == temp.data)
                {
                    Console.WriteLine("Your number " + data + " is found in the tree.");
                    return;
                }

                else if (data < temp.data)
                {
                    if(temp.linkLeft == null)
                    {
                        Console.WriteLine("Your number " + data + " is not found");
                        return;
                    }
                    else
                    {
                        temp = temp.linkLeft;
                    }
                }

                else if (data > temp.data)
                {
                    if (temp.linkRight == null)
                    {
                        Console.WriteLine("Your number " + data + " is not found");
                        return;
                    }
                    else
                    {
                        temp = temp.linkRight;
                    }
                }

            }
                                
        }
    }
}