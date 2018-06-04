using System;
using Xunit;
using NibApi.Controllers;
using NibApi.Core;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;

namespace NibApiTests
{
    public class NumberSequenceControllerTest
    {
        [Fact]
        public void Can_Return_AllNumber()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable<int> data = controller.GetAllNumber(10).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal(11, data.Count());

            Assert.Equal(0, data.ElementAt(0));
            Assert.Equal(1, data.ElementAt(1));
            Assert.Equal(2, data.ElementAt(2));
            Assert.Equal(3, data.ElementAt(3));
            Assert.Equal(4, data.ElementAt(4));
            Assert.Equal(5, data.ElementAt(5));
            Assert.Equal(6, data.ElementAt(6));
            Assert.Equal(7, data.ElementAt(7));
            Assert.Equal(8, data.ElementAt(8));
            Assert.Equal(9, data.ElementAt(9));
            Assert.Equal(10, data.ElementAt(10));

        }
        
        [Fact]
        public void Can_Return_EvenNumber()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable<int> data = controller.GetEvenNumber(10).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal(6, data.Count());
            Assert.Equal(0, data.ElementAt(0));
            Assert.Equal(2, data.ElementAt(1));
            Assert.Equal(4, data.ElementAt(2));
            Assert.Equal(6, data.ElementAt(3));
            Assert.Equal(8, data.ElementAt(4));
            Assert.Equal(10, data.ElementAt(5));           
        }
        
        [Fact]
        public void Can_Return_OddNumber()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable<int> data = controller.GetOddNumber(10).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal(5, data.Count());
            Assert.Equal(1, data.ElementAt(0));
            Assert.Equal(3, data.ElementAt(1));
            Assert.Equal(5, data.ElementAt(2));
            Assert.Equal(7, data.ElementAt(3));
            Assert.Equal(9, data.ElementAt(4));           

        }
        [Fact]
        public void Can_Return_Character_C()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable data = controller.GetAllNumberCharacter(9).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal("C", data);

        }
        [Fact]
        public void Can_Return_Character_E()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable data = controller.GetAllNumberCharacter(10).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal("E", data);

        }
        [Fact]
        public void Can_Return_Character_Z()
        {

            //Arrange
            NumberSequenceCalculation mockObject = new NumberSequenceCalculation();

            NumberSequenceController controller = new NumberSequenceController(mockObject);

            //Act
            IEnumerable data = controller.GetAllNumberCharacter(105).GetAwaiter().GetResult();

            //Assert
            Assert.NotNull(data);
            Assert.Equal("Z", data);

        }
        
    }
}
