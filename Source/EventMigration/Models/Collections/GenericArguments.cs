﻿#region Copyright 2015 Exceptionless

// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU Affero General Public License as published 
// by the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
//     http://www.gnu.org/licenses/agpl-3.0.html

#endregion

using System;
using System.Collections.ObjectModel;

namespace Exceptionless.EventMigration.Models {
    public class GenericArguments : Collection<string> {
        public Exceptionless.Core.Models.GenericArguments ToGenericArguments() {
            var arguments = new Exceptionless.Core.Models.GenericArguments();
            foreach (var item in Items) {
                arguments.Add(item);
            }

            return arguments;
        }
    }
}