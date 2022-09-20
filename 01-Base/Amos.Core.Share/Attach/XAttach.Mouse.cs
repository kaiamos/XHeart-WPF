using System;
using System.Windows;
using System.Windows.Media;

namespace Amos.Core.Attach
{
    /// <summary>
    /// 此处是附加属性中关于鼠标操作的判断
    /// </summary>
    public static partial class XAttach
    {
        /// <summary>
        ///  鼠标进入控件的背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseOverBackgroundProperty = 
            DependencyProperty.RegisterAttached(
                "MouseOverBackground",
                typeof(Brush),
                typeof(XAttach),
                new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));

        public static Brush GetMouseOverBackground(DependencyObject element) => (Brush)element.GetValue(MouseOverBackgroundProperty);

        public static void SetMouseOverBackground(DependencyObject element,Brush brush)
        {
            element.SetValue(MouseOverBackgroundProperty, brush);
        }

        /// <summary>
        /// 鼠标进入控件的前景色属性
        /// </summary>
        public static readonly DependencyProperty MouseOverForegroundProperty = 
            DependencyProperty.RegisterAttached(
                "MouseOverForeground", 
                typeof(Brush), 
                typeof(XAttach), 
                new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetMouseOverForeground(DependencyObject element, Brush value)
        {
            element.SetValue(MouseOverForegroundProperty, value);
        }

        public static Brush MouseOverForeground(DependencyObject element)
        {
            return (Brush)element.GetValue(MouseOverForegroundProperty);
        }

        /// <summary>
        /// 鼠标选择控件时的背景色
        /// </summary>
        public static readonly DependencyProperty SelectBackgroundProperty = 
            DependencyProperty.RegisterAttached(
                "SelectBackground", 
                typeof(Brush), 
                typeof(XAttach), 
                new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetSelectBackground(DependencyObject element, Brush value)
        {
            element.SetValue(SelectBackgroundProperty, value);
        }

        public static Brush SelectBackground(DependencyObject element)
        {
            return (Brush)element.GetValue(SelectBackgroundProperty);
        }

        /// <summary>
        ///  鼠标进入时候的控件边框颜色
        /// </summary>
        public static readonly DependencyProperty MouseOverBorderBrushProperty =
           DependencyProperty.RegisterAttached("MouseOverBorderBrush", typeof(Brush), typeof(XAttach),
               new FrameworkPropertyMetadata(Brushes.Transparent,
                   FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));

        public static void SetMouseOverBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(MouseOverBorderBrushProperty, value);
        }

        public static Brush GetMouseOverBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(MouseOverBorderBrushProperty);
        }

        /// <summary>
        ///    鼠标进入时候控件的边框粗细
        /// </summary>
        public static readonly DependencyProperty MouseOverBorderThicknessProperty =
            DependencyProperty.RegisterAttached(
                "MouseOverBorderThickness", 
                typeof(Thickness), 
                typeof(XAttach), 
                new FrameworkPropertyMetadata(new Thickness(1), OnMouseOverBorderThicknessChanged));

        public static Thickness GetMouseOverBorderThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(MouseOverBorderThicknessProperty);
        }

        public static void SetMouseOverBorderThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(MouseOverBorderThicknessProperty, value);
        }

        /// <summary>
        ///  当鼠标进入时候修改
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void OnMouseOverBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DependencyObject control = d;

            Thickness o = (Thickness)e.OldValue;

            Thickness n = (Thickness)e.NewValue;
        }
    }
}
