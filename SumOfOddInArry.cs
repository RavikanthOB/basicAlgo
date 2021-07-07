using System;
class Program
{
    static void Main() {
        int sizeOfAry = Convert.ToInt32(Console.ReadLine());
        string [] inps=Console.ReadLine().Split(' ');
        int sum=0;
        for(int i=0;i<=sizeOfAry-1;i++){
            if(Convert.ToInt32(inps[i])%2!=0){
               sum+=Convert.ToInt32(inps[i]);
            }
        } 
        Console.WriteLine(sum);
    }
}

//Sample Input 0

//6
//5 4 10 9 21 10
//Sample Output 0

//10
