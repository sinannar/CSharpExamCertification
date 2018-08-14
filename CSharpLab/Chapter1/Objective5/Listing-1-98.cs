using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace CSharpLab.Chapter1.Objective5
{
    public static class Listing_1_98
    {
        public static void RunMain()
        {

        }



        [Serializable]
        public class OrderProcessingException : Exception, ISerializable
        {
            public OrderProcessingException(int orderId)
            {
                OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
            }
            public OrderProcessingException(int orderId, string message) : base(message)
            {
                OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
            }
            public OrderProcessingException(int orderId, string message, Exception innerException)
                : base(message, innerException)
            {
                OrderId = orderId;
                this.HelpLink = "http://www.mydomain.com/infoaboutexception";
            }
            protected OrderProcessingException(SerializationInfo info, StreamingContext context)
            {
                OrderId = (int)info.GetValue("OrderId", typeof(int));
            }

            public int OrderId { get; private set; }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("OrderId", OrderId, typeof(int));
            }
        }
    }
}
