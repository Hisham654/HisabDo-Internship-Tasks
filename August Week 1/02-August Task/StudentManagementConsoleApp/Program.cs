
using System;
using System.Collections.Generic;

public class Student{

        public int StudentId{get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }
        public string Course{ get; set; }
        public int Age{ get; set; }

    public Student(int Id, string name,string mail,string course,int  age){
        StudentId = Id;
        Name = name;
        Email = mail;
        Course = course;
        Age = age;

    }
    public void DisplayStudentDetails(){
        Console.WriteLine("Student Id: "+StudentId);
        Console.WriteLine("Student Name: "+Name);
        Console.WriteLine("Student Email: "+Email);
        Console.WriteLine("Student Course: "+Course);
        Console.WriteLine("Student Age: "+Age);
    }

    
}


public class Program{
    public static void Main(string[] args){
    
    int choice;
    List<Student> studentInfo=new List<Student>();
    Console.WriteLine("Day 02 Task: Student Management Console Application\n-------------------");

    do{
        Console.WriteLine("-------------------\nWhat do you want to do?\n\n1)Add a Student\n2)Display All Students\n3)Search For A Student By ID\n4)Exit\n\nEnter your choice(1-4): ");
        while(!int.TryParse(Console.ReadLine(), out choice)){
            Console.WriteLine("Invalid input. Please enter a valid integer for your choice.");
        }
        switch(choice){
            case 1:
                Console.WriteLine("Enter the Student's ID");
                int id;
                while(!int.TryParse(Console.ReadLine(), out id)){
                    Console.WriteLine("Invalid input. Please enter a valid integer for Student ID.");
                }

                Console.WriteLine("Enter the Student's Name");
                string name=Console.ReadLine();

                Console.WriteLine("Enter the Student's Age");
                int age;
                while(!int.TryParse(Console.ReadLine(), out age)){
                    Console.WriteLine("Invalid input. Please enter a valid integer for Student Age.");
                }

                Console.WriteLine("Enter the Student's Email");
                string mail=Console.ReadLine();
                Console.WriteLine("Enter the Student's Course");
                string course=Console.ReadLine();

                Student newStudent=new Student(id,name,mail,course,age);
                studentInfo.Add(newStudent);
                Console.WriteLine("Student Object Added to the list...");
                break;
            case 2:
                Console.WriteLine("StudentInfo List:-------------------\n");
                foreach(Student st in studentInfo){
                    st.DisplayStudentDetails();
                    Console.WriteLine("\n");
                }
                break;
                
            case 3:
                Console.WriteLine("Enter the the Student's ID to search in the list: ");
                int searchIdinList;
                while(!int.TryParse(Console.ReadLine(), out searchIdinList)){
                    Console.WriteLine("Invalid input. Please enter a valid integer for Student ID.");
                }
                
                bool found = false;
                foreach(Student st in studentInfo){
                    if(st.StudentId == searchIdinList){
                        st.DisplayStudentDetails();
                        Console.WriteLine("\n");
                        found=true;
                        break;

                    }
                    
                }
                if(!found){
                        Console.WriteLine("XXX No student found with the given ID No. in the list XXX\n");
                }

                break;
            
            case 4:
                break;
                
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;


         }
        
    }while(choice!=4);

    Console.WriteLine("Application Exited...\n-------------------");


    }
}