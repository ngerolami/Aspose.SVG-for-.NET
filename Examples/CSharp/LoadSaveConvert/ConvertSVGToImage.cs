﻿using Aspose.Svg;
using Aspose.Svg.Rendering.Image;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LoadSaveConvert
{
    class ConvertSVGToImage
    {
        public static void ConvertSVGToBMP()
        {
            //ExStart: ConvertSVGToBMP
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), dataDir + "smiley_out.bmp"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToBMP
        }

        public static void ConvertSVGToGIF()
        {
            //ExStart: ConvertSVGToGIF
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Gif), dataDir + "smiley_out.gif"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToGIF
        }

        public static void ConvertSVGToJPEG()
        {
            //ExStart: ConvertSVGToJPEG
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Jpeg), dataDir + "smiley_out.jpg"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToJPEG
        }

        public static void ConvertSVGToPNG()
        {
            //ExStart: ConvertSVGToPNG
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Png), dataDir + "smiley_out.png"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToPNG
        }

        public static void ConvertSVGToTIFF()
        {
            //ExStart: ConvertSVGToTIFF
            string dataDir = RunExamples.GetDataDir_Convert();

            using (var document = new SVGDocument(Path.Combine(dataDir, "smiley.svg")))
            {
                using (var device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Tiff), dataDir + "smiley_out.tiff"))
                {
                    document.RenderTo(device);
                }
            }
            //ExEnd: ConvertSVGToTIFF
        }
    }
}
