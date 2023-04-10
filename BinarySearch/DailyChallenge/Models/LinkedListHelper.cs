﻿using System;
namespace DailyChallenge.Models
{
	public static class LinkedListHelper
	{ 
		public static void AddNode(this Node startNode, Node newNode)
		{
			Node original = startNode;
			while (startNode != null && startNode.next != null)
			{
				startNode = startNode.next;
			}

			if (startNode != null)
            {
                startNode.next = newNode;
            }
		}

		public static void PrintLinkedList(this Node start)
		{
			while (start != null)
			{
				Console.WriteLine($"The element : {start.value}");
				start = start.next;
			}
		}
	}
}

