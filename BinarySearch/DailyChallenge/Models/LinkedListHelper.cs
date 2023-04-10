using System;
namespace DailyChallenge.Models
{
	public static class LinkedListHelper
	{ 
		public static Node AddNode(this Node startNode, Node newNode)
		{
			Node original = startNode;
			while (startNode.next != null)
			{
				startNode = startNode.next;
			}

			startNode.next = newNode;
			return original;
		}
	}
}

