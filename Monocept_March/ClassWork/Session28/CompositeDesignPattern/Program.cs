using CompositeDesignPattern.Model;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositRoot = new Folder("Movies");
            compositRoot.AddChild(new File("A.avi", 400));
            compositRoot.AddChild(new File("B.avi", 500));

            Folder action = new Folder("Action");
            compositRoot.AddChild(action);
            action.AddChild(new File("B.avi", 700));
            

            Folder drama = new Folder("Drama");
            drama.AddChild(new File("C.avi", 800));
            compositRoot.AddChild(drama);

            compositRoot.Display();
        }
    }
}