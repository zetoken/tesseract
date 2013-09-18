using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper
{
    public interface IEngineHandle
    {
        IntPtr Handle { get; }
    }
}
