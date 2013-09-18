using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper
{
    public enum PageIteratorLevel : int
    {
        Block,
        Para, 
        TextLine, 
        Word, 
        Symbol
    }
}
