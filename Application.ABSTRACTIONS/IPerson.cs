using System;

namespace Application.ABSTRACTIONS
{
    public interface IPerson
    {
        string Name { get; set; }
        string Lastname { get; set; }
        string DNI { get; set; }
        string Address { get; set; }
        DateTime CreationDate { get; set; }
        bool Active { get; set; }
        string FullName { get; }
        string Email { get; set; }
    }
}
