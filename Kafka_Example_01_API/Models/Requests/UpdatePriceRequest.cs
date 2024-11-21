﻿namespace Kafka_Example_01_API.Models.Requests
{
    public class UpdatePriceRequest
    {
        public string       Key         { get; set; }
        public Guid         ProductId   { get; set; }
        public decimal      Price       { get; set; }
    }
}
