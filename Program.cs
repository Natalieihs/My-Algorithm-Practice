// See https://aka.ms/new-console-template for more information


Console.WriteLine(ReverseString("hello"));

Console.WriteLine(FindMax(new int[] { 1, 3, 4, 5, 6, 99 }));
Console.WriteLine(IsPalindrome("hello"));
// Path: Program.cs

//定义一个反转字符串的方法
static string ReverseString(string s)
{
    //convert string to char array
    char[] arr = s.ToCharArray();
    int left = 0, right = s.Length - 1;
    while (left < right)
    {
        char temp = arr[left];

        arr[left] = arr[right];
        arr[right] = temp;
        right--;
        left++;
    }
    return new String(arr);
}



//寻找数组中的最大元素
static int FindMax(int[] arr)
{
    var max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

//检查是否回文字符串
static bool IsPalindrome(string s)
{
    var arr = s.ToCharArray();
    int left = 0, right = arr.Length - 1;
    while (left < right)
    {
        if (arr[left] != arr[right])
        {
           return false;
        }
        left++;
        right--;
    }
    return true;
}