﻿#region License GNU GPL
// Spell.cs
// 
// Copyright (C) 2012 - BehaviorIsManaged
// 
// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free Software Foundation;
// either version 2 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details. 
// You should have received a copy of the GNU General Public License along with this program; 
// if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

// Author : FastFrench - antispam@laposte.net
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiM.Behaviors.Game.World.Pathfinding
{
    public interface IAdvancedPathFinder : ISimplePathFinder
    {
        Path FindPath(IEnumerable<Cell> startCells, IEnumerable<Cell> endCells, bool outsideFight, int mp = -1, int minDistance = 0, bool cautiousMode = false);
        Path FindPath(Cell startCell, IEnumerable<Cell> endCells, bool outsideFight, int mp = -1, int minDistance = 0, bool cautiousMode = false);
        Path FindPath(Cell startCell, Cell endCell, bool outsideFight, int mp = -1, int MinDistance = 0, bool cautiousMode = false);
    }
}
