using System;
using System.Collections.Generic;
namespace Messenger_Maks
{

    public static class MessengerServer
    {

        public static List<MessageModel> AllHistory = new List<MessageModel>();

        public static event Action<MessageModel> OnNewMessage;

        public static void Send(MessageModel msg)
        {
            if (msg.Receiver == "General")
            {

                msg.DeliveryStatus["User1"] = false;
                msg.DeliveryStatus["User2"] = false;
                msg.DeliveryStatus["User3"] = false;
                msg.DeliveryStatus["Admin"] = false;
            }

            AllHistory.Add(msg);
            OnNewMessage?.Invoke(msg);
        }
    }
}