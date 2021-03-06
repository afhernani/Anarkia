﻿/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/05/2017
 * Hora: 19:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace ImageFrame
{
	/// <summary>
	/// Description of ImageGif.
	/// </summary>
	public class ImageGif
	{
		private Image GifImage{ get; set; }
		//private Image Frame{ get; set; }
		private FrameDimension Dimension{ get; set; }
		private int Count{ get; set; }
		public int CurrentFrame{ get; set; }
		private bool Reverse{ get; set; }
		private int Step{ get; set; }
		
		public ImageGif(string path)
		{
			CurrentFrame = -1;
			Step = 1;
			Reverse = false; 
			frames = EnumerateFrames(path);
			/*GifImage = Image.FromFile(path);
			Dimension = new FrameDimension(GifImage.FrameDimensionsList[0]);
			Count = GifImage.GetFrameCount(Dimension);*/
		}
		public bool ReverseAtEnd {
        //whether the gif should play backwards when it reaches the end
			get { return Reverse; }
			set { Reverse = value; }
		}
		public Image GetNextFrame()
		{

			CurrentFrame += Step;

			//if the animation reaches a boundary...
			if (CurrentFrame >= Count || CurrentFrame < 1) {
				if (Reverse) {
					Step *= -1;
					//...reverse the count
					//apply it
					CurrentFrame += Step;
				} else {
					CurrentFrame = 0;
					//...or start over
				}
			}
			return GetFrame(CurrentFrame);
		}
		/// <summary>
		/// Retorna la imagen del indice correspondiente.
		/// No existe verificacion de indice por lo que
		/// es conveniente que este este entre los valores 
		/// correctos.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public Image GetFrame(int index)
		{
			//GifImage.SelectActiveFrame(Dimension, index);
			//find the frame
			//Frame=(Image)GifImage.Clone();
			//return Frame;
			CurrentFrame = index;
			if (CurrentFrame < Count && CurrentFrame >= 0)
			{
				return ConvertBytesToImage(frames[index]);
			}
			return null;
			//return a copy of it
		}
		/// <summary>
		/// lista de imagenes en bytes.
		/// </summary>
		List<byte[]> frames = new List<byte[]>() { };
		
		/// <summary>
		/// Extrae las imagenes del fichero gif en una lista de bytes
		/// </summary>
		/// <param name="imagePath"></param>
		/// <returns></returns>
		private List<byte[]> EnumerateFrames(string imagePath)
        {
            try
            {
                //Make sure the image exists
                if (!File.Exists(imagePath))
                {
                    throw new FileNotFoundException("Unable to locate " + imagePath);
                }

                Dictionary<Guid, ImageFormat> guidToImageFormatMap = new Dictionary<Guid, ImageFormat>()
                {
                    {ImageFormat.Bmp.Guid,  ImageFormat.Bmp},
                    {ImageFormat.Gif.Guid,  ImageFormat.Png},
                    {ImageFormat.Icon.Guid, ImageFormat.Png},
                    {ImageFormat.Jpeg.Guid, ImageFormat.Jpeg},
                    {ImageFormat.Png.Guid,  ImageFormat.Png}
                };

                List<byte[]> tmpFrames = new List<byte[]>() { };

                using (Image img = Image.FromFile(imagePath, true))
                {
                    //Check the image format to determine what
                    //format the image will be saved to the 
                    //memory stream in
                    ImageFormat imageFormat = null;
                    Guid imageGuid = img.RawFormat.Guid;

                    foreach (KeyValuePair<Guid, ImageFormat> pair in guidToImageFormatMap)
                    {
                        if (imageGuid == pair.Key)
                        {
                            imageFormat = pair.Value;
                            break;
                        }
                    }

                    if (imageFormat == null)
                    {
                        throw new NoNullAllowedException("Unable to determine image format");
                    }

                    //Get the frame count
                    Dimension = new FrameDimension(img.FrameDimensionsList[0]);
                    Count = img.GetFrameCount(Dimension);

                    //Step through each frame
                    for (int i = 0; i < Count; i++)
                    {
                        //Set the active frame of the image and then 
                        //write the bytes to the tmpFrames array
                        img.SelectActiveFrame(Dimension, i);
                        using (MemoryStream ms = new MemoryStream())
                        {

                            img.Save(ms, imageFormat);
                            tmpFrames.Add(ms.ToArray());
                        }
                    }

                }

                return tmpFrames;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "Error type: " + ex.GetType().ToString() + "\n" +
                    "Message: " + ex.Message,
                    "Error in " + MethodBase.GetCurrentMethod().Name
                    );
            }

            return null;
        }
		
		private Bitmap ConvertBytesToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
            {
                return null;
            }

            try
            {
                //Read bytes into a MemoryStream
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    //Recreate the frame from the MemoryStream
                    using (Bitmap bmp = new Bitmap(ms))
                    {
                        return (Bitmap)bmp.Clone();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "Error type: " + ex.GetType().ToString() + "\n" +
                    "Message: " + ex.Message,
                    "Error in " + MethodBase.GetCurrentMethod().Name
                    );
            }

            return null;
        }
		
	}
}
