using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void Should_Return_Error_When_CNPJ_IsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);

            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void Should_Return_Success_When_CNPJ_IsValid()
        {
            var doc = new Document("34110468000150", EDocumentType.CNPJ);

            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void Should_Return_Error_When_CPF_IsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);

            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("63526891753")]
        [DataRow("52082583740")]
        [DataRow("45462747268")]
        public void Should_Return_Success_When_CPF_IsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);

            Assert.IsTrue(doc.Valid);
        }
    }
}