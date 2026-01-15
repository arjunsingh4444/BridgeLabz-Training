using System;

namespace BrowserBuddy
{
    // Doubly Linked List Node
    class PageNode
    {
        public string Url; // URL of the page
        public PageNode Prev;
        public PageNode Next;

        public PageNode(string url) // Constructor
        {
            Url = url;
            Prev = null;
            Next = null;
        }
    }

    // Stack Node for Closed Tabs
    class ClosedTabNode
    {
        public PageNode HistoryPointer; // Pointer to the page node
        public ClosedTabNode Next; // Next node in the stack

        public ClosedTabNode(PageNode pointer) // Constructor
        {
            HistoryPointer = pointer; // Set the page node pointer
            Next = null;
        }
    }

    // Stack for closed tabs
    class ClosedTabStack
    {
        private ClosedTabNode top; // Top of the stack

        public void Push(PageNode pointer) // Push a new node to the stack
        {
            ClosedTabNode node = new ClosedTabNode(pointer); // Create new stack node
            node.Next = top;
            top = node;
        }

        public PageNode Pop() // Pop the top node from the stack
        {
            if (top == null)
                return null;

            PageNode data = top.HistoryPointer; // Get the page node pointer
            top = top.Next;
            return data;
        }

        public bool IsEmpty() // Check if the stack is empty
        {
            return top == null;
        }
    }

    // Browser Tab with Doubly Linked List
    class BrowserTab
    {
        private PageNode current; // Current page node

        public void Visit(string url) // Visit a new page
        {
            PageNode newPage = new PageNode(url); // Create new page node

            if (current != null) // Link the new page
            {
                current.Next = null;
                newPage.Prev = current;
                current.Next = newPage;
            }

            current = newPage;
            Console.WriteLine($"Visited: {url}");
        }

        public void GoBack() // Go back to previous page
        {
            if (current != null && current.Prev != null) // Check if there is a previous page
            {
                current = current.Prev;
                Console.WriteLine($"Back to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No previous page");
            }
        }

        public void GoForward() // Go forward to next page
        { 
            if (current != null && current.Next != null) // Check if there is a next page
            {
                current = current.Next;
                Console.WriteLine($"Forward to: {current.Url}");
            }
            else
            {
                Console.WriteLine("No forward page");
            }
        }

        public PageNode CloseTab() // Close the current tab and return the page node pointer
        {
            Console.WriteLine("Tab closed");
            return current;
        }

        public void RestoreTab(PageNode pointer) // Restore a closed tab with the page node pointer
        {
            current = pointer;
            Console.WriteLine($"Tab restored at: {current.Url}");
        }

        public void ShowCurrent() // Show the current page URL
        {
            if (current != null)
                Console.WriteLine($"Current Page: {current.Url}");
            else
                Console.WriteLine("No active tab");
        }
    }

    class BrowserBuddyMain
    {
        static void Main() // Main function
        {
            BrowserTab tab = new BrowserTab();
            ClosedTabStack closedTabs = new ClosedTabStack();

            int choice;

            do
            {
                Console.WriteLine("\n--- BrowserBuddy Menu ---"); // Menu options
                Console.WriteLine("1. Visit New Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Show Current Page");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                choice = Convert.ToInt32(Console.ReadLine()); // Read user choice

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        tab.Visit(Console.ReadLine());
                        break;

                    case 2:
                        tab.GoBack();
                        break;

                    case 3:
                        tab.GoForward();
                        break;

                    case 4:
                        closedTabs.Push(tab.CloseTab());
                        break;

                    case 5:
                        if (!closedTabs.IsEmpty())
                            tab.RestoreTab(closedTabs.Pop());
                        else
                            Console.WriteLine("No closed tabs to restore");
                        break;

                    case 6:
                        tab.ShowCurrent();
                        break;
                }

            } while (choice != 0);
        }
    }
}