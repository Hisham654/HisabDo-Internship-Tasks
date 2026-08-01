
using System;
public class ConsoleAppTask{

    public static void helloProgram(){
        Console.WriteLine("Hello, HisabDo. Hello World!!");
    }
    
    public static void Main(string[] args){
    
        helloProgram();

        Console.WriteLine("Day 01 Task:ConsoleApp...\n------------------");
        string name="Ahmed";

        int number=32;
        
        double decimalNumber=3.2;
       
        char SingleCharacter='B';
        
        bool status=true;



        Console.WriteLine("Integer Number: "+number+"\nString Value: "+name+"\nDecimal: "+decimalNumber+"\nSingle Character: "+SingleCharacter+"\nBool Value: "+status+"\n------------------");
        Console.WriteLine("Implementation of Loop...\n Table of 3: \n------------------");
            for(int i=1;i<=10;i++){

                Console.WriteLine(3+" X "+i+" = "+i*3);
            }

        Console.WriteLine("Implementation of If/Else Conditional Statements...\n");    
        Console.WriteLine("Enter Y or N: ");
        char choice=Convert.ToChar(Console.ReadLine());
        if(choice=='Y' || choice=='y'){
            Console.WriteLine("You will have a Good Day!!!");
        }
        else if(choice=='N' || choice=='n'){
            Console.WriteLine("You will have an Amazing Day!!!");
        }
        else{
            Console.WriteLine("You Entered Wrong Letter!!!");
        }

        
        
    }
}