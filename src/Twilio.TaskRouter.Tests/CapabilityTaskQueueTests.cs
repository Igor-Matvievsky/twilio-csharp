﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JWT;

namespace Twilio.TaskRouter.Tests
{
    [TestFixture]
    public class CapabilityTaskQueueTests
    {
		private TaskRouterTaskQueueCapability cap;

        [SetUp]
        public void Setup()
        {
			cap = new TaskRouterTaskQueueCapability("AC123", "foobar", "WS456", "WQ789");
        }

        [Test]
        public void ShouldGenerateToken()
        {
            var token = cap.GenerateToken();
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;
            Assert.AreEqual("AC123", payload["iss"]);
            Assert.AreEqual("AC123", payload["account_sid"]);
            Assert.AreEqual("WS456", payload["workspace_sid"]);
			Assert.AreEqual("WQ789", payload["taskqueue_sid"]);
			Assert.AreEqual("WQ789", payload["channel"]);
            Assert.AreEqual("v1", payload["version"]);
			Assert.AreEqual("WQ789", payload["friendly_name"]);
        }

        [Test]
        public void ShouldGenerateTokenWithDefaultTtl()
        {
            var token = cap.GenerateToken();
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;
            var expiration = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds + 3600;

            Assert.AreEqual(expiration, payload["exp"]);
        }

        [Test]
        public void ShouldGenerateTokenWithSpecifiedTtl()
        {
            var token = cap.GenerateToken(10000);
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;
            var expiration = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds + 10000;

            Assert.AreEqual(expiration, payload["exp"]);
        }

        [Test]
        public void ShouldAllowDefaults()
        {
            var token = cap.GenerateToken();
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;

            var policies = payload["policies"] as System.Collections.IList;
            Assert.AreEqual(3, policies.Count);
			var url = "https://event-bridge.twilio.com/v1/wschannels/AC123/WQ789";

            var getPolicy = policies[0] as IDictionary<string, object>;
            Assert.AreEqual(url, getPolicy["url"]);
            Assert.AreEqual("GET", getPolicy["method"]);
            Assert.IsTrue((bool) getPolicy["allow"]);
            var queryFilter = getPolicy["query_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(queryFilter);
            var postFilter = getPolicy["post_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(postFilter);

            var postPolicy = policies[1] as IDictionary<string, object>;
            Assert.AreEqual(url, postPolicy["url"]);
            Assert.AreEqual("POST", postPolicy["method"]);
            Assert.IsTrue((bool)postPolicy["allow"]);
            queryFilter = postPolicy["query_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(queryFilter);
            postFilter = postPolicy["post_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(postFilter);

			var taskQueueFetchPolicy = policies[2] as IDictionary<string, object>;
			Assert.AreEqual("https://taskrouter.twilio.com/v1/Workspaces/WS456/TaskQueues/WQ789", taskQueueFetchPolicy["url"]);
			Assert.AreEqual("GET", taskQueueFetchPolicy["method"]);
			Assert.IsTrue((bool)taskQueueFetchPolicy["allow"]);
			queryFilter = taskQueueFetchPolicy["query_filter"] as IDictionary<string, object>;
			Assert.IsEmpty(queryFilter);
			postFilter = taskQueueFetchPolicy["post_filter"] as IDictionary<string, object>;
			Assert.IsEmpty(postFilter);
        }

        [Test]
        public void ShouldAllowFetchAll()
        {
			cap.AllowFetchSubresources();
            var token = cap.GenerateToken();
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;

            var policies = payload["policies"] as System.Collections.IList;
            Assert.AreEqual(4, policies.Count);

			var url = "https://taskrouter.twilio.com/v1/Workspaces/WS456/TaskQueues/WQ789/**";
            var policy = policies[3] as IDictionary<string, object>;

            Assert.AreEqual(url, policy["url"]);
            Assert.AreEqual("GET", policy["method"]);
            Assert.IsTrue((bool)policy["allow"]);
            var queryFilter = policy["query_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(queryFilter);
            var postFilter = policy["post_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(postFilter);
        }

        [Test]
        public void ShouldAllowUpdateAll()
        {
			cap.AllowUpdatesSubresources();
            var token = cap.GenerateToken();
            Assert.IsNotNullOrEmpty(token);

            var payload = JsonWebToken.DecodeToObject(token, "foobar") as IDictionary<string, object>;

            var policies = payload["policies"] as System.Collections.IList;
            Assert.AreEqual(4, policies.Count);

			var url = "https://taskrouter.twilio.com/v1/Workspaces/WS456/TaskQueues/WQ789/**";
            var policy = policies[3] as IDictionary<string, object>;

            Assert.AreEqual(url, policy["url"]);
            Assert.AreEqual("POST", policy["method"]);
            Assert.IsTrue((bool)policy["allow"]);
            var queryFilter = policy["query_filter"] as IDictionary<string, object>;
            Assert.IsEmpty(queryFilter);
            var postFilter = policy["post_filter"] as IDictionary<string, object>;
			Assert.IsEmpty(postFilter);
        }
    }
}
