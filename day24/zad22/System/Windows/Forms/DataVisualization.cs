using System.Drawing;

namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            internal class ChartArea
            {
                public string Name { get; internal set; }
            }

            internal class Legend
            {
            }

            internal class Series
            {
            }

            internal class Chart
            {
                public Chart()
                {
                }

                public object ChartAreas { get; internal set; }
                public Point Location { get; internal set; }
            }
        }
    }
}