using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper.Helpers
{
    static class IntPtrHelpers
    {

        /// <summary>
        /// Gets a <see cref="String"/> pointed by an <see cref="IntPtr"/> and delete the handle managed by Tesseract library.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static unsafe string IntPtrToStringSafe(this IntPtr handle)
        {
            if (handle != IntPtr.Zero)
            {
                var result = handle.IntPtrToString(Encoding.UTF8);
                TesseractPrimitives.Api.DeleteText(handle);
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a <see cref="String"/> pointed by an <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        private static unsafe string IntPtrToString(this IntPtr handle,
            Encoding encoding
            )
        {
            var length = IntPtrStringLength(handle);
            return new String((sbyte*)handle.ToPointer(), 0, length, encoding);
        }

        /// <summary>
        /// Gets the number of bytes in a null terminated byte array.
        /// </summary>
        static unsafe int IntPtrStringLength(this IntPtr handle)
        {
            var ptr = (byte*)handle.ToPointer();
            int length = 0;
            while (*(ptr + length) != 0)
            {
                length++;
            }
            return length;
        }
    }
}
