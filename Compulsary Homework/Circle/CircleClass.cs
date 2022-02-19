class Circle {
    Coordinator center;
    float radius;
    public float Perimeter() { return 2 * (float)Math.PI * radius; }
    public float Area() { return (float)Math.PI * radius * radius; }
    public Circle(Coordinator center, float radius)
    {
        setCenter(center);
        setRadius(radius);
    }
    public Circle()
    {
        center = new Coordinator("O", 0, 0);
        radius = 0;
    }
    public Coordinator getCenter() { return center; }
    public float getRadius() { return radius; }
    public void setCenter(Coordinator newCenter) { center = newCenter; }
    public void setRadius(float newRadius) { if (newRadius > 0) radius = newRadius; }

    public override string ToString() { return $"Circle with center {center.toString()} and radius {radius} has perimeter of {Perimeter()} and area of {Area()}."; }
}