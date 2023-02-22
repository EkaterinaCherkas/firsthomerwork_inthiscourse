Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int number3 = int.Parse(Console.ReadLine());
int max_num;
max_num = number1;
if (number2 > number1){
    max_num = number2;
}
if (number3 > max_num){
    max_num = number3;
}

Console.Write("Максимальное число " + max_num);