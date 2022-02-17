using System;

class Shape{
    public virtual int Area(){
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape {
    private int width;
    private int height;
    public int Width{
        get { return this.width; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }
    public int Height{
        get { return this.height; }
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }

	public new int Area() => this.height * this.width;

    public override string ToString() => $"[Rectangle] {width} / {height}";
}

class Square: Rectangle{
    private int size;
    public int Size{
        get { return this.size; }
        set {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            this.size = value;
            this.Width = value;
            this.Height = value;
        }
    }
}
