//using System.Linq;
////int num = 10;

////Dictionary<int,string> keyValuePairs
////    = new Dictionary<int,string>();

////keyValuePairs.Add(1, "I");
////keyValuePairs.Add(5, "V");
////keyValuePairs.Add(10, "X");

////keyValuePairs.GetValueOrDefault(10);


//string s = "2aAbcddefda111111113333333";


//Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

//for (int i = 0; i < s.Length; i++)
//{
//    int num = 0;
//    if (!int.TryParse(s[i].ToString(), out num))
//    {
//        if (keyValuePairs.ContainsKey(s[i]))
//        {
//            var res = keyValuePairs[s[i]];
//            keyValuePairs[s[i]] = res + 1;
//        }
//        else
//        {
//            keyValuePairs.Add(s[i], 1);
//        }
//    }
//}


//var val = keyValuePairs.MaxBy(k => k.Value).Key;



//Input: nums = [3, 2, 2, 3], val = 3
//Output: 2, nums = [2, 2, _, _]

//Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
//Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]


//int[] nums = { 3, 2, 2, 3 };
//int val = 3;

//int i = 0;
//foreach (var item in nums)
//{
//    if (item != val)
//    {
//        nums[i++] = item;
//    }
//}
//Console.WriteLine("");


//string[] strs = { "flower", "flow", "flight" };
//Output: "fl"

//Input: strs = ["dog", "racecar", "car"]
//Output: ""

//string lcp = string.Empty;

//var res = "";
//for (int i = 1; i < strs.Length; i++)
//{
//    var check = lcp == string.Empty ? strs[0] : lcp;
//    if (check == string.Empty)
//    {
//        res = "";
//        break;
//    }
//    if (res == "" && i != 1)
//    {
//        Console.WriteLine(res);
//    }
//    lcp = "";
//    res = "";
//    var len = check.Length > strs[i].Length ? strs[i].Length : check.Length;
//    for (int j = 0; j < len; j++)
//    {
//        var st = strs[i][j];

//        if (st == check[j])
//        {
//            lcp += st;
//            res += st;
//        }
//        else
//        {
//            break;
//        }
//    }
//}
//Console.WriteLine(res);


//taking 1 index
//loop through every item with 1st index
//increase 1st index char
//loop through every other item

//string[] strs = { "flower", "flow", "flight" };

//string lcp = string.Empty;

//var s = strs[0][0..6];
//int start = 0;

//for (int j = 1; j < strs.Length; j++)
//{
//    if (strs[0][start] == strs[j][start])
//    {

//    }
//    else
//    {
//        break;
//    }
//    start++;

//}


//Console.WriteLine(strs[0].Substring(0, start));

//int[] bbsrt = { 2, 56, 5, 8 };


//var lng = bbsrt.Length;
//for (int i = 0; i < bbsrt.Length; i++)
//{
//    for (int j = 0; j < lng - 1; j++)
//    {
//        if (bbsrt[j] > bbsrt[j + 1])
//        {
//            int temp = bbsrt[j];
//            bbsrt[j] = bbsrt[j + 1];
//            bbsrt[j + 1] = temp;
//        }
//    }
//    lng--;
//}
//Console.WriteLine(bbsrt);



//ListNode list1 = new ListNode(1,
//    new ListNode
//    {
//        val = 2,
//        next = new ListNode { val = 7, next = null }
//    });

//ListNode list2 = new ListNode(1,
//    new ListNode
//    {
//        val = 3,
//        next = new ListNode { val = 6, next = null }
//    });
//ListNode res = new ListNode();
////var dummyNode = new ListNode();
////var tail = dummyNode;

////var pointer1 = list1;
////var pointer2 = list2;

////while (pointer1 != null && pointer2 != null)
////{
////    if (pointer1.val < pointer2.val)
////    {
////        tail.next = pointer1;
////        pointer1 = pointer1.next;
////    }
////    else
////    {
////        tail.next = pointer2;
////        pointer2 = pointer2.next;
////    }

////    tail = tail.next;
////}

////tail.next = pointer1 ?? pointer2;

////Console.WriteLine(dummyNode.next);



////int[] bbsrt = { 2, 56, 5, 8 };


////var lng = bbsrt.Length;
////for (int i = 0; i < bbsrt.Length; i++)
////{
////    for (int j = 0; j < lng - 1; j++)
////    {
////        if (bbsrt[j] > bbsrt[j + 1])
////        {
////            int temp = bbsrt[j];
////            bbsrt[j] = bbsrt[j + 1];
////            bbsrt[j + 1] = temp;
////        }
////    }
////    lng--;
////}
////Console.WriteLine(bbsrt);


////selection sort

//using System.Linq;

//internal class Program
//{
//    private static async Task Main(string[] args)
//    {
//        int[] SSort = { 8, 5, 2, 6, 9, 3, 1, 4, 0, 7 };


//        int index = 0;
//        int sml = 0;
//        for (int i = 0; i < SSort.Length; i++)
//        {
//            sml = SSort[i];
//            index = i;

//            for (int j = i + 1; j < SSort.Length - 1; j++)
//            {
//                if (SSort[j] < sml)
//                {
//                    sml = SSort[j];
//                    index = j;
//                }
//            }
//            SSort[index] = SSort[i];
//            SSort[i] = sml;

//        }

//        Console.WriteLine(SSort);


//        //int[] nums = { 1, 3, 5, 6 };
//        //int target = 5;

//        //nums.length/2 
//        //if index is > 2


//        //int[] arr = { 8, 5, 2, 6, 9, 3, 1, 4, 0, 7 };
//        //int n = arr.Length;
//        //for (int i = 1; i < n; ++i)
//        //{
//        //    int key = arr[i];
//        //    int j = i - 1;

//        //    while (j >= 0 && arr[j] > key)
//        //    {
//        //        arr[j + 1] = arr[j];
//        //        j = j - 1;
//        //    }
//        //    arr[j + 1] = key;
//        //}


//        int[] arr = { 9, 3, 4, 0, 2, 6, 5, 7, 13, 15 };
//        var re = await mergeSort(arr);
//        Console.WriteLine(re);

//        //var left = arr.Length % 2 == 1 ? arr.Length / 2 + 1 : arr.Length / 2;

//        //var mid = arr.Length / 2;

//        //var lf = arr.Take(arr.Length / 2).ToArray();
//        //var rf = arr.Skip(arr.Length / 2).ToArray();

//        //Console.WriteLine(arr[..mid]);
//        //Console.WriteLine(arr[mid..]);

//        //Console.WriteLine(arr[^1]);
//        //string s = "abcdef";




//        Console.WriteLine();


//async Task<int[]> mergeSort(int[] arr)
//{
//    if (arr.Length == 1)
//    {
//        return arr;
//    }
//    var mid = arr.Length / 2;

//    var left = arr[..mid];
//    var right = arr[mid..];
//    return await merge(await mergeSort(left), await mergeSort(right));

//}

//        async Task<int[]> merge(int[] left, int[] right)
//        {
//            //int[] mrgdArr = new int[left.Length + right.Length];
//            List<int> mrgdArr = new List<int>();
//            int lI = 0;
//            int rI = 0; 
//            while (lI < left.Length && rI < right.Length)
//            {
//                if (left[lI] < right[rI])
//                {
//                    mrgdArr.Add(left[lI]);
//                    lI++;
//                }
//                else
//                {
//                    mrgdArr.Add(right[rI]);
//                    rI++;
//                }
//            }
//            var remL = left[lI..^0];
//            var remR = right[rI..^0];
//            mrgdArr.AddRange(remL);
//            mrgdArr.AddRange(remR);
//            return mrgdArr.ToArray();
//        }
//    }
//}




//ListNode l1 =
//    new ListNode(9, null);


//ListNode l2 = new ListNode(1, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, null))))))))));


//string n1 = string.Empty;
//string n2 = string.Empty;
//while (l1 != null)
//{
//    n1 += l1.val;
//    l1 = l1.next;
//}
//while (l2 != null)
//{
//    n2 += l2.val;
//    l2 = l2.next;
//}


//var v2a = string.Join("", n2.Reverse());
//var v2b = string.Concat(n2.Reverse());

//var v2 = new string(n2.Reverse().ToArray());

//long num1 = long.Parse(string.Concat(n1.Reverse()));
//long num2 = long.Parse(string.Concat(n2.Reverse()));

//string sum = (num1 + num2).ToString();
//int[] res = new int[sum.Length];

//ListNode dn = new ListNode();
//var result = dn;
//for (int i = sum.Length - 1; i >= 0; i--)
//{
//    result.val = (int)Convert.ToInt64(sum[i].ToString());
//    if (i == 0)
//    {
//        result = null;
//    }
//    else
//    {
//        result.next = new ListNode();
//        result = result.next;
//    }
//}



//ListNode l1 =
//    new ListNode(9, null);


//ListNode l2 = new ListNode(1, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, null))))))))));


//Convert

//while (l1 != null)
//{

//}



//string[,] names = { { "sai", "cha", "ran" },
//                    { "ya", "da", "velli"} };

//foreach (string nm in names)
//{
//    Console.WriteLine(nm);
//}


//ListNode l1 =
//    new ListNode(9, null);


//ListNode l2 = new ListNode(1, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, new ListNode(9,
//    new ListNode(9, new ListNode(9, null))))))))));

//int sum = 0;
//var res = new ListNode();
//var hd = res;
//while (l1 != null || l2 != null || sum > 0)
//{
//    if (l1 != null)
//    {
//        sum += l1.val;
//        l1 = l1.next;
//    }

//    if (l2 != null)
//    {
//        sum += l2.val;
//        l2 = l2.next;
//    }

//    res.next = new ListNode(sum % 10);
//    sum = sum / 10;
//    res = res.next;
//}


//int[] nums1 = new int[2] { 1, 2 };
//int[] nums2 = new int[2] { 3, 4 };

//var list = nums1.Concat(nums2).ToList();
//list.Sort();



//bool isEven = list.Count % 2 == 0 ? true : false;

//if (isEven)
//{
//    var ms = list.Count / 2;
//    float a = (list[ms - 1] + list[ms]) / 2f;
//}
//else
//{
//    var a = list[list.Count / 2];
//}


//var dict = new Dictionary<string, string>();

//dict.Add("2", "abc");
//dict.Add("3", "def");

//string inp = "23";
//List<string> list = new List<string>();
//for (int i = 0; i < inp.Length; i++)
//{
//    string val1 = dict.GetValueOrDefault(inp[0].ToString());
//    string val2 = dict.GetValueOrDefault(inp[1].ToString());

//    var s = val1.SelectMany(x => val2.Select(y => list.Add(y.ToString()))).ToList();

//    Console.WriteLine(s);
//}

//int[] values = { 20, 90, 50, 20, 30, 70, 10, 40, 80, 50 };
//var result = from value in values where value <= 40 select value;
//Console.WriteLine(result);


//Func<int, bool> EvenNumber=(i => i % 2 == 1); 
//for (int i = 0; i <= 10; i++) { 
//    if (EvenNumber(i))
//        Console.Write(i.ToString());
//}


// populate a List of sungs var items = new List<string>(); items.Add("aQua");
//var items  = new List<string>();
//items.Add("aQua");

//items.Add("RusT");
//items.Add("yElLow");
//items.Add("rEd");

//// display initial List
//Console.Write("items contains");

//foreach (var item in items) { 
//    Console.Write($" {item}");
//}
//Console.WriteLine(); // output end of line
//var startsWithR = from item in items
//                  let uppercaseString = item.ToUpper()
//                  where uppercaseString.StartsWith("R")
//                  orderby uppercaseString
//                  select uppercaseString;


//// display query results
//Console.Write("results of query starts WithR:"); 
//foreach (var item in startsWithR)
//{
//    Console.Write($" {item}");
//}
//Console.WriteLine(); // output end of line

//items.Add("rUbY"); 
//items.Add("SaFfRon");
////display initial List
//Console.Write("items contains:"); 
//foreach (var item in items)
//{
//    Console.Write($" {item}");
//}
//Console.WriteLine(); // output end of line

//// display updated query results
//Console.Write("results of query startsWithR:");
//foreach (var item in startsWithR)
//{
//    Console.Write($" {item}");
//}
//    Console.WriteLine(); // output end of line

//    Console.ReadKey();

//int num = 1994;


//string[] s1 = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
//string[] s2 = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
//string[] s3 = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
//string[] s4 = { "", "M", "MM", "MMM" };

//string res = s4[num / 1000] + s3[(num % 1000) / 100] + s2[(num % 100) / 10] + s1[(num % 10)];
//// s4[1] + s3[9] + s2[9]+ s1[4]
//// MCMXCIV
//Console.WriteLine(res);
//Console.ReadKey();

//string s = "   fly me   to   the moon  ";
//var res = s.Trim().Split(" ");
//Console.ReadKey();

//int n = 3;
//List<string> list= new List<string>();
//while (true)
//{
//	var s= string.Empty;

//	for (int i = 0; i < n; i++)
//	{

//		s = s + "(";
//	}
//	for (int i = 0; i < s.Length; i++)
//	{
//		if (s[i].ToString() == "(")
//		{
//			s= s + ")";
//		}
//	}
//	list.Add(s);
//    // ((()))

//}

//2 - 2 [(1,1),(2)]
//3 - 3 - [(1,1,1),(2,1),(1,2)]
//4 - 5 -[(1,1,1,1),(2,2),(2,1,1),(1,2,1),(1,1,2)]
//5 - 8



//int[] arr = { 1, -1, 3, 2, -7, -5, 11, 6 };
//int n = arr.Length;
//int left = 0;
//int right = n - 1;

//while (left <= right)
//{
//    if (arr[left] < 0 && arr[right] >= 0)
//    {
//        // Swap arr[left] and arr[right]
//        int temp = arr[left];
//        arr[left] = arr[right];
//        arr[right] = temp;
//        left++;
//        right--;
//    }
//    else if (arr[left] >= 0)
//    {
//        left++;
//    }
//    else
//    {
//        right--;
//    }
//}


//Console.WriteLine("\nRearranged Array 1:");
//Console.WriteLine(string.Join(" ", arr));

//Console.ReadKey();


//int[] qArray = new int[] { 6, 1, 3, 4, 9, 12, 8, 2 };
//quickSort(qArray, 0, qArray.Length - 1);
//for (int i = 0; i < qArray.Length; i++)
//{
//    Console.Write(qArray[i] + " ");
//}

//static void quickSort(int[] arr,int start,int end)
//{
//    if (start < end)
//    {
//        var pivotIndex = partition(arr, start, end);
//        quickSort(arr, start, pivotIndex - 1);
//        quickSort(arr, pivotIndex + 1, end);
//    }
//}

//static int partition(int[] arr, int start, int end)
//{
//    int pivot = arr[end];
//    int i = start - 1, j = start;
//    for (j = start; j <= end; j++)
//    {
//        if (arr[j] < pivot)
//        {
//            i++;
//            swap(arr, i, j);
//        }
//    }
//    i++;
//    swap(arr, i, j - 1);
//    return i;
//}

//static void swap(int[] arr, int i,int j)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}












//int[] qArray = new int[] { 3, 6, 2, 9, 1, 0, 5, 6, 3 };
//quick(qArray, 0, qArray.Length - 1);
//Console.ReadKey();

//static void quick(int[] arr,int start, int end)
//{
//    if (end > start)
//    {
//        //sort with pivot
//        int pivotIndex = partition(arr, start, end);
//        //take left and repeat
//        quick(arr, start, pivotIndex - 1);
//        //take right and repeat
//        quick(arr, pivotIndex + 1, end);

//    }
//}

//static int partition(int[] arr, int start,int end)
//{
//    int pivot = arr[end];
//    int i = start - 1;
//    for(int j = start; j <= end-1;j++)
//    {
//        if (arr[j] < pivot)
//        {
//            i++;
//            swap(arr, i, j);
//        }
//    }
//    swap(arr, i + 1, end);
//    return i + 1;
//}
//static void swap(int[] arr,int i,int j)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}




//int[] mSortArray = new int[] { 2, 5, 1, 6, 3, 7, 9, 4 };

//var res= mSort(mSortArray);
//for (int i = 0; i < res.Length; i++)
//{
//    Console.Write(res[i] + " ");

//}
//Console.ReadKey();
//static int[] mSort(int[] arr)
//{
//    if(arr.Length<=1) return arr;
//    int mid = arr.Length / 2;
//    var leftArray = arr[..mid];
//    var rightArray = arr[mid..];
//    var lres = mSort(leftArray);
//    var rres = mSort(rightArray);
//    return merge(lres, rres);

//}

//static int[] merge(int[] lres,int[] rres)
//{
//    int[] result = new int[lres.Length + rres.Length];
//    int i = 0, j = 0, k = 0;
//    while (i < lres.Length && j < rres.Length)
//    {
//        if (lres[i] < rres[j])
//        {
//            result[k++] = lres[i++];
//        }
//        else
//        {
//            result[k++] = rres[j++];
//        }
//    }
//    while (i < lres.Length)
//    {
//        result[k++] = lres[i++];
//    }
//    while (j < rres.Length)
//    {
//        result[k++] = rres[j++];
//    }
//    return result;
//}

//static void sort(int[] arr)
//{

//}

//int[] arr = { 1, -1, 3, 2, -7, -5, 11, 6 };
//int n = arr.Length;

//Console.WriteLine("Input array:");
//PrintArray(arr);

//RearrangeArray(arr,arr.Length);

//Console.WriteLine("Output array:");
//PrintArray(arr);

//Console.ReadKey();
//static void PrintArray(int[] arr)
//{
//    foreach (var element in arr)
//    {
//        Console.Write(element + " ");
//    }
//    Console.WriteLine();
//}
//static void RearrangeArray(int[] arr, int n)
//{
//    int i = n - 1;
//    int j = n - 1;

//    //{ 1, -1, 3, 2, -7, -5, 11, 6 };
//    while (i >= 0)
//    {
//        if (arr[i] < 0)
//        {

//            j = i;

//        }

//        while (j < n - 1)
//        {
//            if (arr[j + 1] >= 0)
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;

//            }

//            j++;
//        }

//        i--;
//    }
//}


//int[] arr = { 1, -1, 3, 2, -7, -5, 11, 6 };

//int[] arr = new int[] {
//    720, 616, -775, 930, 960, 991, 811, 94, 798, -214, 134, 102, -659, 715, -900, 156, 711, 531, 809, -763, -439, 969, -848, -293, 593, -807, 440, 261, 139, -850, -492, 305, 462, 166, 334, 82, -942, 521, -696, -123, 415, -402, -646, 322, -854, -531, 481, 578, -361, 495, -225, -290, 100, 810, 820, 460, -138, 164, 320, 725, -775, -908, -795, 511, -111, 77, -171, -778, -522, -890, -524, 106, 600, -393, 835, 822, -311, -390, -710, -330, -307, -772, 728, 208, 181, 156, 363, 384, -292, 521, -578, -279, -190, -886, 772, 447, 235, -270, -349, -350, 339, -200, -444, 563, -701, 479, -592, 58, 760, -512, 971, 82, 446, 587, -28, 741, -378, 547, 993, 596, 878, 338, -641, -443, -475, 614, -717, 87, 856, 708, 31, 745, -477, 757, 58, -53, 267, -474, 119, 811, -526, 185, 0, 870, 606, -465, -556, -965, -88, 585, -734, 150, -121, -954, 522, 222, 895, -593, 580, 454, -271, 501, -341, 816, 134, 359, 207, 880, 681, 584, -282, 613, -637, -650, -396, 360, 282, 935, 141, 412, 74, 783, -557, -546, 538, 2, 788, -369, -714, 548, 767, 971, -310, 853, 997, -398, -760, -573, -256, -784, 714, 957, 600, 734, 439, -818, 782, -690, 905, -362, -590, 858, 48, -262, 667, 941, 441, 14, -69, 569, -327, -605, 778, -317, -348, 283, -781, -284, -616, -154, -20, 760, 378, -24, -555, -929, 947, -80, -444, 282, -159, -775, -408, 944, 848, 188, -570, 241, 38, -806, 382, -36, 428, -892, -183, -647, 865, -284, -962, -121, -808, 744, 69, -205, 260, -198, 510, 19, -793, 6, -875, -753, -740, -566, -20, -15, 257, 790, 998, -838, -30, 964, 877, 13, 444, -268, -411, -432, 861, -338, -304, 557, -410, -324, 340, 161, 264, 429, 323, -285, -653, -83, 148, 383, -933, -712, -221, -857, -550, 119, -841, 571, -641, 944, 748, -2, -298, -970, -940, 152, 491, -812, 610, -715, -607, -920, 321, -834, -119, 452, 482, 374, -914, 229, 578, 552, -523, -70, -876, -792, -271, -859, 315, 86, 260, -688, 383, -913, -582, -121, 880, 124, -774, 234, -777, -889, 361, 910, -137, 378, 255, 295, 821, 792, -360, 935, 0, -949, 577, 168, 348, 308, -921, 661, 678, 804, 94
//};


//int n = arr.Length;
//int i = n - 1, j = n - 1;
//while (i >= 0)
//{
//    //if (arr[i] > 0)
//    //{
//    //    i--;
//    //}
//    if (arr[i] < 0)
//    {
//        j = i;
//    }
//    while (j < n - 1)
//    {
//        if (arr[j + 1] > 0)
//        {
//            swap(arr, j, j + 1);
//        }
//        j++;
//    }
//    i--;
//}

//printA(arr);
//static void printA(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}
//Console.ReadKey();

//static void swap(int[] arr,int i,int j)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}

//int[] a = new int[] { 1, 2, 3, 4, 5 };
//int[] b = new int[] { 1, 2, 3 };
//HashSet<int> ints = new HashSet<int>();

//for (int i = 0; i < a.Length; i++)
//{
//    if (!ints.Contains(a[i]))
//    {
//        ints.Add(a[i]);
//    }
//}

//for (int j = 0; j < b.Length; j++)
//{
//    if (!ints.Contains(b[j]))
//    {
//        ints.Add(b[j]);
//    }
//}

//foreach (var item in ints)
//{
//    Console.Write(item + " ");
//}





//int[] arr = { 9, 8, 7, 6, 4, 2, 1, 3 };

//int high = arr.Length-1;


//while (high>0)
//{
//    swap(arr, high, high - 1);
//    high--;
//}

//static void swap(int[] arr,int i,int j)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}
//for (int i = 0; i < arr.Length ; i++)
//{
//    Console.Write(arr[i] + " ");
//}



//int[] arr = { -10 ,-2 ,-3, -4};
//Console.WriteLine(MaxSubArraySum(arr));

//static int MaxSubArraySum(int[] array)
//{
//    int arrayLength = array.Length;
//    int maxSoFar = int.MinValue;
//    int maxEndingHere = 0;

//    for (int i = 0; i < arrayLength; i++)
//    {
//        maxEndingHere = maxEndingHere + array[i];
//        if (maxSoFar < maxEndingHere)
//            maxSoFar = maxEndingHere;

//        if (maxEndingHere < 0)
//            maxEndingHere = 0;
//    }
//    return maxSoFar;
//}



//int K = 3, N = 5;
//int[] arr = { 3, 9, 12, 16, 20 };
//for (int i = 0; i < N; i++)
//{
//    if (arr[i] - K <= 0)
//    {
//        arr[i] = arr[i] + K;
//    }
//    else
//    {
//        arr[i] = arr[i] - K;
//    }
//}
//if(N == 1)
//{
//    //return arr[0];
//}

//int minVal = arr[0];
//int maxVal = arr[0];
//for (int i = 0; i < N; i++)
//{
//    if (arr[i]>maxVal)
//    {
//        maxVal = arr[i];
//    }
//    if (arr[i] < minVal)
//    {
//        minVal = arr[i];
//    }
//}
//int res = maxVal - minVal;
//Console.WriteLine(res);


//int lastVal = arr[arr.Length - 1];
//int firstVal = arr[0];



//int K = 3, N = 5;
//int[] arr = { 3, 9, 12, 16, 20 };

//Array.Sort(arr);

//int small = arr[0] + K;
//int big = arr[N - 1] - K;
//if (small > big)
//{
//    int temp = small;
//    small = big;
//    big = temp;
//}
//for (int i = 1; i < N - 1; i++)
//{
//    int add = arr[i] + K;
//    int sub = arr[i] - K;
//    if (add <= big || sub >= small)
//    {
//        continue;
//    }
//    if (add - small < big - sub)
//    {
//        big = add;
//    }
//    else
//    {
//        small = sub;
//    }
//}
//Console.WriteLine(big - small);


//using System;

//int[] arr = new int[]
//{
//    380, 705, 706, 177, 710, 416, 853, 147, 957, 693, 
//    631, 891, 287, 277, 976, 210, 876, 77, 205, 172, 
//    741, 810, 959, 399, 710, 157, 222, 934, 887, 413, 
//    617, 72, 503, 390, 489, 373, 34, 944, 719, 832, 
//    726, 115, 803, 827, 920, 306, 455, 104, 956, 301, 
//    3, 980, 812, 739, 634, 25, 408, 319, 213, 684, 
//    335, 371, 574, 595, 965, 186, 784, 43, 70, 859, 
//    261, 153, 595, 531, 424, 280, 874, 897, 588, 251,
//    482, 560, 940, 395, 63, 129, 389, 91, 498, 919, 
//    721, 994, 461, 303, 885, 288, 990, 311, 901, 445, 10, 542, 55, 271, 348, 389, 645, 826, 310, 765, 271, 996, 383, 728, 360, 41, 581, 444, 24, 781, 781, 678, 10, 729, 937, 851, 286, 904, 745, 61, 754, 569, 837, 771, 429, 695, 874, 682, 380, 544, 411, 779, 312, 35, 994, 685, 207, 510, 711, 309, 91, 167, 232, 90, 480, 721, 226, 350, 193, 81, 735, 202, 318, 377, 256, 785, 391, 292, 700, 945, 444, 251, 386, 741, 271, 184, 828, 694, 26, 434, 821, 42, 590, 440, 236, 501, 291, 769, 49, 832, 7, 579, 175, 656, 169, 635, 298, 985, 933, 580, 764, 562, 181, 35, 3, 610, 621, 379, 732, 259, 655, 644, 838, 358, 969, 146, 48, 799, 44, 947, 149, 722, 342, 744, 386, 814, 714, 776, 252, 698, 727, 665, 943, 157, 838, 952, 981, 810, 584, 675, 267, 732, 304, 478, 643, 734, 428, 483, 101, 647, 561, 61, 295, 139, 263, 342, 863, 917, 427, 271, 430, 948, 197, 769, 455, 971, 425, 794, 368, 926, 601, 714, 865, 706, 779, 6, 211, 972, 79, 236, 699, 557, 340, 656, 278, 900, 283, 190, 743, 516, 683, 562, 399, 151, 447, 5, 692, 19, 853, 856, 237, 469, 793, 558, 365, 388, 418, 573, 239, 871, 18, 541, 553, 585, 171, 780, 683, 747
//};

//int k = 494;
//int n = 318;
//Console.WriteLine(MinDifference(arr, n, k));
using System;
using System.Collections.Generic;
using System.Drawing;

static int MinDifference(int[] arr, int n, int k)
{
    if (n == 1)
        return 0;

    Array.Sort(arr);

    int ans = arr[n - 1] - arr[0];

    if (k > ans)
    {
        // If k is greater than the initial difference between tallest and shortest towers,
        // adjust k to be within a reasonable range
        k = ans;
    }

    int small = arr[0] + k;
    int big = arr[n - 1] - k;

    if (small > big)
    {
        int temp = small;
        small = big;
        big = temp;
    }

    int result = arr[n - 1] - arr[0];


    for (int i = 1; i < n - 1; i++)
    {
        if (arr[i] - k < 0)
        {
            continue;
        }
        //int subtract = arr[i] - k;
        //int add = arr[i] + k;

        //if (subtract >= small || add <= big)
        //    continue;

        //if (big - subtract <= add - small)
        //    small = subtract;
        //else
        //    big = add;

        //int add = arr[i] + K;
        //int sub = arr[i] - K;
        //if (add <= big || sub >= small)
        //{
        //    continue;
        //}
        //if (big - sub <= add - small)
        //{
        //    small = sub;
        //}
        //else
        //{
        //    big = add;
        //}
        int minHeight, maxHeight;
        if (arr[i] >= k)
        {
            maxHeight = Math.Max(arr[i - 1] + k, arr[n - 1] - k);
            minHeight = Math.Min(arr[0] + k, arr[i] - k);
            result = Math.Min(result, maxHeight - minHeight);
        }
    }

    return result;
}

//return res;

//int K = 3, N = 5;
//int[] arr = { 3, 9, 12, 16, 20 };

//static int getMinDiff(int[] arr, int n, int k)
//{
//    // Sort the array in ascending order
//    Array.Sort(arr);

//    // Initialize minimum difference
//    int min = arr[0];
//    int max = arr[n - 1];
//    int ans = max - min;

//    for (int i = 1; i < n; i++)
//    {
//        int a = arr[i - 1] + k;
//        int b = arr[i] - k;
//        if (b < 0)
//        {
//            continue;
//        }
//        max = Math.Max(max - k, a);
//        min = Math.Min(min + k, b);

//        ans = Math.Min(ans, max - min);
//    }
//    return ans;
//}

//var res = getMinDiff(arr, N, K);
//Console.WriteLine(res.ToString());




//int n = 76;

//int[] arr = { 10, 14, 29, 21, 17, 4, 18, 20, 18, 22,
//    21, 14, 27, 12, 3, 28, 17, 0, 2, 18, 8, 20, 26, 16, 9, 23,25, 20, 7, 27, 5,
//    7, 16, 5, 25, 11, 3,7,
//    2, 17, 
//    14, 6, 12, 14, 23, 25, 26, 5, 18, 1, 6, 10, 9, 12, 2, 25, 29, 12, 19, 4, 8, 5, 8, 30, 2, 22, 24, 30, 7, 24, 8, 15, 16, 2, 11, 20 };


//int n = 11;

//int[] arr = {1, 4, 3, 2, 6, 7};


//int i = 0;
//int index = 0;
//int jumps = 0;
//if (arr[i] == 0)
//{

//}
//while (arr[i] == 0)
//{
//    i = i + 1;
//    if (i >= n - 1)
//    {
//        Console.WriteLine("-1");
//       // return -1;
//    }
//}

//while (i <= n - 1)
//{
//    if (arr[i] == 0)
//    {
//        i = i - 1;
//        if (i <= 0)
//        {
//            // return -1;
//            Console.WriteLine("-1");


//        }
//        continue;
//    }

//    i = arr[i] + i;
//    jumps = jumps + 1;
//    if (i >= n - 1)
//    {
//        Console.WriteLine(jumps);

//        //return jumps;
//    }

//}


//if (arr[0] == 0)
//{
//    Console.WriteLine("-1");

//}

//int jumps = 0;
//int currentIndex = 0;
//int i = 0;

//while(i <= n - 1)
//{
//    if (arr[i] == 0)
//    {
//        i--;
//        if (i <= currentIndex)
//        {
//            if(jumps== 0)
//            {
//                Console.WriteLine("-1");
//            }
//        }
//        if (i <= 0)
//        {
//            Console.WriteLine("-1");

//        }
//        continue;
//    }
//    currentIndex = i;
//    i = arr[i] + i;
//    jumps++;
//    if (i >= n - 1)
//    {
//        Console.WriteLine(jumps);

//    }
//}


static int minJumps(int[] arr, int n)
{

    //Your code here
    if (arr[0] == 0)
    {
        return -1;
    }

    int jumps = 0;
    int pI = 0;

    for (int i = 1; i < n ; i++)
    {
        if (arr[i] == 0)
        {
            i--;
            if (i <= pI)
            {
                return -1;
            }
            if (i <= 0)
            {
                return -1;
            }
            continue;
        }
        pI = i;
        i = arr[i] + i;
        jumps++;

        if (i >= n - 1)
        {
            return jumps;
        }
    }

    return -1;
}


static int minJumpsWithSahiti()
{
//    int[] arr = { 1, 4, 3, 10, 6, 7, 2, 4, 5, 7, 4, 1, 8, 7, 5, 4 };
    int[] arr = { 1 ,2 ,0 ,0 ,0 };

    

   // int[] arr = { 1, 4, 3, 9, 6, 7, 2, 4, 5, 7, 4, 1, 8, 7, 5, 4 };

    int n = arr.Length;
    if (arr[0] == 0)
    {
        return -1;
    }
    int jumps = 0;
    int maxEleIndex = arr[0];
    int steps = arr[0];
    for (int i = 1; i < n; i++)
    {
        if(i== n - 1)
        {
            return jumps;
        }
        maxEleIndex = Math.Max(maxEleIndex, i + arr[i]);
        steps--;

        if (steps == 0)
        {
            jumps++;

            if (i >= maxEleIndex)
            {
                return -1;
            }
            steps = maxEleIndex - i;
        }
    }

    return jumps > 0 ? jumps : -1;
}

static int findDuplicateNumber()
{
    int[] nums = { 1, 3, 4, 2, 2 };
    HashSet<int> set = new HashSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (set.Contains(nums[i]))
        {
            return nums[i];
        }
        else
        {
            set.Add(nums[i]);
        }
    }
    return nums[0];
}

static int findDuplicateNumberAPP2()
{
    int[] nums = { 1, 3, 4, 2, 2 };

    int slow = 0, fast = 0;
    do
    {
        slow = nums[slow];
        fast = nums[nums[fast]];
    }
    while (slow != fast);    // The loop breaks when the slow & fast pointer meets.

    // Then set the slow pointer to start and then again iterate till the slow & fast pointer meet again.
    slow = 0;
    while (slow != fast)
    {
        slow = nums[slow];
        fast = nums[fast];
    }
    // The element they meet again is the duplicate element.
    return slow;
}


static int findDuplicateNumberAPP3()
{
    int[] nums = { 1, 3, 4, 2, 2 };

    int fast= 0,slow = 0;
    do
    {
        slow = nums[slow];
        fast = nums[nums[fast]];
    }while(slow != fast);


    slow = 0;
    while(slow != fast)
    {
        slow = nums[slow];
        fast = nums[fast];
    }
    return slow;
  
}
//Console.WriteLine(findDuplicateNumberAPP3());


//static void mergeTwoArrays(int[] arr1, int[] arr2, int n, int m)
//{
//    //int n = 3, m = 1;
//    //int[] arr1 = { 389 ,3539, 6077 };
//    //int[] arr2 = { 1469 };

//    int i = 0,j = 0;
//    while (i < arr1.Length)
//    {
//        if (arr1[i] >= arr2[0])
//        {
//            int lastElementof1st = arr1[arr1.Length - 1];
//            int FirstElementof2nd = arr2[0];
//            adjustLastElementof1stin2nd(lastElementof1st, arr2);
//            adjustLastElementof2ndin1st(FirstElementof2nd, arr1, i);
//        }
//        i++;
//    }
//}
//static void adjustLastElementof2ndin1st(int FirstElementof2nd, int[] arr1,int index)
//{
//    int high = arr1.Length - 1;
//    while (high > index)
//    {
//        swap(high - 1, high, arr1);
//        high--;
//    }
//    arr1[index] = FirstElementof2nd;
//}

//static void adjustLastElementof1stin2nd(int lastElementof1st,int[] arr2)
//{
//    if(arr2.Length== 1)
//    {
//        arr2[0] = lastElementof1st;
//        return;
//    }
//    if (lastElementof1st <= arr2[1])
//    {
//        arr2[0] = lastElementof1st;
//    }
//    else if(lastElementof1st >= arr2[arr2.Length -1])
//    {
//        shiftElementsToLeft(arr2.Length-1, arr2);
//        arr2[arr2.Length - 1] = lastElementof1st;
//    }
//    else
//    {
//        for (int i = 1; i < arr2.Length; i++)
//        {
//            if (lastElementof1st <= arr2[i])
//            {
//                shiftElementsToLeft(i - 1, arr2);
//                arr2[i - 1] = lastElementof1st;
//                break;
//            }
//        }
//    }
//}
//static void shiftElementsToLeft(int index, int[] arr)
//{
//    int i = 0;
//    while(i < index)
//    {
//        swap(i, i + 1,  arr);
//        i++;
//    }
//}

//static void swap(int i, int j,  int[] arr)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}

//var ip = Console.ReadLine().Trim().Split(' ');
//int z = int.Parse(ip[0]);
//int m = int.Parse(ip[1]);
//int[] arr1 = new int[z];
//ip = Console.ReadLine().Trim().Split(' ');
//for (int i = 0; i < z; i++)
//{
//    arr1[i] = int.Parse(ip[i]);
//}
//int[] arr2 = new int[m];
//ip = Console.ReadLine().Trim().Split(' ');
//for (int i = 0; i < m; i++)
//{
//    arr2[i] = int.Parse(ip[i]);
//}

//mergeTwoArrays(arr1, arr2, z, m);


//int z = 5, m = 5;
//long[] arr1 = { 0,1,2,3,4 };
//long[] arr2 = { 0,1,2,3,4 };
//merge(arr1, arr2, z, m);

//static void merge(long[] arr1, long[] arr2, int n, int m)
//{
//    //Your code here

//    int i = 0;
//    while (i < n)
//    {
//        if (arr1[i] >= arr2[0])
//        {
//            long lastElementof1st = arr1[n - 1];
//            long FirstElementof2nd = arr2[0];
//            adjustLastElementof1stin2nd(lastElementof1st, arr2, m);
//            adjustLastElementof2ndin1st(FirstElementof2nd, arr1, i, n);
//        }
//        i++;
//    }
//}

//static void adjustLastElementof2ndin1st(long FirstElementof2nd, long[] arr1, long index, int n)
//{
//    int high = n - 1;
//    while (high > index)
//    {
//        swap(high - 1, high, arr1);
//        high--;
//    }
//    arr1[index] = FirstElementof2nd;
//}

//static void adjustLastElementof1stin2nd(long lastElementof1st, long[] arr2, int m)
//{
//    if (m == 1)
//    {
//        arr2[0] = lastElementof1st;
//        return;
//    }
//    if (lastElementof1st <= arr2[1])
//    {
//        arr2[0] = lastElementof1st;
//    }

//    else if (lastElementof1st >= arr2[m - 1])
//    {
//        shiftElementsToLeft(m - 1, m - 1, arr2, lastElementof1st);
//        arr2[m - 1] = lastElementof1st;
//    }
//    else
//    {
//        for (int i = 1; i < m; i++)
//        {
//            if (lastElementof1st <= arr2[i])
//            {
//                shiftElementsToLeft(i - 1, i - 1, arr2, lastElementof1st);
//                break;
//            }
//        }
//    }
//}
//static void shiftElementsToLeft(long toBeStore, long index, long[] arr, long lastElementof1st)
//{
//    int i = 0;
//    while (i < index)
//    {
//        swap(i, i + 1, arr);
//        i++;
//    }
//    arr[toBeStore] = lastElementof1st;
//}
//static void swap(long i, long j, long[] arr)
//{
//    long temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}

//static void sahitiHulk()
//{
//    int n = 4, m = 5;
//    long[] arr1 = { 1,3,5,7 };
//    long[] arr2 = { 0,2,6,8,9 };
//    int length = n + m;

//    int gap = length / 2 + length % 2;
//    while(gap > 0 )
//    {
//        long leftPointerIndex = 0;
//        long rightPointerIndex = gap;

//        while (rightPointerIndex < length)
//        {
//            //arr1 and arr2
//            if(leftPointerIndex< n && rightPointerIndex >= n)
//            {
//                swap2(leftPointerIndex, rightPointerIndex-n, arr1, arr2);
//            }
//            //arr2
//            else if (leftPointerIndex >= n)
//            {
//                swap2(leftPointerIndex-n, rightPointerIndex - n, arr2, arr2);
//            }
//            //arr1
//            else if(rightPointerIndex < n)
//            {
//                swap2(leftPointerIndex, rightPointerIndex, arr1, arr1);
//            }


//            leftPointerIndex++;
//            rightPointerIndex++;
//        }
//        if(gap == 1)
//        {
//            break;
//        }
//        gap = gap/2 + gap % 2;
//    }
//}
//static void swap2(long i, long j, long[] arr1 , long[] arr2)
//{
//    if (arr1[i] > arr2[j])
//    {
//        long temp = arr1[i];
//        arr1[i] = arr2[j];
//        arr2[j] = temp;
//    }
//}

//static int kadane()
//{

//    int n = 5;
//    int[] arr = { 1, 2, 3, -2, 5 };
//    //Output:9
//    int maxSum = 0;
//    int maxSoFar = int.MinValue;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        maxSum = maxSum + arr[i];
//        if(maxSoFar< maxSum)
//        {
//            maxSoFar = maxSum;
//        }
//        if (maxSum < 0)
//        {
//            maxSum = 0;
//        }

//    }
//    return maxSoFar;
//}

//static int[][] mergeIntervals()
//{
//    //[[1,3],[2,6],[8,10],[15,18]]
//    int[][] intervals = new int[][]
//    {
//        new int[] { 2, 6},

//        new int[] { 1, 3},
//        new int[] { 8, 10},
//        new int[] { 15, 18},
//    };


//    // var sortedArray = intervals.OrderBy(innerArray => innerArray[0]).ToArray();
//    if(intervals.Length == 1)
//    {
//        return intervals;
//    }
//    Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

//    List<int[]> results = new List<int[]>();
//    int[] comparableRecord = intervals[0];
//    results.Add(comparableRecord);
//    foreach (int[] item in intervals)
//    {
//        if (item[0] <= comparableRecord[1])
//        {
//            comparableRecord[1] = Math.Max(comparableRecord[1], item[1]);
//        }
//        else
//        {
//            comparableRecord = item;
//            results.Add(comparableRecord);
//        }
//    }
//    return results.ToArray();

//}


//static int[] codeWithSaiti()
//{
//    int[] nums = { 2, 1, 5, 4, 3, 0, 0 };
//    int n = nums.Length;
//    int index = -1;
//    for (int i = n-2; i >=0; i--)
//    {
//        if (nums[i] < nums[i + 1])
//        {
//            index = i;
//            break;
//        }
//    }
//    int start = index + 1;
//    int end = n - 1;
//    if (index < 0)
//    {
//        reverse(start, end, nums);
//    }
//    for (int i = n-1; i > index; i--)
//    {
//        if (nums[i] > nums[index])
//        {
//            swapForS(i, index, nums);
//            break;
//        }
//    }
//    reverse(start,end,nums);

//    return nums;

//}
//static void reverse(int start,int end, int[] nums)
//{
//    while (start < end)
//    {
//        swapForS(start, end, nums);
//        start++;
//        end--;
//    }
//}
//static void swapForS(int i,int j, int[] nums)
//{
//    int temp = nums[i];
//    nums[i] = nums[j];
//    nums[j] = temp;
//}

// List<int> nextPermutation(int n, List<int> arr)
//{
//    //Your code here
//    if (n == 1)
//    {
//        return arr;
//    }
//    int index = -1;
//    for (int i = n - 2; i >= 0; i--)
//    {
//        if (arr[i + 1] > arr[i])
//        {
//            index = i;
//            break;
//        }
//    }
//    if (index < 0)
//    {
//        reverselist(0, n - 1, arr);
//        return arr;
//    }
//    else
//    {
//        for (int i = n - 1; i > index; i--)
//        {
//            if (arr[i] > arr[index])
//            {
//                swaplist(i, index, arr);
//                break;
//            }
//        }
//        reverselist(index + 1, n - 1, arr);
//        return arr;
//    }
//}
//static void reverselist(int start, int end, List<int> arr)
//{
//    while (start < end)
//    {
//        swaplist(start, end, arr);
//        start++;
//        end--;
//    }
//}
//static void swaplist(int i, int j, List<int> arr)
//{
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//}
//List<int> nums = new List<int>() { 2, 1, 5, 4, 3, 0, 0 };

//nextPermutation(nums.Count,nums);

//static void CountInversion()
//{
//    int N = 5;
//    int[] arr = { 2, 4, 1, 3, 5 };
//    int result = 0;
//    for (int i = 0; i < N-1; i++)
//    {
//        swapCountInversion(i, i + 1, arr, ref result);

//    }
//    Console.WriteLine(result);
//}

//static void swapCountInversion(int i,int j , int[] arr,ref int res)
//{
//    int key = arr[i];
//    while (j < arr.Length)
//    {
//        if (key > arr[j])
//        {
//            res++;
//        }
//        j++;
//    }
//}

//static int[] mergeSort(int[] arr,int low,int high,ref int rev)
//{
//    if(arr.Length == 1)
//    {
//        return arr;
//    }
//    int mid = arr.Length / 2;
//    var left = arr[..mid];
//    var right = arr[mid..];

//    var leftres = mergeSort(left,low,mid+1, ref rev);
//    var rightres = mergeSort(right,mid+1, high,ref rev);
//    return combineMergeSort(leftres, rightres,low, mid,high,ref rev);
//}
//static int[] combineMergeSort(int[] left, int[] right,int low, int mid,int high,ref int rev)
//{
//    int i = low, j = high, k = 0;
//    int[] res = new int[left.Length + right.Length];
//    while(i<left.Length && j < right.Length)
//    {
//        if (left[i] <= right[j])
//        {
//            res[k++] = left[i++];
//        }
//        else
//        {
//            res[k++] = right[j++];
//            rev += mid - i + 1;
//        }
//    }
//    while (i<left.Length)
//    {
//        res[k++] = left[i++];
//    }
//    while (j < right.Length)
//    {
//        res[k++] = right[j++];
//    }
//    return res;
//}



//var res = mergeSort(arr, 0, arr.Length - 1, ref inv);
//Console.WriteLine(res);



//static long inversionCount(long[] arr, long N)
//{
//    //Your Code Here
//    long inversions = 0;
//    for (long i = 0 ; i <= N-1; i++)
//    {
//        long j = 0;
//        while (j < N -1)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                long temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//                inversions++;
//            }
//            j++;
//        }
//        N--;

//    }
//    return inversions;

//}
//long[] arr1 = new long[] { 6,5,4,3,2,1 };
//inversionCount(arr1, arr1.Length);
//Console.WriteLine();





//static void merge(int[] arr,int low,int high)
//{
//    int mid = low+ high/2;


//}


//int[] arr = { 6 };
//int inv = 0;

//int[] res = new int[arr.Length];

//var invs = mergeSort(arr, 0, arr.Length-1);
static int mergeSort(int[] arr,int low,int high)
{
    int inv = 0;
    if (low < high)
    {
        int mid = (low + high) / 2;

        inv += mergeSort(arr, low, mid);
        inv += mergeSort(arr, mid + 1, high);
        inv += mergeCombine(arr, low, high, mid);
    }
    return inv;

}

static int mergeCombine(int[] arr,int low,int high,int mid)
{
    int left = low, right = mid + 1;

    int[] temp = new int[arr.Length];
    int k = low;
    int cnt = 0;
    while (left <= mid && right <= high)
    {
        if (arr[left]<= arr[right])
        {
            temp[low++] = arr[left++];
        }
        else
        {
            temp[low++] = arr[right++];
            cnt += mid - left + 1;
        }
    }
    while (left <= mid)
    {
        temp[low++] = arr[left++];
    }

    while (right <= high)
    {
        temp[low++] = arr[right++];
    }

    for (int i = k; i <=high; i++)
    {
        arr[i] = temp[i];
    }

    return cnt;
}


//MaxProfit(arr);
static int MaxProfit(int[] prices)
{
    int maxProfit = 0;
    int len = prices.Length;
    if (len == 1)
    {
        return maxProfit;
    }
    int buyPrice = prices[0];
    int sellPrice = prices[1];
    maxProfit = Math.Max(sellPrice - buyPrice, maxProfit);
    if (len == 2)
    {
        return maxProfit;
    }
  
    if(sellPrice < buyPrice)
    {
        buyPrice = sellPrice;
    }
    for (int i = 2; i < len; i++)
    {
        if (prices[i] - buyPrice > maxProfit)
        {
            maxProfit = prices[i] - buyPrice;
            sellPrice = prices[i];
        }
        if (prices[i] < buyPrice)
        {
            buyPrice = prices[i];
        }
    }
    return maxProfit;
}

//getPairsCount(arr,arr.Length,k);
 int getPairsCount(int[] arr, int n, int k)
{
    int pairs = 0;
    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
    for (int i = 0; i < n; i++)
    {
        if (keyValuePairs.ContainsKey(arr[i]))
        {
            keyValuePairs[arr[i]]++;
        }
        else
        {
            keyValuePairs[arr[i]] = 1;
        }
    }

    for (int i = 0; i < n; i++)
    {
        int comp = k - arr[i];
        if (keyValuePairs.ContainsKey(comp))
        {
            pairs += keyValuePairs[comp];
        }
        if(comp == arr[i])
        {
            pairs--;
        }
    }
    return pairs;
    //Your code here
}

//int[] arr = { 1, 5, 7, 1 };
//int k = 6;

//int n1 = 6;
//int[] A = { 1, 5, 10, 20, 40, 80 };
//int n2 = 5;
//int[] B = { 6, 7, 20, 80, 100 };
//int n3 = 8;
//int[] C = { 3, 4, 15, 20, 30, 70, 80, 120 };

//commonElements(A, B, C, n1, n2, n3);
static List<int> commonElements(int[] A, int[] B, int[] C, int n1, int n2, int n3)
{
    int i = 0, j = 0, k = 0;
    List<int> ints = new List<int>();
    while (i<n1 && j<n2 && k < n3)
    {
        if (A[i] == B[j] && B[j] == C[k])
        {
            if (!ints.Contains(A[i]))
            {
                ints.Add(A[i]);
            }
            i++;j++;k++;
        }
        else if (A[i] < B[j])
        {
            i++;
        }
        else if (B[j] < C[k])
        {
            j++;
        }
        else
        {
            k++;
        }
    }
    return ints;
}

//int[] C = { 3, 4, 15, 20, 30, 70, 80, 120 };


// static void alternate(int[] arr)
//{
//    int n = arr.Length
//    int low = 0, high = 0;

//    boolean positive = true; // Indicates whether the next number to be placed should be positive

//    while (low < n && high < n)
//    {

//        // Find the next index to swap
//        while (low < n && arr[low] >= 0 == positive)
//        {
//            low++;
//        }
//        high = low + 1;

//        // Find the next number to swap
//        while (high < n && arr[high] >= 0 != positive)
//        {
//            high++;
//        }

//        // Swap the numbers
//        if (low < n && high < n)
//        {
//            swap(low, high, arr);
//            positive = !positive;
//        }
//    }
//}
//static void shiftRight(int[] arr, int start, int end)
//{
//    for (int i = end; i >= start; i--)
//    {
//        arr[i + 1] = arr[i];
//    }
//}

static void rearrange2(int[] arr, int n)
{
    //int[] arr = { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };
    List<int> pos = new List<int>();
    List<int> neg = new List<int>();

    for (int i = 0; i < n; i++)
    {
        if (arr[i] >= 0)
        {
            pos.Add(arr[i]);
        }
        else
        {
            neg.Add(arr[i]);
        }
    }
    //if positive are low fill positive first
    if (neg.Count > pos.Count)
    {
        for (int i = 0; i < pos.Count; i++)
        {
            arr[2 * i] = pos[i];
            arr[2 * i + 1] = neg[i];
        }
        int index = pos.Count * 2;
        for (int i = pos.Count; i < neg.Count; i++)
        {
            arr[index] = neg[i];
            index++;
        }
    }
    else
    {
        for (int i = 0; i < neg.Count; i++)
        {
            arr[2 * i] = pos[i];
            arr[2 * i + 1] = neg[i];
        }
        int index = neg.Count * 2;
        for (int i = neg.Count; i < pos.Count; i++)
        {
            arr[index] = pos[i];
            index++;
        }
    }


}
static void rearrange(int[] arr, int n)
{
    // code here

    //init with positive
    //search in array till init
    //swap with i and mundu unay ani index ni move chey
    //swap aindi ante init val -nve

    int low = 0, high = 0;
    bool init = true;

    while (low < n)
    {
        //int[] arr = { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };

        if (arr[low] >= 0 && low % 2 == 0)
        {
            low++;
            high = low;
            init = !init;
            continue;
        }
        if (arr[low]<0 && low % 2 != 0)
        {
            low++;
            high = low;
            init = !init;
            continue;
        }
        while (high < n) {
            if (arr[high] >=0 == init)
            {
                swap(low, high, arr);
                init = !init;
                break;
            }
            high++;
        }
        if (high >= n-1)
        {
            break;
        }
        low++;
        high = low;
    }
    Console.WriteLine("");
}

static void swap(int low,int high,int[] arr)
{
    int temp = arr[high];
    while (high >low)
    {
        arr[high] = arr[high - 1];
        high--;
    }
    arr[low] = temp;
}


static bool subArrayExists(int[] arr, int n,int k)
{
    //Your code here
    Dictionary<int, int> prefixSum = new Dictionary<int, int>();
    prefixSum[0] = 1;
    int sum = 0;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        sum += arr[i];
            if (prefixSum.ContainsKey(sum - k))
        {
            count += prefixSum[sum - k];
        }
        if (count > 0)
        {
            return true;
        }
        if (prefixSum.ContainsKey(sum))
        {
            prefixSum[sum] += 1;
        }
        else
        {
            prefixSum.Add(sum, 1);
        }

    }
    return false;
}
//int[] arr = {23, 2, 4, 6, 6};
//int k = 7;

//subArrayExists(arr, arr.Length,k);
static List<int> factorial(int N)
{
    // code here
    List<int> ints = new List<int>();
    nuint result = 1;
    nuint len = (nuint)N;
    for (nuint i = 2; i <= len; i++)
    {
        result *= i;
    }
    while (result > 0)
    {
        int rem = (int)result % 10;
        ints.Add(rem);
        result = result / 10;
    }
    ints.Reverse();
    return ints;
}

static int fact(int n)
{

    if (n > 1)
    {
        return n;
    }
    return fact(n-1) * fact(n - 2);
}


//var  arr1 = new List<int>() { 1, 2, 2, 3 };
//var result1 = arrayChallenge(arr1);
//Console.WriteLine("Count for [1, 2, 2, 3]:");
//for (int i = 0; i < arr1.Count; i++)
//{
//    Console.WriteLine(result1[i]);
//}
//int[] arr2 = { 2, 1, 3 };
//int n2 = arr2.Length;
//int[] result2 = arrayChallenge(arr2);
//Console.WriteLine("Count for [2, 1, 3]:");
//for (int i = 0; i < n2; i++)
//{
//    Console.WriteLine(result2[i]);
//}
static List<int> arrayChallenge(List<int> arr)
{
    List<int> ans = new List<int>();
    ans.Add(0);

    for (int i = 1; i < arr.Count; i++)
    {
        int diff = arr[i] - arr[i - 1];
        int diffHandler = (i - 1) * diff + diff + ans[i - 1];
        ans.Add(diffHandler);
    }

    return ans;
}

int findLongestConseqSubseq(int[] arr, int N)
{
    //Your code here
    Array.Sort(arr);
    int maxSub = 0;
    int maxLen = 0;
    for (int i = 0; i < N - 1; i++)
    {
        if (arr[i] + 1 == arr[i + 1])
        {
            maxLen++;
            if (i == N - 2)
            {
                maxSub = Math.Max(maxSub, maxLen + 1);
            }
        }
        else if (arr[i] == arr[i + 1])
        {
            continue;
        }
        else
        {
            maxSub = Math.Max(maxSub, maxLen + 1);
            maxLen = 0;
        }
    }

    return maxSub;
}

int findLongestConseqSubseq2(int[] arr, int N)
{
    HashSet<int> ints= new HashSet<int>();
    for (int i = 0; i < N; i++)
    {
      
            ints.Add(arr[i]);
        
    }
    int maxSeq = 1;

    foreach (var item in ints)
    {
        if (!ints.Contains(item - 1))
        {
            int maxSub = 1;

            var ele = item;
            while (ints.Contains(ele+1))
            {
                ele= ele + 1;
                maxSub++;
            }
            maxSeq =  Math.Max(maxSeq, maxSub);
        }
    }
       
    return maxSeq;
}



static IList<int> MajorityElement(int[] nums)
{
    int el1 = int.MinValue, el2 = int.MinValue;
    int cnt1 = 0, cnt2 = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (cnt1 == 0 && nums[i] != el2)
        {
            cnt1 =1;
            el1 = nums[i];
        }
        else if (cnt2 == 0 && nums[i] != el1)
        {
            cnt2=1;
            el2 = nums[i];
        }
        else if (nums[i] == el1)
        {
            cnt1++;
        }
        else if (nums[i] == el2)
        {
            cnt2++;
        }
        else
        {
            cnt1--;
            cnt2--;
        }
    }

    cnt1 = 0;cnt2 = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == el1) cnt1++;
        if (nums[i] == el2) cnt2++;
    }

    int mustBeLen = nums.Length / 3;
    List<int> ints = new List<int>();
    
   if (cnt1 > mustBeLen)
    {
        ints.Add(el1);
    }
    if (cnt2 > mustBeLen)
    {
        ints.Add(el2);
    }

    return ints;
}


//static int MajorityElementnby2(int[] nums)
//{
//Array.Sort(nums);
//return nums[nums.Length / 2];
//List<int> a = new List<int>();
//a.Remove
//HashSet<int> ints = new HashSet<int>();
//ints.Remove

//int el1 = int.MinValue;
//int cnt1 = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (cnt1 == 0)
//    {
//        cnt1 = 1;
//        el1 = nums[i];
//    }
//    else if (nums[i] == el1)
//    {
//        cnt1++;
//    }
//    else
//    {
//        cnt1--;
//    }
//}

//int mustBeLen = nums.Length / 2;
//if (cnt1 > mustBeLen)
//{
//    return el1;
//}
//else
//{
//    return -1;
//}

//cnt1 = 0; 
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == el1) cnt1++;
//}

//int mustBeLen = nums.Length / 2;
//List<int> ints = new List<int>();

//if (cnt1 > mustBeLen)
//{
//    ints.Add(el1);
//}
//else
//{
//    ints.Add(-1);
//}

//return ints;
//}

 IList<IList<int>> ThreeSum(int[] A)
{
    int X = 0;
    var res = new List<IList<int>>();
    Array.Sort(A);
    int n = A.Length;
    for (int i = 0; i < n; i++)
    {
        if (i > 0 && A[i] == A[i - 1])
        {
            continue;
        }
        int j = i + 1;
        int k = n - 1;
        while (j < k)
        {
            int sum = A[i] + A[j] + A[k];
            if (sum < X)
            {
                i++;
            }
            else if (sum > X)
            {
                k--;
            }
            else
            {
                var val = new List<int>();
                val.Add(A[i]);
                val.Add(A[j]);
                val.Add(A[k]);

                res.Add(val);
                j++;
                k--;
            }
        }
    }
    return res;
}


 long trappingWater(int[] arr, int n)
{
    //Your code here
    int startIndex = -1;
    int endIndex = - 1;
    int k = 0;
    while (k<n)
    {
        if (k + 1 < n && arr[k + 1] < arr[k])
        {
            startIndex = k;
            break;
        }
        k++;
    }
    if (startIndex < 0)
    {
        return 0;
    }
    int z = n-1;
    while (z > startIndex)
    {
        if (z - 1 > startIndex && arr[z - 1] < arr[z])
        {
            endIndex = z;
            break;
        }
        z--;
    }
    if (endIndex < 0)
    {
        return 0;
    }


    long res = 0;
    long startHeight = arr[startIndex];
    long endHeight = Math.Min(arr[startIndex], arr[endIndex]);
    
    for (int i = startIndex+1; i < endIndex; i++)
    {
       
       
    }
    return res;
}

long trappingWater2(int[] arr, int n)
{
    List<long> a = new List<long>() { 1,2,3};
    a.Sort();
    var res2 = a[2] - a[0];
    

    int l = 0, r = n-1, leftmax = 0, rightmax = 0;
    long res = 0;
    while (l < r)
    {
        if (arr[r] >= arr[l])
        {
            if (arr[l] < leftmax)
            {
                res += leftmax - arr[l];
            }
            else
            {
                leftmax = arr[l];
            }
            l++;
        }
        else
        {
            if (arr[r]> rightmax)
            {
                rightmax = arr[r];
            }
            else
            {
                res += rightmax - arr[r];
            }
            r--;
        }
    }

    return res;


}

long findMinDiff(List<long> a, long n, long m)
{
    //Your code here
    a.Sort();
    
    int mint = (int)m;
    long minSoFar = a[mint - 1] - a[0];
    for (int i = 0; i < a.Count; i++)
    {
        int endIndex = i + mint - 1;
        if (endIndex > n - 1)
        {
            break;
        }
        long newVal = a[endIndex] - a[i];
        minSoFar = Math.Min(newVal, minSoFar);
    }
    return minSoFar;
}

int MinSubArrayLen(int target, int[] nums)
{
    int min = int.MinValue;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= target)
        {
            return 1;
        }
      
        int j = i + 1;
        int sum = nums[i];
        while (j < nums.Length)
        {
            sum += nums[j];

            if (sum >= target)
            {
                if (min == int.MinValue)
                {
                    min = j - i + 1;
                }
                min = Math.Min(min, j - i + 1);
                break;
            }
            j++;
        }

    }
    if (min == int.MinValue)
    {
        return 0;
    }
    return min;
}



int MinSubArrayLen2(int target, int[] nums)
{

    int start = 0, end = 0;
    int maxSum = 0;
    int len = nums.Length + 1;
    while (end<nums.Length)
    {
        while (maxSum <= target && end < nums.Length)
        {
            maxSum += nums[end];
            end++;
        }


        while (maxSum > target && start<nums.Length)
        {
            if (end - start < len)
            {
                len = end - start ;
            }
            maxSum = maxSum - nums[start];
            start++;
        }
    }
    return len;
}

void threeWayPartition(List<int> array, int a, int b)
{
    // code here 
    int start = 0, mid = 0, end = array.Count - 1;
    while (start < end)
    {
        if (array[start] < a)
        {
            start++;
            mid++;
            continue;
        }
        if (array[end] > b)
        {
            end--;
            continue;
        }
        if (array[start]>a && array[start] > b)
        {
            swap3way(array, start, end);
            end--;
            continue;
        }
        if (array[end]<b && array[end] < a)
        {
            swap3way(array, start, end);
            start++;
            mid++;
            continue;
        }
        if (array[start] >= a)
        {

        }
    }
}

void swap3way(List<int> arr,int start,int end)
{
    int temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;
}


void threeWayPartition2(List<int> array, int a, int b)
{
    // code here 
    int start = 0, mid = 0, end = array.Count - 1;
    while (mid <= end)
    {
        if (array[start] < a)
        {
            start++;
            if (start > mid)
            {
                mid = start;
            }
            continue;
        }
        if (array[end] > b)
        {
            end--;
            continue;
        }
        if (array[mid] < a)
        {
            swap3way(array, start, mid);
            start++;
            
        }
        else if (array[mid] > b)
        {
            swap3way(array, mid, end);
            end--;

        }
        mid++;
    }
}


void threeWayPartition3(List<int> array, int a, int b)
{
    int i = 0,start = 0;
    while (i<array.Count)
    {
        if (array[i] < a)
        {
            moveLeft(array, start, i);
            start++;
        }
        i++;
    }
    int j = array.Count - 1, end = array.Count - 1;
    while (j >=start)
    {
        if (array[j] >b)
        {
            moveRight(array, j, end);
            end--;
        }
        j--;
    }
}


void threeWayPartition4(List<int> array, int a, int b)
{
    int i = 0, start = 0;
    int j = array.Count - 1, end = array.Count - 1;
    while (i<j)
    {
        if (array[i] < a)
        {
            moveLeft(array, start, i);
            start++;
        }
        i++;
        if (array[j] > b)
        {
            moveRight(array, j, end);
            end--;
        }
        j--;
    }
    
    //while (j >= start)
    //{
    //    if (array[j] > b)
    //    {
    //        moveRight(array, j, end);
    //        end--;
    //    }
    //    j--;
    //}
}

void moveRight(List<int> arr, int start, int end)
{
    while (start <end)
    {
        int temp = arr[start + 1];
        arr[start+1] = arr[start];
        arr[start] = temp;
        start++;
    }
}

void moveLeft(List<int> arr,int start,int from)
{
    while (from > start)
    {
        int temp = arr[from-1];
        arr[from - 1] = arr[from];
        arr[from] = temp;
        from--;
    }
}



int swapForMinSwap(int[] arr, int i, int j,int swaps)
{
    
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
    swaps++;
    return swaps;
}



int minSwap2(int[] arr, int n, int k)
{
    // Your code here
    int swaps = 0;
    int keyIndex = -1;
    int maxVal = -1;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] == k)
        {
            keyIndex = i;
            break;
        }
        else if (arr[i] < k)
        {
            var res = Math.Max(maxVal, arr[i]);
            if (res > maxVal)
            {
                maxVal = res;
                keyIndex = i;
            }
        }
    }
    if (keyIndex == -1)
    {
        return 0;
    }
    var leftIndex = keyIndex - 1;
    var rightIndex = keyIndex + 1;

    var keyVal = arr[keyIndex];

    int start = 0;
    int end = n-1;
    while (leftIndex >= start)
    {
        if (arr[leftIndex] > keyVal && start < leftIndex)
        {
            while (arr[start] > keyVal && start<leftIndex)
            {
                start++;
            }
            if (start < leftIndex)
            {
                swaps = swapForMinSwap(arr, leftIndex, start, swaps);
            }
            start++;
        }

        leftIndex--;
    }

   

    while (rightIndex <= end)
    {
        if (arr[rightIndex] > keyVal && end > rightIndex)
        {
            while (arr[end] > keyVal && end > rightIndex)
            {
                end--;
            }
            if (end > rightIndex)
            {
                swaps = swapForMinSwap(arr, rightIndex, end, swaps);
            }
            end--;
        }
        rightIndex++;
    }

    if (keyIndex == 0 || keyIndex == n - 1)
    {
        swaps--;
    }

    return swaps;

}

//20
//4 11 6 5 11 20 19 14 14 2 9 20 11 11 15 1 7 12 19 9
//14

//arr[] = { 2, 1, 5, 6, 3}
//3
//1

//arr[] = { 2, 7, 9, 5, 8, 7, 4}
//K = 6
//2

//10 12 20 20 5 19 19 12 1 20 1
//1
//1

//var ls = new List<int>() { 4, 2, 8, 8, 1, 9, 7, 1, 10, 2, 8
//};
//threeWayPartition4(ls, 1, 1);

int minSwap(int[] arr, int n, int k)
{
    //Your code here
    int requiredElements = 0;
    for (int m = 0; m < n; m++)
    {
        if (arr[m] == 1)
        {
            requiredElements++;
        }
    }
    int maxExpand = 0;
    for (int l = 0; l < requiredElements; l++)
    {
        if (arr[l] != k)
        {
            maxExpand++;
        }
    }
    int minSwaps = maxExpand;
    int j = requiredElements;
    int i = 0;
    while (j <n)
    {
        if (arr[i] != 1)
        {
            maxExpand--;
        }
        if (arr[j] != k)
        {
            maxExpand++;
        }
        minSwaps = Math.Min(minSwaps, maxExpand);
        i++;
        j++;
       
    }
   
    return minSwaps;
}


int findMidSum(int[] ar1, int[] ar2, int n)
{
    // code here 
    int i = 0, j = 0;
    if (n == 1)
    {
        return ar1[0] + ar2[0];
    }
    int mid2 = n * 2/2;
    int mid1 = mid2 - 1;
    int res = 0;
    int k = 0;
    while(k<=mid2 && i<n && j<n)
    {
        if (ar1[i] < ar2[j])
        {
            if(k == mid1)
            {
                res += ar1[i];
                mid1 = -1;

            }
            else if (k == mid2)
            {
                res += ar1[i];
                return res;
            }
            i++;
        }
        else
        {
            if (k == mid1)
            {
                res += ar2[j];
                mid1 = -1;
            }
            else if (k == mid2)
            {
                res += ar2[j];
                return res;
            }
            j++;

        }
        k++;
    }
    if (i < n)
    {
        res += ar1[i];
        return res;
    }
    if (j < n)
    {
        res += ar2[j];
        return res;
    }

    return res;
}


long kthElement(int[] ar1, int[] ar2, int n, int m, int f)
{
    int i = 0, j = 0;
    int k = 0;
    while(i < n && j < m)
    {
        if (ar1[i] < ar2[j])
        {
            if (k == f)
            {
                return ar1[i];
            }
            i++;
        }
        else
        {
            if (k == f)
            {
                return ar2[j];
            }
            j++;
        }
        k++;
    }
    while (i < n)
    {
        if(k == f)
        {
            return ar1[i];
        }
        i++;
        k++;
    }
    while (j < m)
    {
        if (k == f)
        {
            return ar2[j];
        }
        j++;
        k++;
    }

    return ar1[0];

}



long findMedian(int[] ar1, int[] ar2, int n, int m, int f)
{
    int i = 0, j = 0;
    int k = 0;
    if (n + m % 2 != 0)
    {

        while (i < n && j < m)
        {
            if (ar1[i] < ar2[j])
            {
                if (k == f)
                {
                    return ar1[i];
                }
                i++;
            }
            else
            {
                if (k == f)
                {
                    return ar2[j];
                }
                j++;
            }
            k++;
        }
        while (i < n)
        {
            if (k == f)
            {
                return ar1[i];
            }
            i++;
            k++;
        }
        while (j < m)
        {
            if (k == f)
            {
                return ar2[j];
            }
            j++;
            k++;
        }
    }

    return ar1[0];

}


double FindMedianSortedArrays(int[] ar1, int[] ar2)
{
    int n1 = ar1.Length;
    int n2 = ar2.Length;
    double median = 0;
    int oneEle = (n1 + n2) / 2 ;
    int twoEle = oneEle + 1;
    int i = 0, j = 0;
    int k = 0;
    //one median
    if ((n1+n2)%2 != 0)
    {
        while (i < n1 && j < n2)
        {
            if (ar1[i] < ar2[j])
            {
                if (k == oneEle)
                {
                    return ar1[i];
                }
                i++;
            }
            else
            {
                if (k == oneEle)
                {
                    return ar2[j];
                }
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            if (k == oneEle)
            {
                return ar1[i];
            }
            i++;
            k++;
        }
        while (j < n2)
        {
            if (k == oneEle)
            {
                return ar2[j];
            }
            j++;
            k++;
        }

        return median;
    }
    else
    {
        //two median
        double m1 = double.MinValue, m2 = double.MinValue;

        while (k <= twoEle && i < n1 && j < n2)
        {
            if (ar1[i] < ar2[j])
            {
                if (k == oneEle)
                {
                    median += ar1[i];
                    m1 = median;

                }
                else if (k == twoEle)
                {
                    median += ar1[i];
                    m2 = median;
                    return median /2;
                }
                i++;
            }
            else
            {
                if (k == oneEle)
                {
                    median += ar2[j];
                    m1 = median;
                }
                else if (k == twoEle)
                {
                    median += ar2[j];
                    m2 = median;
                    return median/2;
                }
                j++;

            }
            k++;
        }
        while (k <= twoEle && i < n1)
        {
            if(m1== double.MinValue && k ==oneEle)
            {
                median += ar1[i];
            }
            if(m2== double.MinValue && k == twoEle)
            {
                median += ar1[i];
                return median / 2;
            }
            i++;
            k++;
        }
        while (k <= twoEle && j < n2)
        {
            if (m1 == double.MinValue && k == oneEle)
            {
                median += ar2[j];
            }
            if (m2 == double.MinValue && k == twoEle)
            {
                median += ar2[j];
                return median / 2;
            }
            j++;
            k++;
        }

        return median;
    }

    return median;
}


double FindMedianSortedArraysopti(int[] ar1, int[] ar2)
{
    int n1 = ar1.Length;
    int n2 = ar2.Length;
    double median = double.MinValue;
    int oneEle = (n1 + n2) / 2;
    int twoEle = oneEle + 1;
    int i = 0, j = 0;
    int k = 0;

    while (i < n1 && j < n2)
    {
        if (ar1[i] < ar2[j])
        {
            if (k == oneEle)
            {
                median= ar1[i];
            }
            i++;
        }
        else
        {
            if (k == oneEle)
            {
                median= ar2[j];
            }
            j++;
        }
        k++;
    }


    //one median
    if ((n1 + n2) % 2 != 0)
    {
        if (median != double.MinValue)
        {
            return median;
        }

        while (i < n1)
        {
            if (k == oneEle)
            {
                return ar1[i];
            }
            i++;
            k++;
        }
        while (j < n2)
        {
            if (k == oneEle)
            {
                return ar2[j];
            }
            j++;
            k++;
        }

        return median;
    }
    else
    {
        oneEle = oneEle - 1;
        twoEle = oneEle + 1;
        //two median
        double m1 = double.MinValue, m2 = double.MinValue;
        if (median != double.MinValue)
        {
            m1 = median;
        }

        while (k <= twoEle && i < n1 && j < n2)
        {
            if (ar1[i] < ar2[j])
            {
                if (m1 == double.MinValue && k == oneEle)
                {
                    median += ar1[i];
                    m1 = median;

                }
                else if (m2 == double.MinValue && k == twoEle)
                {
                    median += ar1[i];
                    m2 = median;
                    return median / 2;
                }
                i++;
            }
            else
            {
                if (m1 == double.MinValue && k == oneEle)
                {
                    median += ar2[j];
                    m1 = median;
                }
                else if (m2 == double.MinValue && k == twoEle)
                {
                    median += ar2[j];
                    m2 = median;
                    return median / 2;
                }
                j++;

            }
            k++;
        }
        while (k <= twoEle && i < n1)
        {
            if (m1 == double.MinValue && k == oneEle)
            {
                median = ar1[i];
            }
            if (m2 == double.MinValue && k == twoEle)
            {
                median += ar1[i];
                return median / 2;
            }
            i++;
            k++;
        }
        while (k <= twoEle && j < n2)
        {
            if (m1 == double.MinValue && k == oneEle)
            {
                median = ar2[j];
            }
            if (m2 == double.MinValue && k == twoEle)
            {
                median += ar2[j];
                return median / 2;
            }
            j++;
            k++;
        }

        return median;
    }

    return median;
}


double FindMedianSortedArrays1(int[] nums1, int[] nums2)
{
    double toReturn = 0;

    int c1 = 0, c2 = 0;
    double midPoint = (nums1.Length + nums2.Length) / 2.0;
    for (int count = 0; count <= midPoint; count++)
    {
        int num = (c1 < nums1.Length && (c2 >= nums2.Length || nums1[c1] < nums2[c2])) ? nums1[c1++] : nums2[c2++];
        if (count >= midPoint - 1) toReturn += num / (2 - (midPoint * 2 % 2));
    }

    return toReturn;
}



int fibWithRec(int n)
{

    if (n <= 1)
    {
        return n;
    }
    return fibWithRec(n - 1) + fibWithRec(n - 2);
}

static int DP(int n)
{
    int[] dp = new int[n + 1];
    dp[0] = 0;
    dp[1] = 1;
    for (int i = 2; i <=n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2];
    }
    return dp[n];

}
 int minimumEnergy(int[] arr, int N)
{
    //code here
    if(N == 0)
    {
        return 0;
    }
    int left = minimumEnergy(arr, N - 1) + Math.Abs(arr[N] - arr[N - 1]);
    int right = 0;
    if (N > 1)
    {
        right = minimumEnergy(arr, N - 2) + Math.Abs(arr[N] - arr[N - 2]);
    }
    return Math.Min(left, right);
}
 static int MinCost(int[] a, int n)
{
    if (n < 4) return -1;  // Check if input length is less than the minimum requirement.

    // Initialize an array to store the minimum costs and fill it with a large value.
    int[] cost = new int[n];
    Array.Fill(cost, int.MaxValue);
    cost[0] = a[0];  // Start from the first element.

    // Priority queue to process elements based on the minimum accumulated cost (Dijkstra's algorithm).
    SortedSet<(int cost, int index)> pq = new SortedSet<(int cost, int index)>();
    pq.Add((cost[0], 0));

    // Process the priority queue
    while (pq.Count > 0)
    {
        // Extract the current smallest cost element
        var (currentCost, i) = pq.Min;
        pq.Remove(pq.Min);

        // Move backward to i-1 if within bounds
        if (i - 1 >= 0 && currentCost + a[i - 1] < cost[i - 1])
        {
            pq.Remove((cost[i - 1], i - 1));  // Remove old value if it exists
            cost[i - 1] = currentCost + a[i - 1];
            pq.Add((cost[i - 1], i - 1));
        }

        // Move forward to i+3 if within bounds
        if (i + 3 < n && currentCost + a[i + 3] < cost[i + 3])
        {
            pq.Remove((cost[i + 3], i + 3));  // Remove old value if it exists
            cost[i + 3] = currentCost + a[i + 3];
            pq.Add((cost[i + 3], i + 3));
        }
    }

    // Check if the last index is reachable, otherwise return -1.
    return cost[n - 1] == int.MaxValue ? -1 : cost[n - 1];
}




int reduceGifts(List<int> prices,int k,int threshold)
{
    prices.Sort((a, b) => b.CompareTo(a)); // Sort descending
    int minRemove = 0;
    while (prices.Count >= k)
    {
        long total = 0; // Use long to avoid overflow.
        total = prices.Take(k).Select(x => (long)x).Sum(); // Cast to long before summing.

        if (total <= threshold)
            break; // If the sum of the top k prices is within the threshold, stop removing.

        prices.RemoveAt(0); // Remove the largest element that's likely causing the high sum.
        minRemove++; // Increment the number of removals needed.
    }

    return minRemove;
}


int[] findKthMinVulner(int k,int m, int[] vulner)
{
    List<int> list = new List<int>(); 
    int i = 0, j = m - 1;
    while (j < vulner.Length)
    {
        var currArray = vulner.Take(new Range(i++,j+1)).ToArray();
        Array.Sort(currArray);
        list.Add(currArray[k - 1]);
        j++;
    }

    return list.ToArray();

}
//int res = reduceGifts(new List<int> { 9, 6, 3, 2, 9, 10, 10, 11 }, 4, 1);





static List<int> FindKthMinimumVulnerability(int k, int m, List<int> vulnerability)
{
    var n = vulnerability.Count;
    var result = new List<int>();
    var countMap = new SortedDictionary<int, int>();

    // Initialize the first window
    for (int i = 0; i < m; i++)
    {
        if (!countMap.ContainsKey(vulnerability[i]))
            countMap[vulnerability[i]] = 0;
        countMap[vulnerability[i]]++;
    }

    // Get the k-th minimum from the first window
    result.Add(GetKthMin(countMap, k));

    // Slide the window over the rest of the array
    for (int i = m; i < n; i++)
    {
        // Remove the element going out of the window
        if (countMap[vulnerability[i - m]] == 1)
            countMap.Remove(vulnerability[i - m]);
        else
            countMap[vulnerability[i - m]]--;

        // Add the new element coming into the window
        if (!countMap.ContainsKey(vulnerability[i]))
            countMap[vulnerability[i]] = 0;
        countMap[vulnerability[i]]++;

        // Get the k-th minimum from the current window
        result.Add(GetKthMin(countMap, k));
    }

    return result;

}

static int GetKthMin(SortedDictionary<int, int> map, int k)
{
    int count = 0;
    foreach (var pair in map)
    {
        count += pair.Value;
        if (count >= k)
            return pair.Key;
    }
    return -1; // In case there is no k-th minimum, which shouldn't happen here
}


//var res = findKthMinVulner(1, 1, new int[] { 3, 2, 1, 1, 1 });
//for (int i = 0; i < res.Length; i++)
//{
//    Console.WriteLine(res[i]+ " ");

//}

//var res = findKthMinVulner(1,1, new int[] { 3, 2, 1, 1, 1 });
//for (int i = 0; i < res.Length; i++)
//{
//    Console.WriteLine(res[i] + " ");

//}

List<int> vulnerability = new List<int> { 1,3,2,1 };
int k = 2;
int m = 3;
var result = FindKthMinimumVulnerability(k, m, vulnerability);
Console.WriteLine(string.Join(", ", result));

Console.ReadKey();
