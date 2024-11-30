using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class ComposerPattern
    {
        public Node ComposePineTree()
        {
            Node result = new Node {name = "Ель", value = "3" };
            result.AddLeft("Ель2", "2");
            result.AddRight("Ель3", "2");
            result.leftNode.AddLeft("Ель4", "1");
            result.leftNode.AddRight("Ель5", "1");
            result.rightNode.AddLeft("Ель6", "1");
            result.rightNode.AddRight("Ель7", "1");
            return result;
        }
        public Node ComposePalmTree()
        {
            Node result = new Node { name = "Пальма", value = "3" };
            Node current = result;
            for (int i = 0; i < 3; i++) 
            {
                current.AddLeft(i.ToString(), i.ToString());
                current = current.leftNode;
            }
            return result;
        }
    }
    public class Node
    {
        public Node leftNode;
        public Node rightNode;
        public string name;
        public string value;

        public void AddLeft(string name, string value) 
        {
            this.leftNode = new Node { name = name, value = value };
        }
        public void AddRight(string name, string value) 
        {
            this.rightNode = new Node { name = name, value = value};
        }
    }
}
