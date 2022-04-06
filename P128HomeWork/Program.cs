using System;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task -1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod -
            //3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa
            //onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu
            //tapan metodlar da yazin (method overloading)

            //Console.WriteLine(BigNum(5,5,15));
            //Console.WriteLine(BigNum(5,5,15,25));
            //Console.WriteLine(BigNum(5,5,15,7,16));

            //int count = 0;

            //int[] arr = { };

            //while (count <= 5)
            //{
            //    Console.WriteLine("Deyer Daxil Etmek Isdedeyirsinizmi y / n");
            //    string choose = Console.ReadLine();

            //    if (choose == "y")
            //    {
            //        Console.WriteLine("Daxil et:");
            //        string numStr = Console.ReadLine();
            //        int num = int.Parse(numStr);

            //        Array.Resize(ref arr, arr.Length + 1);
            //        arr[arr.Length - 1] = num;

            //        count++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //switch (count)
            //{
            //    case 3:
            //        Console.WriteLine(BigNum(arr[0], arr[1], arr[2]));
            //        break;
            //    case 4:
            //        Console.WriteLine(BigNum(arr[0], arr[1], arr[2], arr[3]));
            //        break;
            //    case 5:
            //        Console.WriteLine(BigNum(arr[0], arr[1], arr[2], arr[3],arr[4]));
            //        break;
            //    default:
            //        Console.WriteLine("Minimum 3 deyer Daxil Edilmelidir");
            //        break;
            //}

            #endregion

            #region Task -2
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod -
            //misalcun bu metodu call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir

            //Console.WriteLine(SumOfNums(9564654));

            #endregion

            #region Task - 4
            //int[] arr = { 99, 35, 66, 25, 5 };
            //CustomSort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task -5
            //Stringlerden ibaret array-i və char qəbul edən metod
            //yazın.Arrayin hansi index-də bu qəbul edilən char varsa, o
            //string-ləri array seklinde geri qaytaran method.

            //string[] arr = { "Hello", "World", "P128", "Code", "Academy" };
            //char symbol = 'o';

            //string[] result = Seach(symbol, "Hello","World","P128","Baki");

            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Class Work
            //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve
            //gonderilmis char deyeri gonderilmis string deyerinde necenci indexde yerlesirse
            //hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir. Misal ucun metodu call
            //ederken "alma" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a' deyerlerini
            //gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib isledeceksiniz.
            //Metodu call ederken gondereceyiniz deyerleri Main metodunda console-dan istifadeci
            //daxil etmelidir.

            //Console.WriteLine(CustomIndexOf("Salam",'a'));

            #endregion

            #region Class Work - 2
            //GetValueIndexes() - string-ler ucun parameter oaraq gonderilen charin
            //stringin hansi indexlerinde yerlesdiyini tapan ve tapdigi butun
            //indexleri array olaraq geri qaytaran metod (hec bir deyer tapilmazsa
            //geriya bos (0 uzunluqlu) int[] qayidir) Salam a  1,3


            foreach (int item in GetValueIndexes("Salam",'z'))
            {
                Console.WriteLine(item);
            }

            #endregion

        }

        #region Task - 1
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod -
        //3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa
        //onu tapib return edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu
        //tapan metodlar da yazin (method overloading)


        static int BigNum(int a, int b, int c)
        {
            int max = 0;

            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a && c > b)
            {
                max = c;
            }
            else
            {
                Console.WriteLine("Deyerlerde BEraberlik Var");
                return 0;
            }

            return max;
        }

        static int BigNum(int a, int b, int c, int d)
        {
            int max = 0;

            int result = BigNum(a, b, c);

            if (result > d)
            {
                max = result;
            }
            else if (result < d)
            {
                max = d;
            }
            else
            {
                Console.WriteLine("Deyerlerde BEraberlik Var");
                return 0;
            }

            return max;
        }

        static int BigNum(int a, int b, int c, int d, int e)
        {
            int max = 0;

            int result = BigNum(a, b, c,d);

            if (result > e)
            {
                max = result;
            }
            else if (result < e)
            {
                max = e;
            }
            else
            {
                Console.WriteLine("Deyerlerde BEraberlik Var");
                return 0;
            }

            return max;
        }

        #endregion

        #region Task - 2
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod -
        //misalcun bu metodu call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir

        static int SumOfNums(int a)
        {
            int sum = 0;

            if (a >= 10)
            {
                while (a > 0)
                {
                    int mod = a % 10;
                    sum += mod;
                    a = (a - mod) / 10;
                }
            }
            else
            {
                Console.WriteLine("Daxil Edilen Eded Mutleq 10-dan Boyuk Olmalidir");
            }

            return sum;
        }

        #endregion

        #region Task - 3
        //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
        //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti
        //verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin - yəni metodunuz 3 doubel parameter
        //qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir

        static double SumOfTwoBigNum(double a, double b, double c)
        {
            double result = 0;

            if (a < b && a < c)
            {
                result = (b + c);
            }
            else if (b < a && b < c)
            {
                result = (a + c);
            }
            else if (c < a && c < b)
            {
                result = (a + b);
            }
            else
            {

            }

            return result;
        }
        #endregion

        #region Task - 4
        static void CustomSort(int[] arr)
        {
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        num = arr[i];
                        arr[i] = arr[j];
                        arr[j] = num;
                    }
                }
            }
        }
        #endregion

        #region Task - 5
        //Stringlerden ibaret array-i və char qəbul edən metod
        //yazın.Arrayin hansi index-də bu qəbul edilən char varsa, o
        //string-ləri array seklinde geri qaytaran method.

        static string[] Seach(char symbol, params string[] words)
        {
            string[] reult = { };

            foreach (string item in words)
            {
                if (item.Contains(symbol))
                {
                    Array.Resize(ref reult, reult.Length + 1);
                    reult[reult.Length - 1] = item;
                }
            }

            return reult;
        }
        #endregion

        #region Class Work
        //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve
        //gonderilmis char deyeri gonderilmis string deyerinde necenci indexde yerlesirse
        //hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir. Misal ucun metodu call
        //ederken "alma" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a' deyerlerini
        //gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib isledeceksiniz.
        //Metodu call ederken gondereceyiniz deyerleri Main metodunda console-dan istifadeci
        //daxil etmelidir.

        static int CustomIndexOf(string word, char symbol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

        #region Class Work - 2
        //GetValueIndexes() - string-ler ucun parameter oaraq gonderilen charin
        //stringin hansi indexlerinde yerlesdiyini tapan ve tapdigi butun
        //indexleri array olaraq geri qaytaran metod (hec bir deyer tapilmazsa
        //geriya bos (0 uzunluqlu) int[] qayidir) Salam a  1,3

        static int[] GetValueIndexes(string word, char symbol)
        {
            int[] arr = { };

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }

            return arr;
        }
        #endregion
    }
}
