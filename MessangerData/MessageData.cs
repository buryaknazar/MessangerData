namespace MessangerData
{
    [Serializable]
    public class MessageData
    {
        public string From { get; set; } //sender
        public string To { get; set; } //receiver
        public string Action { get; set; } //verbs
        public string Text { get; set; } //text message
        public string? FileName { get; set; } //file name
        public byte[] FileData { get; set; } //file data
        public DateTime CreatedAt { get; set; } // creation time
    }
}