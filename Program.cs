//int[] nums = { 1, 2, 3, 4,5 };

//int one = 0;
//int two = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0) {
//        two++;
//    }
//    else { one++; }
//};

//Console.WriteLine("Не четних чисел "+one+" "+ "Четних чисел "+two);

//Console.WriteLine("==============================");

//int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Console.WriteLine("Enter nums");
//string Input = Console.ReadLine();

//int intInput = int.Parse(Input);


//int col = 0;

//for (int i = 0; i < nums2.Length; i++)
//{
//    if (nums2[i] < intInput) { col++; };
//}

//Console.WriteLine(col);


//Console.WriteLine("==============================");

//using System.Text.RegularExpressions;


//int[] num3  = {7,6,5,3,4,7,6,5,8,7,6,5 };


//string num3str = string.Join("", num3) ;

//Console.WriteLine("enter nums");
//string userInput = Console.ReadLine();


//int count = Regex.Matches(num3str, Regex.Escape(userInput)).Count;

//Console.WriteLine(count);

//Console.WriteLine("==============================");


int[] arr = {7, 2, 3, 4, 5, 6, 3, 4, 6, 4, 6, 4, 6, 4, 6, 33 };
int[] arr2 = { 5, 6, 7, 43, 6, 4, 7, 5, 7,3, 67, 6, 5, 4, 3, 5, 6, 7, };

var comElements = arr.Intersect(arr2).ToArray();

