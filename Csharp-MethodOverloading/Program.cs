//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");







//Csharp-MethodOverloading-Hometask





//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//void Number(int n)
//{
//    if ( n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");
//    }
//    else 
//    {
//        Console.WriteLine("bolunmur");
//    }
//}

//Number(21);


//string Number( int n)
//{
//    if ( n % 3 == 0 && n % 7 == 0)
//    {
//        return "bolunur";
//    }
//    else
//    {
//        return "bolunmur";
//    }
//}

//string result = Number(42);
//Console.WriteLine(result);



//bool Number( int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//bool result = Number(84);
//Console.WriteLine(result);


////////////////////////////////////////////////////////////////////



//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.





//int Numbers( int n , int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }
//    return sum;

//}

//int result = Numbers(6, 16);
//Console.WriteLine(result);




//void Numbers(int n, int m)
//{
//    int sum = 0;

//    if ( n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);

//    }
//    else
//    {
//        Console.WriteLine("ededlerin her ikisi cut eded deyil");
//    }
//}

//Numbers(8, 101);


////////////////////////////////////////////////////////////////////////////////





//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.






//void Numbers(int n, int m)
//{
//    int count = 0;

//    for ( int i = n; i <= m; i++ )
//    {
//        if ( i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}

//Numbers(9, 19);




//int Numbers( int n, int m)
//{
//    int count = 0;

//    for ( int i = n; i <= m; i++ )
//    {
//        if ( i % 2 == 1)
//        {
//            count++;
//        }
//    }

//    return count;

//}

////int result = Numbers(5,18);
////Console.WriteLine(result);





//////////////////////////////////////////////////////////////////////////
///


//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin. 





//void Numbers(int n , int m )
//{
//    int sum = 0;

//    for  ( int i = n; i <= m; i++ )
//    {
//        if ( i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}

//Numbers(4, 7);



//int Numbers( int n, int m)
//{
//    int sum = 0;

//    for ( int i = n; i <= m; i++)
//    {
//        if ( i % 2 == 1)
//        {
//            sum += i; 
//        }
//    }

//    return sum;
//}

//int result = Numbers(7, 13);
//Console.WriteLine(result);




////////////////////////////////////////////////////////////






//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.




//int SumOfArray(int[] array)
//{
//    int sum = 0;

//    for ( int i = 0; i < array.Length; i++)
//    {
//        if (array[i] % 2 == 1)
//        {
//            sum+= array[i];
//        }
//    }

//    return sum;
//}


//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

//int result = SumOfArray(array);

//Console.WriteLine(result);









//void SumOfArray(int[] array)
//{
//    int sum = 0;

//    for (int i = 0;  i < array.Length; i++)
//    {
//        if (array[i] % 2 == 1)
//        {
//            sum += array[i];
//        }
//    }

//    Console.WriteLine(sum);

//}

//int[] array = { 2, 3, 4, 5, 6 , 9};
//SumOfArray(array);





////////////////////////////////////////////////////




//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.




//void CountOfArray(int[] array)
//{
//    int count = 0;

//    for (int i= 0; i < array.Length; i++)
//    {
//        if (array[i] % 2 == 0)
//        {
//            count++;
//        }
//    }

//    Console.WriteLine(count);
//}

//int[] array = { 1, 2, 3, 4, 5, 56, 6, 7, 7, 7, 8, 8, 8, 9 };
//CountOfArray(array);







//int CountOfArray(int[] array)
//{
//    int count = 0;

//    for ( int i=0; i < array.Length; i++)
//    {
//        if (array[i] % 2 == 0 )
//        {
//            count++;
//        }
//    }

//    return count;
//}


//int[] array = { 1, 2, 3, 4, 5, 56, 6, 7, 343, 23, 24 };

//int result = CountOfArray(array);
//Console.WriteLine(result);





////////////////////////////////////////////////////////////////////////////////////////






//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.






//void Number(int n)
//{
//    int count = 0;


//    if (n < 2)
//    {
//        Console.WriteLine("ne sade, ne murekkeb");
//    }

//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }

//        if (count == 2)
//        {
//            Console.WriteLine("sade");
//        }

//        else
//        {
//            Console.WriteLine("murekkeb");
//        }
//    }
//}
//Number(5);








//string Numbers(int n)
//{
//    int count = 0;

//    if (n < 2)
//    {
//        return " ne sade , ne murekkeb";
//    }

//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }

//        if (count == 2)
//        {
//            return " sade";

//        }
//        else
//        {
//            return "murekkeb";
//        }
//    }
//}

//string result = Numbers(7);
//Console.WriteLine(result);







////////////////////////////////////////////////////////////////////////////////////////////////






//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola
//biler: 2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

//???????

//void Value(int n)
//{
//    int number = 2;
//    int multi = 1;

//    if ( n % 2 == 0)
//    {
//        Console.WriteLine();
//    }























//////////////////////////////////////////////////////////////////////////////////////////////////////







//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).




//void MultiOfArray(int[] array)
//{
//    int multi = 1;

//    for ( int i = 0; i< array.Length; i++)
//    {
//        if ( array[i] < 20 )
//        {
//            multi *= array[i];
//        }
//    }

//    Console.WriteLine(multi);

//}

//int[] array = { 2, 3, 24, 25, 6, 2 };
//MultiOfArray(array);








//int MultiOfArray(int[] array)
//{
//    int multi = 1;

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] <20)
//        {
//            multi *= array[i];
//        }
//    }


//    return multi;

//}


//int[] array = { 1, 20, 23, 4, 3 };

//int result = MultiOfArray(array);

//Console.WriteLine(result);






/////////////////////////////////////////////////////////////////////////////////////////////////////////////








//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.




//int SumOfArray(int[] array)
//{
//    int sum = 0;



//    for ( int i =0; i < array.Length; i++ )
//    {
//        if (array[i] % 2== 0)
//        {
//            sum += array[i];
//        }

//    }


//    return sum * sum;
//}



//int[] array = { 2, 5, 7, 4, 8, 11 };

//int result = SumOfArray(array);

//Console.WriteLine(result);






//void SumOfArray(int[] array)
//{
//    int sum = 0;

//    int power = 1;

//    for ( int i = 0; i < array.Length; i++ )
//    {
//        if (array[i] % 2 == 0)
//        {
//            sum+= array[i];
//        }
//    }

//    power = sum * sum;

//    Console.WriteLine(power);
//}


//int[] array = {2,3,4,5,13,15,11,15,13,13};
//SumOfArray(array);









//////////////////////////////////////////////////////////////////////////////////////////








//11)temp qebul eden method yazirsiz. Return type olan method olmalidir. Method temp 20den boyukdurse isti,
//kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.









//string Temperature(int temp)
//{
//    if (temp > 20)
//    {
//        return "isti";
//    }

//    else if  ( temp ==  20)
//    {
//        return "mulayim";
//    }

//    else
//    {
//        return "soyuq";
//    }
//}

//int temp = 10;

//string result = Temperature(temp);

//Console.WriteLine(result);








////////////////////////////////////////////////////////////////////////////////////








//12)methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.





//int CountOfNumbers(int a, int b)
//{
//    int count = 0;

//    {
//        count = b - a ;
//    }

//   return count; 
//}

//int result = CountOfNumbers(2, 7);
//Console.WriteLine(result);





//int a = 12;
//int b = 16;
//int sum = 0;

//int value(int a, int b)
//{
//    return (sum = b - a);
//}

//int result = value(12, 16);
//Console.WriteLine(result);







//////////////////////////////////////////////////////////////////////////////////////////////



//13)method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.




//int[] array1 = { 1, 2, 3, 4, 5, 6 };
//int[] array2 = { 1, 2, 3, 4, 5, 6 };
//int sum = 0;
//int sum2 = 0;

//int SumOfArray(int[] array1, int[] array2)
//{
//    foreach (int elems in array1)
//    {
//        sum += elems;
//    }

//    foreach (int elems in array2)
//    {
//        sum2 += elems;
//    }

//    return sum + sum2;
//}

//int result = SumOfArray(array1, array2);
//Console.WriteLine(result);


//////////////////////////////////////////////////////////////////////////////////////////////////////////
///




//14)methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.



//int Multi(int n)
//{
//    return  n * n;
//}

//int result = Multi(9);
//Console.WriteLine(result);







//int Multi(int n)
//{
//    int multi = 1;


//    return (multi = n * n);
//}

//int result = Multi(4);
//Console.WriteLine(result);







/////////////////////////////////////////////////////////////////////////////////////////








//15)methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.




//int Value(int n)
//{
//    int sum = 0;

//    for (int i=1; i< n; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//int result = Value(9);
//Console.WriteLine(result);



















































///practise


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//string Login(string username, string password)
//{

//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        return "Login succes";

//    }

//    else
//    {
//        return "Username or password  is wrong";
//    }

//}

//Console.WriteLine("Username:");
//string username = Console.ReadLine();


//Console.WriteLine("Password:");
//string password = Console.ReadLine();


//string result = Login(username, password);
//Console.WriteLine(result);










////////////////////////////////////////////////////////////////////////////////////////////////////////

//string Login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        message = "Login succes";

//    }

//    else
//    {
//        message = "Username or password  is wrong";
//    }
//    return message;
//}

//Console.WriteLine("Username:");
//Username: string username = Console.ReadLine();


//Console.WriteLine("Password:");
//string password = Console.ReadLine();


//if (!IsValid(username, password))
//{
//    Console.WriteLine("Input cannot be empty");
//    goto Username;
//}



//string result = Login(username, password);
//Console.WriteLine(result);




//bool IsValid(string username, string password)
//{
//    if (username == "" || password == "")
//    {
//        return false;
//    }
//    return true;
//}







///////////////////////////////////////////////////////////////////////////////////////////////////////////////




//Practice-CsharpOverloading//




//void GetStudentsByCondition(string[] students)
//{
//    foreach ( var student in students)
//    {
//        if ( student == " Fatime ")
//        {
//            Console.WriteLine("Found");
//            return;
//        }
//    }

//    Console.WriteLine("Welcome pb101");
//}

//GetStudentsByCondition(new string[] { "Fexriyye", "Ilqar", "Fatime ","Kamran", "Behruz" });



////////////////////////////////////////////////
///




//int a = 5;


//void Test(ref int b)
//{
//    b = 30;
//    Console.WriteLine(b);
//}

//Test(ref a);

//Console.WriteLine(a);


























