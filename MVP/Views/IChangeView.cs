using System;

namespace MVP.Views
{
    public interface IChangeView : IView
    {
        int id { get; }
        string site { get; }
        string url { get; }
        int gap { get; }
        event Action Change;
    }
}
