using System;

Shape[] shapes = new Shape[5]
{
    new Circle{Radius = 5},
    new Circle{Radius = 15},
    new Rectangle{Width = 4, Height = 6},
    new Rectangle{Width = 5, Height = 5},
    new Square{Side = 7 }
};
foreach(var shape in shapes)
{
    Console.WriteLine($"{ClassifyShape(shape)}넓이: {CalculateArea(shape):f2}");
}


static double CalculateArea(Shape shape) => shape switch
{
    Circle { Radius: var radius } => radius * radius * Math.PI,
    Rectangle { Height: var height, Width: var width} => height * width,
    Square { Side: var side} => side * side
};
static string ClassifyShape(Shape shape) => shape switch
{
    Circle { Radius: >= 10 } c => $"원(반지름: {c.Radius}) 큰 원, ",
    Circle { Radius: < 10 } c => $"원(반지름: {c.Radius}) 작은 원, ",
    Rectangle { Height: var h, Width: var w} r when h == w => $"직사각형({w}X{h}) 정사각형 모양의 직사각형, ",
    Rectangle { Height: var h, Width: var w } r => $"직사각형({w}X{h}) 일반 직사각형, ",
    Square { } s => $"정사각형({s.Side}): 정사각형, "
};
