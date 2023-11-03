namespace Application.ABSTRACTIONS
{
    public interface IUser : IPerson
    {
        string LoginName { get; set; }
        string Password { get; set; }
    }
}
