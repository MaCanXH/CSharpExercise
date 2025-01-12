
// // string helloString = "Hello, Extension Methods!";
// // int WordCount = helloString.WordCount();
// // Console.WriteLine(WordCount);

// using System.ComponentModel.Design;
// using System.Globalization;
// using System.Runtime.CompilerServices;
// using System.Text;
// using System.Text.RegularExpressions;

// // List<int> numbers = new List<int> {1, 2, 3, 4, 5};
// // Console.WriteLine(numbers.ToString<int>());
// // numbers.IncreaseWith(5);
// // Console.WriteLine(numbers.ToString<int>());

// // List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
// // List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
// // foreach (var num in evenNumbers)
// // {
// // Console.Write("{0} ", num);
// // }
// // Console.WriteLine();

// List<Dog> dogs = new List<Dog>() {
// new Dog { Name = "Rex", Age = 4 },
// new Dog { Name = "Sean", Age = 0 },
// new Dog { Name = "Stacy", Age = 3 }
// };
// // var names = dogs.Select(x => x.Name);
// // foreach (var name in names)
// // {
// // Console.WriteLine(name);
// // }

// // var newDogList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0]});
// // foreach (var item in newDogList)
// // {
// //     Console.WriteLine(item);
// // }

// // var sortedDogs = dogs.OrderBy(x => x.Age);
// // foreach (var dog in sortedDogs)
// // {
// //     Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
// // }

// // List<int> list = new List<int>() {20, 1, 4, 8, 9, 44};
// // var evenNumbers = list.FindAll((i) => 
// // {
// //     Console.WriteLine("Value of i is: {0}", i);
// //     return (i % 2) == 0;
// // });
// // foreach (var item in evenNumbers)
// // {
// //     Console.WriteLine(item);
// // }

// // Func<bool> boolFunc = () => true;
// // Func<int, bool> intFunc = (x) => x < 10;
// // if (boolFunc() && intFunc(5))
// // {
// //     Console.WriteLine("5 < 10");
// // }

// // Func<int, int> testFunc = (x) => x / 2;
// // Console.WriteLine(testFunc(7));

// // List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// // var evenNumbers = 
// //     from num in numbers
// //     where num % 2 == 0
// //     select string.Format("The number {0}", num);
// // foreach (var item in evenNumbers)
// // {
// //     Console.WriteLine(item + " ");
// // }

// // string[] words = { "cherry", "apple", "blueberry"};
// // var wordsSortedByLength =
// //     from word in words
// //     orderby word.Length descending
// //     select word;
// // foreach (var word in wordsSortedByLength)
// // {
// //     Console.WriteLine(word);
// // }

// // int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13 };
// // int divisor = 5;

// // var numberGroups = 
// //     from number in numbers
// //     group number by number % divisor into grp
// //     select new { Remainder = grp.Key, Numbers = grp};

// // foreach (var group in numberGroups)
// // {
// //     Console.WriteLine("Numbers with a remainder of {0} when divded by {1}:", group.Remainder, divisor);
// //     foreach (var number in group.Numbers)
// //     {
// //         Console.WriteLine(number);
// //     }
// // }

// List<Category> categories = new List<Category>()
// {
//     new Category() { ID = 1, Name = "Fruit"},
//     new Category() { ID = 2, Name = "Food"},
//     new Category() { ID = 3, Name = "Shoe"},
//     new Category() { ID = 4, Name = "Juice"},
// };
// List<Product> products = new List<Product>()
// {
//     new Product() { Name = "Strawberry", CategoryID = 1 },
//     new Product() { Name = "Banana", CategoryID = 1 },
//     new Product() { Name = "Chicken meat", CategoryID = 2 },
//     new Product() { Name = "Apple Juice", CategoryID = 4 },
//     new Product() { Name = "Fish", CategoryID = 2 },
//     new Product() { Name = "Orange Juice", CategoryID = 4 },
//     new Product() { Name = "Sandal", CategoryID = 3 },
// };
// // var productsWithCategories = 
// //     from product in products
// //     join category in categories
// //         on product.CategoryID equals category.ID
// //     select new { Name = product.Name, Category = category.Name};

// // var productsWithCategories = 
// //     from product in products
// //     select new {
// //         Name = product.Name,
// //         Category = 
// //             (from category in categories
// //             where category.ID == product.CategoryID
// //             select category.Name).First()
// //     };
// // foreach (var item in productsWithCategories)
// // {
// //     Console.WriteLine(item);
// // }

// // List<int> l1 = new List<int>();
// // DateTime startTime = DateTime.Now;
// // l1.AddRange(Enumerable.Range(1, 50000000));
// // Console.WriteLine("Ext.method:\t{0}", DateTime.Now - startTime);
// // startTime = DateTime.Now;
// // List<int> l2 = new List<int>();
// // for (int i = 0; i < 50000000; i++) l2.Add(i);
// // Console.WriteLine("For-loop:\t{0}", DateTime.Now - startTime);

// // List<int> list = new List<int>();
// // list.AddRange(Enumerable.Range(1, 100000));
// // DateTime start = DateTime.Now;
// // for (int i = 0; i < 10000; i++)
// // {
// // var elements = list.Where(e => e > 20000);
// // }
// // Console.WriteLine("No execution:\t{0}", DateTime.Now - start);
// // start = DateTime.Now;
// // for (int i = 0; i < 10000; i++)
// // {
// // var element = list.Where(e => e > 20000).First();
// // }
// // Console.WriteLine("Execution:\t{0}", DateTime.Now - start);

// HashSet<Guid> set = new HashSet<Guid>();
// for (int i = 0; i < 50000; i++)
// {
//     set.Add(Guid.NewGuid()); // Add random GUID
// }
// Guid keyForSearching = new Guid();
// DateTime start = DateTime.Now;
// for (int i = 0; i < 50000; i++)
// {
// // Use HashSet.Contains(…)
// bool found = set.Contains(keyForSearching);
// }
// Console.WriteLine("HashSet: {0}", DateTime.Now - start);
// start = DateTime.Now;
// for (int i = 0; i < 50000; i++)
// {
// // Use IEnumerable<Guid>.Contains(…) extension method
// bool found = set.Contains<Guid>(keyForSearching);
// }
// Console.WriteLine("Contains: {0}", DateTime.Now - start);
// start = DateTime.Now;
// for (int i = 0; i < 50000; i++)
// {
// // Use IEnumerable<Guid>.Where(…) extension method
// bool found = set.Where(g => g==keyForSearching).Count() > 0;
// }
// Console.WriteLine("Where: {0}", DateTime.Now - start);

// public class Product
// {
//     public string Name {get; set;}
//     public int CategoryID {get; set;}
// }

// public class Category
// {
//     public int ID {get; set;}
//     public string Name {get; set;}  
// }

// class Dog
// {
// public string Name { get; set; }
// public int Age { get; set; }
// }
// public static class StringExtensions
// {
//     public static int WordCount(this string str)
//     {
//         return str.Split(new char[] {' ', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).Length;
//     }
// }
// public static class IListExtensions
// {
//     public static void IncreaseWith(this IList<int> list, int amount)
//     {
//         for (int i = 0; i < list.Count; i++)
//         {
//             list[i] += amount;
//         }
//     }
// }

// public static class IEnumerableExtensions
// {
//     public static string ToString<T>(this IEnumerable<T> enumeration)
//     {
//         StringBuilder result = new StringBuilder();
//         result.Append("[");

//         foreach (var item in enumeration)
//         {
//             result.Append(item.ToString());
//             result.Append(", ");
//         }

//         if (result.Length > 1)
//         {
//             result.Remove(result.Length - 2, 2);
//         }
//         result.Append("]");
//         return result.ToString();
//     }
// }
