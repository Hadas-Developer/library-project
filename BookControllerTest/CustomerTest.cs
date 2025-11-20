using LibraryApplicastion;
using LibraryApplicastion.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BookControllerTest
{
    public class CustomerTest
    {
        private readonly FakeData fakeContext = new FakeData();
        [Fact]
        public void Get_ReturnList()
        {
            //AAA

            //ARRANGE - בחלק זה אנחנו נגדיר את המשתנים שצריך לשלוח לפונקציה

            //ACT - בחלק זה נפעיל את הפונקציה
            var controller = new CustomerController(fakeContext);
            var result = controller.Get();

            //ASSERT - בחלק זה נכריז על התוצאה שאנחנו מצפות לקבל מהפונקציה
            Assert.IsType<List<Customer>>(result);
        }

        [Fact]
        public void GetById_ReturnOk()
        {
            //AAA

            //ARRANGE - בחלק זה אנחנו נגדיר את המשתנים שצריך לשלוח לפונקציה
            var id = 002;
            //ACT - בחלק זה נפעיל את הפונקציה
            var controller = new CustomerController(fakeContext);
            var result = controller.Get(id);

            //ASSERT - בחלק זה נכריז על התוצאה שאנחנו מצפות לקבל מהפונקציה
            Assert.IsType<OkObjectResult>(result);
        }


    }
}