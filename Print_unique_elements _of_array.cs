using System;
using System.Collections.Generic;

class Program
{
    static void Main() {
        int sizeOfAry = Convert.ToInt32(Console.ReadLine());
        string [] inps=Console.ReadLine().Split(' ');
    
        Dictionary<string, int> KeyVals =
            new Dictionary<string, int>();
     
        for(int i=0;i<=sizeOfAry-1;i++){
            if(KeyVals.ContainsKey(inps[i])){
                KeyVals[inps[i]]++;
            }else{
                KeyVals.Add(inps[i], 1);;
            }
        }
        foreach(KeyValuePair<string, int> item in KeyVals){
            if(item.Value==1){
                Console.Write("{0} ",item.Key);
            }
        }
    }
}


//Sample Input 0

//7
//5 4 10 9 21 4 10
//Sample Output 0

//5 9 21
