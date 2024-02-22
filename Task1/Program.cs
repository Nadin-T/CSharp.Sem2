//Напишите Напишите программу, которая принимает на вход число
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

// int num = 322;

// if ((num%7 == 0) && (num%23 == 0)){
//     Console.Write ("да");
// } else {
//     Console.Write ("нет");
// }


//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.

// int x = 4;
// int y = -2;

// if (x > 0){
//     if (y > 0){
//         Console.Write("1");
//     } else {
//         Console.Write("4");
//     }
// } else {
//     if (y > 0){
//         Console.Write("2");
//     } else {
//         Console.Write("3");
//     }
// }


//Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

// int num = 72;
// if (10 <= num && num <= 99){
//     int first = num / 10;
//     int second = num % 10;

//     if (first > second){
//         Console.Write(first);
//     } else {
//         Console.Write(second);
//     }
// }


//Напишите программу, которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.

// int num = 568;
// int count = 0;
// int remains = num;

// while (num > 0)
// {
//     remains = num % 10;
//     count = count + 1;
//     num = num / 10;
// }
// Console.Write(remains);


// for (count - 1; i >= 0; i--)
// {
//     int remains = num % 10;
//     Console.Write(remains);

//     num = num / 10;
//     if (remains != 0)
//     {
//         Console.Write(", ");
//     }
// }

int num = 100100;
int count = 0;
int num1 = num;
int remainsNum = num;

while (num1 > 0)
{
    num1 = num1 / 10;
    count = count + 1;
}

if (num >= 0 && num < 10)
{
    Console.Write(num);
}
else
{
    int d10 = 10;
    while (num >= d10)
    {
        d10 = d10 * 10;
    //        Console.WriteLine(d10);
    }
    
    int result = remainsNum;
    while (remainsNum < d10 && remainsNum > 0)
    {
        result = remainsNum / (d10 / 10);
        Console.Write(result);

        count = count - 1;
        remainsNum = remainsNum % (d10 / 10);
        //    Console.WriteLine(count);
        if (count > 0)
        {
            Console.Write(", ");
            if (remainsNum == 0)
            {
                while (count > 0)
                {
                    Console.Write(remainsNum);

                    count = count - 1;
                    if (count > 0) { Console.Write(", "); }
                }
            }

        }
        // Console.WriteLine(num);
        //    Console.WriteLine(remainsNum);
        d10 = d10 / 10;
    }
}