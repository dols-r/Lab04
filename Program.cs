using System.Runtime.InteropServices;

Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine($"Архитектура процесса: {RuntimeInformation.ProcessArchitecture}");
Console.WriteLine($"64-битный процесс: {Environment.Is64BitProcess}");