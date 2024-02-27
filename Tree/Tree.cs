using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable
namespace Tree
{
    internal class Tree
    {
        public Node? root = null;

        public Tree()
        {
            root = null;
        }

        public void Add( int value)
        {
            
            if(root == null)
            {
                Node newnode = new Node(value);
                root = newnode;
                Console.WriteLine(newnode.data);
            }
            else
            {
                AddRec(root, value);
            }
        }
        private Node AddRec(Node selected, int value)
        {

            if (selected == null) 
            {
                Node newnode = new Node(value);
                selected = newnode;
            } 
            else
            {
                if (value > selected.data)
                {
                    selected =  AddRec(selected.right, value);
                }
                if (value < selected.data)
                {
                    selected =  AddRec(selected.left, value);
                }
            }

            return selected;
        }

        public void InOrder()
        {
            InOrderRec(root);
        }

        public void InOrderRec(Node selected)
        {
            if(selected != null)
            {
                InOrderRec(selected.left);
                Console.WriteLine(selected.data);
                InOrderRec(selected.right);
            }
        }
    }
}
