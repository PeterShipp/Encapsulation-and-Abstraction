using System;

namespace MyEncapsulation
{
    class Program
    {
        public static ClassA classAObject;
        public static ClassB classBObject;

        static public void Main()
        {

            classAObject = new ClassA();
            classBObject = new ClassB();
            classBObject.SeemsHarmless();

            Console.WriteLine(classAObject.state);

            Encapsulation exampleObject = new Encapsulation();
            exampleObject.notProtected = -50;
            //Program Class directly updates the public, unprotected property.

            exampleObject.UpdatePrivateProperty(4);
            //Program class asks Encapsulation ("WithEncap") class to update the protected private property
            //Encapsulation aka "WithEncap" class is "in control"

            Cars myCar = new Cars("Ford", "Mustang", 2, "Red", Cars.DriveTrain.FrontWheel);
            myCar.PaintCar("turkey");
            myCar.PaintCar("black");

            GetSetExample example1 = new GetSetExample("Read me", "Hidden Name", 1);
            GetSetExample example2 = new GetSetExample("Another Read Only", "Hidden Name", 2);

            example1.isProtected = 12;
            //set this to a negative number to throw an validation error.

            //Asking for the pulic objName let's us get the value of the hidden objName
            Console.WriteLine(example2.objName);
            example2.objName = "Update by another class";
            example2.ShowMeInternalName();


            //I can read the value of the pulic variable with Get
            Console.WriteLine(example1.readOnly);
            //example1.readOnly = "Error!"
            //Property cannot be assigned to -- it is read only
            Console.WriteLine(example2.readOnly);
            //This other object has a different value for it's readOnly property.

            Console.WriteLine(GetSetExample.alwaysTheSame);
            //This public constant is always the same for EVERY object of the class.





        }
    }
}
