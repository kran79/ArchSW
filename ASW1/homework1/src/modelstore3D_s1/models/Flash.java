package modelstore3D_s1.models;

public class Flash {

    //TODO: Доработать - ДЗ / Ниже что сделал /

    private Point3D location;
    private Angle3D angle;
    private String color;
    private float power;

    public Flash(Point3D location, Angle3D angle, String color, float power) {
        this.location = location;
        this.angle = angle;
        this.color = color;
        this.power = power;

    }

    public void rotate(Angle3D angle) {

    }
    public void move(Point3D point) {
        this.location = point;
    }
}
