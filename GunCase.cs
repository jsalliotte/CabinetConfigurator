using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;
using SldWorks;
class GunCase
{


    public void Main()
    {

        ModelDoc2 swModel;
        SldWorks.SldWorks swApp = new SldWorks.SldWorks();
        swModel = swApp.OpenDoc6("X:\\2.00 CLIENT PROJECTS\\DISPLAY SMART\\5' Display Case\\Actual\\DST-0100.sldasm", (int)swDocumentTypes_e.swDocASSEMBLY, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 1, 1);
        swApp.Visible = true;


        Dimension myDimension = default(Dimension);
      
        myDimension = (Dimension)swModel.Parameter("D1@OverallLength");
        
        string end = "";

        while (end != "3")
        {
            Console.WriteLine("Enter Length");
            float length = Convert.ToSingle(Console.ReadLine());

            myDimension.SystemValue = length / 39.37;
          
            swModel.ForceRebuild3(true);
            Console.WriteLine("Enter E to exit or C to enter new dimensions");
            end = Console.ReadLine();
            if (end == "E")
            {
                break;
            }
        }

        Console.ReadLine();

    }

}
