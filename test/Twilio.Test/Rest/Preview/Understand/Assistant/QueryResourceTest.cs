/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.Understand.Assistant;

namespace Twilio.Tests.Rest.Preview.Understand.Assistant
{

    [TestFixture]
    public class QueryTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/understand/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Queries/UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                QueryResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"language\": \"language\",\"date_created\": \"2015-07-30T20:00:00Z\",\"model_build_sid\": \"UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"query\": \"query\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"status\",\"sample_sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"results\": {\"task\": {\"name\": \"name\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"confidence\": 0.9},\"entities\": [{\"name\": \"name\",\"value\": \"value\",\"type\": \"type\"}]},\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries/UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_channel\": \"voice\"}"
                                     ));

            var response = QueryResource.Fetch("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/understand/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Queries",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                QueryResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"queries\": [],\"meta\": {\"previous_page_url\": null,\"next_page_url\": null,\"first_page_url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries?Status=status&ModelBuild=UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Language=language&PageSize=50&Page=0\",\"page\": 0,\"key\": \"queries\",\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries?Status=status&ModelBuild=UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Language=language&PageSize=50&Page=0\",\"page_size\": 50}}"
                                     ));

            var response = QueryResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"queries\": [{\"language\": \"language\",\"date_created\": \"2015-07-30T20:00:00Z\",\"model_build_sid\": \"UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"query\": \"query\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"status\",\"sample_sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"results\": {\"task\": {\"name\": \"name\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"confidence\": 0.9},\"entities\": [{\"name\": \"name\",\"value\": \"value\",\"type\": \"type\"}]},\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries/UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_channel\": null}],\"meta\": {\"previous_page_url\": null,\"next_page_url\": null,\"first_page_url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries?Status=status&ModelBuild=UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Language=language&PageSize=50&Page=0\",\"page\": 0,\"key\": \"queries\",\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries?Status=status&ModelBuild=UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Language=language&PageSize=50&Page=0\",\"page_size\": 50}}"
                                     ));

            var response = QueryResource.Read("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/understand/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Queries",
                ""
            );
            request.AddPostParam("Language", Serialize("language"));
            request.AddPostParam("Query", Serialize("query"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                QueryResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "language", "query", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"language\": \"language\",\"date_created\": \"2015-07-30T20:00:00Z\",\"model_build_sid\": \"UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"query\": \"query\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"status\",\"sample_sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"results\": {\"task\": {\"name\": \"name\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"confidence\": 0.9},\"entities\": [{\"name\": \"name\",\"value\": \"value\",\"type\": \"type\"}]},\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries/UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_channel\": \"voice\"}"
                                     ));

            var response = QueryResource.Create("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "language", "query", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/understand/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Queries/UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                QueryResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"language\": \"language\",\"date_created\": \"2015-07-30T20:00:00Z\",\"model_build_sid\": \"UGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"query\": \"query\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"status\",\"sample_sid\": \"UFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assistant_sid\": \"UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"results\": {\"task\": {\"name\": \"name\",\"task_sid\": \"UDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"confidence\": 0.9},\"entities\": [{\"name\": \"name\",\"value\": \"value\",\"type\": \"type\"}]},\"url\": \"https://preview.twilio.com/understand/Assistants/UAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Queries/UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"UHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"source_channel\": \"sms\"}"
                                     ));

            var response = QueryResource.Update("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Preview,
                "/understand/Assistants/UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Queries/UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                QueryResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = QueryResource.Delete("UAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}