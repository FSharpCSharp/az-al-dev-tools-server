using AnZwDev.ALTools.ALProxy;
using AnZwDev.ALTools.ALSymbols;
using AnZwDev.ALTools.ALSymbols.SymbolReaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZALDevToolsTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            ALExtensionProxy alExtensionProxy = new ALExtensionProxy();
            alExtensionProxy.Load("C:\\vscode\\preview-al\\data\\extensions\\microsoft.al-2.1.99743\\bin");

            //ALPackageSymbolsLibrary lib = new ALPackageSymbolsLibrary(alExtensionProxy,
            //    "C:\\Projects\\Sandboxes\\samplealprojects\\big\\.alpackages\\Microsoft_Application_11.0.20901.0.app");
            //lib.Load(false);

            ALSymbolInfoSyntaxTreeReader s = new ALSymbolInfoSyntaxTreeReader(alExtensionProxy);
            //ALSymbolInformation m = s.ProcessSourceFile("C:\\Projects\\Sandboxes\\ALProject5\\New Page.al");
            ALSymbolInformation m = s.ProcessSourceFile(
             "C:\\Projects\\Sandboxes\\samplealprojects\\big\\ftest\\CodeunitTest01.al");

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
