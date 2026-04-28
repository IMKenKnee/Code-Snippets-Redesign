using CodeSnippets2.Models;

namespace CodeSnippets2.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext db)
    {
        if (db.Categories.Any()) return;

        var sorting = new Category
        {
            Id = 1,
            Name = "Sorting Algorithms",
            Description = "Algorithms that arrange data into a useful order.",
            Slug = "sorting",
            ImagePath = "/images/logo-solo.png"
        };

        var searching = new Category
        {
            Id = 2,
            Name = "Searching Algorithms",
            Description = "Algorithms that find values inside a collection.",
            Slug = "searching",
            ImagePath = "/images/logo-solo.png"
        };

        var dataStructures = new Category
        {
            Id = 3,
            Name = "Data Structures",
            Description = "Ways to organize and store information in code.",
            Slug = "data-structures",
            ImagePath = "/images/logo-solo.png"
        };

        db.Categories.AddRange(sorting, searching, dataStructures);

        db.Snippets.AddRange(
            new Snippet
            {
                Title = "Bubble Sort",
                Description = "A beginner-friendly sorting algorithm that repeatedly swaps adjacent values.",
                Language = "JavaScript",
                Difficulty = "Easy",
                UseCase = "Best for teaching sorting logic, not for large datasets.",
                CategoryId = 1,
                Code = """
function bubbleSort(arr) {
  for (let i = 0; i < arr.length; i++) {
    for (let j = 0; j < arr.length - i - 1; j++) {
      if (arr[j] > arr[j + 1]) {
        [arr[j], arr[j + 1]] = [arr[j + 1], arr[j]];
      }
    }
  }

  return arr;
}
"""
            },
            new Snippet
            {
                Title = "Selection Sort",
                Description = "Finds the smallest value and moves it into the correct position.",
                Language = "JavaScript",
                Difficulty = "Easy",
                UseCase = "Useful for learning comparison-based sorting.",
                CategoryId = 1,
                Code = """
function selectionSort(arr) {
  for (let i = 0; i < arr.length; i++) {
    let minIndex = i;

    for (let j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[minIndex]) {
        minIndex = j;
      }
    }

    [arr[i], arr[minIndex]] = [arr[minIndex], arr[i]];
  }

  return arr;
}
"""
            },
            new Snippet
            {
                Title = "Binary Search",
                Description = "A fast search algorithm for sorted arrays.",
                Language = "JavaScript",
                Difficulty = "Medium",
                UseCase = "Best when the data is already sorted.",
                CategoryId = 2,
                Code = """
function binarySearch(arr, target) {
  let left = 0;
  let right = arr.length - 1;

  while (left <= right) {
    const mid = Math.floor((left + right) / 2);

    if (arr[mid] === target) return mid;
    if (arr[mid] < target) left = mid + 1;
    else right = mid - 1;
  }

  return -1;
}
"""
            },
            new Snippet
            {
                Title = "Arrays",
                Description = "A basic data structure that stores items in indexed order.",
                Language = "JavaScript",
                Difficulty = "Easy",
                UseCase = "Useful when you need ordered, index-based storage.",
                CategoryId = 3,
                Code = """
const numbers = [10, 20, 30, 40];

console.log(numbers[0]); // 10

numbers.push(50);

console.log(numbers);
"""
            }
        );

        db.SaveChanges();
    }
}