namespace Vejledningsbooking.Domain.Interfaces
{
    public interface ICalender
    {
        int ClassId { get; set; }
        int Id { get; set; }
        byte[] Rowversion { get; set; }
    }
}