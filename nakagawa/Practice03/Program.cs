//コンソールアプリケーションで以下を満たすものを作ってください

//int型で以下の要素の入った配列を作成(配列1: 1,2,3,4,5)
//int型で以下の要素の入った配列を作成(配列2: 6,7,8,9,10)
//配列1と配列2の各要素を合計した数を新しい配列(配列3)を作って、そこに代入					
//配列3を作成したら、配列の中身を出力(for文を使うこと)

var firstList = new List<int> { 1, 2, 3, 4, 5 };
var secondList = new List<int> { 6, 7, 8, 9, 10 };


firstList.ForEach((item) => Console.Write(item + " "));
Console.WriteLine("");
secondList.ForEach((item) => Console.Write(item + " "));
Console.WriteLine("");

for(int i = 0; i < firstList.Count; i++)
{
    int sum = firstList[i] + secondList[i];
    Console.Write(sum + " ");
}
