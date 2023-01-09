using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_106
{
    class Program
    {
        /*A node class consi
         * 
         */
        class node
        {
            public string info;
            public node lchild;
            public node rchild;
            //constructor for the node class

            public node(string i, node l, node r)
            {
                info = i;
                lchild = l;
                rchild = r;
            }
        }
    }
}


        
