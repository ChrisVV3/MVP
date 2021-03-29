using MVP.DomainModel;
using System;
using System.Collections.Generic;

namespace MVP.Views
{
    public interface IMainView : IView
    {
        event Action Insert;
        event Action Change;
        event Action Delete;
        event Action SetData;
        List<Website> websites { get; set; }
        int id { get; set; }
    }
}
