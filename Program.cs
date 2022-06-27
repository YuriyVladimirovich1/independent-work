/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = b9 -> (-0,5; 5,5) */
 

void PrintArray(int[,] matr) {       //метод печатает массив с нулевыми значениями
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++) {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintTable1(int[,] coordTable, int k1, int b1) {                      //метод для 1-й прямой. рисует таблицу со значениями X,Y
    int xi = -2; int xj = -2;                                              //устанавливаем начальные значения X
    for (int i = 0; i < coordTable.GetLength(0); i++) {                    //перебираем строки i
        for (int j = 0; j < coordTable.GetLength(1); j++) {                //перебираем столбцы j
            if (i == 1 & j > 2 & j % 2 != 0) {                             //если условия по расположению индекса ячейки в двумерном массиве выполняются
                coordTable[i, j] = xi++;                                   //тогда в каждую следующую ячейку, подходящую под условие, записываем значение X + 1
                    if (coordTable[i, j] >= 0 & coordTable[i, j] < 10) {   //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали внутри ячейки
                        Console.Write(" " + coordTable[i, j] + " ");
                    } else if (coordTable[i, j] < 0 & coordTable[i, j] > -10) {
                        Console.Write(coordTable[i, j] + " ");
                    } else if (coordTable[i, j] >= 10 & coordTable[i, j] < 100) {
                        Console.Write(" " + coordTable[i, j]);
                    } else {
                        Console.Write(coordTable[i, j]);
                    }
            }
            else if (i == 3 & j > 2 & j % 2 != 0) {
                coordTable[i, j] = k1 * xj++ + b1;                    
                    if (coordTable[i, j] >= 0 & coordTable[i, j] < 10) {   //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали внутри ячейки
                        Console.Write(" " + coordTable[i, j] + " ");
                    } else if (coordTable[i, j] < 0 & coordTable[i, j] > -10) {
                        Console.Write(coordTable[i, j] + " ");
                    } else if (coordTable[i, j] >= 10 & coordTable[i, j] < 100) {
                        Console.Write(" " + coordTable[i, j]);
                    } else {
                        Console.Write(coordTable[i, j]);
                    }
            }
            //рисуем каркас таблицы координат на базе двумерного массива
            else if (i == 1 & j == 1) Console.Write(" X ");
            else if (i == 3 & j == 1) Console.Write(" Y ");
            else if (i == 0 & j == 0) Console.Write("┌");
            else if (i == 4 & j == 0) Console.Write("└");
            else if (i == 0 & j == coordTable.GetLength(1) - 1) Console.Write("┐");
            else if (i == 4 & j == coordTable.GetLength(1) - 1) Console.Write("┘");
            else if (i == 2 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┼");
            else if (i == 2 & j == 0) Console.Write("├");
            else if (i == 2 & j == coordTable.GetLength(1) - 1) Console.Write("┤");
            else if (i == 0 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┬");
            else if (i == 4 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┴");
            else if (i % 2 != 0 & j % 2 == 0) Console.Write("│");
            else Console.Write("───");
        }
        Console.WriteLine();
    }
}

//эта функция копипаст предыдущей. не делайте так
void PrintTable2(int[,] coordTable, int k2, int b2) {                      //метод для 2-й прямой. рисует таблицу со значениями X,Y
    int xi = -2; int xj = -2;                                              //устанавливаем начальные значения X
    for (int i = 0; i < coordTable.GetLength(0); i++) {                    //перебираем строки i
        for (int j = 0; j < coordTable.GetLength(1); j++) {                //перебираем столбцы j
            if (i == 1 & j > 2 & j % 2 != 0) {                             //если условия по расположению индекса ячейки в двумерном массиве выполняются
                coordTable[i, j] = xi++;                                   //тогда в каждую следующую ячейку, подходящую под условие, записываем значение X + 1
                    if (coordTable[i, j] >= 0 & coordTable[i, j] < 10) {   //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали внутри ячейки
                        Console.Write(" " + coordTable[i, j] + " ");
                    } else if (coordTable[i, j] < 0 & coordTable[i, j] > -10) {
                        Console.Write(coordTable[i, j] + " ");
                    } else if (coordTable[i, j] >= 10 & coordTable[i, j] < 100) {
                        Console.Write(" " + coordTable[i, j]);
                    } else {
                        Console.Write(coordTable[i, j]);
                    }
            }
            else if (i == 3 & j > 2 & j % 2 != 0) {
                coordTable[i, j] = k2 * xj++ + b2;
                    if (coordTable[i, j] >= 0 & coordTable[i, j] < 10) {   //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали внутри ячейки
                        Console.Write(" " + coordTable[i, j] + " ");
                    } else if (coordTable[i, j] < 0 & coordTable[i, j] > -10) {
                        Console.Write(coordTable[i, j] + " ");
                    } else if (coordTable[i, j] >= 10 & coordTable[i, j] < 100) {
                        Console.Write(" " + coordTable[i, j]);
                    } else {
                        Console.Write(coordTable[i, j]);
                    }
            }
            //рисуем каркас таблицы координат на базе двумерного массива
            else if (i == 1 & j == 1) Console.Write(" X ");
            else if (i == 3 & j == 1) Console.Write(" Y ");
            else if (i == 0 & j == 0) Console.Write("┌");
            else if (i == 4 & j == 0) Console.Write("└");
            else if (i == 0 & j == coordTable.GetLength(1) - 1) Console.Write("┐");
            else if (i == 4 & j == coordTable.GetLength(1) - 1) Console.Write("┘");
            else if (i == 2 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┼");
            else if (i == 2 & j == 0) Console.Write("├");
            else if (i == 2 & j == coordTable.GetLength(1) - 1) Console.Write("┤");
            else if (i == 0 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┬");
            else if (i == 4 & j != 0 & j % 2 == 0 & j < coordTable.GetLength(1) - 1) Console.Write("┴");
            else if (i % 2 != 0 & j % 2 == 0) Console.Write("│");
            else Console.Write("───");
        }
        Console.WriteLine();
    }
}

double[,] cross = new double[,]      //используется иной метод отображения каркаса таблицы
{
    { 3, 0, 10,  0,  0,  5 },
    {12, 1, 12, -1, 13, 12 },
    { 8, 0,  7,  0,  0,  9 },
    {12, 2, 12, -2, 13, 12 },
    { 4, 0, 11,  0,  0,  6 },
    };

void PrintCrossTable(double[,] CrossTable, int k1, int b1, int k2, int b2) {   //метод вычисляет точку пересечения двух прямых. рисует таблицу со значением X,Y. 
    for (int i = 0; i < CrossTable.GetLength(0); i++) {                                      //перебираем строки i
        for (int j = 0; j < CrossTable.GetLength(1); j++) {                                  //перебираем столбцы j
            if (CrossTable[i, j] == -1) {                                                    //если значение элемента массива равно -1
                CrossTable[i, j] = Math.Round((double)(b2 - b1) / (k1 - k2), 1);             //вычисляем X и записываем его вместо -1
                    if (CrossTable[i, j] >= 0 & CrossTable[i, j] < 10) {                     //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали
                        Console.Write("  " + CrossTable[i, j] + " ");
                    } else if (CrossTable[i, j] < 0 || CrossTable[i, j] >= 10 & CrossTable[i, j] < 100) {
                        Console.Write(" " + CrossTable[i, j] + " ");
                    } else {
                        Console.Write(CrossTable[i, j]);
                    }
                }
            else if (CrossTable[i, j] == -2) {
                CrossTable[i, j] = Math.Round((double)(k1 * b2 - k2 * b1) / (k1 - k2), 1);   //вычисляем Y и записываем его вместо -2
                    if (CrossTable[i, j] >= 0 & CrossTable[i, j] < 10) {                     //добавлем пробелы слева и/или справа к числу для выравнения его по горизонтали
                        Console.Write("  " + CrossTable[i, j] + " ");
                    } else if (CrossTable[i, j] < 0 & CrossTable[i, j] > -10 || CrossTable[i, j] >= 10 & CrossTable[i, j] < 100) {
                        Console.Write(" " + CrossTable[i, j] + " ");
                    } else {
                        Console.Write(CrossTable[i, j]);
                    }
                }
            else if (CrossTable[i,j] == 0) Console.Write("───");
            else if (CrossTable[i,j] == 1) Console.Write(" X ");
            else if (CrossTable[i,j] == 2) Console.Write(" Y ");
            else if (CrossTable[i,j] == 3) Console.Write("┌");
            else if (CrossTable[i,j] == 4) Console.Write("└");
            else if (CrossTable[i,j] == 5) Console.Write("┐");
            else if (CrossTable[i,j] == 6) Console.Write("┘");
            else if (CrossTable[i,j] == 7) Console.Write("┼");
            else if (CrossTable[i,j] == 8) Console.Write("├");
            else if (CrossTable[i,j] == 9) Console.Write("┤");
            else if (CrossTable[i,j] == 10) Console.Write("┬");
            else if (CrossTable[i,j] == 11) Console.Write("┴");
            else if (CrossTable[i,j] == 12) Console.Write("│");
            else Console.Write("");
        }
        Console.WriteLine();
    }
}

void PrintCoord(int[,] coord, int k1, int b1, int k2, int b2) {                 //метод печатает систему координат, точки обоих прямых и точку их пересечения
    for (int i = 0; i < coord.GetLength(0); i++) {                              //перебираем строки i
        for (int j = 0; j < coord.GetLength(1); j++) {                          //перебираем столбцы j
            for (int x = -2; x < 3; x++) {                                      //перебираем значения X [-2;2] в счетчике для обоих прямых
                if (i == (coord.GetLength(0) / 2) - 2 * (k1 * x + b1) &         //считаем Y для 1-й прямой и конвертируем систему координат двумерного массива в нужную нам
                    j == (coord.GetLength(1) / 2) + 2 * x) {                    //считаем X для 1-й прямой и конвертируем систему координат двумерного массива в нужную нам
                        Console.Write("\u001B[34m*\u001b[0m");                 //использован код цвета ANSI в .NET синий \u001B[34m для символа "⬤" на выбор "〇 ◯ ●"
                } else if (i == (coord.GetLength(0) / 2) - 2 * (k2 * x + b2) &
                    j == (coord.GetLength(1) / 2) + 2 * x) {
                        Console.Write("\u001B[31m*\u001b[0m");                 //использован код цвета ANSI в .NET красный \u001B[31m для символа "⬤" на выбор "〇 ◯ ●"
                } 
            }
            if (i == (coord.GetLength(0) / 2) - 2 * ((k1 * b2 - k2 * b1) / (k1 - k2)) &
                j == (coord.GetLength(1) / 2) + 2 * (b2 - b1) / (k1 - k2)) {
                    Console.Write("\u001B[32m* \u001b[0m");                     //использован код цвета ANSI в .NET зеленый \u001B[32m для символа "⦿" на выбор "◉ ⊗ ⚫ ⦾"
            }
            //далее рисуется только система координат
            else if (i == coord.GetLength(0) / 2 &       //рисуем ось абсцисс (X)
                j % 2 != 0 &
                j != coord.GetLength(1) / 2 &            //не заполняем X = 0
                j <= coord.GetLength(1) - 2) {
                Console.Write("— ");
            }
            else if (i == coord.GetLength(0) / 2 &       //рисуем деление на оси абсцисс (X)
                j % 2 == 0 &
                j != coord.GetLength(1) / 2 &
                j <= coord.GetLength(1) - 2) {
                Console.Write("| ");
            } 
            else if (i != 0 &                            //рисуем ось ординат (Y)
                i % 2 != 0 &
                j == coord.GetLength(1) / 2) {
                Console.Write("|");
            }                       
            else if (i != 0 & i % 2 == 0 &               //рисуем деления на оси ординат (Y)
                i != coord.GetLength(0) / 2 &            //не заполняем Y = 0
                j == coord.GetLength(1) / 2) {
                Console.Write("—");
            }
            else if (i == coord.GetLength(0) / 2 &       //рисуем "+" на пересечении осей X,Y
                j == coord.GetLength(1) / 2) {
                Console.Write("+ ");
            } 
            else if (i == coord.GetLength(0) / 2 + 1 &   //обозначаем ось абсцисс символом "X"
                j == coord.GetLength(1) - 1) {
                Console.Write(" X");
            }
            else if (i == 0 &                            //обозначаем ось ординат символом "Y"
                j == coord.GetLength(1) / 2 + 1) {
                Console.Write(" Y");
            } 
            else if (i == coord.GetLength(0) / 2 &       //рисуем символ ">"
                j == coord.GetLength(1) - 1) {
                Console.Write(">");
            }
            else if (i == 0 &                            //рисуем символ "^"
                j == coord.GetLength(1) / 2) {
                Console.Write("^");
            } else if (coord[i, j] == 0) {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Введите данные для нахождения точки\u001B[32m ⦿ \u001b[0m пересечения двух прямых.");
Console.WriteLine("\u001B[1mНапример,\u001B[43m b1 = 2, k1 = 5, b2 = 4, k2 = 9 \u001b[0m");
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] arr = new int[5, 13];                   //шаблон двумерного массива для таблицы координат X, Y для 5 значений
//PrintArray(arr);                             //печатает двумерный массив с нулевыми значениями
Console.WriteLine();
Console.WriteLine("\u001B[34mТаблица координат для 1-й прямой: \u001b[0m");    //использован код цвета ANSI в .NET синий \u001B[34m
PrintTable1(arr, k1, b1);                      //печатает таблицу координат для 1-й прямой
Console.WriteLine();
Console.WriteLine("\u001B[31mТаблица координат для 2-й прямой: \u001b[0m");    //использован код цвета ANSI в .NET красный \u001B[31m
PrintTable2(arr, k2, b2);                      //печатает таблицу координат для 2-й прямой
Console.WriteLine();

Console.WriteLine("\u001B[32mТаблица координат точки пересечения двух прямых: \u001b[0m");    //использован код цвета ANSI в .NET зеленый \u001B[32m
PrintCrossTable(cross, k1, b1, k2, b2);        //печатает таблицу координат точки пересечения двух прямых

int[,] array = new int[57, 57];                //шаблон двумерного массива для системы координат. рекомендуемый мин. размер [57, 57], макс. размер [93, 93]
//PrintArray(array);                           //печатает двумерный массив с нулевыми значениями
Console.WriteLine();
PrintCoord(array, k1, b1, k2, b2);             //печатает систему координат и точки прямых
Console.WriteLine();