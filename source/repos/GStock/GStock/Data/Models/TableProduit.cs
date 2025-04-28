using System;
using System.Collections.Generic;

namespace GStock.Data.Models;

public partial class TableProduit
{
    public int IdProduit { get; set; }

    public string NomProduit { get; set; } = null!;

    public int QuantiteProduit { get; set; }

    public string PrixProduit { get; set; } = null!;

    public byte[] ImageProduit { get; set; } = null!;

    public int IdCategorie { get; set; }

    public virtual TableCategorie IdCategorieNavigation { get; set; } = null!;
}
