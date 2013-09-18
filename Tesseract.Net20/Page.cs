using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Tesseract.Wrapper;

namespace Tesseract
{
    public sealed class Page : DisposableBase
    {
        private bool runRecognitionPhase;

        public TesseractEngine Engine { get; private set; }

        internal Page(TesseractEngine engine)
        {
            Engine = engine;
        }

       
        public PageIterator AnalyseLayout()
        {
            var resultIteratorHandle = TesseractPrimitives.Api.BaseApiAnalyseLayout(Engine);
            return new PageIterator(resultIteratorHandle);
        }

        public ResultIterator GetIterator()
        {
            Recognize();
            var resultIteratorHandle = TesseractPrimitives.Api.BaseApiGetIterator(Engine);
            return new ResultIterator(resultIteratorHandle);
        }

        public string GetText()
        {
            Recognize();
            return TesseractPrimitives.Api.BaseApiGetUTF8Text(Engine);
        }

        public string GetHOCRText(int pageNum)
        {
            Recognize();
            return TesseractPrimitives.Api.BaseApiGetHOCRText(Engine, pageNum);
        }

        public float GetMeanConfidence()
        {
            Recognize();
            return TesseractPrimitives.Api.BaseApiMeanTextConf(Engine) / 100.0f;
        }


#if Net45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        private void Recognize()
        {            
            if (!runRecognitionPhase) {
                if (TesseractPrimitives.Api.BaseApiRecognize(Engine, IntPtr.Zero) != 0)
                {
                    throw new InvalidOperationException("Recognition of image failed.");
                }
                runRecognitionPhase = true;
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                TesseractPrimitives.Api.BaseApiClear(Engine);
            }
        }
    }
}
