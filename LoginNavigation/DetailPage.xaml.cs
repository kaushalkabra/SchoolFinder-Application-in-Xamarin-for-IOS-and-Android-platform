using System;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class DetailPage : ContentPage
	{
		public PlotModel PieModel { get; set; }
		public DetailPage()
		{
			InitializeComponent();
			PieModel = CreatePieChart();
		
		}
		private PlotModel CreatePieChart()
		{
			var model = new PlotModel { Title = "Pie Chart" };

			var ps = new PieSeries
			{
				StrokeThickness = .25,
				InsideLabelPosition = .25,
				AngleSpan = 360,
				StartAngle = 0
			};

			// http://www.nationsonline.org/oneworld/world_population.htm
			// http://en.wikipedia.org/wiki/Continent
			ps.Slices.Add(new PieSlice("Africa", 1030) { IsExploded = false });
			ps.Slices.Add(new PieSlice("Americas", 929) { IsExploded = false });
			ps.Slices.Add(new PieSlice("Asia", 4157));
			ps.Slices.Add(new PieSlice("Europe", 739) { IsExploded = false });
			ps.Slices.Add(new PieSlice("Oceania", 35) { IsExploded = false });
			model.Series.Add(ps);
			return model;
		}
	}
}
