using System;
using System.Collections.Generic;

public class MessageModel
{
    public string Sender { get; set; }
    public string Receiver { get; set; } // "General"
    public string Text { get; set; }
    public DateTime Time { get; set; }


    public Dictionary<string, bool> DeliveryStatus { get; set; } = new Dictionary<string, bool>();

    public MessageModel(string sender, string receiver, string text)
    {
        Sender = sender;
        Receiver = receiver;
        Text = text;
        Time = DateTime.Now;
    }
}
