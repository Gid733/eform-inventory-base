﻿/*
The MIT License (MIT)
Copyright (c) 2007 - 2021 Microting A/S
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Microting.eFormInventoryBase.Infrastructure.Data.Entities
{
    using Const;
    using System;
    using System.Collections.Generic;

    public class ItemType : PnBase
    {
        public string No { get; set; }

        public string GtinEanUpc { get; set; }

        public string Description { get; set; }

        public int NetWeight { get; set; }

        public int GrossWeight { get; set; }

        public int UnitVolume { get; set; }

        public CostingMethod CostingMethod { get; set; }

        public int UnitPrice { get; set; }

        public int ProofitProcent { get; set; }

        public UnitOfMeasure SalesUnitOfMeasure { get; set; }

        public DateTime LastPhysicalInventoryDate { get; set; }

        public int Region { get; set; }

        public int? ItemGroupId { get; set; }

        public virtual ItemGroup ItemGroup { get; set; }

        public string Usage { get; set; }

        public string RiscDescription { get; set; }

        public bool Aviable { get; set; }

        public string Name { get; set; }

        public virtual List<InventoryTag> InventoryTags { get; set; }
            = new List<InventoryTag>();
    }
}
