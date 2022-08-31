var watch = new System.Diagnostics.Stopwatch();

watch.Start();
var array = new int[] { 99, 65, 33, 1, 2, 54, 11, 15, 91, 3, 15 };
Console.WriteLine("Original Array:");
Console.WriteLine("[{0}]", string.Join(", ", array));
//Depending of the number of elements and max value in your array this is going to take very long, but it is going to be fun :)
var orderedArray = BogoSortClass.BogoSort(array);
Console.WriteLine("Ordered Array:");
Console.WriteLine("[{0}]", string.Join(", ", array));

watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

