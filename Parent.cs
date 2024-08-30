class Parent{

    internal int id;
    internal String name;

    internal void SetIdAndName(int id,String name){
        this.id = id;
        this.name= name;
    }

    internal void getIdAndName(){
        Console.WriteLine("id is {0} and name is {1}",this.id,this.name);
    }
}