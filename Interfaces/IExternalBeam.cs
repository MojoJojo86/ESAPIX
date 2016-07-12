﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESAPIX.Interfaces
{
    public interface IExternalBeam : IApiDataObject
    {
        double SourceAxisDistance { get; }

        string MachineModel { get; }

        string MachineScaleDisplayName { get; }
    }
}