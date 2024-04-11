using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main() 
    {
        string str = "абобка";
        char[] arr = str.ToCharArray();
        arr[0] = ' ';
        arr[arr.Length - 1] = '.';
        str = new string(arr);
        Console.WriteLine(str);
    }
 
    
        
        
}
