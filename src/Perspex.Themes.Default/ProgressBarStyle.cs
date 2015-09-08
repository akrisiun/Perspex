﻿





namespace Perspex.Themes.Default
{
    using System.Linq;
    using System.Reactive.Linq;
    using Perspex.Controls;
    using Perspex.Controls.Presenters;
    using Perspex.Controls.Primitives;
    using Perspex.Controls.Shapes;
    using Perspex.Controls.Templates;
    using Perspex.Layout;
    using Perspex.Media;
    using Perspex.Styling;

    /// <summary>
    /// The default style for the <see cref="ProgressBar"/> control.
    /// </summary>
    public class ProgressBarStyle : Styles
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBarStyle"/> class.
        /// </summary>
        public ProgressBarStyle()
        {
            this.AddRange(new[]
            {
                new Style(x => x.OfType<ProgressBar>())
                {
                    Setters = new[]
                    {
                        new Setter(ProgressBar.TemplateProperty, new ControlTemplate<ProgressBar>(Template)),
                        new Setter(ProgressBar.BackgroundProperty, new SolidColorBrush(0xffdddddd)),
                        new Setter(ProgressBar.ForegroundProperty, new SolidColorBrush(0xffbee6fd)),
                    },
                }
            });
        }

        /// <summary>
        /// The default template for the <see cref="ProgressBar"/> control.
        /// </summary>
        /// <param name="control">The control being styled.</param>
        /// <returns>The root of the instantiated template.</returns>
        public static Control Template(ProgressBar control)
        {
            Border container = new Border
            {
                [~Border.BackgroundProperty] = control[~ProgressBar.BackgroundProperty],
                [~Border.BorderBrushProperty] = control[~ProgressBar.BorderBrushProperty],
                [~Border.BorderThicknessProperty] = control[~ProgressBar.BorderThicknessProperty],

                Child = new Grid
                {
                    MinHeight = 14,
                    MinWidth = 200,

                    Children = new Controls
                    {
                        new Border
                        {
                            Name = "PART_Track",
                            BorderThickness = 1,
                            [~Border.BorderBrushProperty] = control[~ProgressBar.BackgroundProperty],
                        },

                        new Border
                        {
                            Name = "PART_Indicator",
                            BorderThickness = 1,
                            HorizontalAlignment = HorizontalAlignment.Left,
                            [~Border.BackgroundProperty] = control[~ProgressBar.ForegroundProperty],
                            Child = new Grid
                            {
                                Name = "Animation",
                                ClipToBounds = true,
                            }
                        }
                    }
                }
            };

            return container;
        }
    }
}
