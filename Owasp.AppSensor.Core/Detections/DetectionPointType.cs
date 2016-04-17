﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp.AppSensor.Core.Detections
{
    public enum DetectionPointType
    {
        UnexpectedHttpCommand,
        UnsupportedHttpMethod,
        GetWhenExpectingPost,
        PostWhenExpectingGet
    }
}
