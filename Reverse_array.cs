using System;
using System.Collections.Generic;

class Program
{
    static void printR(string[] arry,int size){
        Console.Write("{0} ",arry[size]);
        if(size!=0){
            printR(arry,size-1);
        }
    
    }
    
    static void Main() {
        int sizeOfAry = Convert.ToInt32(Console.ReadLine());
        string [] inps=Console.ReadLine().Split(' ');
    
       printR(inps,sizeOfAry-1);
    }
}

//5
//2 19 8 15 4
