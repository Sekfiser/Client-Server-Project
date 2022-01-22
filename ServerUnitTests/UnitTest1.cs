using NUnit.Framework;
using Server;

namespace ServerUnitTests
{
    public class Tests
    {
        public SQLConnector Connector;

        [SetUp]
        public void SetUp()
        {
            var Connector = new SQLConnector();
        }
        /// <summary>
        /// �������� �������� ����������� 
        /// </summary>
        [Test]
        public void Connection_Create_Not_Null()
        {
            Assert.IsNotNull(Connector.Connection);
        }

        /// <summary>
        /// �������� ���������� �������� � ������� 
        /// </summary>
        [Test]
        public void Requests_Exequte_Returns_Not_Null()
        {
            var result = Connector.SelectTimeTable();
            Assert.IsNotNull(result);
        }
    }
}