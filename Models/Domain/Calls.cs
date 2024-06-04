namespace CALLОМОЙСЬКИЙ.Models.Domain;

public class Calls
{
    public Guid Id { get; set; }
    public Guid CallerUserId { get; set; }
    public Guid ReceiverUserId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}