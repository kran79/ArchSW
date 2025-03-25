package modelstore3D_s1.models;

public class Camera {

    //TODO: Доработать - ДЗ / Ниже что сделал /

    private Point3D location;
    private Angle3D angle;

    public Camera(Point3D location, Angle3D angle) {
        this.location = location;
        this.angle = angle;
    }

    public void rotate(Angle3D angle) {
        this.angle = angle;
    }

    public void move(Point3D point) {
        this.location = point;
    }

}
