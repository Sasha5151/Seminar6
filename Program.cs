// Задача 40 
// Напишите программу , которая принимает на вход три числа 
// и проверяет , может ли существовать треугольник со сторонами 
// такой длины

// int DataEntry(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// bool CheckTriangle(int a , int b , int c )
// {
//     return ((a < b + c ) && ( b < a + c) && (c < b + a));
//     //     return true;
//     // else 
//     //     return false;    
// }

// int a = DataEntry ("a = ");
// int b = DataEntry ("b = ");
// int c = DataEntry ("c = ");
// System.Console.WriteLine(CheckTriangle(a , b , c ));

// //end

// Задача 42 
// Преобразовать десятичное число в двоичное 


// int DataEntry(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

//  string ConvertToBinary ( int x)
//  {
//     string result = "";
//     for (; x > 0; x /= 2)
//     {
//         result += (x%2);
//     }
//     return Reverse(result);
//  }
// string Reverse(string x)
// {
//     string buffer = "";
//     for (int i = x.Length - 1 ; i >= 0 ; i--)
//     {
//         buffer += x[i];      
//     }
//     return buffer;
// }

// int number = DataEntry ("число  = ");
// System.Console.WriteLine(ConvertToBinary ( number ));


// // End

// Задача 44
// Не используя рекурсию выведите первые N чисел Фибоначчи .
// Первые два числа 0 и 1 


// int DataEntry(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int[] FindFibonacci(int N)
// {
//     int[] result = new int [N];
//     result[0] =0 ;
//     result[1] =1 ;
//     for (int i = 2; i < N ; i++)
//     {
//         result[i] = result[i-1] + result[i-2];
//     }
//     return result;
// }

// int N = DataEntry ("число  = ");
// System.Console.WriteLine(string.Join(',' , FindFibonacci(N)));

// //End

// Задача 45 
// Создать копию заданного массива 
// с помощью поэлементного копирования

int [] numbers = { 2 , 6 , 78 , 43 , 32};
// int [] numbers2 = (int[])numbers.Clone() ;
int [] numbers2 = new int[numbers.Length] ;
numbers2 = CopyArray(numbers);
System.Console.WriteLine(string.Join(',' , numbers ));
System.Console.WriteLine(string.Join(',' , numbers2 ));
// System.Console.WriteLine(string.Join(',' , numbers ));
// System.Console.WriteLine(string.Join(',' , numbers2 ));

numbers[0] = 5;
System.Console.WriteLine(string.Join(',' , numbers ));
System.Console.WriteLine(string.Join(',' , numbers2 ));

int[] CopyArray(int[] array)
{
    int[] array1 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array1[i] = array[i];
    }
    return array1;
}



//End