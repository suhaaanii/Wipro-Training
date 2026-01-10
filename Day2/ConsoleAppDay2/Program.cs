using System.Runtime.Versioning;
using System;
using System.Collections;
using System.Collections.Generic;

int[] numbers = { 10, 20, 30, 40, 50 }; //declaration and initialization of array

//ForLoop consiiste of (Initialization; Condition; Increment/Decrement)
//For loop is used for iterating over a sequence (like an array) a specific number of times
for (int i = 0; i < numbers.Length; i++) // here numbers.Length gives the size of the array
{
    Console.WriteLine("Element at index " + i + ": " + numbers[i]);
}

Console.WriteLine( " here is  a 2 D array in action ");
int[,] matrix = new int[3, 3] //3 rows and 3 columns
{
    {1, 2, 3}, //Row 0
    {4, 5, 6}, //Row 1
    {7, 8, 9}  //Row 2
};

//Step 3: Print the values of the 2D array using nested for loops
for (int i = 0; i < 3; i++) //Iterate through rows
{
    for (int j = 0; j < 3; j++) //Iterate through columns
    {
        Console.Write(matrix[i, j] + " "); //Print element at row i and column j
    }
    Console.WriteLine(); //New line after each row
}

Console.WriteLine(  "here is a Jagged array in action ...!!!s");
int[][] jaggedArray = new int[3][]; //Declare a jagged array with 3 rows
jaggedArray[0] = new int[] { 1, 2 }; //First row with 2 elements
jaggedArray[1] = new int[] { 3, 4, 5 }; //Second row with 3 elements
jaggedArray[2] = new int[] { 6, 7, 8, 9 }; //Third row with 4 elements
                                           //Print jagged array
   for (int i = 0; i < jaggedArray.Length; i++) //Iterate through rows
    {
         for (int j = 0; j < jaggedArray[i].Length; j++) //Iterate through columns of each row
         {
              Console.Write(jaggedArray[i][j] + " "); //Print element at row i and column j
         }
         Console.WriteLine(); //New line after each row
    }

// Showing memory efficiency of Jagged Arrays over 2D arrays
Console.WriteLine("Memory Efficiency Comparison:");
int totalElements2D = 3 * 3; // 2D array with 3 rows and 3 columns
int totalElementsJagged = 2 + 3 + 4; // Jagged array with rows of sizes 2, 3, and 4
for (int i = 0; i < totalElements2D; i++)
{
    Console.Write("*"); // Representing memory usage for 2D array
    Console.Write(totalElements2D > totalElementsJagged ? "" : ""); // Just for alignment
}
    
Console.WriteLine("  <- 2D Array Memory Usage"); // memeory comsumption representation
int bytesPerElement =  Buffer.ByteLength(new int[1]); // Get size of an int in bytes
Console.WriteLine(" total memory in bytes taken by 2 D array  "+bytesPerElement);

for (int i = 0; i < totalElementsJagged; i++)
{
    Console.Write("*"); // Representing memory usage for Jagged array
    Console.Write(totalElements2D > totalElementsJagged ? "" : ""); // Just for alignment
}
Console.WriteLine("  <- Jagged Array Memory Usage");

Console.WriteLine(" total memory in bytes taken by Jagged array  " + (bytesPerElement * totalElementsJagged));


Console.WriteLine("non generic ");
ArrayList orderCollection = new ArrayList();
orderCollection.Add("laptop");
orderCollection.Add(12345);
orderCollection.Add(99.99);
orderCollection.Add(new DateTime(2024, 6, 1));

foreach (var item in orderCollection)
{
    Console.WriteLine(item);
}
Console.WriteLine("Generic Collection Implementation");
List<string> genericOrderCollection = new List<string>();//only string type items can be stored in this collection
genericOrderCollection.Add("laptop");
genericOrderCollection.Add("mobile");
genericOrderCollection.Add("tablet");
genericOrderCollection.Add(12345.ToString());//This line will cause a compile-time error as we are trying to add an integer to a string collection

Console.WriteLine("total no of elelemnt in the generic collection " + genericOrderCollection.Count);
Console.WriteLine("Right now the memory of generic collection is " + genericOrderCollection.Capacity);
//displaying the items in the generic collection
Console.WriteLine("Items in the Generic Order Collection:");
foreach (var item in genericOrderCollection)
{
    Console.WriteLine(item);
}
List<Order> orderList = new List<Order>();

//Adding some sample orders to the collection
orderList.Add(new Order { OrderId = 1, ProductName = "Laptop", Quantity = 2, Price = 1500.00 });
orderList.Add(new Order { OrderId = 2, ProductName = "Mobile", Quantity = 5, Price = 800.00 });

//displaying the orders in the collection
Console.WriteLine("Orders in the Order Collection:");
foreach (var order in orderList)
{
    Console.WriteLine(order);
}
  public  class Order
    {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public override string ToString()
            {
                return $"OrderId: {OrderId}, ProductName: {ProductName}, Quantity: {Quantity}, Price: {Price}";
            }
        
    }