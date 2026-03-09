using System;


Console.WriteLine("=== 도형 분류기 ===");
var shape = new Shape[]
{
    new Circle{Radius = 5},
    new Circle{Radius = 15},
    new Rectangle{Width = 4, Height = 6},
    new Rectangle{Width = 5, Height = 5},
    new Square{Side = 7 }
};

Console.WriteLine($"원(반지름: 5): {ClassifyShape(shape[0])}, 넓이: {CalculateArea(shape[0]):f2}");
Console.WriteLine($"원(반지름: 15): {ClassifyShape(shape[1])}, 넓이: {CalculateArea(shape[1]):f2}");
Console.WriteLine($"직사각형(4X6): {ClassifyShape(shape[2])}, 넓이: {CalculateArea(shape[2]):f2}");
Console.WriteLine($"직사각형(5X5): {ClassifyShape(shape[3])}, 넓이: {CalculateArea(shape[3]):f2}");
Console.WriteLine($"정사각형(7): {ClassifyShape(shape[4])}, 넓이: {CalculateArea(shape[4]):f2}");

static double CalculateArea(Shape shape) => shape switch
{
    Circle { Radius: var r } => Math.PI * r * r,
    Rectangle { Width: var w, Height: var h } => w * h,
    Square { Side: var s } => s * s,
    _ => 0
};
static string ClassifyShape(Shape shape) => shape switch
{
    Circle { Radius: >= 10 } => "큰 원",
    Circle { Radius: < 10 } => "작은 원",

    Rectangle { Width: var w, Height: var h } when w == h
        => "정사각형 모양의 직사각형",

    Rectangle => "일반 직사각형",

    Square => "정사각형",

    _ => "알 수 없는 도형"
};
