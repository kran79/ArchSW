# Урок 18. Семинар: Способы организации передачи данных между компонентами приложения, протоколы и API. REST, gRPC, очереди

_____________________________________________________________________________________________________

Задание:

Урок 18. Семинар: Способы организации передачи данных между компонентами приложения, протоколы и API. REST, gRPC, очереди

Разработать экранные формы интерфейса для заказа ресурсов в облачном сервисе в https://www.figma.com/ или https://app.diagrams.net/.

Разработать полную ERD домена в https://www.dbdesigner.net/.

Дополнить swagger ответами домена (сутевые ответы) о статусе заказа ресурсов (создан, ошибка, нет ответа) и смоделировать ошибки REST «400, 500» типов.

Имплементировать сгенерированный swagger код в приложения студента.


*****************************************************************************************************

Урок 18. Семинар: Способы организации передачи данных между компонентами приложения, протоколы и API. REST, gRPC, очереди

## Введение в API и протоколы
- API (Application Programming Interface) позволяет взаимодействовать модулям приложений и обеспечивает доступ к функциям и данным других систем   .
- Архитектура API реализуется с использованием протоколов и спецификаций, определяющих семантику и синтаксис сообщений   .
- Основные архитектурные стили API: RPC, SOAP, REST, GraphQL и gRPC, каждый из которых имеет свои паттерны обмена данными   .

## Архитектурные стили API
### API
- API описывает способы взаимодействия модулей и может включать описание протоколов и фреймворков    .

### Модель OSI
- OSI (Open Systems Interconnection) — модель, позволяющая различным сетевым устройствам взаимодействовать   .
- Транспортный уровень использует протоколы TCP и UDP для передачи данных    .

### Протокол взаимодействия
- Протоколы, такие как HTTP и FTP, определяют правила обмена данными между сервисами    .
- SOAP — протокол для обмена структурированными сообщениями, использующий XML   .

### REST
- REST (Representational State Transfer) предоставляет данные как ресурсы и использует HTTP-методы для взаимодействия    .
- REST считается более простой альтернативой SOAP и позволяет использовать различные форматы данных    .

### gRPC
- gRPC — это фреймворк для реализации API RPC через HTTP/2 с использованием Protobuf для сериализации данных    .
- gRPC поддерживает двунаправленные потоки и обеспечивает высокую производительность    .

### GraphQL
- GraphQL позволяет клиентам запрашивать только необходимые данные и управлять сложными сущностями    .
- Он использует типизированные схемы и предоставляет гибкие возможности для работы с данными    .

## Стили взаимодействия
### Синхронное взаимодействие
- Клиент отправляет запрос и ожидает ответ от сервиса, что может блокировать выполнение    .

### Асинхронное взаимодействие
- Клиент не ожидает ответа от сервиса, что позволяет выполнять другие операции    .

## Обмен сообщениями
### Брокеры сообщений
- Брокеры обеспечивают асинхронный обмен сообщениями между сервисами, позволяя им взаимодействовать без знания сетевого местоположения друг друга    .
- Примеры брокеров: RabbitMQ, ActiveMQ, Apache Kafka   .

### AMPQ
- AMQP (Advanced Message Queuing Protocol) — открытый протокол для передачи сообщений между компонентами системы, обеспечивающий маршрутизацию и гарантированную доставку    .