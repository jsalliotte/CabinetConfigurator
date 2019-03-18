using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;
using SldWorks;
namespace Add3_CSharp.csproj
{
    class Program
    {
        static void Main(string[] args)
        {
            GunCase GunCase = new GunCase();
            BasicBox BasicBox = new BasicBox();

            String fixtureType = "GunCase";

            switch (fixtureType)
            {
                case "GunCase":
                   
                    GunCase.Main();
                    break;
                case "BasicBox":
                   BasicBox.Main();
                    break;
                default:
                    GunCase.Main();
                    break;
            }


           

            
        }
    }

   

}