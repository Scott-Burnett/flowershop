using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            var orderDAO = Substitute.For<IOrderDAO>();
            var client = Substitute.For<IClient>();
            Order order = new Order(orderDAO, client);

            //ACT
            try{
                order.Deliver();
            }
            //ASSERT
            catch{ 
                orderDAO.Received().SetDelivered(order);               
            }
        }
    }
}