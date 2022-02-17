using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj){
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        var properties = myObj.GetType().GetProperties();
        foreach(var property in properties){
            Console.WriteLine(property.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        var methods = myObj.GetType().GetMethods();
        foreach(var method in methods){
            Console.WriteLine(method.Name);
        }
    }
}
