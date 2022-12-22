// Задача № 2
// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели");
int Days = int.Parse(Console.ReadLine()!);
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(Days == a){
    Console.WriteLine("Понедельник");
}

if(Days == b){
    Console.WriteLine("Вторник");
}

if(Days == c){
    Console.WriteLine("Среда");
}

if(Days == d){
    Console.WriteLine("Четверг");
}

if(Days == e){
    Console.WriteLine("Пятница");
}

if(Days == f){
    Console.WriteLine("Суббота");
}

if(Days == g){
    Console.WriteLine("Воскресение");
}