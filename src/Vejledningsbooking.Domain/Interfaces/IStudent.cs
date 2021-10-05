namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IStudent
    {
        int Id { get; set; }
        byte[] Rowversion { get; set; }
    }
}