using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Week7Practice.Services
{
    public interface IDetectOrientation
    {
        DeviceOrientation DetectOrientation();
    }
}
