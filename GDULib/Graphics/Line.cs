using Hardware;

namespace HR;

public class Line:shapes,Printer{
    public point startingpoint{
        set;get;
    }

    public point endingpoint{
        set;get;
    }

    public Line():base(){
        this.startingpoint=new startingpoint(0,0);
        this.endingpoint=new endingpoint(0,0);
    }

    public Line(point p1,point p2,string c,int w):base(colour,width){
        this.startingpoint=p1;
        this.endingpoint=p2;
    }

    public override string ToString(){
        return base.Tostring()+"startingpoint"+this.startingpoint+","+"endingpoint"+this.endingpoint;
    }

    public override void draw(){
        Console.WriteLine("drawing line");
        Console.WriteLine(this);
    }

    void Printer.print(){
        Console.WriteLine("printing line");
        Console.WriteLine(this);

    }
}