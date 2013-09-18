using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper
{
    /// <summary>
    /// Interface to be implemented by all Tesseract API wrappers
    /// </summary>
    public interface ITesseractPrimitives
    {
        #region >> General

        string GetVersion();

        #endregion

        #region >> Memory Management

        void DeleteText(IntPtr textPtr);

        void DeleteTextArray(IntPtr arr);

        void DeleteIntArray(IntPtr arr);

        void DeleteBlockList(IntPtr arr);

        #endregion

        #region >> Base API

        IntPtr BaseApiCreate();

        void BaseApiDelete(IEngineHandle engine);

        int BaseApiInit(IEngineHandle engine,
            string datapath,
            string language,
            int mode,
            IntPtr configs, int configs_size,
            IntPtr vars_vec, int vars_vec_size, IntPtr vars_values, int vars_values_size
            );

        int BaseApiSetVariable(IEngineHandle engine,
            string name,
            string value
            );

        int BaseApiSetDebugVariable(IEngineHandle engine,
            string name,
            string value
            );

        int BaseApiGetIntVariable(IEngineHandle engine,
            string name,
            out int value
            );

        int BaseApiGetBoolVariable(IEngineHandle engine,
            string name,
            out int value
            );

        int BaseApiGetDoubleVariable(IEngineHandle engine,
            string name,
            out double value
            );

        string BaseApiGetStringVariable(IEngineHandle engine,
            string name
            );

        int BaseApiGetVariableAsString(IEngineHandle engine,
            string name,
            out string val
            );

        void BaseApiSetPageSegMode(IEngineHandle engine,
            PageSegMode mode
            );

        PageSegMode BaseApiGetPageSegMode(IEngineHandle engine);

        void BaseApiSetImage(IEngineHandle engine,
            IntPtr pixHandle
            );

        void BaseApiSetRectangle(IEngineHandle engine,
            int left,
            int top,
            int width,
            int height
            );

        int BaseApiRecognize(IEngineHandle engine,
            IntPtr monitor
            );

        IntPtr BaseApiAnalyseLayout(IEngineHandle engine);

        IntPtr BaseApiGetIterator(IEngineHandle engine);

        string BaseApiGetUTF8Text(IEngineHandle engine);

        string BaseApiGetHOCRText(IEngineHandle engine,
            int pageNum
            );

        int BaseApiMeanTextConf(IEngineHandle engine);

        void BaseApiClear(IEngineHandle engine);

        #endregion

        #region >> Result Iterator

        void ResultIteratorDelete(IntPtr handle);

        IntPtr ResultIteratorCopy(IntPtr handle);

        IntPtr ResultIteratorGetPageIterator(IntPtr handle);

        string ResultIteratorGetUTF8Text(IntPtr handle,
            PageIteratorLevel level
            );

        float ResultIteratorGetConfidence(IntPtr handle,
            PageIteratorLevel level);

        #endregion

        #region >> Page Iterator

        void PageIteratorDelete(IntPtr handle);

        IntPtr PageIteratorCopy(IntPtr handle);

        void PageIteratorBegin(IntPtr handle);

        int PageIteratorNext(IntPtr handle,
            PageIteratorLevel level
            );

        int PageIteratorIsAtBeginningOf(IntPtr handle,
            PageIteratorLevel level
            );

        int PageIteratorIsAtFinalElement(IntPtr handle,
            PageIteratorLevel level,
            PageIteratorLevel element
            );

        int PageIteratorBoundingBox(IntPtr handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
            );

        PolyBlockType PageIteratorBlockType(IntPtr handle);

        IntPtr PageIteratorGetBinaryImage(IntPtr handle,
            PageIteratorLevel level
            );

        IntPtr PageIteratorGetImage(IntPtr handle,
            PageIteratorLevel level,
            int padding,
            out int left,
            out int top
            );

        int PageIteratorBaseline(IntPtr handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
            );

        void PageIteratorOrientation(IntPtr handle,
            out Orientation orientation,
            out WritingDirection writingDirection,
            out TextLineOrder textLineOrder,
            out float deskew_angle
            );

        #endregion
    }
}
