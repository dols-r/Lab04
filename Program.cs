// using System.Diagnostics;
// using System.Runtime.InteropServices;

// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// Console.WriteLine($"Архитектура процесса: {RuntimeInformation.ProcessArchitecture}");
// Console.WriteLine($"64-битный процесс: {Environment.Is64BitProcess}");

using System.Diagnostics;

int threadCount = 8;

Console.WriteLine($"Логических процессоров: {threadCount}");
Console.WriteLine($"Потоков запущено: {threadCount}");
Console.WriteLine("Запуск вычислений...");

Thread[] threads = new Thread[threadCount];
for (int i = 0; i < threadCount; i++)
{
    threads[i] = new Thread(() =>
    {
        long result = 0;
        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < 5)
        {
            for (int j = 0; j < 1_000_000; j++)
            {
                result += j * j;
            }
        }
    });
    threads[i].Start();
}
foreach (Thread thread in threads)
{
    thread.Join();
}
Console.WriteLine("Все потоки завершили работу.");
