**Программа из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.**

Для удобства пользователя - ввод элементов массива через строку в консоли.

Применяются 3 функции на цикле for:

1. _GetArrayLength_ - определяет размер выходного массива. На входе строка из консоли, преобразуется в массив строк. Счетчик определяет количество элементов с размером < 4, т.е. размер выходного массива. 
2. _GetArray_ - формирует выходной массив строк. На входе функции строка из консоли ( преобразуется в массив строк) и размер выходного массива. Для компенсации сдвига выходного массива относительного входного вводится переменная j.
3. _PrintArray_ - выводит выходной массив строк в консоль. 