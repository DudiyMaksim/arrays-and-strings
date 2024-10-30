namespace Масиви_і_рядки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1
            //Random rnd = new Random();
            //int[] A = new int[5];
            //double[,] B = new double[3,4];

            //for (int i = 0; i < 5; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 3; i++){
            //    for (int j = 0; j < 4; j++){
            //        B[i,j] = rnd.NextDouble();
            //    }
            //}
            //Console.WriteLine();

            //foreach (int v in A)
            //{
            //    Console.Write(v + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 4; j++){
            //        Console.Write(B[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //int max = A[0];
            //foreach(int v in A)
            //{
            //    if (v > max)
            //    {
            //        max= v;
            //    }
            //}
            //double maxd = B[0, 0];
            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        if (B[i,j] > maxd)
            //        {
            //            maxd = B[i, j];
            //        }
            //    }
            //}


            //int sumint = 0;
            //foreach (int v in A) {
            //    sumint += v;
            //}
            //double sumd = 0;
            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 4; j++) { 
            //        sumd += B[i,j];
            //    }
            //}


            //int productint = 1;
            //foreach (int v in A)
            //{
            //    productint *= v;
            //}
            //double productdouble = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        productdouble *= B[i, j];
            //    }
            //}


            //int suminteven = 0;
            //foreach (int v in A)
            //{
            //    if (v%2 == 0)
            //    {
            //        suminteven += v;
            //    }
            //}


            //double sumodd = 0;
            //for (int i = 0; i < 3; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        if (j%2!=0)
            //        {
            //            sumodd += B[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("maxDouble : " + maxd);
            //Console.WriteLine("maxInt : " + max);
            //Console.WriteLine("Total sum : " + (sumint + sumd));
            //Console.WriteLine("Product int : " + productint);
            //Console.WriteLine("Product double : " + productdouble);
            //Console.WriteLine("Sum of even int : " + suminteven);
            //Console.WriteLine("Sum of odd column : " + sumodd);

            //// task 2
            //Random rnd1 = new Random();
            //int[,] arr = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr[i, j] = rnd1.Next(-100, 100);
            //    }
            //}

            //int min = arr[0, 0];
            //int[] mincord = { 0, 0 };

            //int max = arr[0, 0];
            //int[] maxcord = { 0, 0 };

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arr[i, j] < min)
            //        {
            //            min = arr[i, j];
            //            mincord[0] = i;
            //            mincord[1] = j;
            //        }
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arr[i, j] > max)
            //        {
            //            max = arr[i, j];
            //            maxcord[0] = i;
            //            maxcord[1] = j;
            //        }
            //    }
            //}

            //int summinmax = 0;
            //int startRow = Math.Min(mincord[0], maxcord[0]);
            //int endRow = Math.Max(mincord[0], maxcord[0]);
            //int startCol = Math.Min(mincord[1], maxcord[1]);
            //int endCol = Math.Max(mincord[1], maxcord[1]);

            //for (int i = startRow; i <= endRow; i++)
            //{
            //    for (int j = startCol; j <= endCol; j++)
            //    {
            //        summinmax += arr[i, j];
            //    } 
            //}

            //Console.WriteLine("Sum_min-max : " + summinmax);

            ////task 4
            //int[,] A= new int[4,4];
            //int[,] B= new int[4,4];
            //Random rnd = new Random();
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        A[i, j] = rnd.Next(20);
            //        B[i, j] = rnd.Next(20);
            //    }
            //}

            //int[,] C = new int[4, 4];
            //for (int i = 0; i < 4; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        C[i, j] = A[i, j] + B[i, j];
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; n > 0; i++) {
            //    for (int j = 0; j < 4; j++) {
            //        C[i, j] *= n;
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////task 5
            //string str = Console.ReadLine();
            //if (str.IndexOf('+')!=-1) { 
            //    string[] values = str.Split('+');
            //    Console.WriteLine( int.Parse(values[0]) + int.Parse(values [1]));  
            //}
            //else if (str.IndexOf("-")!=-1){
            //    string[] values = str.Split('-');
            //    Console.WriteLine(int.Parse(values[0]) - int.Parse(values[1]));
            //}
            ////task 6
            //string text = Console.ReadLine();
            //string[] text1 = text.Split('.');
            //string[] FinallText = new string[text1.Length];
            //int l = 0;

            //foreach (string s in text1) {
            //    char[] chararr = s.ToCharArray();
            //    for (int i = 0; i < chararr.Length; i++) { 
            //        if (char.IsLetter(chararr[i])){
            //            chararr[i] = char.ToUpper(chararr[i]);
            //            break;
            //        }
            //    }

            //    string str = new string(chararr);
            //    FinallText[l++] = str;
            //}

            //string finalResult = string.Join(".", FinallText);
            //Console.WriteLine(finalResult);
            ////task 7
            //string text = Console.ReadLine();
            //string badword = Console.ReadLine();
            //string coutstars = new string('*', badword.Length);
            //Console.WriteLine(text.Replace(badword, coutstars));
        }
    }
}
