/**
 * Copyright (C) 2018-2019 Emilian Roman
 * 
 * This file is part of NieR.EXPer.
 * 
 * NieR.EXPer is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * NieR.EXPer is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with NieR.EXPer.  If not, see <http://www.gnu.org/licenses/>.
 */

﻿namespace YuMi.NieRexper.Patching
{
    /// <summary>
    /// Interface to be implemented by NieR:Automata EXP patchers.
    /// </summary>
    public interface IPatcher
    {
        /// <summary>
        /// Patch experience points to a resource.
        /// </summary>
        /// <param name="amount">Amount of EXP to patch to the resource.</param>
        void Patch(int amount);
    }
}
