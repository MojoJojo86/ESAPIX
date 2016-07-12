﻿using ESAPIX.Interfaces;


namespace ESAPIX.Fakes
{
    public class ExternalBeam : ApiDataObject, IExternalBeam
    {
        public double SourceAxisDistance { get; set; }

        public string MachineModel { get; set; }

        public string MachineScaleDisplayName { get; set; }
    }
}