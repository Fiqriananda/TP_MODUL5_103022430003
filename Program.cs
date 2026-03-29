// See https://aka.ms/new-console-template for more 
using TP_MODUL5_103022430003;

HaloGeneric h = new HaloGeneric();
h.SapaUser("Fiqri");


string nim = "103022430003";

DataGeneric<string> DataNIM = new DataGeneric<string>(nim);
DataNIM.PrintData();