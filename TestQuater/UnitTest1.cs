
using LibQuaternion;

namespace TestQuater
{
    public class Tests
    {
        [Test]
        public void TestAddition()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);
            var result = q1 + q2;
            Assert.AreEqual(new Quaternion(6, 8, 10, 12), result);
        }

        [Test]
        public void TestSubtraction()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);
            var result = q1 - q2;
            Assert.AreEqual(new Quaternion(-4, -4, -4, -4), result);
        }

        [Test]
        public void TestMultiplication()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);
            var result = q1 * q2;
            Assert.AreEqual(new Quaternion(-60, 12, 4, 10), result);
        }

        [Test]
        public void TestAbs()
        {
            var q = new Quaternion(1, 2, 3, 4);
            Assert.AreEqual(Math.Sqrt(30), q.Abs, 1e-13);
        }

        [Test]
        public void TestEquality()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(1, 2, 3, 4);
            Assert.IsTrue(q1 == q2);
        }

        [Test]
        public void TestHashCode()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(1, 2, 3, 4);
            Assert.AreEqual(q1.GetHashCode(), q2.GetHashCode());
        }
    }
}