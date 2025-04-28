using System;
using System.Collections.Generic;

namespace GStock.Data.Models;

public partial class TableClient
{
    public int IdClient { get; set; }

    public string NomClient { get; set; } = null!;

    public string PrenomClient { get; set; } = null!;

    public string TelephoneClient { get; set; } = null!;

    public string AdressClient { get; set; } = null!;

    public string EmailClient { get; set; } = null!;

    public string VilleClient { get; set; } = null!;

    public virtual ICollection<TableCommande> TableCommandes { get; set; } = new List<TableCommande>();
}
