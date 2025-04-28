using System;
using System.Collections.Generic;

namespace GStock.Data.Models;

public partial class TableDetailsCommande
{
    public int IdCommande { get; set; }

    public int IdProduit { get; set; }

    public string? Quantite { get; set; }

    public virtual TableCommande IdCommandeNavigation { get; set; } = null!;

    public virtual TableProduit IdProduitNavigation { get; set; } = null!;
}
