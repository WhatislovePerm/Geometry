# Тестовое задание
## Figure
### Библиотека с классом Фигуры - Figure
#### Поля класса

- Радиус фигуры
    `public double? Radius { get; set; }`
- Стороны фигуры
    `public double?[] Sides { get; set; }`
- Признак того, что фигура является прямоугольным треугольником
    `public bool IsRightTriangle => Sides.Length == 3 && CheckOnPythagoreanTriple() ? true : false;`

- Полупериметр фигуры 
    `public double? HalfMeter`
#### Методы
- Метод вычисления площади фигуры
    `public static double SquareCalc(Figure f)`
- Метод определения признака прямоугольности треугольника
 (Возвращает: True, если треугольник прямоугольный, иначе False)
  `private bool CheckOnPythagoreanTriple()`
#### Конструкторы
- Конструктор круга
    `public Figure(double? radius)`
- Конструктор треугольника
    `public Figure(double?[] sides)`
### Проект с Unit тестами - SquareCalculatorTests
#### Тесты
- Тест на обычный треугольник
    `public void TestSquareCalcTriangle()`
- Тест на прямоугольный треугольник
    `public void TestSquareCalcRightTriangle()`
- Тест на круг
    `public void TestSquareCalcRound()`
### Консольное приложение для вывода - SquareCalculator
### sql.txt - файл с запросом на ответ задачи про продукты и категории
