﻿using Newtonsoft.Json;

namespace HuobiSDK.Model.Request.Order
{
    public class PlaceOrderRequest
    {
        [JsonProperty(PropertyName="account-id")]
        public string AccountId;

        public string symbol;

        public string type;

        public string amount;

        public string price;

        public string source;

        [JsonProperty(PropertyName="client-order-id")]
        public string ClientOrderId;

        [JsonProperty(PropertyName = "stop-price")]
        public string StopPrice;

        [JsonProperty(PropertyName = "operator")]
        public string Operator;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
