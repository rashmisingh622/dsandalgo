// See https://aka.ms/new-console-template for more information
using DailyChallenge;
using DailyChallenge.Models;

//var shift = new Shift2DGrid();
//var result = shift.ShiftGrid(new int[3][] { new int[]{ 1, 2, 3 }, new int[]{ 4, 5, 6 }, new int[]{ 7, 8, 9 } }, 1);
Console.WriteLine("Hello, World!!!");
var newNode = new Node(1);
newNode.AddNode(new Node(2));
newNode.AddNode(new Node(3));
newNode.AddNode(new Node(4));
newNode.AddNode(new Node(5));
newNode.PrintLinkedList();
var reversedList = newNode.ReverseLinkedList();
reversedList.PrintLinkedList();
