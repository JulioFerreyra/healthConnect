using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class MonthCalendarX : UserControl
    {
        public MonthCalendarX()
        {
            InitializeComponent();
        }
        //
        private Color borderColor = Color.MediumSeaGreen;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.Honeydew;
        private bool isFocussed = false;
        //
        private int borderRadius = 0;
        private Color placeholderColor = Color.Violet;
       
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }

        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                monthCalendar1.ForeColor = value;
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
                pathTxt = GetFigurePath(monthCalendar1.ClientRectangle, borderRadius - borderSize);
                monthCalendar1.Region = new Region(pathTxt);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //quiere decir que es un cuadro de texto con esquinas redondeadas
            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -BorderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // dibujo del control con bordes redondeados suaves
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (!isFocussed)
                    {
                        if (underlineStyle)
                        { //line style
                            //aqui dibujamos la ruta del suavizado del contorno de borde
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //dibujamos el borde del estilo subrayado
                            graph.SmoothingMode = SmoothingMode.None;
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width - 0.5F, this.Height - 1);
                        }
                        else
                        {
                            // lo borro => graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                            //aqui dibujamos la ruta del suavizado del contorno de borde
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            //dibujamos el borde del estilo subrayado
                            graph.DrawPath(penBorder, pathBorder);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlineStyle) //line style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width - 0.5F, this.Height - 1);
                        else
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (!isFocussed)
                    {
                        if (underlineStyle) //line style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width - 0.5F, this.Height - 1);
                        else
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlineStyle) //line style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width - 0.5F, this.Height - 1);
                        else
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
    }
}

