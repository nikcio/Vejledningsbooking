namespace Vejledningsbooking.Domain.Interfaces
{
    public interface ITeacher
    {
        int Id { get; set; }
        byte[] Rowversion { get; set; }
    }
}