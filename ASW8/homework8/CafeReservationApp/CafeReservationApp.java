package CafeReservationApp;

import Model.CafeModel;
import Model.MyTableModel;
import Presenter.CafePresenter;
import View.CafeView;
import View.ConsoleCafeView;


/**
 * Главный класс приложения для бронирования столов в кафе.
 */
public class CafeReservationApp {

  public static void main(String[] args) {
    // Создаем модель, представление и презентер
    CafeModel cafeModel = new CafeModel("Мое Кафе");
    // Добавляем столы в модель
    cafeModel.addTable(new MyTableModel(1));
    cafeModel.addTable(new MyTableModel(2));
    cafeModel.addTable(new MyTableModel(3));
    CafeView cafeView = new ConsoleCafeView();
    CafePresenter cafePresenter = new CafePresenter(cafeModel, cafeView);

    // Устанавливаем презентер для представления
    ((ConsoleCafeView) cafeView).setPresenter(cafePresenter);

    // Запускаем приложение
    cafePresenter.start();
  }
}
