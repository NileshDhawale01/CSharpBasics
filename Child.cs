
class Child:Parent{

   // Child:Parent meains chile extend to parent

   internal float salary; 

   internal void SetSallary(float salary){
    this.salary= salary;
   }

   internal void getSalary(){
    Console.WriteLine("salary is {0}",this.salary);
   }
}