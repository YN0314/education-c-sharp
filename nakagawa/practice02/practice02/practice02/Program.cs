//int i = 0; を宣言
//iが3の倍数の時にアホになる文を出力してください。
//iの上限が40まで
//上記が終わったら以下もやってみてね
//iに3が含まれる場合もアホになる文を出力してください。

Enumerable.Range(0, 41).ToList().ForEach(i =>
{
    var mod = i % 3;
    var isMultipleOfThree = mod == 0 && i != 0;
    var isContainsThree = i.ToString().Contains('3');
    if (isMultipleOfThree || isContainsThree)
    {
        Console.WriteLine($"{i.ToString("D2")} はアホです");
    }
    else
    {
        Console.WriteLine($"{i.ToString("D2")}");
    }
});
