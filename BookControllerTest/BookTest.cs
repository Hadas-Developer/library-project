using LibraryApplicastion;
using LibraryApplicastion.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryControllerTest
{
    public class BookTest
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
        public void Get_ReturnCount()
        {
            //AAA

            //ARRANGE - בחלק זה אנחנו נגדיר את המשתנים שצריך לשלוח לפונקציה

            //ACT - בחלק זה נפעיל את הפונקציה
            var controller = new CustomerController(fakeContext);
            var result = controller.Get();

            //ASSERT - בחלק זה נכריז על התוצאה שאנחנו מצפות לקבל מהפונקציה
            Assert.Equal(3, result.Count());
        }

       
    }
}
