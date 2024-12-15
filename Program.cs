namespace C43_G03_CS02;

class Program
{
    // class Student
    // {
    //     public string Name { get; set; }
    // }
    
    static void Main()
    {

        #region 01

        // int number;
        // Console.WriteLine("Enter number:");
        // number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"The number is {number}");

        #endregion

        #region 02

        // string name = "hello";
        // int number =  int.Parse(name);   // The input string 'hello' was not in a correct format.
        // Console.WriteLine(number);
        
        #endregion
        
        #region 03

        // double number1 = 1.5, number2 = 2.6;
        // Console.WriteLine($"The answer is: {number1 + number2}");  // application executed successfully

        #endregion
        
        #region 04

        // string str = "hello world";
        // string substr = str.Substring(0, 4);
        // Console.WriteLine(substr);

        #endregion

        #region 05

        // int x = 5;
        // int y = x;
        // x = 100;
        // Console.WriteLine($"x = {x} , y = {y}");  // only the changed value will change

        #endregion

        #region 06

        // Student student = new Student {Name = "Adel Saudi"};
        // Student student2 = student;
        //
        // student.Name = "Salem Fathy";
        //
        //
        // Console.WriteLine($"student1: {student.Name}");
        // Console.WriteLine($"student2: {student2.Name}");
        //
        // Console.WriteLine(student.Name == student2.Name);
        
        /*
         * When one of the reference values types value changes the other will change automatically
         * because we assigned the address of the first one to the second        
          */

        #endregion

        #region 07

        // string str1 = "Hello";
        // string str2 = " World";
        // string str = string.Concat(str1,str2);
        // Console.WriteLine(str);
        

        #endregion

        #region 08

        // A value 1 will be assigned to d. 
        // the condition is True and the int representation of true is 1.

        #endregion

        #region 09
        
        // 6 1 
        // we didn't specify the number as float to get the 6.5
        /* Console.WriteLine(13.0 / 2 + " " + 13 % 2); 
        * OR
        * Console.WriteLine((float)13 / 2 + " " + 13 % 2); 
        */
        
        #endregion

        #region 10

       // 7 7

        #endregion


    }
}