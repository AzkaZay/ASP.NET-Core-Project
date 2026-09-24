namespace PatisserieCD.Models;

public enum OrderStatus
{
    Pending,
    Confirmed,
    InProduction,
    Ready,
    OutForDelivery,
    Delivered,
    Cancelled
}