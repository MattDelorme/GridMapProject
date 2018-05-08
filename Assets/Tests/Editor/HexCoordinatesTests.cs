using NUnit.Framework;
using Shared;

namespace GridMap.Tests
{
    [TestFixture]
    public class HexCoordinatesTests
    {
        [Test]
        public void LineTest1()
        {
            HexCoordinates start = HexCoordinates.FromMapCoordinates(new IntVector2(0, 0));
            HexCoordinates end = HexCoordinates.FromMapCoordinates(new IntVector2(6, 0));

            var lineList = HexCoordinates.GetLine(start, end);

            Assert.AreEqual(6, lineList.Count);

            for (int i = 0; i < lineList.Count; i++)
            {
                Assert.AreEqual(i + 1, lineList[i].MapCoordinates.X);
                Assert.AreEqual(0, lineList[i].MapCoordinates.Y);
            }
        }

        [Test]
        public void LineTest2()
        {
            HexCoordinates start = new HexCoordinates(0, 0);
            HexCoordinates end = new HexCoordinates(0, 6);

            var lineList = HexCoordinates.GetLine(start, end);

            Assert.AreEqual(6, lineList.Count);

            for (int i = 0; i < lineList.Count; i++)
            {
                Assert.AreEqual(0, lineList[i].X);
                Assert.AreEqual(i + 1, lineList[i].Z);
            }
        }
    }
}
