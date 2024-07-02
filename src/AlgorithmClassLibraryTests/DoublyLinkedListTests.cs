using AlgorithmClassLibrary;
using System.Text;

namespace AlgorithmClassLibrary.Tests
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void AddLastCountAndNextTest()
        {
            var testData = Common.CreateTestDataArray();
            var list = new DoublyLinkedList<int>();

            foreach (int i in testData)
            {
                list.AddLast(i);
                Assert.True(list.Last.Value == testData[i], $"Successfuly added value to last position at index {i}.");
            }

            Assert.Equal(list.Count, testData.Length);
        }

        [Fact]
        public void AddFirstCountAndPreviousTest()
        {
            int[] testData = Common.CreateTestDataArray();

            DoublyLinkedList<int> list = new();

            foreach (int i in testData)
            {
                list.AddFirst(i);
                Assert.True(list.First.Value == testData[i], $"Successfuly added value to first position at index {i}");
            }

            var currentNode = list.Last;

            for (int i = 0; i < list.Count; i++)
            {
                Assert.Equal(testData[i], currentNode.Value);

                currentNode = currentNode.Previous;
            }
        }

        [Fact]
        public void DoublyLinkedListCount_ShouldReturnTrue()
        {
            var list = new DoublyLinkedList<string>();

            list.AddFirst("Firstly");
            list.AddLast("bump");
            list.AddLast("Lastly");

            Assert.Equal(3, list.Count);

            var currentNode = list.First;

            do
            {
                if (currentNode.Value != null)
                {
                    Console.WriteLine(currentNode.Value);
                }

                currentNode = currentNode.Next;
            } while (currentNode != null);
        }

        [Fact]
        public void DoublyLinkedListOrder_ShouldReturnTrue()
        {
            var list = new DoublyLinkedList<string>();

            list.AddFirst("Firstly");
            list.AddLast("bump");
            list.AddLast("Lastly");

            var currentNode = list.First;
            StringBuilder output = new StringBuilder();

            do
            {
                if (currentNode.Value != null)
                {
                    output.Append(currentNode.Value);
                }

                currentNode = currentNode.Next;
            } while (currentNode != null);

            Assert.True(output.ToString() == "FirstlybumpLastly");
        }
    }
}