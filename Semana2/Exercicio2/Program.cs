int fib1 = 0;
int fib2 = 1;
var fib = fib1 + fib2;

Console.WriteLine(fib1);
Console.WriteLine(fib2);
Console.WriteLine(fib);

while(fib < 100){
    fib1 = fib2;
    fib2 = fib;
    fib = fib1 + fib2;
    Console.WriteLine(fib);
}