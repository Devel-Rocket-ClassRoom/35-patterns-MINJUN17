using System;

Console.WriteLine("=== 성적 평가기 ===");
int[] scores = new int[6]
{
    95, 87, 73, 65, 45, 30
};
for(int i =0; i < scores.Length; i++)
{
    if (IsPassingGrade(scores[i]) == true)
    {
        Console.WriteLine($"{scores[i]}점: {GetGrade(scores[i])} ({GetSatus(scores[i])}) - 합격");
    }
    else
    {
        Console.WriteLine($"{scores[i]}점: {GetGrade(scores[i])} ({GetSatus(scores[i])}) - 불합격");
    }
}


string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};
string GetSatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 => "우수",
    >= 70 => "보통",
    >= 40 => "노력 필요",
    _ => "재수강 권장",
};

bool IsPassingGrade(int score) => score switch
{
    >= 60 and <= 100 => true,
    _ => false
};