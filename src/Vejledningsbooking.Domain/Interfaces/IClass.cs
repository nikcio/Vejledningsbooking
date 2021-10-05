namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IClass
    {
        int CalenderId { get; set; }
        string ClassName { get; set; }
        int Id { get; set; }
        byte[] Rowversion { get; set; }
    }
}