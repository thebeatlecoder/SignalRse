namespace ScaleOut.Event.Contracts
{
    public class CustomerSurnameUpdatedEvent
    {
        public int Id { get; set; }
        public string NewSurname { get; set; }
    }
}