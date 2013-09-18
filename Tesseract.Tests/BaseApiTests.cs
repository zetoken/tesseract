using System;
using System.Diagnostics;
using NUnit.Framework;
using Tesseract.Wrapper;

namespace Tesseract.Tests
{
    [TestFixture]
    public class BaseApiTests
    {
        [Test]
        public void GetVersion_Is302()
        {
            var version = TesseractPrimitives.Api.GetVersion();
            Assert.That(version, Is.EqualTo("3.02"));
        }
    }
}
