// See https://aka.ms/new-console-template for more information
using SRPLive;

//var fh = new TextFileHandler();
//fh.Filename = "Test.txt";
//var txt = fh.Load();

//IOutputList screen = new ScreenOutput();
//screen.Print(txt.Contents);

//fh.Save(txt);

var bridge = new TextBridge(new TextFileHandler(), new ScreenOutput());
bridge.Print("Test.txt");
