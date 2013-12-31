﻿using System.Configuration;
using FluentAssertions;
using MessageBus.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.UnitTests
{
    [TestClass]
    public class RabbitMQBusConfigSectionHandlerTest
    {
        [TestMethod]
        public void TestConfiguration()
        {
            RabbitMQBusConfigSectionHandler section = (RabbitMQBusConfigSectionHandler) ConfigurationManager.GetSection(RabbitMQBusConfigSectionHandler.SectionName);

            section.BrokerHost.Should().Be("myHost");
            section.Exchange.Should().Be("myExchange");
            section.Port.Should().Be(1234);

            section.ReaderQuotas.Should().NotBeNull();
            section.ReaderQuotas.MaxBytesPerRead.Should().Be(4096);
            section.ReaderQuotas.MaxDepth.Should().Be(2147483647);
            section.ReaderQuotas.MaxArrayLength.Should().Be(2147483647);
            section.ReaderQuotas.MaxNameTableCharCount.Should().Be(2147483647);
            section.ReaderQuotas.MaxStringContentLength.Should().Be(2147483647);
        }
    }
}
