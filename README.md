# FinalTask1
# **Итоговая проверочная работа № 1**

## Задача:

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Алгоритм решения:

1. Запрашиваем у пользователя количество строк (элементов массива).
2. Пользователь вводит каждый элемент массива отдельной строкой, нажимая Enter (заполняет исходный массив).
3. Выводим на экран полученный массив из данных от пользователя.
4. Вводим переменную symbols (максимально допустимое количество символов в элементе массива, по условию <= 3).
5. Вводим переменную count (счетчик элементов подходящих под условие).
6. Каждый элемент массива проверяем по условию: длина элемента <= 3. Если условие соблюдено, увеличиваем count на один. Если нет - переходим к проверке следующего элемента исходного массива.
7. Получаем значение count (количество элементов нового  массива).
8. Заполняем новый массив в пределах цикла. Для этого повторно проводим проверку каждого элемента исходного массива, чтобы длина элемента была меньше или равна symbols. Если условие соблюдено, элементу нового массива присваиваем текущее значение элемента исходного массива, если нет - переходим к проверке следующего элемента исходного массива.
9. Выводим полученный новый массив на экран.
