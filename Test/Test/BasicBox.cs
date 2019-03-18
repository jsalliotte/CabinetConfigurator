using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;
using SldWorks;
class BasicBox
{


    public void Main()
    {

        ModelDoc2 swModel;
        SldWorks.SldWorks swApp = new SldWorks.SldWorks();
        swModel = swApp.OpenDoc6("C:\\Users\\Jason Salliotte\\Downloads\\Test\\Test.sldasm", (int)swDocumentTypes_e.swDocASSEMBLY, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 1, 1);
        swApp.Visible = true;


        Dimension myDimension = default(Dimension);
        Dimension myDimension2 = default(Dimension);

        myDimension = (Dimension)swModel.Parameter("D1@Sketch1");
        myDimension2 = (Dimension)swModel.Parameter("D2@Sketch1");
        string end = "";
        float metersToInches = 39.37f;

        while (end != "e")
        {

            Console.WriteLine("Enter Length");
            float length = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Width");
            float width = Convert.ToSingle(Console.ReadLine());

            myDimension.SystemValue = length / metersToInches;
            myDimension2.SystemValue = width / metersToInches;

            swModel.ForceRebuild3(true);
            Console.WriteLine("Enter E to exit or Press Any Key to enter new dimensions");
            end = Console.ReadLine().ToLower();


        }

        Console.ReadLine();

    }

}
