using System;
using System.Collections.Generic;
using System.Text;

namespace Tesseract.Wrapper
{
    /// <summary>
    /// Interface to be implemented by all Leptonica API wrappers
    /// </summary>
    public interface ILeptonicaPrimitives
    {
        #region >> Pix

        IntPtr pixCreate(int width,
            int height,
            int depth
            );

        void pixDestroy(ref IntPtr pix);

        int pixGetWidth(IntPtr pix);

        int pixGetHeight(IntPtr pix);

        int pixGetDepth(IntPtr pix);

        int pixGetXRes(IntPtr pix);

        int pixGetYRes(IntPtr pix);

        int pixGetResolution(IntPtr pix,
            out int xres,
            out int yres
            );

        int pixGetWpl(IntPtr pix);

        int pixSetXRes(IntPtr pix,
             int xres
             );

        int pixSetYRes(IntPtr pix,
            int yres
            );

        int pixSetResolution(IntPtr pix,
            int xres,
            int yres
            );

        int pixScaleResolution(IntPtr pix,
            float xscale,
            float yscale
            );

        IntPtr pixGetData(IntPtr pix);

        ImageFormat pixGetInputFormat(IntPtr pix);

        int pixSetInputFormat(IntPtr pix,
            ImageFormat inputFormat
            );

        int pixEndianByteSwap(IntPtr pix);

        IntPtr pixRead(string filename);

        int pixWrite(string filename,
            IntPtr handle,
            ImageFormat format
            );

        IntPtr pixGetColormap(IntPtr pix);

        int pixSetColormap(IntPtr pix,
            IntPtr pixCmap
            );

        int pixDestroyColormap(IntPtr pix);

        IntPtr pixConvertRGBToGray(IntPtr pix,
            float rwt,
            float gwt,
            float bwt
            );

        IntPtr pixDeskewGeneral(IntPtr pix,
            int redSweep,
            float sweepRange,
            float sweepDelta,
            int redSearch,
            int thresh,
            out float pAngle,
            out float pConf
            );

        int pixOtsuAdaptiveThreshold(IntPtr pix,
            int sx,
            float sy,
            float smoothx,
            int smoothy,
            float scorefract,
            out IntPtr ppixth,
            out IntPtr ppixd
            );

        #endregion

        #region >> Color Map

        /// <summary>
        /// Creates a new colormap with the specified <paramref name="depth"/>.
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <returns>The pointer to the color map, or null on error.</returns>
        IntPtr pixcmapCreate(int depth);

        /// <summary>
        /// Creates a new colormap of the specified <paramref name="depth"/> with random colors where the first color can optionally be set to black, and the last optionally set to white.
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <param name="hasBlack">If set to 1 the first color will be black.</param>
        /// <param name="hasWhite">If set to 1 the last color will be white.</param>
        /// <returns>The pointer to the color map, or null on error.</returns>
        IntPtr pixcmapCreateRandom(int depth,
            int hasBlack,
            int hasWhite
            );

        /// <summary>
        /// Creates a new colormap of the specified <paramref name="depth"/> with equally spaced gray color values. 
        /// </summary>
        /// <param name="depth">The depth of the pix in bpp, can be 2, 4, or 8</param>
        /// <param name="levels">The number of levels (must be between 2 and 2^<paramref name="depth"/></param>
        /// <returns>The pointer to the colormap, or null on error.</returns>
        IntPtr pixcmapCreateLinear(int depth,
            int levels
            );

        /// <summary>
        /// Performs a deep copy of the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>The pointer to the colormap, or null on error.</returns>
        IntPtr pixcmapCopy(IntPtr cmaps);

        /// <summary>
        /// Destorys and cleans up any memory used by the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance, set to null on success.</param>
        void pixcmapDestroy(ref IntPtr cmap);

        /// <summary>
        /// Gets the number of color entries in the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns the number of color entries in the color map, or 0 on error.</returns>
        int pixcmapGetCount(IntPtr cmap);

        /// <summary>
        /// Gets the number of free color entries in the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns the number of free color entries in the color map, or 0 on error.</returns>
        int pixcmapGetFreeCount(IntPtr cmap);

        /// <returns>Returns color maps depth, or 0 on error.</returns>
        int pixcmapGetDepth(IntPtr cmap);

        /// <summary>
        /// Gets the minimum pix depth required to support the color map.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="minDepth">Returns the minimum depth to support the colormap</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        int pixcmapGetMinDepth(IntPtr cmap, 
            out int minDepth
            );

        /// <summary>
        /// Removes all colors from the color map by setting the count to zero.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        int pixcmapClear(IntPtr cmap);

        /// <summary>
        /// Adds the color to the pix color map if their is room.
        /// </summary>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        int pixcmapAddColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue
            );

        /// <summary>
        /// Adds the specified color if it doesn't already exist, returning the colors index in the data array.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>
        /// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        int pixcmapAddNewColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
            );

        /// <summary>
        /// Adds the specified color if it doesn't already exist, returning the color's index in the data array.
        /// </summary>
        /// <remarks>
        /// If the color doesn't exist and there is not enough room to add a new color return the nearest color.
        /// </remarks>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="colorIndex">The index of the new color if it was added, or the existing color if it already existed.</param>
        /// <returns>Returns 0 for success, 1 for error, 2 for not enough space.</returns>
        int pixcmapAddNearestColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int colorIndex
            );

        /// <summary>
        /// Checks if the color already exists or if their is enough room to add it.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="redValue">The red value</param>
        /// <param name="greenValue">The green value</param>
        /// <param name="blueValue">The blue value</param>
        /// <param name="usable">Returns 1 if usable; 0 if not.</param>
        /// <returns>Returns 0 if OK, 1 on error.</returns>
        int pixcmapUsableColor(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int usable
            );

        /// <summary>
        /// Adds a color (black\white) if not already there returning it's index through <paramref name="index"/>.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="color">The color to add (0 for black; 1 for white)</param>
        /// <param name="index">The index of the color.</param>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapAddBlackOrWhite(IntPtr cmap,
            int color,
            out int index
            );

        /// <summary>
        /// Sets the darkest color in the colormap to black, if <paramref name="setBlack"/> is 1. 
        /// Sets the lightest color in the colormap to white if <paramref name="setWhite"/> is 1. 
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="setBlack">0 for no operation; 1 to set darket color to black</param>
        /// <param name="setBlack">0 for no operation; 1 to set lightest color to white</param>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapSetBlackAndWhite(IntPtr cmap,
            int setBlack,
            int setWhite
            );

        /// <summary>
        /// Gets the color at the specified index.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the color entry.</param>
        /// <param name="redValue">The color entry's red value.</param>
        /// <param name="blueValue">The color entry's blue value.</param>
        /// <param name="greenValue">The color entry's green value.</param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        int pixcmapGetColor(IntPtr cmap,
            int index,
            out int redValue,
            out int greenValue,
            out int blueValue
            );

        /// <summary>
        /// Gets the color at the specified index.
        /// </summary>
        /// <remarks>
        /// The alpha channel will always be zero as it is not used in Leptonica color maps.
        /// </remarks>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the color entry.</param>
        /// <param name="color">The color entry as 32 bit value</param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        int pixcmapGetColor32(IntPtr cmap,
            int index,
            out int color
            );

        /// <summary>
        /// Sets a previously allocated color entry.
        /// </summary>
        /// <param name="cmap">The pointer to the colormap instance.</param>
        /// <param name="index">The index of the colormap entry</param>
        /// <param name="redValue"></param>
        /// <param name="blueValue"></param>
        /// <param name="greenValue"></param>
        /// <returns>Returns 0 if OK; 1 if not accessable (caller should check).</returns>
        int pixcmapResetColor(IntPtr cmap,
            int index,
            int redValue,
            int greenValue,
            int blueValue
            );

        /// <summary>
        /// Gets the index of the color entry with the specified color, return 0 if found; 1 if not.
        /// </summary>
        int pixcmapGetIndex(IntPtr cmap,
            int redValue,
            int greenValue,
            int blueValue,
            out int index
            );


        /// <summary>
        /// Returns 0 if the color exists in the color map; otherwise 1.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapHasColor(IntPtr cmap,
            int color
            );


        /// <summary>
        /// Returns the number of unique grey colors including black and white.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapCountGrayColors(IntPtr cmap,
            out int ngray
            );

        /// <summary>
        /// Finds the index of the color entry with the rank intensity.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapGetRankIntensity(IntPtr cmap,
            float rankVal,
            out int index
            );


        /// <summary>
        /// Finds the index of the color entry closest to the specified color.
        /// </summary>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapGetNearestIndex(IntPtr cmap,
            int rVal,
            int gVal,
            int bVal,
            out int index
            );

        /// <summary>
        /// Finds the index of the color entry closest to the specified color.
        /// </summary>
        /// <remarks>
        /// Should only be used on gray colormaps.
        /// </remarks>
        /// <returns>Returns 0 if OK; 1 on error.</returns>
        int pixcmapGetNearestGrayIndex(IntPtr cmap,
            int val,
            out int index
            );

        int pixcmapGetComponentRange(IntPtr cmap,
            int component,
            out int minVal,
            out int maxVal
            );

        int pixcmapGetExtremeValue(IntPtr cmap,
            int type,
            out int rVal,
            out int gVal,
            out int bVal
            );

        IntPtr pixcmapGrayToColor(int color);

        IntPtr pixcmapColorToGray(IntPtr cmaps,
            float redWeight,
            float greenWeight,
            float blueWeight
            );

        int pixcmapToArrays(IntPtr cmap,
            out IntPtr redMap,
            out IntPtr greenMap,
            out IntPtr blueMap
            );

        int pixcmapToRGBTable(IntPtr cmap,
            out IntPtr colorTable,
            out int colorCount
            );

        int pixcmapSerializeToMemory(IntPtr cmap,
            out int components,
            out int colorCount,
            out IntPtr colorData,
            out int colorDataLength
            );

        IntPtr pixcmapSerializeToMemory(IntPtr colorData,
             int colorCount,
             int colorDataLength
             );

        int pixcmapGammaTRC(IntPtr cmap,
            float gamma,
            int minVal,
            int maxVal
            );

        int pixcmapContrastTRC(IntPtr cmap,
            float factor
            );

        int pixcmapShiftIntensity(IntPtr cmap,
            float fraction
            );

        #endregion
    }
}
