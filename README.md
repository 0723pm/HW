Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Описание решения:

Объявляется массив A и массив B. 
Далее объявляется метод, в котором содержится цикл, равный длине массива.
Внутри цикла проверяется условия данное в задаче (длина строк массива меньше либо равна 3).
При выполнении условия элемент массива А заносится в count массива В. 
Переменная count служит для перехода элемента из массива А в массив В. 
После присвоения переменная count увеличивается на 1 и возвращается в цикл for, где i увеличивается на 1.
Цикл повторяется до окончания по условию.

Блок схема метода представлена в файле Diagram.png

Реализация задачи расположена в папке Task, файл Program.cs