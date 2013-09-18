using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper
{
    /// <summary>
    /// Accessor to the concrete Tesseract API wrapper.
    /// It also automatically selects the wrapper corresponding to the Operating System in use.
    /// </summary>
    public class LeptonicaPrimitives
    {
        #region >> Static Properties

        /// <summary>
        /// Accessor to concrete API for current Operating System
        /// </summary>
        public static ILeptonicaPrimitives Api { get; private set; }

        #endregion

        #region >> Static Constructor

        static LeptonicaPrimitives()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix)
            {
                //if (Environment.Is64BitProcess)
                //    api = new Linux64.TesseractPrimitives();
                //else
                //    api = new Linux32.TesseractPrimitives();
            }
            else
            {
                Api = new Win32.LeptonicaPrimitives();
            }
        }

        #endregion
    }
}
