using System;
using System.Collections.Generic;

namespace GStock.Data.Models;

public partial class TableCategorie
{
    public int IdCategorie { get; set; }

    public string NomCategorie { get; set; } = null!;

    public virtual ICollection<TableProduit> TableProduits { get; set; } = new List<TableProduit>();
}
