using DFe.Print.Core;
using System;
using Xunit;

namespace DFe.Print.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var data = new NFe()
            {
                ChaveAcesso = "01234567890123456789012345678901234567890123"
            };
            var printer = new NFePrinter();

            var result = printer.ToHtml(data);
        }
    }
}
