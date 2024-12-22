using System;
using arbol_de_busqueda;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Вставка элементов
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(3);
        bst.Insert(7);

        // Проверка наличия элементов
        Console.WriteLine(bst.Contains(10)); // True
        Console.WriteLine(bst.Contains(7));  // True
        Console.WriteLine(bst.Contains(20)); // False
    }
}



