using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeLibrary;

namespace TreeLibraryUseExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            // создание  дерева:
            Tree<int> tree = new Tree<int>(1);
            Tree<string> tree1 = new Tree<string>("q");

            // добавление детей:
            tree.Add(3);
            tree.Add(5);
            tree.ChildNodes[0].Add(6);
            tree.ChildNodes[0].Add(7);


            //печать дерева
            string str = "";
            tree.ToStr(ref str);
            Console.WriteLine(str);

            tree.Add(2);
            tree.Add(4);
            tree.ChildNodes[2].Add(8);

            str = "";
            tree.ToStr(ref str);
            Console.WriteLine(str);

            //удаление узла
            tree.ChildNodes[0].Remove();

            str = "";
            tree.ToStr(ref str);
            Console.WriteLine(str);

            //удаление только детей
            tree.RemoveAllChildren();

            //-------------------------//
            tree.Add(3);
            tree.Add(5);
            tree.ChildNodes[0].Add(6);
            tree.ChildNodes[0].Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.ChildNodes[2].Add(8);
            //-------------------------//

            // сортировка
            tree.SortNodes(Comparer<Int32>.Create(new Comparison<Int32>((x, y) => x.CompareTo(y))));

            str = "";
            tree.ToStr(ref str);
            Console.WriteLine(str);

            //обходы
            Console.WriteLine("updown");
            tree.ForEach(Tree<int>.WalkType.UpDown, x => Console.WriteLine(x.Value));

            Console.WriteLine("down up");
            tree.ForEach(Tree<int>.WalkType.DownUp, x => Console.WriteLine(x.Value));

            Console.WriteLine("left  right ");
            tree.ForEach(Tree<int>.WalkType.LeftRight, x => Console.WriteLine(x.Value));

            Console.WriteLine("by levels ");
            tree.ForEach(Tree<int>.WalkType.ByLevels, x => Console.WriteLine(x.Value));



            //-----------------исключения--------------------//
            /*
            //"Null nodes are not allowed!"
            Node<int> node1 = new Node<int>();
            node1 = null;
            tree.Add(node1);
           */


            /*
            //-------"Null-value  nodes are not allowed!"--------//
            string s="";
            s = null;
            tree1.Add(s);
            */


            /*
            Tree<string> tree2 = new Tree<string>(null);
            str = "";
            tree2.ToStr(ref str);
            Console.WriteLine(str);
            */

            // Node<string> nodeN = new Node<string>(null);
            //-----------------------------------------------------//

            /*
            // удалить корень
            tree.Remove();
            */


            Console.ReadKey();
        }
    }
}
