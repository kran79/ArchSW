package modelstore3D_s1.inmemory;

import modelstore3D_s1.models.Camera;
import modelstore3D_s1.models.Flash;
import modelstore3D_s1.models.PoligonalModel;
import modelstore3D_s1.models.Scene;

import java.util.ArrayList;
import java.util.List;

public class ModelStore implements IModelCharger {

    private List<IModelChargedObserver> observers = new ArrayList<>();

    private List<PoligonalModel> models = new ArrayList<>();

    private List<Flash> flashes = new ArrayList<>();

    private List<Scene> scenes = new ArrayList<>();

    private List<Camera> cameras = new ArrayList<>();

    public void add(PoligonalModel model){
        models.add(model);
        notifyChange();
    }
    
    public Scene getScene(int id); {
        int id;
        return scenes.get(id);
    }

    @Override
    public void notifyChange() {
        for (IModelChargedObserver observer : observers){
            observer.applyupdatemodel();
        }

    }

    @Override
    public void RegisterModelChanger(IModelChargedObserver o) {
        observers.add(o);
    }

    @Override
    public void RemoveModelChanger(IModelChargedObserver o) {
    observers.remove(o);
    }

}
