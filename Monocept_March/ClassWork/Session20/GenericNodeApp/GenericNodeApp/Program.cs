using GenericNodeApp.Model;

namespace GenericNodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var nodeD = new Node<string>();
            var nodeE = new Node<string>();
            var nodeF = new Node<string>();

            nodeD.Data = "Gautam";
            nodeE.Data = "Ravi";
            nodeF.Data = "Vikrant";

            nodeD.Next = nodeE;
            nodeE.Next = nodeF;
            PrintDetails(nodeD);
        }

        private static void CaseStudy1()   
        {
            var nodeA = new Node<int>();
            var nodeB = new Node<int>();
            var nodeC = new Node<int>();

            nodeA.Data = 10;
            nodeB.Data = 20;
            nodeC.Data = 30;

            nodeA.Next = nodeB;
            nodeB.Next = nodeC;

            PrintDetails(nodeA);
        }

        private static void PrintDetails<T>(Node<T> node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node =node.Next;
            }
        }
    }
}