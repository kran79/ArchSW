package modelstore3D_s1.inmemory;

public interface IModelCharger {

    /**
     *  Произошло изменение в хранилище моделей
     */

    void notifyChange();

    void RegisterModelChanger(IModelChargedObserver o);

    void RemoveModelChanger(IModelChargedObserver O);



}
