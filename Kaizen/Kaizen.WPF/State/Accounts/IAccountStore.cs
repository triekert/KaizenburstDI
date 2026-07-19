using Kaiizen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaiizen.WPF.State.Accounts
{
    public interface IAccountStore
    {
        Account CurrentAccount { get; set; }
        event Action StateChanged;
    }
}
