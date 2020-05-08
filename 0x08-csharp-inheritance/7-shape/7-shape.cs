using System;

///<summary>class</summary>
class Shape {
    ///<summary>class</summary>
    public virtual int Area() => throw new NotImplementedException("Area() is not implemented");
}

class Rectangle: Shape {
    private int width;
    private int height;

    ///<summary>getter setter</summary>
    public int Width {
        get { return width; }
        set {
            if (value < 0) { throw new ArgumentException("Width must be greater than or equal to 0") ; }
            else { width = value; }
        }
    }
    public int Height {
        get { return height; }
        set {
            if (value < 0) { throw new ArgumentException("Height must be greater than or equal to 0") ; }
            else { height = value; }
        }
    }
    public override string ToString() {
        string str = "[Rectangle] " + width + " / " + height;
        return str;
    }
}
