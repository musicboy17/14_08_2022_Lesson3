// // Виды методов - четыре штуки.
// // Первый и второй ничего не возвращают - void.
// // Третий и четвёртый - возвращают.
// // Второй и четвёртый принимают данные.

// /*void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();
// */
// //***

// /*void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения второго метода!");

// */
// // К методу 2 передаваемые аргументы именованные:

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;    
//     }
// }

//     Method21("Текст", 4);
    
// //    Console.WriteLine(msg);

// Мы можем явно указать - какому аргументу - какое значение присвоить

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;    
    }
}

   // Method21(msg:"Текст", count: 4);
    // В этом случае мы можем указать аргументы в произвольном порядке
    Method21(count: 4, msg:"Новый текст");





