 namespace HR;

 public class point{
    public int x{
        set;get;
    }
    public int y{
        set;get;
    }

    public point(){
        this.x=0;
        this.y=0;
    }

    public point(int x,int y){
        this.x=x;
        this.y=y;
    }

    public override string ToString(){
        string str=string.Format("x={0},y={1}",this.x,this.y);
        return str;
    }

 }