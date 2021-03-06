/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// PaymentResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Call
{

    public class PaymentResource : Resource
    {
        public sealed class PaymentMethodEnum : StringEnum
        {
            private PaymentMethodEnum(string value) : base(value) {}
            public PaymentMethodEnum() {}
            public static implicit operator PaymentMethodEnum(string value)
            {
                return new PaymentMethodEnum(value);
            }

            public static readonly PaymentMethodEnum CreditCard = new PaymentMethodEnum("credit-card");
            public static readonly PaymentMethodEnum AchDebit = new PaymentMethodEnum("ach-debit");
        }

        public sealed class BankAccountTypeEnum : StringEnum
        {
            private BankAccountTypeEnum(string value) : base(value) {}
            public BankAccountTypeEnum() {}
            public static implicit operator BankAccountTypeEnum(string value)
            {
                return new BankAccountTypeEnum(value);
            }

            public static readonly BankAccountTypeEnum ConsumerChecking = new BankAccountTypeEnum("consumer-checking");
            public static readonly BankAccountTypeEnum ConsumerSavings = new BankAccountTypeEnum("consumer-savings");
            public static readonly BankAccountTypeEnum CommercialChecking = new BankAccountTypeEnum("commercial-checking");
        }

        public sealed class TokenTypeEnum : StringEnum
        {
            private TokenTypeEnum(string value) : base(value) {}
            public TokenTypeEnum() {}
            public static implicit operator TokenTypeEnum(string value)
            {
                return new TokenTypeEnum(value);
            }

            public static readonly TokenTypeEnum OneTime = new TokenTypeEnum("one-time");
            public static readonly TokenTypeEnum Reusable = new TokenTypeEnum("reusable");
        }

        public sealed class CaptureEnum : StringEnum
        {
            private CaptureEnum(string value) : base(value) {}
            public CaptureEnum() {}
            public static implicit operator CaptureEnum(string value)
            {
                return new CaptureEnum(value);
            }

            public static readonly CaptureEnum PaymentCardNumber = new CaptureEnum("payment-card-number");
            public static readonly CaptureEnum ExpirationDate = new CaptureEnum("expiration-date");
            public static readonly CaptureEnum SecurityCode = new CaptureEnum("security-code");
            public static readonly CaptureEnum PostalCode = new CaptureEnum("postal-code");
            public static readonly CaptureEnum BankRoutingNumber = new CaptureEnum("bank-routing-number");
            public static readonly CaptureEnum BankAccountNumber = new CaptureEnum("bank-account-number");
        }

        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Complete = new StatusEnum("complete");
            public static readonly StatusEnum Cancel = new StatusEnum("cancel");
        }

        private static Request BuildCreateRequest(CreatePaymentOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Calls/" + options.PathCallSid + "/Payments.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create an instance of payments. This will start a new payments session
        /// </summary>
        /// <param name="options"> Create Payment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payment </returns>
        public static PaymentResource Create(CreatePaymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create an instance of payments. This will start a new payments session
        /// </summary>
        /// <param name="options"> Create Payment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payment </returns>
        public static async System.Threading.Tasks.Task<PaymentResource> CreateAsync(CreatePaymentOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create an instance of payments. This will start a new payments session
        /// </summary>
        /// <param name="pathCallSid"> The SID of the call that will create the resource. </param>
        /// <param name="idempotencyKey"> A unique token for each payment session that should be provided to maintain
        ///                      idempotency of the session. </param>
        /// <param name="statusCallback"> The URL we should call to send status of payment session. </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="bankAccountType"> If Payment source is ACH, type of bank account. </param>
        /// <param name="chargeAmount"> If this field is present and greater than `0.0` payment source will be charged. </param>
        /// <param name="currency"> Currency `charge_amount` is in. </param>
        /// <param name="description"> Decription of the charge. </param>
        /// <param name="input"> Kind of medium customer would enter payment source information in. </param>
        /// <param name="minPostalCodeLength"> If postal code is expected, minimum length of the postal code. </param>
        /// <param name="parameter"> Additonal data to be sent over to payment provider. </param>
        /// <param name="paymentConnector"> Payment connector that you would like Twilio to use for processing payments.
        ///                        </param>
        /// <param name="paymentMethod"> Payment source type. </param>
        /// <param name="postalCode"> Whether to expect postal code during payment source data gathering. </param>
        /// <param name="securityCode"> Whether to expect security code during payment source data gathering. </param>
        /// <param name="timeout"> The number of seconds that we should allow customer to enter payment information </param>
        /// <param name="tokenType"> If tokenization of payment source is desired, this represents type of token. </param>
        /// <param name="validCardTypes"> List of card types accepted with each card types separated by space. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payment </returns>
        public static PaymentResource Create(string pathCallSid,
                                             string idempotencyKey,
                                             Uri statusCallback,
                                             string pathAccountSid = null,
                                             PaymentResource.BankAccountTypeEnum bankAccountType = null,
                                             decimal? chargeAmount = null,
                                             string currency = null,
                                             string description = null,
                                             string input = null,
                                             int? minPostalCodeLength = null,
                                             object parameter = null,
                                             string paymentConnector = null,
                                             PaymentResource.PaymentMethodEnum paymentMethod = null,
                                             bool? postalCode = null,
                                             bool? securityCode = null,
                                             int? timeout = null,
                                             PaymentResource.TokenTypeEnum tokenType = null,
                                             string validCardTypes = null,
                                             ITwilioRestClient client = null)
        {
            var options = new CreatePaymentOptions(pathCallSid, idempotencyKey, statusCallback){PathAccountSid = pathAccountSid, BankAccountType = bankAccountType, ChargeAmount = chargeAmount, Currency = currency, Description = description, Input = input, MinPostalCodeLength = minPostalCodeLength, Parameter = parameter, PaymentConnector = paymentConnector, PaymentMethod = paymentMethod, PostalCode = postalCode, SecurityCode = securityCode, Timeout = timeout, TokenType = tokenType, ValidCardTypes = validCardTypes};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create an instance of payments. This will start a new payments session
        /// </summary>
        /// <param name="pathCallSid"> The SID of the call that will create the resource. </param>
        /// <param name="idempotencyKey"> A unique token for each payment session that should be provided to maintain
        ///                      idempotency of the session. </param>
        /// <param name="statusCallback"> The URL we should call to send status of payment session. </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="bankAccountType"> If Payment source is ACH, type of bank account. </param>
        /// <param name="chargeAmount"> If this field is present and greater than `0.0` payment source will be charged. </param>
        /// <param name="currency"> Currency `charge_amount` is in. </param>
        /// <param name="description"> Decription of the charge. </param>
        /// <param name="input"> Kind of medium customer would enter payment source information in. </param>
        /// <param name="minPostalCodeLength"> If postal code is expected, minimum length of the postal code. </param>
        /// <param name="parameter"> Additonal data to be sent over to payment provider. </param>
        /// <param name="paymentConnector"> Payment connector that you would like Twilio to use for processing payments.
        ///                        </param>
        /// <param name="paymentMethod"> Payment source type. </param>
        /// <param name="postalCode"> Whether to expect postal code during payment source data gathering. </param>
        /// <param name="securityCode"> Whether to expect security code during payment source data gathering. </param>
        /// <param name="timeout"> The number of seconds that we should allow customer to enter payment information </param>
        /// <param name="tokenType"> If tokenization of payment source is desired, this represents type of token. </param>
        /// <param name="validCardTypes"> List of card types accepted with each card types separated by space. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payment </returns>
        public static async System.Threading.Tasks.Task<PaymentResource> CreateAsync(string pathCallSid,
                                                                                     string idempotencyKey,
                                                                                     Uri statusCallback,
                                                                                     string pathAccountSid = null,
                                                                                     PaymentResource.BankAccountTypeEnum bankAccountType = null,
                                                                                     decimal? chargeAmount = null,
                                                                                     string currency = null,
                                                                                     string description = null,
                                                                                     string input = null,
                                                                                     int? minPostalCodeLength = null,
                                                                                     object parameter = null,
                                                                                     string paymentConnector = null,
                                                                                     PaymentResource.PaymentMethodEnum paymentMethod = null,
                                                                                     bool? postalCode = null,
                                                                                     bool? securityCode = null,
                                                                                     int? timeout = null,
                                                                                     PaymentResource.TokenTypeEnum tokenType = null,
                                                                                     string validCardTypes = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreatePaymentOptions(pathCallSid, idempotencyKey, statusCallback){PathAccountSid = pathAccountSid, BankAccountType = bankAccountType, ChargeAmount = chargeAmount, Currency = currency, Description = description, Input = input, MinPostalCodeLength = minPostalCodeLength, Parameter = parameter, PaymentConnector = paymentConnector, PaymentMethod = paymentMethod, PostalCode = postalCode, SecurityCode = securityCode, Timeout = timeout, TokenType = tokenType, ValidCardTypes = validCardTypes};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdatePaymentOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Calls/" + options.PathCallSid + "/Payments/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update an instance of payments with different phases of payment flows.
        /// </summary>
        /// <param name="options"> Update Payment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payment </returns>
        public static PaymentResource Update(UpdatePaymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update an instance of payments with different phases of payment flows.
        /// </summary>
        /// <param name="options"> Update Payment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payment </returns>
        public static async System.Threading.Tasks.Task<PaymentResource> UpdateAsync(UpdatePaymentOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update an instance of payments with different phases of payment flows.
        /// </summary>
        /// <param name="pathCallSid"> The SID of the call that will create the resource. </param>
        /// <param name="pathSid"> The SID of Payments session </param>
        /// <param name="idempotencyKey"> A unique token for each payment session that should be provided to maintain
        ///                      idempotency of the session. </param>
        /// <param name="statusCallback"> The URL we should call to send status of payment session. </param>
        /// <param name="pathAccountSid"> The SID of the Account that will update the resource </param>
        /// <param name="capture"> Specific payment source information to expect. </param>
        /// <param name="status"> Instruction to complete or cancel the transaction. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Payment </returns>
        public static PaymentResource Update(string pathCallSid,
                                             string pathSid,
                                             string idempotencyKey,
                                             Uri statusCallback,
                                             string pathAccountSid = null,
                                             PaymentResource.CaptureEnum capture = null,
                                             PaymentResource.StatusEnum status = null,
                                             ITwilioRestClient client = null)
        {
            var options = new UpdatePaymentOptions(pathCallSid, pathSid, idempotencyKey, statusCallback){PathAccountSid = pathAccountSid, Capture = capture, Status = status};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update an instance of payments with different phases of payment flows.
        /// </summary>
        /// <param name="pathCallSid"> The SID of the call that will create the resource. </param>
        /// <param name="pathSid"> The SID of Payments session </param>
        /// <param name="idempotencyKey"> A unique token for each payment session that should be provided to maintain
        ///                      idempotency of the session. </param>
        /// <param name="statusCallback"> The URL we should call to send status of payment session. </param>
        /// <param name="pathAccountSid"> The SID of the Account that will update the resource </param>
        /// <param name="capture"> Specific payment source information to expect. </param>
        /// <param name="status"> Instruction to complete or cancel the transaction. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Payment </returns>
        public static async System.Threading.Tasks.Task<PaymentResource> UpdateAsync(string pathCallSid,
                                                                                     string pathSid,
                                                                                     string idempotencyKey,
                                                                                     Uri statusCallback,
                                                                                     string pathAccountSid = null,
                                                                                     PaymentResource.CaptureEnum capture = null,
                                                                                     PaymentResource.StatusEnum status = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdatePaymentOptions(pathCallSid, pathSid, idempotencyKey, statusCallback){PathAccountSid = pathAccountSid, Capture = capture, Status = status};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a PaymentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PaymentResource object represented by the provided JSON </returns>
        public static PaymentResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PaymentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the Payments resource.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Call the resource is associated with.
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The SID of the Payments resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URI of the resource, relative to `https://api.twilio.com`
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        private PaymentResource()
        {

        }
    }

}