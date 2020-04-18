using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 9);
            Item panel = new Part("Panel", 35);
            Item gizmo = new Assemblies("Gizmo");
            gizmo.AddItem(panel);
            gizmo.AddItem(nut);
            gizmo.AddItem(bolt);
            Item widget = new Assemblies("Widget");
            widget.AddItem(gizmo);
            widget.AddItem(nut);

            Console.WriteLine(widget);
            Console.WriteLine(gizmo);

            Console.Read();
        }
    }
}
