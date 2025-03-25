package modelstore3D_s1.models;

import java.util.List;

public class Scene {

    //TODO: Доработать - ДЗ / Ниже что сделал /

    private int id;
    private List<PoligonalModel> models;
    private List<Flash> flashes;
    private List<Camera> cameras;

    public Scene(int id, List<PoligonalModel> models, List<Flash> flashes, List<Camera> cameras) {
        this.id = id;
        this.models = models;
        this.flashes = flashes;
        this.cameras = cameras;
    }

    public List<PoligonalModel> getModels() {
        return models;
    }

    public List<Flash> getFlashes() {
        return flashes;
    }

    public List<Camera> getCameras() {
        return cameras;
    }

}
