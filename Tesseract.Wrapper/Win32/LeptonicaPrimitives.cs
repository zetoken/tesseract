using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper.Win32
{
    sealed class LeptonicaPrimitives : ILeptonicaPrimitives
    {
        #region >> Pix

        /// <inheritdoc />
        public IntPtr pixCreate(int width,
            int height,
            int depth
            )
        {
            return UnsafeLeptonicaPrimitives.pixCreate(width, height, depth);
        }

        /// <inheritdoc />
        public void pixDestroy(ref IntPtr pix)
        {
            UnsafeLeptonicaPrimitives.pixDestroy(ref pix);
        }

        /// <inheritdoc />
        public int pixGetWidth(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetWidth(pix);
        }

        /// <inheritdoc />
        public int pixGetHeight(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetHeight(pix);
        }

        /// <inheritdoc />
        public int pixGetDepth(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetDepth(pix);
        }

        /// <inheritdoc />
        public int pixGetXRes(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetXRes(pix);
        }

        /// <inheritdoc />
        public int pixGetYRes(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetYRes(pix);
        }

        /// <inheritdoc />
        public int pixGetResolution(IntPtr pix,
            out int xres,
            out int yres
            )
        {
            return UnsafeLeptonicaPrimitives.pixGetResolution(pix, out xres, out yres);
        }

        /// <inheritdoc />
        public int pixGetWpl(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetWpl(pix);
        }

        /// <inheritdoc />
        public int pixSetXRes(IntPtr pix,
            int xres
            )
        {
            return UnsafeLeptonicaPrimitives.pixSetXRes(pix, xres);
        }

        /// <inheritdoc />
        public int pixSetYRes(IntPtr pix,
            int yres
            )
        {
            return UnsafeLeptonicaPrimitives.pixSetYRes(pix, yres);
        }

        /// <inheritdoc />
        public int pixSetResolution(IntPtr pix,
            int xres,
            int yres
            )
        {
            return UnsafeLeptonicaPrimitives.pixSetResolution(pix, xres, yres);
        }

        /// <inheritdoc />
        public int pixScaleResolution(IntPtr pix,
            float xscale,
            float yscale
            )
        {
            return UnsafeLeptonicaPrimitives.pixScaleResolution(pix, xscale, yscale);
        }

        /// <inheritdoc />
        public IntPtr pixGetData(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetData(pix);
        }

        /// <inheritdoc />
        public ImageFormat pixGetInputFormat(IntPtr pix)
        {
            return (ImageFormat)UnsafeLeptonicaPrimitives.pixGetInputFormat(pix);
        }

        /// <inheritdoc />
        public int pixSetInputFormat(IntPtr pix,
            ImageFormat inputFormat
            )
        {
            return UnsafeLeptonicaPrimitives.pixSetInputFormat(pix, (int)inputFormat);
        }

        /// <inheritdoc />
        public int pixEndianByteSwap(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixEndianByteSwap(pix);
        }

        /// <inheritdoc />
        public IntPtr pixRead(string filename)
        {
            return UnsafeLeptonicaPrimitives.pixRead(filename);
        }

        /// <inheritdoc />
        public int pixWrite(string filename,
            IntPtr handle,
            ImageFormat format
            )
        {
            return UnsafeLeptonicaPrimitives.pixWrite(filename, handle, (int)format);
        }

        /// <inheritdoc />
        public IntPtr pixGetColormap(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixGetColormap(pix);
        }

        /// <inheritdoc />
        public int pixSetColormap(IntPtr pix,
            IntPtr pixCmap
            )
        {
            return UnsafeLeptonicaPrimitives.pixSetColormap(pix, pixCmap);
        }

        /// <inheritdoc />
        public int pixDestroyColormap(IntPtr pix)
        {
            return UnsafeLeptonicaPrimitives.pixDestroyColormap(pix);
        }

        /// <inheritdoc />
        public IntPtr pixConvertRGBToGray(IntPtr pix,
            float rwt,
            float gwt,
            float bwt
            )
        {
            return UnsafeLeptonicaPrimitives.pixConvertRGBToGray(pix, rwt, gwt, bwt);
        }

        /// <inheritdoc />
        public IntPtr pixDeskewGeneral(IntPtr pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
            )
        {
            return UnsafeLeptonicaPrimitives.pixDeskewGeneral(pix, redSearch, sweepRange, sweepDelta, redSearch, thresh, out pAngle, out pConf);
        }

        /// <inheritdoc />
        public int pixOtsuAdaptiveThreshold(IntPtr pix,
            int sx,
            float sy,
            float smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
            )
        {
            return UnsafeLeptonicaPrimitives.pixOtsuAdaptiveThreshold(pix, sx, sy, smoothx, smoothy, scorefract, out ppixth, out ppixd);
        }

        #endregion

        #region >> Color Map

        /// <inheritdoc />
        public IntPtr pixcmapCreate(int depth)
        {
            return UnsafeLeptonicaPrimitives.pixcmapCreate(depth);
        }

        /// <inheritdoc />
        public IntPtr pixcmapCreateRandom(int depth,
            int hasBlack,
            int hasWhite
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapCreateRandom(depth, hasBlack, hasWhite);
        }

        /// <inheritdoc />
        public IntPtr pixcmapCreateLinear(int depth,
            int levels
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapCreateLinear(depth, levels);
        }

        /// <inheritdoc />
        public IntPtr pixcmapCopy(IntPtr cmaps)
        {
            return UnsafeLeptonicaPrimitives.pixcmapCopy(cmaps);
        }

        /// <inheritdoc />
        public void pixcmapDestroy(ref IntPtr cmap)
        {
            UnsafeLeptonicaPrimitives.pixcmapDestroy(ref cmap);
        }

        /// <inheritdoc />
        public int pixcmapGetCount(IntPtr cmap)
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetCount(cmap);
        }

        /// <inheritdoc />
        public int pixcmapGetFreeCount(IntPtr cmap)
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetFreeCount(cmap);
        }

        /// <inheritdoc />
        public int pixcmapGetDepth(IntPtr cmap)
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetDepth(cmap);
        }

        /// <inheritdoc />
        public int pixcmapGetMinDepth(IntPtr cmap,
            out int minDepth
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetMinDepth(cmap, out minDepth);
        }

        /// <inheritdoc />
        public int pixcmapClear(IntPtr cmap)
        {
            return UnsafeLeptonicaPrimitives.pixcmapClear(cmap);
        }

        /// <inheritdoc />
        public int pixcmapAddColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapAddColor(cmap, redValue, greenValue, blueValue);
        }

        /// <inheritdoc />
        public int pixcmapAddNewColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapAddNewColor(cmap, redValue, greenValue, blueValue, out colorIndex);
        }

        /// <inheritdoc />
        public int pixcmapAddNearestColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapAddNearestColor(cmap,
                redValue,
                greenValue,
                blueValue,
                out colorIndex
                );
        }

        /// <inheritdoc />
        public int pixcmapUsableColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapUsableColor(cmap, redValue, greenValue, blueValue, out usable);
        }

        /// <inheritdoc />
        public int pixcmapAddBlackOrWhite(IntPtr cmap,
            int color,
            out int index
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapAddBlackOrWhite(cmap, color, out index);
        }

        /// <inheritdoc />
        public int pixcmapSetBlackAndWhite(IntPtr cmap,
            int setBlack,
            int setWhite
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapSetBlackAndWhite(cmap, setBlack, setWhite);
        }

        /// <inheritdoc />
        public int pixcmapGetColor(IntPtr cmap,
            int index,
            out int redValue,
            out int greenValue,
            out int blueValue
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetColor(cmap, index, out redValue, out greenValue, out blueValue);
        }

        /// <inheritdoc />
        public int pixcmapGetColor32(IntPtr cmap,
            int index,
            out int color
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetColor32(cmap, index, out color);
        }

        /// <inheritdoc />
        public int pixcmapResetColor(IntPtr cmap,
            int index,
            int redValue,
            int greenValue,
            int blueValue
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapResetColor(cmap, index, redValue, greenValue, blueValue);
        }

        /// <inheritdoc />
        public int pixcmapGetIndex(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int index
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetIndex(cmap, redValue, greenValue, blueValue, out index);
        }

        /// <inheritdoc />
        public int pixcmapHasColor(IntPtr cmap,
            int color
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapHasColor(cmap, color);
        }

        /// <inheritdoc />
        public int pixcmapCountGrayColors(IntPtr cmap,
            out int ngray
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapCountGrayColors(cmap, out ngray);
        }

        /// <inheritdoc />
        public int pixcmapGetRankIntensity(IntPtr cmap,
            float rankVal,
            out int index
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetRankIntensity(cmap, rankVal, out index);
        }

        /// <inheritdoc />
        public int pixcmapGetNearestIndex(IntPtr cmap,
            int rVal,
            int gVal,
            int bVal,
            out int index
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetNearestIndex(cmap, rVal, gVal, bVal, out index);
        }

        /// <inheritdoc />
        public int pixcmapGetNearestGrayIndex(IntPtr cmap,
            int val,
            out int index
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetNearestGrayIndex(cmap, val, out index);
        }

        /// <inheritdoc />
        public int pixcmapGetComponentRange(IntPtr cmap,
            int component,
            out int minVal,
            out int maxVal
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetComponentRange(cmap, component, out minVal, out maxVal);
        }

        /// <inheritdoc />
        public int pixcmapGetExtremeValue(IntPtr cmap,
            int type,
            out int rVal,
            out int gVal,
            out int bVal
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGetExtremeValue(cmap, type, out rVal, out gVal, out bVal);
        }

        /// <inheritdoc />
        public IntPtr pixcmapGrayToColor(int color)
        {
            return UnsafeLeptonicaPrimitives.pixcmapGrayToColor(color);
        }

        /// <inheritdoc />
        public IntPtr pixcmapColorToGray(IntPtr cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapColorToGray(cmaps, redWeight, greenWeight, blueWeight);
        }

        /// <inheritdoc />
        public int pixcmapToArrays(IntPtr cmap,
            out IntPtr redMap,
            out IntPtr greenMap,
            out IntPtr blueMap
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapToArrays(cmap, out redMap, out greenMap, out blueMap);
        }

        /// <inheritdoc />
        public int pixcmapToRGBTable(IntPtr cmap,
            out IntPtr colorTable,
            out int colorCount
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapToRGBTable(cmap, out colorTable, out colorCount);
        }

        /// <inheritdoc />
        public int pixcmapSerializeToMemory(IntPtr cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapSerializeToMemory(cmap, out components, out colorCount, out colorData, out colorDataLength);
        }

        /// <inheritdoc />
        public IntPtr pixcmapSerializeToMemory(IntPtr colorData,
            int colorCount,
            int colorDataLength
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapSerializeToMemory(colorData, colorCount, colorDataLength);
        }

        /// <inheritdoc />
        public int pixcmapGammaTRC(IntPtr cmap,
            float gamma,
            int minVal,
            int maxVal
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapGammaTRC(cmap, gamma, minVal, maxVal);
        }

        /// <inheritdoc />
        public int pixcmapContrastTRC(IntPtr cmap,
            float factor
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapContrastTRC(cmap, factor);
        }

        /// <inheritdoc />
        public int pixcmapShiftIntensity(IntPtr cmap,
            float fraction
            )
        {
            return UnsafeLeptonicaPrimitives.pixcmapShiftIntensity(cmap, fraction);
        }

        #endregion
    }
}
