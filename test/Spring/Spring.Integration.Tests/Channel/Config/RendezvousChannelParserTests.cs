#region License

/*
 * Copyright 2002-2009 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF Any KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region

using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using Spring.Integration.Channel;
using Spring.Integration.Config.Xml;
using Spring.Objects.Factory.Xml;

#endregion

namespace Spring.Integration.Tests.Channel.Config
{
    /// <author>Mark Fisher</author>
    /// <author>Andreas D�hring (.NET)</author>
    [TestFixture]
    public class RendezvousChannelParserTests
    {
        [Test]
        public void testRendezvous()
        {
            NamespaceParserRegistry.RegisterParser(typeof (IntegrationNamespaceParser));

            IApplicationContext ctx = new XmlApplicationContext(@"Channel\Config\RendezvousChannelParserTests.xml");

            object channel = ctx.GetObject("channel");
            Assert.That(channel.GetType(), Is.EqualTo(typeof (RendezvousChannel)));
        }
    }
}