class Coordinator {
    private string name;
    private float x, y;
    public Coordinator() {
        this.name = "Cartesian";
        this.x = 0;
        this.y = 0;
    } 
    public Coordinator(string coordinate_name, float x_value, float y_value) {
        this.name = coordinate_name;
        this.x = x_value;
        this.y = y_value;
    }
    public void setName(string coordinate_name) {
        this.name = coordinate_name;
    }
    public void setX(int x_value) {
        this.x = x_value;
    }

    public void setY(int y_value) {
        this.y = y_value;
    }

    public string getName() {
        return this.name;
    }
    public float getX() {
        return this.x;
    }
    public float getY() {
        return this.y;
    }
    public string toString() {
        return $"{this.name}( {this.x}, {this.y})";
    }
}