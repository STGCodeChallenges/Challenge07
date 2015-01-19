using System;
using Xunit;

namespace Isbn10API.Tests
{
    public class SupportTest
    {
        [Fact]
        public void ShouldGenerateValidIsbn10()
        {
            var isbn = Support.Isbn10API.Generate();

            Assert.NotNull(isbn);
            Assert.NotEmpty(isbn);
            Assert.Equal(10, isbn.Length);
            Assert.True(Support.Isbn10API.IsValid(isbn));
        }

        [Theory]
        [InlineData("0-7475-3269-9")]
        [InlineData("156881111X")]
        [InlineData("1428263934")]
        public void ShouldValidateValidIsbn10(string isbn)
        {
            Assert.True(Support.Isbn10API.IsValid(isbn));
        }

        [Theory]
        [InlineData("0-7475-3269-8")]
        [InlineData("1568811119")]
        [InlineData("1428263933")]
        public void ShouldNotValidateIsbn10(string isbn)
        {
            Assert.False(Support.Isbn10API.IsValid(isbn));
        }
    }
}