# Урок 20. Семинар: Структура приложения с пользовательским интерфейсом и базой данных (паттерн Repository)
По возможности доработать наш WEB API сервис с использованием шаблона Repository. Добавить 1-2 контроллера, протянуть взаимодействие с БД как мы это выполнили на примере репозитория ClientRepository и контроллера ClientController.


_____________________________________________________________________________________________________

Задание:

Доработка сервиса с использованием шаблона репозитория.


Урок 20. Семинар: Структура приложения с пользовательским интерфейсом и базой данных (паттерн Repository)
Доработать пункты задания Блока 1: a, b, c, d, e, f, g.

Задание.

Инструменты:

https://www.figma.com/
https://app.diagrams.net/
https://www.dbdesigner.net/
https://swagger.io

*****************************************************************************************************
Конспект

Урок 20. Семинар: Структура приложения с пользовательским интерфейсом и базой данных (паттерн Repository)


## Проектирование ПО и ИС
- Проектирование — это процесс определения архитектуры, системных элементов, интерфейсов и других характеристик системы или её части   .
- Требования к системе делятся на функциональные и нефункциональные, что важно для проектирования    .
- Этапы проектирования включают сбор требований, формализацию их в виде ТЗ, и проектирование архитектуры    .

## Подходы к проектированию ПО
### Use Case Driven Approach
- Сценарии использования (Use Cases) являются основой для разработки, определяя поведение системы    .
- Они играют важную роль в требованиях, анализе, проектировании и тестировании   .

### Domain Driven Design (DDD)
- DDD фокусируется на соответствии структуры кода бизнес-области, используя единый язык и ограниченные контексты    .
- В DDD выделяются слои: пользовательский интерфейс, прикладной уровень, слой домена и инфраструктура    .

### Programmer Driven Design
- Этот подход не имеет четкого процесса и может привести к трудностям в поддержке и развитии системы   .

## Подходы к разработке ПО
### Feature Driven Development (FDD)
- FDD — это итеративный процесс, сосредоточенный на предоставлении рабочей функциональности    .

### Behaviour Driven Development (BDD)
- BDD объединяет технические и бизнес-интересы, используя предметно-ориентированный язык для описания поведения системы    .

### Test Driven Development (TDD)
- TDD основывается на написании тестов перед кодом, что способствует созданию чистой архитектуры    .

### Panic Driven Development (PDD)
- PDD фокусируется на решении текущих проблем, что может привести к техническому долгу    .

## Проектирование прикладных приложений
### Чистая архитектура
- Чистая архитектура разделяет бизнес-логику от деталей реализации, улучшая тестируемость и независимость от технологий    .

### Виды архитектур
- Архитектуры могут быть файловыми, клиент-серверными или облачными, каждая из которых имеет свои преимущества и недостатки     .

## Паттерны проектирования приложений
### Паттерны связывания компонент
- API Gateway упрощает взаимодействие между клиентом и микросервисами, но может стать узким местом    .

### Паттерны управления данными
- Каждый сервис должен управлять собственными данными, что позволяет избежать взаимозависимостей    .

### Паттерны управления состоянием приложения
- Внешняя конфигурация и самодиагностика помогают управлять состоянием приложения и его окружением    .

### Паттерны структурирования приложений
- N-уровневая архитектура разделяет приложение на логические слои, что улучшает масштабируемость и устойчивость    .

## Разрушающие изменения API
- Ломающее изменение API может нарушить работу клиентского приложения, например, удаление ресурса или изменение его структуры    .