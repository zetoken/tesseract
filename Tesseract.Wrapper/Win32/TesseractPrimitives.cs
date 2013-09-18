using System;
using System.Collections.Generic;
using System.Text;
using Tesseract.Wrapper.Helpers;

namespace Tesseract.Wrapper.Win32
{
    sealed class TesseractPrimitives : ITesseractPrimitives
    {
        #region >> ITesseractPrimitives

        #region >> General

        /// <inheritdoc />
        public string GetVersion()
        {
            return UnsafeTesseractPrimitives.GetVersion();
        }

        #endregion

        #region >> Memory Management

        /// <inheritdoc />
        public void DeleteText(IntPtr textPtr)
        {
            UnsafeTesseractPrimitives.DeleteText(textPtr);
        }

        /// <inheritdoc />
        public void DeleteTextArray(IntPtr arr)
        {
            UnsafeTesseractPrimitives.DeleteTextArray(arr);
        }

        /// <inheritdoc />
        public void DeleteIntArray(IntPtr arr)
        {
            UnsafeTesseractPrimitives.DeleteIntArray(arr);
        }

        /// <inheritdoc />
        public void DeleteBlockList(IntPtr arr)
        {
            UnsafeTesseractPrimitives.DeleteBlockList(arr);
        }

        #endregion

        #region >> Base API

        /// <inheritdoc />
        public IntPtr BaseApiCreate()
        {
            return UnsafeTesseractPrimitives.BaseApiCreate();
        }

        /// <inheritdoc />
        public void BaseApiDelete(IEngineHandle engine)
        {
            UnsafeTesseractPrimitives.BaseApiDelete(engine.Handle);
        }

        /// <inheritdoc />
        public int BaseApiInit(IEngineHandle engine,
            string datapath,
            string language,
            int mode,
            IntPtr configs, int configs_size,
            IntPtr vars_vec, int vars_vec_size, IntPtr vars_values, int vars_values_size
            )
        {
            return UnsafeTesseractPrimitives.BaseApiInit(engine.Handle, datapath, language, mode, configs, configs_size, vars_vec, vars_vec_size, vars_values, vars_values_size);
        }

        /// <inheritdoc />
        public int BaseApiSetVariable(IEngineHandle engine,
            string name,
            string value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiSetVariable(engine.Handle, name, value);
        }

        /// <inheritdoc />
        public int BaseApiSetDebugVariable(IEngineHandle engine,
            string name,
            string value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiSetDebugVariable(engine.Handle, name, value);
        }

        /// <inheritdoc />
        public int BaseApiGetIntVariable(IEngineHandle engine,
            string name,
            out int value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiGetIntVariable(engine.Handle, name, out value);
        }

        /// <inheritdoc />
        public int BaseApiGetBoolVariable(IEngineHandle engine,
            string name,
            out int value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiGetBoolVariable(engine.Handle, name, out value);
        }

        /// <inheritdoc />
        public int BaseApiGetDoubleVariable(IEngineHandle engine,
            string name,
            out double value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiGetDoubleVariable(engine.Handle, name, out value);
        }

        /// <inheritdoc />
        public string BaseApiGetStringVariable(IEngineHandle engine,
            string name
            )
        {
            return UnsafeTesseractPrimitives.BaseApiGetStringVariable(engine.Handle, name);
        }

        /// <inheritdoc />
        public int BaseApiGetVariableAsString(IEngineHandle engine,
            string name,
            out string value
            )
        {
            return UnsafeTesseractPrimitives.BaseApiGetVariableAsString(engine.Handle, name, out value);
        }

        /// <inheritdoc />
        public void BaseApiSetPageSegMode(IEngineHandle engine,
            PageSegMode mode
            )
        {
            UnsafeTesseractPrimitives.BaseAPISetPageSegMode(engine.Handle, (int)mode);
        }

        /// <inheritdoc />
        public PageSegMode BaseApiGetPageSegMode(IEngineHandle engine)
        {
            return (PageSegMode)UnsafeTesseractPrimitives.BaseAPIGetPageSegMode(engine.Handle);
        }

        /// <inheritdoc />
        public void BaseApiSetImage(IEngineHandle engine, IntPtr pixHandle)
        {
            UnsafeTesseractPrimitives.BaseApiSetImage(engine.Handle, pixHandle);
        }

        /// <inheritdoc />
        public void BaseApiSetRectangle(IEngineHandle engine,
            int left,
            int top,
            int width,
            int height
            )
        {
            UnsafeTesseractPrimitives.BaseApiSetRectangle(engine.Handle, left, top, width, height);
        }

        /// <inheritdoc />
        public int BaseApiRecognize(IEngineHandle engine,
            IntPtr monitor
            )
        {
            return UnsafeTesseractPrimitives.BaseApiRecognize(engine.Handle, monitor);
        }

        /// <inheritdoc />
        public IntPtr BaseApiAnalyseLayout(IEngineHandle engine)
        {
            return UnsafeTesseractPrimitives.BaseAPIAnalyseLayout(engine.Handle);
        }

        /// <inheritdoc />
        public IntPtr BaseApiGetIterator(IEngineHandle engine)
        {
            return UnsafeTesseractPrimitives.BaseApiGetIterator(engine.Handle);
        }

        /// <inheritdoc />
        public string BaseApiGetUTF8Text(IEngineHandle engine)
        {
            return UnsafeTesseractPrimitives.BaseAPIGetUTF8Text(engine.Handle).IntPtrToStringSafe();
        }

        /// <inheritdoc />
        public string BaseApiGetHOCRText(IEngineHandle engine,
            int pageNum
            )
        {
            return UnsafeTesseractPrimitives.BaseAPIGetHOCRText(engine.Handle, pageNum).IntPtrToStringSafe();
        }

        /// <inheritdoc />
        public int BaseApiMeanTextConf(IEngineHandle engine)
        {
            return UnsafeTesseractPrimitives.BaseAPIMeanTextConf(engine.Handle);
        }

        /// <inheritdoc />
        public void BaseApiClear(IEngineHandle engine)
        {
            UnsafeTesseractPrimitives.BaseAPIClear(engine.Handle);
        }

        #endregion

        #region >> Result Iterator

        /// <inheritdoc />
        public void ResultIteratorDelete(IntPtr handle)
        {
            UnsafeTesseractPrimitives.ResultIteratorDelete(handle);
        }

        /// <inheritdoc />
        public IntPtr ResultIteratorCopy(IntPtr handle)
        {
            return UnsafeTesseractPrimitives.ResultIteratorCopy(handle);
        }

        /// <inheritdoc />
        public IntPtr ResultIteratorGetPageIterator(IntPtr handle)
        {
            return UnsafeTesseractPrimitives.ResultIteratorGetPageIterator(handle);
        }

        /// <inheritdoc />
        public string ResultIteratorGetUTF8Text(IntPtr handle,
            PageIteratorLevel level
            )
        {
            return UnsafeTesseractPrimitives.ResultIteratorGetUTF8Text(handle, (int)level).IntPtrToStringSafe();
        }

        /// <inheritdoc />
        public float ResultIteratorGetConfidence(IntPtr handle,
            PageIteratorLevel level
            )
        {
            return UnsafeTesseractPrimitives.ResultIteratorGetConfidence(handle, (int)level);
        }

        #endregion

        #region >> Page Iterator

        public void PageIteratorDelete(IntPtr handle)
        {
            UnsafeTesseractPrimitives.PageIteratorDelete(handle);
        }

        public IntPtr PageIteratorCopy(IntPtr handle)
        {
            return UnsafeTesseractPrimitives.PageIteratorCopy(handle);
        }

        public void PageIteratorBegin(IntPtr handle)
        {
            UnsafeTesseractPrimitives.PageIteratorBegin(handle);
        }

        public int PageIteratorNext(IntPtr handle,
            PageIteratorLevel level
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorNext(handle, (int)level);
        }

        public int PageIteratorIsAtBeginningOf(IntPtr handle,
            PageIteratorLevel level
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorIsAtBeginningOf(handle, (int)level);
        }

        public int PageIteratorIsAtFinalElement(IntPtr handle,
            PageIteratorLevel level,
            PageIteratorLevel element
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorIsAtFinalElement(handle, (int)level, (int)element);
        }

        public int PageIteratorBoundingBox(IntPtr handle,
            PageIteratorLevel level,
            out int left,
            out int top,
            out int right,
            out int bottom
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorBoundingBox(handle, (int)level, out left, out top, out right, out bottom);
        }

        public PolyBlockType PageIteratorBlockType(IntPtr handle)
        {
            return (PolyBlockType)UnsafeTesseractPrimitives.PageIteratorBlockType(handle);
        }

        public IntPtr PageIteratorGetBinaryImage(IntPtr handle,
            PageIteratorLevel level
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorGetBinaryImage(handle, (int)level);
        }

        public IntPtr PageIteratorGetImage(IntPtr handle,
            PageIteratorLevel level,
            int padding,
            out int left,
            out int top
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorGetImage(handle, (int)level, padding, out left, out top);
        }

        public int PageIteratorBaseline(IntPtr handle,
            PageIteratorLevel level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
            )
        {
            return UnsafeTesseractPrimitives.PageIteratorBaseline(handle, (int)level, out x1, out y1, out x2, out y2);
        }

        public void PageIteratorOrientation(IntPtr handle,
            out Orientation orientation,
            out WritingDirection writingDirection,
            out TextLineOrder textLineOrder,
            out float deskew_angle
            )
        {
            int intOrientation = 0;
            int intWritingDirection;
            int intTextLineOrder;
            UnsafeTesseractPrimitives.PageIteratorOrientation(handle, out intOrientation, out intWritingDirection, out intTextLineOrder, out deskew_angle);
            orientation = (Orientation)intOrientation;
            writingDirection = (WritingDirection)intWritingDirection;
            textLineOrder = (TextLineOrder)intTextLineOrder;
        }

        #endregion

        #endregion
    }
}
