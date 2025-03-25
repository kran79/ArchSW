package modelstore3D_s1.inmemory;

public class Observer1 implements IModelChargedObserver{
    @Override
    public void applyupdatemodel() {
        System.out.println("Была добавлена новая полигональная модель - observer#1");
    }
}
