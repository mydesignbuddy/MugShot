using System;
using System.Collections;

namespace MugShot.Utilities.Exif
{
    /// <summary>
    /// Summary description for Properties.
    /// </summary>
    public sealed class Properties : Hashtable
    {
        /// <summary>
        /// 
        /// </summary>
        public Properties()
        {
            Add(0x8769, "Exif IFD");
            Add(0x8825, "Gps IFD");
            Add(0xFE, "New Subfile Type");
            Add(0xFF, "Subfile Type");
            Add(0x100, "Image Width");
            Add(0x101, "Image Height");
            Add(0x102, "Bits Per Sample");
            Add(0x103, "Compression");
            Add(0x106, "Photometric Interp");
            Add(0x107, "Thresh Holding");
            Add(0x108, "Cell Width");
            Add(0x109, "Cell Height");
            Add(0x10A, "Fill Order");
            Add(0x10D, "Document Name");
            Add(0x10E, "Image Description");
            Add(0x10F, "Equip Make");
            Add(0x110, "Equip Model");
            Add(0x111, "Strip Offsets");
            Add(0x112, "Orientation");
            Add(0x115, "Samples PerPixel");
            Add(0x116, "Rows Per Strip");
            Add(0x117, "Strip Bytes Count");
            Add(0x118, "Min Sample Value");
            Add(0x119, "Max Sample Value");
            Add(0x11A, "X Resolution");
            Add(0x11B, "Y Resolution");
            Add(0x11C, "Planar Config");
            Add(0x11D, "Page Name");
            Add(0x11E, "X Position");
            Add(0x11F, "Y Position");
            Add(0x120, "Free Offset");
            Add(0x121, "Free Byte Counts");
            Add(0x122, "Gray Response Unit");
            Add(0x123, "Gray Response Curve");
            Add(0x124, "T4 Option");
            Add(0x125, "T6 Option");
            Add(0x128, "Resolution Unit");
            Add(0x129, "Page Number");
            Add(0x12D, "Transfer Funcition");
            Add(0x131, "Software Used");
            Add(0x132, "Date Time");
            Add(0x13B, "Artist");
            Add(0x13C, "Host Computer");
            Add(0x13D, "Predictor");
            Add(0x13E, "White Point");
            Add(0x13F, "Primary Chromaticities");
            Add(0x140, "ColorMap");
            Add(0x141, "Halftone Hints");
            Add(0x142, "Tile Width");
            Add(0x143, "Tile Length");
            Add(0x144, "Tile Offset");
            Add(0x145, "Tile ByteCounts");
            Add(0x14C, "InkSet");
            Add(0x14D, "Ink Names");
            Add(0x14E, "Number Of Inks");
            Add(0x150, "Dot Range");
            Add(0x151, "Target Printer");
            Add(0x152, "Extra Samples");
            Add(0x153, "Sample Format");
            Add(0x154, "S Min Sample Value");
            Add(0x155, "S Max Sample Value");
            Add(0x156, "Transfer Range");
            Add(0x200, "JPEG Proc");
            Add(0x201, "JPEG InterFormat");
            Add(0x202, "JPEG InterLength");
            Add(0x203, "JPEG RestartInterval");
            Add(0x205, "JPEG LosslessPredictors");
            Add(0x206, "JPEG PointTransforms");
            Add(0x207, "JPEG QTables");
            Add(0x208, "JPEG DCTables");
            Add(0x209, "JPEG ACTables");
            Add(0x211, "YCbCr Coefficients");
            Add(0x212, "YCbCr Subsampling");
            Add(0x213, "YCbCr Positioning");
            Add(0x214, "REF Black White");
            Add(0x8773, "ICC Profile");
            Add(0x301, "Gamma");
            Add(0x302, "ICC Profile Descriptor");
            Add(0x303, "SRGB RenderingIntent");
            Add(0x320, "Image Title");
            Add(0x8298, "Copyright");
            Add(0x5001, "Resolution X Unit");
            Add(0x5002, "Resolution Y Unit");
            Add(0x5003, "Resolution X LengthUnit");
            Add(0x5004, "Resolution Y LengthUnit");
            Add(0x5005, "Print Flags");
            Add(0x5006, "Print Flags Version");
            Add(0x5007, "Print Flags Crop");
            Add(0x5008, "Print Flags Bleed Width");
            Add(0x5009, "Print Flags Bleed Width Scale");
            Add(0x500A, "Halftone LPI");
            Add(0x500B, "Halftone LPIUnit");
            Add(0x500C, "Halftone Degree");
            Add(0x500D, "Halftone Shape");
            Add(0x500E, "Halftone Misc");
            Add(0x500F, "Halftone Screen");
            Add(0x5010, "JPEG Quality");
            Add(0x5011, "Grid Size");
            Add(0x5012, "Thumbnail Format");
            Add(0x5013, "Thumbnail Width");
            Add(0x5014, "Thumbnail Height");
            Add(0x5015, "Thumbnail ColorDepth");
            Add(0x5016, "Thumbnail Planes");
            Add(0x5017, "Thumbnail RawBytes");
            Add(0x5018, "Thumbnail Size");
            Add(0x5019, "Thumbnail CompressedSize");
            Add(0x501A, "Color Transfer Function");
            Add(0x501B, "Thumbnail Data");
            Add(0x5020, "Thumbnail ImageWidth");
            Add(0x502, "Thumbnail ImageHeight");
            Add(0x5022, "Thumbnail BitsPerSample");
            Add(0x5023, "Thumbnail Compression");
            Add(0x5024, "Thumbnail PhotometricInterp");
            Add(0x5025, "Thumbnail ImageDescription");
            Add(0x5026, "Thumbnail EquipMake");
            Add(0x5027, "Thumbnail EquipModel");
            Add(0x5028, "Thumbnail StripOffsets");
            Add(0x5029, "Thumbnail Orientation");
            Add(0x502A, "Thumbnail SamplesPerPixel");
            Add(0x502B, "Thumbnail RowsPerStrip");
            Add(0x502C, "Thumbnail StripBytesCount");
            Add(0x502D, "Thumbnail ResolutionX");
            Add(0x502E, "Thumbnail ResolutionY");
            Add(0x502F, "Thumbnail PlanarConfig");
            Add(0x5030, "Thumbnail ResolutionUnit");
            Add(0x5031, "Thumbnail TransferFunction");
            Add(0x5032, "Thumbnail SoftwareUsed");
            Add(0x5033, "Thumbnail DateTime");
            Add(0x5034, "Thumbnail Artist");
            Add(0x5035, "Thumbnail WhitePoint");
            Add(0x5036, "Thumbnail PrimaryChromaticities");
            Add(0x5037, "Thumbnail YCbCrCoefficients");
            Add(0x5038, "Thumbnail YCbCrSubsampling");
            Add(0x5039, "Thumbnail YCbCrPositioning");
            Add(0x503A, "Thumbnail RefBlackWhite");
            Add(0x503B, "Thumbnail CopyRight");
            Add(0x5090, "Luminance Table");
            Add(0x5091, "Chrominance Table");
            Add(0x5100, "Frame Delay");
            Add(0x5101, "Loop Count");
            Add(0x5110, "Pixel Unit");
            Add(0x5111, "Pixel PerUnit X");
            Add(0x5112, "Pixel PerUnit Y");
            Add(0x5113, "Palette Histogram");
            Add(0x829A, "Exposure Time");
            Add(0x829D, "F-Number");
            Add(0x8822, "Exposure Prog");
            Add(0x8824, "Spectral Sense");
            Add(0x8827, "ISO Speed");
            Add(0x8828, "OECF");
            Add(0x9000, "Ver");
            Add(0x9003, "DTOrig");
            Add(0x9004, "DTDigitized");
            Add(0x9101, "CompConfig");
            Add(0x9102, "CompBPP");
            Add(0x9201, "Shutter Speed");
            Add(0x9202, "Aperture");
            Add(0x9203, "Brightness");
            Add(0x9204, "Exposure Bias");
            Add(0x9205, "MaxAperture");
            Add(0x9206, "SubjectDist");
            Add(0x9207, "Metering Mode");
            Add(0x9208, "LightSource");
            Add(0x9209, "Flash");
            Add(0x920A, "FocalLength");
            Add(0x927C, "Maker Note");
            Add(0x9286, "User Comment");
            Add(0x9290, "DTSubsec");
            Add(0x9291, "DTOrigSS");
            Add(0x9292, "DTDigSS");
            Add(0xA000, "FPXVer");
            Add(0xA001, "ColorSpace");
            Add(0xA002, "PixXDim");
            Add(0xA003, "PixYDim");
            Add(0xA004, "RelatedWav");
            Add(0xA005, "Interop");
            Add(0xA20B, "FlashEnergy");
            Add(0xA20C, "SpatialFR");
            Add(0xA20E, "FocalXRes");
            Add(0xA20F, "FocalYRes");
            Add(0xA210, "FocalResUnit");
            Add(0xA214, "Subject Loc");
            Add(0xA215, "Exposure Index");
            Add(0xA217, "Sensing Method");
            Add(0xA300, "FileSource");
            Add(0xA301, "SceneType");
            Add(0xA302, "CfaPattern");
            Add(0x0, "Gps Ver");
            Add(0x1, "Gps LatitudeRef");
            Add(0x2, "Gps Latitude");
            Add(0x3, "Gps LongitudeRef");
            Add(0x4, "Gps Longitude");
            Add(0x5, "Gps AltitudeRef");
            Add(0x6, "Gps Altitude");
            Add(0x7, "Gps GpsTime");
            Add(0x8, "Gps GpsSatellites");
            Add(0x9, "Gps GpsStatus");
            Add(0xA, "Gps GpsMeasureMode");
            Add(0xB, "Gps GpsDop");
            Add(0xC, "Gps SpeedRef");
            Add(0xD, "Gps Speed");
            Add(0xE, "Gps TrackRef");
            Add(0xF, "Gps Track");
            Add(0x10, "Gps ImgDirRef");
            Add(0x11, "Gps ImgDir");
            Add(0x12, "Gps MapDatum");
            Add(0x13, "Gps DestLatRef");
            Add(0x14, "Gps DestLat");
            Add(0x15, "Gps DestLongRef");
            Add(0x16, "Gps DestLong");
            Add(0x17, "Gps DestBearRef");
            Add(0x18, "Gps DestBear");
            Add(0x19, "Gps DestDistRef");
            Add(0x1A, "Gps DestDist");
        }
    }
    /// <summary>
    /// private class
    /// </summary>
    internal class Rational
    {
        private readonly int d;
        private readonly int n;

        public Rational(int n, int d)
        {
            this.n = n;
            this.d = d;
            simplify(ref this.n, ref this.d);
        }

        public Rational(uint n, uint d)
        {
            this.n = Convert.ToInt32(n);
            this.d = Convert.ToInt32(d);

            simplify(ref this.n, ref this.d);
        }

        public Rational()
        {
            n = d = 0;
        }

        public string ToString(string sp)
        {
            if (sp == null) sp = "/";
            return n.ToString() + sp + d.ToString();
        }

        public double ToDouble()
        {
            if (d == 0)
                return 0.0;

            return Math.Round(Convert.ToDouble(n) / Convert.ToDouble(d), 2);
        }

        private void simplify(ref int a, ref int b)
        {
            if (a == 0 || b == 0)
                return;

            int gcd = euclid(a, b);
            a /= gcd;
            b /= gcd;
        }

        private int euclid(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return euclid(b, a % b);
        }
    }
}