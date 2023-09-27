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


namespace prueba
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBoxD : UserControl
    {
        //j
        private Color borderColor = Color.MediumSeaGreen;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.Honeydew;
        private bool isFocussed = false;
        //
        private int borderRadius = 0;
        private Color placeholderColor = Color.Violet;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private int _maxLength = 10; // la longitud máxima permitida
        public TextBoxD()
        {
            InitializeComponent();
            //this.MaxLength = _maxLength;
        }
        //eventos
        public int MaxLength
        {
            get { return _maxLength; }
            set
            {
                _maxLength = value;
                this.Invalidate();
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Permite la tecla de retroceso y el Control+C para copiar
            if (!char.IsControl(e.KeyChar) && this.TextLength >= _maxLength)
            {
                e.Handled = true; // Detiene la entrada de texto adicional
            }
            base.OnKeyPress(e);
        }
        public event EventHandler _TextChanged;

        [Category("TextBoxD Advance")]
        public Color BorderColor {
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
        [Category("TextBoxD Advance")]
        public int BorderSize {
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
        [Category("TextBoxD Advance")]
        public bool UnderlineStyle {
            get {
                return underlineStyle;
            }
            set {
                underlineStyle = value;
                this.Invalidate();
            }
        }
        [Category("TextBoxD Advance")]
        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
               // this.Invalidate();
            }
        }
        [Category("TextBoxD Advance")]
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        [Category("TextBoxD Advance")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("TextBoxD Advance")]
        public override Color ForeColor 
        {
            get{
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("TextBoxD Advance")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if(this.DesignMode)
                    UpdateControlHeight();
            }
        }
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("TextBoxD Advance")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        [Category("TextBoxD Advance")]
        public int BorderRadius 
        { 
            get
            {
                return borderRadius;
            } set
            {
                if (value>= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }
        [Category("TextBoxD Advance")]
        public Color PlaceholderColor { get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if(isPasswordChar)
                    textBox1.ForeColor= value;
            } }
        [Category("TextBoxD Advance")]
        public string PlaceholderText 
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        public int TextLength { get; private set; }

        [Category("TextBoxD Advance")]

        private void SetPlaceholder()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText!= "")
            {
                isPlaceholder= true;
                textBox1.Text= placeholderText;
                textBox1.ForeColor = placeholderColor;
                if(isPasswordChar)
                    textBox1.UseSystemPasswordChar= false;
            }
        }
        private void RemovePlaceHolder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //quiere decir que es un cuadro de texto con esquinas redondeadas
            if (borderRadius > 1) {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -BorderSize, -borderSize);
                int smoothSize = borderSize>0? borderSize:1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using(GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using(Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // dibujo del control con bordes redondeados suaves
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode= SmoothingMode.AntiAlias;
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
            }//es un cuadro de texto cuadrado o tradicional
            // DRAW BORDER
           
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if(Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius-borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize);
                textBox1.Region = new Region(pathTxt);
            }
        }

        //metodo para crear la ruta del control con un radio en especifico
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right- curveSize, rect.Y, curveSize, curveSize, 270,90);
            path.AddArc(rect.Right - curveSize, rect.Bottom- curveSize, curveSize,curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure(); 
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height+ 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize= new System.Drawing.Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height= textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged!= null)
                _TextChanged.Invoke(sender, e);
            
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e); 
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocussed= true;
            this.Invalidate();
            RemovePlaceHolder();

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocussed = false;
            this.Invalidate();
            SetPlaceholder();

        }

    }
}
