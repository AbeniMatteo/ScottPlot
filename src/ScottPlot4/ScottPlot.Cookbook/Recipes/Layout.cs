﻿using System;
using System.Drawing;

namespace ScottPlot.Cookbook.Recipes
{
    class LayoutDefault : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_default";
        public string Title => "Default Layout";
        public string Description =>
            "asdf";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.Title("Plot Title");
        }
    }

    class LayoutPlot : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_plot";
        public string Title => "Plot Layout";
        public string Description =>
            "Call Layout() to manually define padding on all edges of the data area. " +
            "This is the easiest way to make room for large custom tick labels. " +
            "Under the hood, this method sets the minimum size of all 4 primary axes.";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.Title("Plot Title");
            plt.Style(figureBackground: Color.SkyBlue);

            plt.Layout(left: 100, right: 100, bottom: 100, top: 50);
        }
    }

    class LayoutAxisSize : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_axis_size";
        public string Title => "Axis Size";
        public string Description =>
            "The size of each axis can be individually customized. " +
            "Note that axes automatically resize themselves to accomodate tick labels, " +
            "but this method lets users customize the min/max boundaries of axis size. " +
            "Set both numbers to the same value to force an axis to always be a specific size.";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.Title("Plot Title");
            plt.Style(figureBackground: Color.SkyBlue);

            plt.XAxis.Layout(minimumSize: 100, maximumSize: 150);
        }
    }

    class LayoutAxisPadding : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_axis_padding";
        public string Title => "Axis Padding";
        public string Description =>
            "Axis label and ticks are enclosed in a rectangle that is automatically sized " +
            "to accomodate them (optionally limited to a min/max size as seen earlier). " +
            "This rectangle has a small amount of padding on all sides so axis labels do not " +
            "touch the final pixel on the edge of the figure. " +
            "The amount of extra padding around each axis can be customized.";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.Title("Plot Title");
            plt.Style(figureBackground: Color.SkyBlue);

            plt.XAxis.Layout(padding: 50);
        }
    }

    class LayoutFrameless : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_frameless";
        public string Title => "Frameless Plot";
        public string Description =>
            "The Frameless() method disables and collapses all axes " +
            "so the data area is all that appears. Although the figure " +
            "background is blue in this example, none of it will show, because " +
            "the data area occupies all of the available space.";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.Style(figureBackground: Color.SkyBlue);

            plt.Frameless();
        }
    }

    class LayoutMargins : IRecipe
    {
        public ICategory Category => new Categories.Layout();
        public string ID => "layout_margins";
        public string Title => "Data Margins";
        public string Description =>
            "Users who want to define the amount of space around their data can use Margins() to " +
            "automatically pad data boundaries with a certain percentage of extra space when " +
            "axis limits are calculated automatically. Note that this operation acts on the axis limits, " +
            "and does not technically adjust the layout of the plot itself.";

        public void ExecuteRecipe(Plot plt)
        {
            plt.AddSignal(DataGen.Sin(51));
            plt.AddSignal(DataGen.Cos(51));
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");
            plt.Title("Plot Title");
            plt.Style(figureBackground: Color.SkyBlue);

            // 25% horizontal padding means data occupies 75% of horizontal space
            // 40% vertical padding means data occupies 60% of vertical space
            plt.Margins(x: .25, y: .4);
        }
    }
}
