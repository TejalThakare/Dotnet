namespace HR;


public abstract class shapes{

    public string colour{
        set;get;
    }
    public int width{
        set;get;
    }

    public shapes(){
        this.colour="black";
        this.width=10;
    }

    public shapes(string colour,int width){
        this.colour=colour;
        this.width=width;
    }

    public abstract void draw();

    public override string ToString(){
        return "colour"+this.colour+", width"+this.width;
    }


}