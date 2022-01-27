using Moq;
using SandBox.Services;
using SandBox.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SandBox.Tests.UnitTests
{
    /// <summary>
    /// Tests Service2_WithInjection
    /// with applied Mocking for DI simulation (with decoupling)
    /// </summary>
    public class Service2_WithInjection_Tests
    {
        [Fact] // Static values, no parameters
        public void Add_StaticTest()
        {
            #region Coupled Way (Bad Practice)

            // Coupling with Class1 ** Bad Practice,Class2_WithInjection will depend on Class1 **
            //Class2_WithInjection class2_WithInjection = new Class2_WithInjection(new Class1());

            #endregion

            #region Decopling Way by Mocking (Good Practice)

            var class1Mock = new Mock<IService1>();

            // Pass
            class1Mock.Setup(m => m.Add(1, 2)).Returns(3);

            // Fail
            //class1Mock.Setup(m => m.Add(1, 2)).Returns(5);

            #endregion          

            // Assert
            Assert.Equal(3, new Service2_WithInjection(class1Mock.Object).Adder(1, 2));
        }

        [Fact] // Static values, no parameters
        public void Out_VerifyHasBeenCalled()
        {
            #region Mocking (Decoupling)

            var class1Mock = new Mock<IService1>();

            var class2Obj = new Service2_WithInjection(class1Mock.Object);

            // Pass (Adder method should be calling Out(1,1) in order that test case pass)
            class2Obj.Adder(1, 1);

            // Fail
            //class2Obj.Adder(1, 1);
            //class2Obj.Adder(2, 5);

            // Verify: used to verify that a void method has been called

            // Pass if all verified successfully
            class1Mock.Verify(m => m.Out(1, 1), Times.Once, "Out(1,1) Not called");           
            class1Mock.Verify(m => m.Out(1, 1), Times.AtMost(1), "Out(1,1) called more than 1 time");
            class1Mock.Verify(m => m.Out(1, 1), Times.Exactly(1), "Out(1,1) Not called exactly 1 time ");

            // Fail if any verification failed
            //class1Mock.Verify(m => m.Out(1, 0), Times.AtLeastOnce, "Out(1,1) Not called");
            //class1Mock.Verify(m => m.Out(1, 1), Times.AtLeast(2), "Out(1,1) called less than 2 times");

            #endregion         

            // Assert
            //Assert.Equal(3, class2Obj.Adder(1, 2));
        }
    }
}
