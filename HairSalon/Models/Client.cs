namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public string ClientDetails { get; set; }
    public virtual Stylist Stylist { get; set; }
  } 
}