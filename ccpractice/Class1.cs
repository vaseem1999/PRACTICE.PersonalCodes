using System;
using System.Collections.Generic;

class Task
{
  public string Name { get; set; }
  public bool IsCompleted { get; set; }
}

class Program
{
  static List<Task> tasks = new List<Task>();

  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the To-Do List Application!");

    bool exit = false;
    while (!exit)
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Add a new task");
      Console.WriteLine("2. View the to-do list");
      Console.WriteLine("3. Mark a task as completed");
      Console.WriteLine("4. Exit");

      Console.Write("Enter your choice (1/2/3/4): ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          AddTask();
          break;
        case "2":
          ViewToDoList();
          break;
        case "3":
          MarkTaskAsCompleted();
          break;
        case "4":
          exit = true;
          break;
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }
    }

    Console.WriteLine("Goodbye! Press any key to exit.");
    Console.ReadKey();
  }

  static void AddTask()
  {
    Console.Write("Enter the task name: ");
    string taskName = Console.ReadLine();

    Task newTask = new Task
    {
      Name = taskName,
      IsCompleted = false
    };

    tasks.Add(newTask);

    Console.WriteLine("Task added successfully!");
  }

  static void ViewToDoList()
  {
    if (tasks.Count == 0)
    {
      Console.WriteLine("No tasks in the to-do list.");
    }
    else
    {
      Console.WriteLine("To-Do List:");
      for (int i = 0; i < tasks.Count; i++)
      {
        Console.WriteLine($"{i + 1}. [{(tasks[i].IsCompleted ? "X" : " ")}] {tasks[i].Name}");
      }
    }
  }

  static void MarkTaskAsCompleted()
  {
    if (tasks.Count == 0)
    {
      Console.WriteLine("No tasks in the to-do list.");
      return;
    }

    ViewToDoList();

    Console.Write("Enter the task number to mark as completed: ");
    if (int.TryParse(Console.ReadLine(), out int taskNumber))
    {
      if (taskNumber > 0 && taskNumber <= tasks.Count)
      {
        tasks[taskNumber - 1].IsCompleted = true;
        Console.WriteLine("Task marked as completed!");
      }
      else
      {
        Console.WriteLine("Invalid task number.");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid task number.");
    }
  }
}
