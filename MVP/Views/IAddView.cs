using MVP.DomainModel;
using System;

namespace MVP.Views
{
    public interface IAddView : IView
    {
        Website website { get; }
        event Action Add;
    }
}
