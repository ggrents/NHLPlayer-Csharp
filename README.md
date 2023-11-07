# NHL Player Management System

## Описание проекта

Этот проект представляет собой систему управления хоккейными игроками (NHL). Он реализует различные паттерны проектирования для обеспечения гибкости, расширяемости и поддержки различных функциональностей.

## Паттерны проектирования

### Singleton Pattern

-В проекте используется паттерн Singleton для обеспечения единственной точки подключения к базе данных. 
-Класс `DatabaseConnection` реализует синглтон, создавая экземпляр при первой инициализации и предоставляя глобальный доступ.

### Strategy Pattern

Паттерн Strategy используется для обработки различных типов хоккейных игроков. Классы `Forward`, `Defense` и `ForwardDefense` реализуют общий интерфейс `IHockeyPlayer` и предоставляют гибкость в выборе позиции игрока.

### Decorator Pattern

Decorator Pattern используется для добавления дополнительных характеристик игрока. Например, у игрока может быть щит, лук и дополнительные характеристики. Декораторы обеспечивают стековое поведение при добавлении новых характеристик.

### Adapter Pattern

Адаптер применяется для обеспечения взаимодействия с различными видами языка (например, греческим и римским). В проекте адаптер используется для преобразования запросов от греческого объекта к римскому, обеспечивая совместимость.

### Factory Pattern

Проект использует Simple Factory Pattern для создания различных типов хоккейных игроков. Фабрика, реализованная в `SoldierFactory`, управляет производством солдат различных типов на основе входных параметров.

### Observer Pattern

Паттерн Observer используется для отслеживания изменений в наличии товаров. Клиенты могут подписываться на оповещения о доступности товара, и они будут уведомлены, когда товар снова станет доступным.

## Структура проекта

