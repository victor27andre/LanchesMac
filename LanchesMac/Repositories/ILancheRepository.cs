﻿using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.Repositories
{
    interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheID);

    }
}
