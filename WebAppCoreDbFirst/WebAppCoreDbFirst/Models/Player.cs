using System;
using System.Collections.Generic;

namespace WebAppCoreDbFirst.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string PlayerName { get; set; } = null!;

    public string PlayerType { get; set; } = null!;

    public int? PlayerTeam { get; set; }

    public virtual Team? PlayerTeamNavigation { get; set; }
}
