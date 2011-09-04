//-----------------------------------------------------------------------
// <copyright file="IPlotControl.cs" company="OxyPlot">
//     http://oxyplot.codeplex.com, license: Ms-PL
// </copyright>
//-----------------------------------------------------------------------

namespace OxyPlot
{
    /// <summary>
    /// Interface for Plot controls.
    /// </summary>
    public interface IPlotControl
    {
        #region Public Properties

        /// <summary>
        /// Gets the actual model.
        /// </summary>
        /// <value>The actual model.</value>
        PlotModel ActualModel { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the axes from a point.
        /// </summary>
        /// <param name="pt">
        /// The point.
        /// </param>
        /// <param name="xaxis">
        /// The x-axis.
        /// </param>
        /// <param name="yaxis">
        /// The y-axis.
        /// </param>
        void GetAxesFromPoint(ScreenPoint pt, out IAxis xaxis, out IAxis yaxis);

        /// <summary>
        /// Gets the series from point.
        /// </summary>
        /// <param name="pt">
        /// The point (screen coordinates).
        /// </param>
        /// <param name="limit">
        /// The maximum allowed distance.
        /// </param>
        /// <returns>
        /// The series.
        /// </returns>
        ISeries GetSeriesFromPoint(ScreenPoint pt, double limit = 100);

        /// <summary>
        /// Hides the tracker.
        /// </summary>
        void HideTracker();

        /// <summary>
        /// Hides the zoom rectangle.
        /// </summary>
        void HideZoomRectangle();

        /// <summary>
        /// Invalidate the plot (not blocking the UI thread)
        /// </summary>
        /// <param name="updateData">
        /// if set to <c>true</c>, all data collections will be updated.
        /// </param>
        void InvalidatePlot(bool updateData = true);

        /// <summary>
        /// Pans the specified axis.
        /// </summary>
        /// <param name="axis">
        /// The axis.
        /// </param>
        /// <param name="ppt">
        /// The previous point (screen coordinates).
        /// </param>
        /// <param name="cpt">
        /// The current point (screen coordinates).
        /// </param>
        void Pan(IAxis axis, ScreenPoint ppt, ScreenPoint cpt);

        /// <summary>
        /// Refresh the plot immediately (blocking UI thread)
        /// </summary>
        /// <param name="updateData">
        /// if set to <c>true</c>, all data collections will be updated.
        /// </param>
        void RefreshPlot(bool updateData = true);

        /// <summary>
        /// Resets the specified axis.
        /// </summary>
        /// <param name="axis">
        /// The axis.
        /// </param>
        void Reset(IAxis axis);

        /// <summary>
        /// Shows the tracker.
        /// </summary>
        /// <param name="trackerHitResult">
        /// The tracker data.
        /// </param>
        void ShowTracker(TrackerHitResult trackerHitResult);

        /// <summary>
        /// Shows the zoom rectangle.
        /// </summary>
        /// <param name="r">
        /// The rectangle.
        /// </param>
        void ShowZoomRectangle(OxyRect r);

        /// <summary>
        /// Zooms the specified axis to the specified values.
        /// </summary>
        /// <param name="axis">
        /// The axis.
        /// </param>
        /// <param name="p1">
        /// The new minimum value.
        /// </param>
        /// <param name="p2">
        /// The new maximum value.
        /// </param>
        void Zoom(IAxis axis, double p1, double p2);

        /// <summary>
        /// Zooms at the specified position.
        /// </summary>
        /// <param name="axis">
        /// The axis.
        /// </param>
        /// <param name="factor">
        /// The zoom factor.
        /// </param>
        /// <param name="x">
        /// The position to zoom at.
        /// </param>
        void ZoomAt(IAxis axis, double factor, double x);

        #endregion
    }
}
