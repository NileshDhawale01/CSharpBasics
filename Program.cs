using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
class Program()
{

    // public -- access outside project
    // internal -- access inside project

    // incapsulation --> making veriable not accessible like private int id;
    // Abtraction --> declare method and give body somewhere else like in interface method declarartion--> in class actual method body
    public static void Main()
    {
        // Console.WriteLine("Multipliaction is {0}",getSimpleMultiplication(100,100));
        DeligateExampleTwoImpl();

    }

    public static int getSimpleMultiplication(int number1, int number2)
    {
        return number1 * number2;
    }

    // ======================================== Data Types
    public static void dataTypesInCSharp()
    {

        // premative
        // non premative

        // stack --> store premative
        // heap --> store non premative

        // boxing --> premative to non premative
        // un boxing --> non premative to premative

        // boxing
        int number = 100;
        Object num = number;
        // un boxing
        int num2 = (int)num;
        Console.WriteLine("num is {0} and num2 is {1}", num, num2);

    }



    // ============================================ Variable
    public static void variablesUnderstanding()
    {

        // type Inference --> compiler detect datatype
        var number = 100;
        Console.WriteLine(number);

        // constant
        const int num = 100;
        // now we can't change num
        // num = 10; // we can't do it
        Console.WriteLine("constant is {0} ", num);

        // Leterals --> Direct values like "string",100 etc
    }

    // ============================================ Operators
    public static void OperatorData()
    {

        // operator --> it is used to perform operation
        // like +,-,*,/,%,>,<


        // types of Operator
        // 1. Unary --> !,++,--
        // 2. Binary --> <,>,+,-
        // 3. Ternary --> 2>1?"stat1":"state2"

    }

    // ======================================= conditional statement
    public static void conditional()
    {

        int age = 10;
        if (age < 18)
        {
            Console.WriteLine("hey your age is less than 18");
        }
        else if (age > 500)
        {
            Console.WriteLine("are you sure!");
        }
        else
        {
            Console.WriteLine("Hey how are you");
        }
    }

    // ========================================== swith statement
    public static void switchStatement()
    {

        int key = 2;
        switch (key)
        {
            case 1:
                {

                    Console.WriteLine("data from case 1");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("data from case 2");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("data from case 3");
                    break;
                }
            default:
                {
                    Console.WriteLine("this is the default case");
                    break;
                }
        }
    }

    // ============================================= OOP
    // method over loading --> More than one method with same name
    public static void MethodTest()
    {
        Console.WriteLine("method one");
    }

    public static void MethodTest(int number)
    {
        Console.WriteLine("method two parameter is " + number);
    }

    // method over riding --> same method from parent class in child class
    // inheritance
    public static void MethodOverRiding()
    {

        Child child = new Child();
        child.SetIdAndName(1, "userOne");
        child.SetSallary(18200);
        child.getIdAndName();
        child.getSalary();
    }

    // ==================================================== Loop
    // it will run code until condition is true
    public static void Loops()
    {
        // type
        // 1 : for
        // 2 : while
        // 3 : do while

        // 1 : for loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("data from for loop {0}", i);
        }

        // 2 : while loop
        int number = 1;
        while (number < 6)
        {
            Console.WriteLine("data from while loop {0}", number);
            number++;
        }

        // 3 : do while loop
        int number2 = 1;
        do
        {
            Console.WriteLine("data from do while loop {0}", number2);
            number2++;
        } while (number2 < 6);

    }

    // ================================================= arrays
    // array is collection of similar type of element
    public static void ArraysConsepts()
    {

        int[] arr = new int[5];
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

        foreach (int a in arr)
        {
            Console.WriteLine(a);
        }

        // 2D array

        int[,] arr2 = new int[3, 3];

        Console.WriteLine("ln -------------> " + arr2.Length);
        // filling array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr2[i, j] = j;
            }
        }
        // printing array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("I is {0} and J is {1} and value is {2}", i, j, arr2[i, j]);
            }
        }
    }

    // Method Access

    public static void MethodAccess()
    {

        Methods methods = new Methods();
        methods.Methodtesting();
    }

    // Exception Handling

    public static void ExceptionHandling()
    {

        int number = 100;
        int number2 = 0;

        try
        {
            int dev = number/number2;
            Console.WriteLine("Division is {0} ", dev);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception Occured ! " + e);
        }

    }

    // ======================================= Collections
    public static void CollectsExample(){

        // 1. Generic --> collection of similar type
        // 2. Non Generic --> collection of any data

        // 2. Non Generic
        // arraylist , hashtable, ShortedList, Stack,Queue

        // hashtable Iteration Object DictionaryEntry

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Hello there");
        arrayList.Add(3.2);
        arrayList.Add("working");

        foreach(Object a in arrayList){
            Console.WriteLine("array list {0} ",a);
        }

        Hashtable hashtable = new Hashtable();
        hashtable.Add(1,"hey");
        hashtable.Add("how","are you");
        hashtable.Add(3,"working");
        hashtable.Remove(3);

// DictionaryEntry
        foreach(DictionaryEntry entry in hashtable){
            Console.WriteLine("Key is {0} and value is {1} ",entry.Key,entry.Value);
        }
    }

// ============================================== File Handling
    public static void FileHandling(){

        // you can learn from internate
    }

    // ========================================= Deligate
    // Deligate is the pointer of function

// Example One start
    public void DeligateThis(){
        Console.WriteLine("Working Deligation");
    }

    public delegate void MyDeligate();
    public static void DeligateExample(){

        Program program = new Program();
        MyDeligate myDeligate = new MyDeligate(program.DeligateThis);

        // call it 
        myDeligate();
    }

    // Example One start End

    // Example Two Start (parameteriesd Method)

    public void DeligationThisTwo(int id,String name){
        Console.WriteLine("Id is {0} and Name is {1}",id,name);
    }

    public delegate void  DeliateOfTwo(int id,String name);

    public static void DeligateExampleTwoImpl(){

        Program program = new Program();
        DeliateOfTwo deliateOfTwo = new DeliateOfTwo(program.DeligationThisTwo);
        deliateOfTwo(1,"user");
    }
    // Example Two End 

}