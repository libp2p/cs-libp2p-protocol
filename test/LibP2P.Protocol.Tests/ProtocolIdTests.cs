using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibP2P.Protocol.Tests
{
    public class ProtocolIdTests
    {
        [Fact]
        public void Constructor_GivenProtocol_ReturnsValidProtocolId()
        {
            var pid = new ProtocolId("/test/pid");

            Assert.Equal(pid.ToString(), "/test/pid");
        }

        [Fact]
        public void Equals_GivenTwoEqualIds_ReturnsEquality()
        {
            var pid1 = new ProtocolId("/test/pid");
            var pid2 = new ProtocolId("/test/pid");

            Assert.Equal(pid1, pid2);
        }

        [Fact]
        public void Equals_GivenTwoNotEqualIds_ReturnsNoEquality()
        {
            var pid1 = new ProtocolId("/test/pid1");
            var pid2 = new ProtocolId("/test/pid2");

            Assert.NotEqual(pid1, pid2);
        }

        [Fact]
        public void Cast_GivenString_ReturnsProtocolId()
        {
            var pids = "/test/pid";
            var pid = (ProtocolId) pids;

            Assert.IsType<ProtocolId>(pid);
            Assert.Equal(pid.ToString(), pids);
        }

        [Fact]
        public void Cast_GivenProtocolId_ReturnsString()
        {
            var pid = new ProtocolId("/test/pid");
            var pids = (string) pid;

            Assert.Equal(pids, pid.ToString());
        }
    }
}
