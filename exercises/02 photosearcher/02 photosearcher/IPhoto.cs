using System;

namespace _02_photosearcher
{
    public interface IPhoto
    {
        int Id { get; }
        DateTime Date { get; }
        Color Color { get; }
        ContentType ContentType { get; }
    }
}