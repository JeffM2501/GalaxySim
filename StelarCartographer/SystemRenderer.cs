using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

using GalaxySim;
using GalaxySim.Utilities;
using GalaxySim.CoordinateSystems;

namespace StelarCartographer
{
	public class SystemRenderer : IDisposable
	{
		public StarSystem TheStarSystem = null;

		public SystemRenderer(StarSystem ss)
		{
			TheStarSystem = ss;
		}

		public void Dispose()
		{

		}

		protected Brush GetStarColor(StarSystem.Star star)
		{
			switch (star.SpectralType)
			{
				case StarSystem.Star.SpectraTypes.O:
					return Brushes.SlateBlue;
				case StarSystem.Star.SpectraTypes.B:
					return Brushes.SkyBlue;
				case StarSystem.Star.SpectraTypes.A:
					return Brushes.LightSkyBlue;
				case StarSystem.Star.SpectraTypes.F:
					return Brushes.WhiteSmoke;
				case StarSystem.Star.SpectraTypes.G:
					return Brushes.Wheat;
				case StarSystem.Star.SpectraTypes.K:
					return Brushes.LightYellow;
				case StarSystem.Star.SpectraTypes.M:
					return Brushes.Orange;
				case StarSystem.Star.SpectraTypes.L:
					return Brushes.OrangeRed;
                case StarSystem.Star.SpectraTypes.T:
					return Brushes.Red;
			}
			return Brushes.Wheat;
		}

		protected void DrawCircle(Graphics context, Brush fill, int centerX, int centerY, int radius)
		{
			context.FillEllipse(fill, new Rectangle(centerX-radius, centerY - radius, radius*2, radius*2));
		}

		public void Draw(Graphics context, Control guiElement)
		{
			double scale = 1.0/100000000.0;

			int midX = guiElement.Bounds.Width / 2;
			int midY = guiElement.Bounds.Height / 2;

			context.Clear(Color.Black);

			foreach(StarSystem.Star star in TheStarSystem.Stars)
			{
				DrawCircle(context, GetStarColor(star), midX + (int)(star.Offset.X * scale), midY + (int)(star.Offset.Y * scale), 10 + (int)(0.5 * (star.Magnitude + star.Luminosity)));
			}

			foreach(StarSystem.Planet planet in TheStarSystem.Planets)
			{

			}
			
		}
	}

}
