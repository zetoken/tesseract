using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Tesseract.Wrapper.Helpers;

namespace Tesseract.Wrapper.Win32
{
    /// <summary>
    /// Unsafe api coming from windows libtesseract.dll library
    /// </summary>
    sealed class UnsafeTesseractPrimitives
    {
        internal const string TESSERACT_LIB = @"x86\libtesseract302.dll";

        #region >> General

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessVersion")]
        public static extern string GetVersion();

        #endregion

        #region >> Memory Management

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessDeleteText")]
        public static extern void DeleteText(IntPtr textPtr);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessDeleteTextArray")]
        public static extern void DeleteTextArray(IntPtr arr);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessDeleteIntArray")]
        public static extern void DeleteIntArray(IntPtr arr);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessDeleteBlockList")]
        public static extern void DeleteBlockList(IntPtr arr);

        #endregion

        #region >> Base API

        /// <summary>
        /// Creates a new BaseAPI instance
        /// </summary>
        /// <returns></returns>
        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPICreate")]
        public static extern IntPtr BaseApiCreate();


        /// <summary>
        /// Deletes a base api instance.
        /// </summary>
        /// <returns></returns>
        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIDelete")]
        public static extern void BaseApiDelete(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIInit1")]
        public static extern int BaseApiInit(IntPtr handle,
            string datapath,
            string language,
            int mode,
            IntPtr configs, int configs_size,
            IntPtr vars_vec, int vars_vec_size, IntPtr vars_values, int vars_values_size
            );


        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPISetVariable")]
        public static extern int BaseApiSetVariable(IntPtr handle,
            string name,
            string value
            );


        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPISetDebugVariable")]
        public static extern int BaseApiSetDebugVariable(IntPtr handle,
            string name,
            string value
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetIntVariable")]
        public static extern int BaseApiGetIntVariable(IntPtr handle,
            string name,
            out int value
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetBoolVariable")]
        public static extern int BaseApiGetBoolVariable(IntPtr handle,
            string name,
            out int value
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetDoubleVariable")]
        public static extern int BaseApiGetDoubleVariable(IntPtr handle,
            string name,
            out double value
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetStringVariable")]
        public static extern string BaseApiGetStringVariable(IntPtr handle,
            string name
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetStringVariable")]
        public static extern int BaseApiGetVariableAsString(IntPtr handle,
            string name,
            out string val
            );


        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPISetPageSegMode")]
        public static extern void BaseAPISetPageSegMode(IntPtr handle,
            int mode
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetPageSegMode")]
        public static extern int BaseAPIGetPageSegMode(IntPtr handle);

        #endregion

        #region >> Image Analysis

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPISetImage2")]
        public static extern void BaseApiSetImage(IntPtr handle,
            IntPtr pixHandle
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPISetRectangle")]
        public static extern void BaseApiSetRectangle(IntPtr handle,
            int left,
            int top,
            int width,
            int height
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIRecognize")]
        public static extern int BaseApiRecognize(IntPtr handle,
            IntPtr monitor
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIAnalyseLayout")]
        public static extern IntPtr BaseAPIAnalyseLayout(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetIterator")]
        public static extern IntPtr BaseApiGetIterator(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetUTF8Text")]
        public static extern IntPtr BaseAPIGetUTF8Text(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIGetHOCRText")]
        public static extern IntPtr BaseAPIGetHOCRText(IntPtr handle,
            int pageNum
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIMeanTextConf")]
        public static extern int BaseAPIMeanTextConf(IntPtr handle);


        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessBaseAPIClear")]
        public static extern void BaseAPIClear(IntPtr handle);

        #endregion

        #region >> Result Iterator

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessResultIteratorDelete")]
        public static extern void ResultIteratorDelete(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessResultIteratorCopy")]
        public static extern IntPtr ResultIteratorCopy(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessResultIteratorGetPageIterator")]
        public static extern IntPtr ResultIteratorGetPageIterator(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessResultIteratorGetUTF8Text")]
        public static extern IntPtr ResultIteratorGetUTF8Text(IntPtr handle,
            int level
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessResultIteratorConfidence")]
        public static extern float ResultIteratorGetConfidence(IntPtr handle,
            int level
            );

        #endregion

        #region >> Page Iterator

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorDelete")]
        public static extern void PageIteratorDelete(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorCopy")]
        public static extern IntPtr PageIteratorCopy(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorBegin")]
        public static extern void PageIteratorBegin(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorNext")]
        public static extern int PageIteratorNext(IntPtr handle,
            int level
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorIsAtBeginningOf")]
        public static extern int PageIteratorIsAtBeginningOf(IntPtr handle,
            int level
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorIsAtFinalElement")]
        public static extern int PageIteratorIsAtFinalElement(IntPtr handle,
            int level,
            int element
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorBoundingBox")]
        public static extern int PageIteratorBoundingBox(IntPtr handle,
            int level,
            out int left,
            out int top,
            out int right,
            out int bottom
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorBlockType")]
        public static extern int PageIteratorBlockType(IntPtr handle);

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorGetBinaryImage")]
        public static extern IntPtr PageIteratorGetBinaryImage(IntPtr handle,
            int level
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorGetImage")]
        public static extern IntPtr PageIteratorGetImage(IntPtr handle,
            int level,
            int padding,
            out int left,
            out int top
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorBaseline")]
        public static extern int PageIteratorBaseline(IntPtr handle, int level,
            out int x1,
            out int y1,
            out int x2,
            out int y2
            );

        [DllImport(TESSERACT_LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "TessPageIteratorOrientation")]
        public static extern void PageIteratorOrientation(IntPtr handle,
            out int orientation,
            out int writing_direction,
            out int textLineOrder,
            out float deskew_angle
            );

        #endregion
    }
}
