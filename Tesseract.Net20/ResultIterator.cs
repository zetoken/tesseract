﻿using System;
using Tesseract.Wrapper;

namespace Tesseract
{
    public sealed class ResultIterator : PageIterator
    {
        internal ResultIterator(IntPtr handle)
            : base(handle)
        {
        }

        public float GetConfidence(PageIteratorLevel level)
        {
            return TesseractPrimitives.Api.ResultIteratorGetConfidence(handle, level);
        }

        public string GetText(PageIteratorLevel level)
        {
            return TesseractPrimitives.Api.ResultIteratorGetUTF8Text(handle, level);
        }
    }
}
