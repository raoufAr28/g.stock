using System;
using System.Collections.Generic;

namespace GStock.Data.Models;

public partial class TableCommande
{
    public int IdCommande { get; set; }

    public DateTime DateCommande { get; set; }

    public int IdClient { get; set; }

    public virtual TableClient IdClientNavigation { get; set; } = null!;
}
