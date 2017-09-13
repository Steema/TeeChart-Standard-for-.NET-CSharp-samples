namespace SubaruBRZSimul
{
  partial class CarDash
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDash));
      this.chartController1 = new Steema.TeeChart.ChartController();
      this.revChart = new Steema.TeeChart.TChart();
      this.circularGauge1 = new Steema.TeeChart.Styles.CircularGauge();
      this.numericGauge1 = new Steema.TeeChart.Styles.NumericGauge();
      this.numericGauge2 = new Steema.TeeChart.Styles.NumericGauge();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.speedChart = new Steema.TeeChart.TChart();
      this.circularGauge2 = new Steema.TeeChart.Styles.CircularGauge();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // chartController1
      // 
      this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
      this.chartController1.Chart = this.revChart;
      this.chartController1.LabelValues = true;
      this.chartController1.Location = new System.Drawing.Point(0, 0);
      this.chartController1.Name = "chartController1";
      this.chartController1.Size = new System.Drawing.Size(1501, 25);
      this.chartController1.TabIndex = 0;
      this.chartController1.Text = "chartController1";
      // 
      // revChart
      // 
      // 
      // 
      // 
      this.revChart.Aspect.ColorPaletteIndex = 20;
      this.revChart.Aspect.Elevation = 315;
      this.revChart.Aspect.ElevationFloat = 315D;
      this.revChart.Aspect.Orthogonal = false;
      this.revChart.Aspect.Perspective = 0;
      this.revChart.Aspect.Rotation = 360;
      this.revChart.Aspect.RotationFloat = 360D;
      this.revChart.Aspect.View3D = false;
      // 
      // 
      // 
      this.revChart.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.revChart.Axes.Bottom.Labels.Font.Size = 9;
      this.revChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.revChart.Axes.Bottom.MinorTicks.Length = 1;
      // 
      // 
      // 
      this.revChart.Axes.Bottom.Ticks.Length = 20;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Bottom.Title.Font.Size = 11;
      this.revChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
      this.revChart.Axes.Bottom.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.AxisPen.Visible = true;
      this.revChart.Axes.Left.AxisPen.Width = 3;
      // 
      // 
      // 
      this.revChart.Axes.Left.Grid.DrawEvery = 2;
      this.revChart.Axes.Left.Increment = 1D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Left.Labels.Font.Bold = true;
      // 
      // 
      // 
      this.revChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Red;
      this.revChart.Axes.Left.Labels.Font.Name = "Gill Sans MT";
      this.revChart.Axes.Left.Labels.Font.Size = 36;
      this.revChart.Axes.Left.Labels.Font.SizeFloat = 36F;
      this.revChart.Axes.Left.MinorTickCount = 9;
      // 
      // 
      // 
      this.revChart.Axes.Left.MinorTicks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.MinorTicks.Length = 1;
      this.revChart.Axes.Left.MinorTicks.Visible = true;
      this.revChart.Axes.Left.MinorTicks.Width = 4;
      // 
      // 
      // 
      this.revChart.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.Ticks.Length = 20;
      this.revChart.Axes.Left.Ticks.Visible = true;
      this.revChart.Axes.Left.Ticks.Width = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.revChart.Axes.Left.Title.Font.Size = 11;
      this.revChart.Axes.Left.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Right.Labels.Font.Size = 9;
      this.revChart.Axes.Right.Labels.Font.SizeFloat = 9F;
      this.revChart.Axes.Right.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Top.Labels.Font.Size = 9;
      this.revChart.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.revChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.revChart.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.revChart.Header.Font.Size = 12;
      this.revChart.Header.Font.SizeFloat = 12F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Legend.Font.Size = 9;
      this.revChart.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.revChart.Legend.Shadow.Visible = false;
      this.revChart.Location = new System.Drawing.Point(452, 118);
      this.revChart.Name = "revChart";
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.revChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.revChart.Panel.Brush.Gradient.Visible = false;
      this.revChart.Panel.MarginBottom = 3D;
      this.revChart.Panel.MarginLeft = 4D;
      this.revChart.Panel.MarginRight = 4D;
      this.revChart.Panel.MarginTop = 5D;
      this.revChart.Series.Add(this.circularGauge1);
      this.revChart.Series.Add(this.numericGauge1);
      this.revChart.Series.Add(this.numericGauge2);
      this.revChart.Size = new System.Drawing.Size(653, 645);
      this.revChart.TabIndex = 0;
      this.revChart.Tools.Add(this.numericGauge1.ValueMarker);
      this.revChart.Tools.Add(this.numericGauge1.UnitsMarker);
      this.revChart.Tools.Add(this.numericGauge1.TextMarker);
      this.revChart.Tools.Add(this.numericGauge2.ValueMarker);
      this.revChart.Tools.Add(this.numericGauge2.UnitsMarker);
      this.revChart.Tools.Add(this.numericGauge2.TextMarker);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.revChart.Walls.Back.Brush.Visible = false;
      this.revChart.Walls.Back.Visible = false;
      this.revChart.BeforeDrawSeries += new Steema.TeeChart.PaintChartEventHandler(this.revChart_BeforeDrawSeries);
      // 
      // circularGauge1
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.Center.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      this.circularGauge1.Center.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.circularGauge1.Center.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.circularGauge1.Center.Brush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.circularGauge1.Center.Brush.Gradient.Style.Visible = true;
      this.circularGauge1.Center.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.circularGauge1.Center.HorizSize = 45;
      // 
      // 
      // 
      this.circularGauge1.Center.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge1.Center.Pen.Width = 2;
      this.circularGauge1.Center.Position = 0;
      this.circularGauge1.Center.SizeDouble = 0D;
      this.circularGauge1.Center.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.Center.Spiralled = false;
      this.circularGauge1.Center.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style")));
      this.circularGauge1.Center.VertSize = 45;
      this.circularGauge1.Center.Visible = true;
      this.circularGauge1.Circled = true;
      this.circularGauge1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.circularGauge1.ColorEach = false;
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.FaceBrush.Gradient.Style.CenterXOffset = 96;
      this.circularGauge1.FaceBrush.Gradient.Style.CenterYOffset = -96;
      this.circularGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.circularGauge1.FaceBrush.Gradient.Style.Visible = true;
      this.circularGauge1.FaceBrush.Gradient.Visible = false;
      this.circularGauge1.FaceBrush.Visible = false;
      // 
      // 
      // 
      this.circularGauge1.Frame.Circled = true;
      this.circularGauge1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.circularGauge1.Frame.Visible = false;
      this.circularGauge1.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(12);
      this.circularGauge1.HandOffsets.Add(10);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      // 
      // 
      // 
      this.circularGauge1.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.circularGauge1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.circularGauge1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.circularGauge1.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.circularGauge1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
      // 
      // 
      // 
      this.circularGauge1.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.circularGauge1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.circularGauge1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
      this.circularGauge1.Marks.TailParams.Margin = 0F;
      this.circularGauge1.Marks.TailParams.PointerHeight = 5D;
      this.circularGauge1.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.circularGauge1.Maximum = 9D;
      this.circularGauge1.Minimum = 0D;
      this.circularGauge1.MinorTickDistance = 10;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.MinorTicks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      // 
      // 
      // 
      this.circularGauge1.MinorTicks.Brush.Gradient.Transparency = 100;
      this.circularGauge1.MinorTicks.HorizSize = 1;
      // 
      // 
      // 
      this.circularGauge1.MinorTicks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.MinorTicks.Pen.Width = 4;
      this.circularGauge1.MinorTicks.Position = 0;
      this.circularGauge1.MinorTicks.SizeDouble = 0D;
      this.circularGauge1.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.MinorTicks.Spiralled = false;
      this.circularGauge1.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style1")));
      this.circularGauge1.MinorTicks.VertSize = 1;
      this.circularGauge1.MinorTicks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Axis.Horizontal = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Axis.MinorTicks.Length = 1;
      this.circularGauge1.NumericGauge.Axis.OtherSide = false;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Axis.Ticks.Length = 20;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Axis.Title.Visible = false;
      this.circularGauge1.NumericGauge.Color = System.Drawing.Color.Empty;
      this.circularGauge1.NumericGauge.ColorEach = false;
      this.circularGauge1.NumericGauge.ColorLineEndValues.Add(100D);
      this.circularGauge1.NumericGauge.ColorLineEndValues.Add(70D);
      this.circularGauge1.NumericGauge.ColorLineStartValues.Add(80D);
      this.circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Frame.Circled = false;
      this.circularGauge1.NumericGauge.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.GreenLine.Brush.Gradient.UseMiddle = false;
      this.circularGauge1.NumericGauge.GreenLine.Position = 0;
      this.circularGauge1.NumericGauge.GreenLine.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.GreenLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.GreenLine.Spiralled = false;
      this.circularGauge1.NumericGauge.GreenLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style2")));
      this.circularGauge1.NumericGauge.GreenLine.Visible = true;
      this.circularGauge1.NumericGauge.GreenLineEndValue = 70D;
      this.circularGauge1.NumericGauge.GreenLineStartValue = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Hand.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.NumericGauge.Hand.Position = 0;
      this.circularGauge1.NumericGauge.Hand.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.Hand.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.Hand.Spiralled = false;
      this.circularGauge1.NumericGauge.Hand.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style3")));
      this.circularGauge1.NumericGauge.Hand.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
      this.circularGauge1.NumericGauge.Marks.TailParams.Margin = 0F;
      this.circularGauge1.NumericGauge.Marks.TailParams.PointerHeight = 8D;
      this.circularGauge1.NumericGauge.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge1.NumericGauge.Maximum = double.PositiveInfinity;
      this.circularGauge1.NumericGauge.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.MinorTicks.Brush.Color = System.Drawing.Color.Transparent;
      this.circularGauge1.NumericGauge.MinorTicks.Position = 0;
      this.circularGauge1.NumericGauge.MinorTicks.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.MinorTicks.Spiralled = false;
      this.circularGauge1.NumericGauge.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style4")));
      this.circularGauge1.NumericGauge.MinorTicks.Visible = true;
      this.circularGauge1.NumericGauge.OriginalCursor = null;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.RedLine.Position = 0;
      this.circularGauge1.NumericGauge.RedLine.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.RedLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.RedLine.Spiralled = false;
      this.circularGauge1.NumericGauge.RedLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style5")));
      this.circularGauge1.NumericGauge.RedLine.Visible = true;
      this.circularGauge1.NumericGauge.RedLineEndValue = 100D;
      this.circularGauge1.NumericGauge.RedLineStartValue = 80D;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge1.NumericGauge.TextMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.TextMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.TextMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.TextMarker.UsePalette = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.Ticks.Position = 0;
      this.circularGauge1.NumericGauge.Ticks.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.Ticks.Spiralled = false;
      this.circularGauge1.NumericGauge.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style6")));
      this.circularGauge1.NumericGauge.Ticks.Visible = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.UnitsMarker.UsePalette = true;
      this.circularGauge1.NumericGauge.UseExtendedNumRange = false;
      this.circularGauge1.NumericGauge.Value = 0D;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.ValueMarker.UsePalette = true;
      this.circularGauge1.OriginalCursor = null;
      this.circularGauge1.RotateLabels = false;
      this.circularGauge1.RotationAngle = 326;
      this.circularGauge1.ShowInLegend = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge1.Ticks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.circularGauge1.Ticks.Brush.Gradient.Transparency = 100;
      // 
      // 
      // 
      this.circularGauge1.Ticks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.Ticks.Pen.Width = 2;
      this.circularGauge1.Ticks.Position = 0;
      this.circularGauge1.Ticks.SizeDouble = 0D;
      this.circularGauge1.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.Ticks.Spiralled = false;
      this.circularGauge1.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style7")));
      this.circularGauge1.Ticks.VertSize = 20;
      this.circularGauge1.Ticks.Visible = true;
      this.circularGauge1.Title = "circularGauge1";
      this.circularGauge1.TotalAngle = 209D;
      this.circularGauge1.UniqueCustomRadius = true;
      this.circularGauge1.UseExtendedNumRange = false;
      this.circularGauge1.Value = 3.2171903439877512D;
      // 
      // 
      // 
      this.circularGauge1.XValues.DataMember = "Angle";
      this.circularGauge1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.circularGauge1.YValues.DataMember = "Y";
      // 
      // numericGauge1
      // 
      this.numericGauge1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
      this.numericGauge1.ColorEach = false;
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.CustomBounds = new System.Drawing.Rectangle(400, 330, 169, 107);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.FaceBrush.Gradient.Style.CenterXOffset = 34;
      this.numericGauge1.FaceBrush.Gradient.Style.CenterYOffset = -21;
      this.numericGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.numericGauge1.FaceBrush.Gradient.Style.Visible = true;
      // 
      // 
      // 
      this.numericGauge1.Frame.Circled = false;
      this.numericGauge1.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(125))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(160))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.GreenLine.Brush.Gradient.Sigma = true;
      this.numericGauge1.GreenLine.Brush.Gradient.SigmaFocus = 0F;
      this.numericGauge1.GreenLine.Brush.Gradient.UseMiddle = false;
      this.numericGauge1.GreenLine.Position = 0;
      this.numericGauge1.GreenLine.SizeDouble = 0D;
      this.numericGauge1.GreenLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.GreenLine.Spiralled = false;
      this.numericGauge1.GreenLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style8")));
      this.numericGauge1.GreenLine.VertSize = 5;
      this.numericGauge1.GreenLine.Visible = true;
      this.numericGauge1.GreenLineEndValue = 0D;
      this.numericGauge1.GreenLineStartValue = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.Hand.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.numericGauge1.Hand.Brush.Gradient.Transparency = 70;
      this.numericGauge1.Hand.Position = 0;
      this.numericGauge1.Hand.SizeDouble = 0D;
      this.numericGauge1.Hand.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.Hand.Spiralled = false;
      this.numericGauge1.Hand.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style9")));
      this.numericGauge1.Hand.Visible = true;
      // 
      // 
      // 
      this.numericGauge1.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.numericGauge1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.numericGauge1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.numericGauge1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.numericGauge1.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.numericGauge1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
      // 
      // 
      // 
      this.numericGauge1.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.numericGauge1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.numericGauge1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
      this.numericGauge1.Marks.TailParams.Margin = 0F;
      this.numericGauge1.Marks.TailParams.PointerHeight = 5D;
      this.numericGauge1.Marks.TailParams.PointerWidth = 8D;
      this.numericGauge1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.numericGauge1.Maximum = double.PositiveInfinity;
      this.numericGauge1.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.MinorTicks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.numericGauge1.MinorTicks.Brush.Gradient.Transparency = 100;
      this.numericGauge1.MinorTicks.HorizSize = 1;
      this.numericGauge1.MinorTicks.Position = 0;
      this.numericGauge1.MinorTicks.SizeDouble = 0D;
      this.numericGauge1.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.MinorTicks.Spiralled = false;
      this.numericGauge1.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style10")));
      this.numericGauge1.MinorTicks.VertSize = 1;
      this.numericGauge1.MinorTicks.Visible = true;
      this.numericGauge1.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.RedLine.Brush.Gradient.Sigma = true;
      this.numericGauge1.RedLine.Brush.Gradient.SigmaFocus = 0F;
      this.numericGauge1.RedLine.Position = 0;
      this.numericGauge1.RedLine.SizeDouble = 0D;
      this.numericGauge1.RedLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.RedLine.Spiralled = false;
      this.numericGauge1.RedLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style11")));
      this.numericGauge1.RedLine.VertSize = 5;
      this.numericGauge1.RedLine.Visible = true;
      this.numericGauge1.RedLineEndValue = 0D;
      this.numericGauge1.RedLineStartValue = 0D;
      this.numericGauge1.ShowInLegend = false;
      // 
      // 
      // 
      this.numericGauge1.TextMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge1.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge1.TextMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge1.TextMarker.Callout.Distance = 0;
      this.numericGauge1.TextMarker.Callout.SizeDouble = 0D;
      this.numericGauge1.TextMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.TextMarker.Callout.XPosition = 0;
      this.numericGauge1.TextMarker.Callout.YPosition = 0;
      this.numericGauge1.TextMarker.Callout.ZPosition = 0;
      this.numericGauge1.TextMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge1.TextMarker.Shape.Shadow.Visible = false;
      this.numericGauge1.TextMarker.UsePalette = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.Ticks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.numericGauge1.Ticks.Brush.Gradient.Transparency = 100;
      this.numericGauge1.Ticks.Position = 0;
      this.numericGauge1.Ticks.SizeDouble = 0D;
      this.numericGauge1.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.Ticks.Spiralled = false;
      this.numericGauge1.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style12")));
      this.numericGauge1.Ticks.VertSize = 20;
      this.numericGauge1.Ticks.Visible = true;
      this.numericGauge1.Title = "numericGauge1";
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge1.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge1.UnitsMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge1.UnitsMarker.Callout.Distance = 0;
      this.numericGauge1.UnitsMarker.Callout.SizeDouble = 0D;
      this.numericGauge1.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.UnitsMarker.Callout.XPosition = 0;
      this.numericGauge1.UnitsMarker.Callout.YPosition = 0;
      this.numericGauge1.UnitsMarker.Callout.ZPosition = 0;
      this.numericGauge1.UnitsMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge1.UnitsMarker.Shape.Shadow.Visible = false;
      this.numericGauge1.UnitsMarker.UsePalette = true;
      this.numericGauge1.UseExtendedNumRange = false;
      this.numericGauge1.Value = 716.27062080254348D;
      this.numericGauge1.ValueFormat = "N";
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge1.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge1.ValueMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge1.ValueMarker.Callout.Distance = 0;
      this.numericGauge1.ValueMarker.Callout.SizeDouble = 0D;
      this.numericGauge1.ValueMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.ValueMarker.Callout.XPosition = 0;
      this.numericGauge1.ValueMarker.Callout.YPosition = 0;
      this.numericGauge1.ValueMarker.Callout.ZPosition = 0;
      this.numericGauge1.ValueMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.numericGauge1.ValueMarker.Shape.Lines = new string[] {
        "716,27"};
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge1.ValueMarker.Shape.Shadow.Visible = false;
      this.numericGauge1.ValueMarker.Text = "716,27";
      this.numericGauge1.ValueMarker.UsePalette = true;
      // 
      // 
      // 
      this.numericGauge1.XValues.DataMember = "X";
      this.numericGauge1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.numericGauge1.YValues.DataMember = "Y";
      // 
      // numericGauge2
      // 
      this.numericGauge2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
      this.numericGauge2.ColorEach = false;
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.CustomBounds = new System.Drawing.Rectangle(250, 495, 250, 150);
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.FaceBrush.Gradient.Style.CenterXOffset = 50;
      this.numericGauge2.FaceBrush.Gradient.Style.CenterYOffset = -30;
      this.numericGauge2.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.numericGauge2.FaceBrush.Gradient.Style.Visible = true;
      // 
      // 
      // 
      this.numericGauge2.Frame.Circled = false;
      this.numericGauge2.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(125))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(160))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.GreenLine.Brush.Gradient.Sigma = true;
      this.numericGauge2.GreenLine.Brush.Gradient.SigmaFocus = 0F;
      this.numericGauge2.GreenLine.Brush.Gradient.UseMiddle = false;
      this.numericGauge2.GreenLine.Position = 0;
      this.numericGauge2.GreenLine.SizeDouble = 0D;
      this.numericGauge2.GreenLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.GreenLine.Spiralled = false;
      this.numericGauge2.GreenLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style13")));
      this.numericGauge2.GreenLine.VertSize = 5;
      this.numericGauge2.GreenLine.Visible = true;
      this.numericGauge2.GreenLineEndValue = 0D;
      this.numericGauge2.GreenLineStartValue = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.Hand.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.numericGauge2.Hand.Brush.Gradient.Transparency = 70;
      this.numericGauge2.Hand.Position = 0;
      this.numericGauge2.Hand.SizeDouble = 0D;
      this.numericGauge2.Hand.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.Hand.Spiralled = false;
      this.numericGauge2.Hand.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style14")));
      this.numericGauge2.Hand.Visible = true;
      // 
      // 
      // 
      this.numericGauge2.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.numericGauge2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.numericGauge2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.numericGauge2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.numericGauge2.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.numericGauge2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
      // 
      // 
      // 
      this.numericGauge2.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.numericGauge2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.numericGauge2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
      this.numericGauge2.Marks.TailParams.Margin = 0F;
      this.numericGauge2.Marks.TailParams.PointerHeight = 5D;
      this.numericGauge2.Marks.TailParams.PointerWidth = 8D;
      this.numericGauge2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.numericGauge2.Maximum = double.PositiveInfinity;
      this.numericGauge2.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.MinorTicks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.numericGauge2.MinorTicks.Brush.Gradient.Transparency = 100;
      this.numericGauge2.MinorTicks.HorizSize = 1;
      this.numericGauge2.MinorTicks.Position = 0;
      this.numericGauge2.MinorTicks.SizeDouble = 0D;
      this.numericGauge2.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.MinorTicks.Spiralled = false;
      this.numericGauge2.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style15")));
      this.numericGauge2.MinorTicks.VertSize = 1;
      this.numericGauge2.MinorTicks.Visible = true;
      this.numericGauge2.OriginalCursor = null;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.RedLine.Brush.Gradient.Sigma = true;
      this.numericGauge2.RedLine.Brush.Gradient.SigmaFocus = 0F;
      this.numericGauge2.RedLine.Position = 0;
      this.numericGauge2.RedLine.SizeDouble = 0D;
      this.numericGauge2.RedLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.RedLine.Spiralled = false;
      this.numericGauge2.RedLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style16")));
      this.numericGauge2.RedLine.VertSize = 5;
      this.numericGauge2.RedLine.Visible = true;
      this.numericGauge2.RedLineEndValue = 0D;
      this.numericGauge2.RedLineStartValue = 0D;
      this.numericGauge2.ShowInLegend = false;
      // 
      // 
      // 
      this.numericGauge2.TextMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge2.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge2.TextMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge2.TextMarker.Callout.Distance = 0;
      this.numericGauge2.TextMarker.Callout.SizeDouble = 0D;
      this.numericGauge2.TextMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.TextMarker.Callout.XPosition = 0;
      this.numericGauge2.TextMarker.Callout.YPosition = 0;
      this.numericGauge2.TextMarker.Callout.ZPosition = 0;
      this.numericGauge2.TextMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge2.TextMarker.Shape.Shadow.Visible = false;
      this.numericGauge2.TextMarker.UsePalette = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.Ticks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.numericGauge2.Ticks.Brush.Gradient.Transparency = 100;
      this.numericGauge2.Ticks.Position = 0;
      this.numericGauge2.Ticks.SizeDouble = 0D;
      this.numericGauge2.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.Ticks.Spiralled = false;
      this.numericGauge2.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style17")));
      this.numericGauge2.Ticks.VertSize = 20;
      this.numericGauge2.Ticks.Visible = true;
      this.numericGauge2.Title = "numericGauge2";
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge2.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge2.UnitsMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge2.UnitsMarker.Callout.Distance = 0;
      this.numericGauge2.UnitsMarker.Callout.SizeDouble = 0D;
      this.numericGauge2.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.UnitsMarker.Callout.XPosition = 0;
      this.numericGauge2.UnitsMarker.Callout.YPosition = 0;
      this.numericGauge2.UnitsMarker.Callout.ZPosition = 0;
      this.numericGauge2.UnitsMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge2.UnitsMarker.Shape.Shadow.Visible = false;
      this.numericGauge2.UnitsMarker.UsePalette = true;
      this.numericGauge2.UseExtendedNumRange = false;
      this.numericGauge2.Value = 75.075647828670057D;
      this.numericGauge2.ValueFormat = "N";
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.AutoSize = true;
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.numericGauge2.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.numericGauge2.ValueMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.numericGauge2.ValueMarker.Callout.Distance = 0;
      this.numericGauge2.ValueMarker.Callout.SizeDouble = 0D;
      this.numericGauge2.ValueMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.ValueMarker.Callout.XPosition = 0;
      this.numericGauge2.ValueMarker.Callout.YPosition = 0;
      this.numericGauge2.ValueMarker.Callout.ZPosition = 0;
      this.numericGauge2.ValueMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.numericGauge2.ValueMarker.Shape.Lines = new string[] {
        "75,08"};
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.numericGauge2.ValueMarker.Shape.Shadow.Visible = false;
      this.numericGauge2.ValueMarker.Text = "75,08";
      this.numericGauge2.ValueMarker.UsePalette = true;
      // 
      // 
      // 
      this.numericGauge2.XValues.DataMember = "X";
      this.numericGauge2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.numericGauge2.YValues.DataMember = "Y";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // panel1
      // 
      this.panel1.BackgroundImage = global::SubaruBRZSimul.Properties.Resources.subaru_template1;
      this.panel1.Controls.Add(this.revChart);
      this.panel1.Controls.Add(this.speedChart);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1501, 958);
      this.panel1.TabIndex = 1;
      // 
      // speedChart
      // 
      // 
      // 
      // 
      this.speedChart.Aspect.ColorPaletteIndex = 20;
      this.speedChart.Aspect.Elevation = 315;
      this.speedChart.Aspect.ElevationFloat = 315D;
      this.speedChart.Aspect.Orthogonal = false;
      this.speedChart.Aspect.Perspective = 0;
      this.speedChart.Aspect.Rotation = 360;
      this.speedChart.Aspect.RotationFloat = 360D;
      this.speedChart.Aspect.View3D = false;
      // 
      // 
      // 
      this.speedChart.Axes.Automatic = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Bottom.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.speedChart.Axes.Bottom.Labels.Font.Size = 9;
      this.speedChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Bottom.Title.Font.Size = 11;
      this.speedChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.speedChart.Axes.Left.AxisPen.Visible = true;
      this.speedChart.Axes.Left.AxisPen.Width = 5;
      // 
      // 
      // 
      this.speedChart.Axes.Left.Grid.DrawEvery = 2;
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Left.Labels.Font.Bold = true;
      // 
      // 
      // 
      this.speedChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.speedChart.Axes.Left.Labels.Font.Name = "Arial";
      this.speedChart.Axes.Left.Labels.Font.Size = 12;
      this.speedChart.Axes.Left.Labels.Font.SizeFloat = 12F;
      this.speedChart.Axes.Left.Labels.Visible = false;
      // 
      // 
      // 
      this.speedChart.Axes.Left.MinorTicks.Length = 1;
      // 
      // 
      // 
      this.speedChart.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.speedChart.Axes.Left.Ticks.Length = 12;
      this.speedChart.Axes.Left.Ticks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.speedChart.Axes.Left.Title.Font.Size = 11;
      this.speedChart.Axes.Left.Title.Font.SizeFloat = 11F;
      this.speedChart.Axes.Left.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Right.Labels.Font.Size = 9;
      this.speedChart.Axes.Right.Labels.Font.SizeFloat = 9F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Top.Labels.Font.Size = 9;
      this.speedChart.Axes.Top.Labels.Font.SizeFloat = 9F;
      this.speedChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.speedChart.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Header.Font.Brush.Color = System.Drawing.Color.Gray;
      this.speedChart.Header.Font.Size = 12;
      this.speedChart.Header.Font.SizeFloat = 12F;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Legend.Font.Size = 9;
      this.speedChart.Legend.Font.SizeFloat = 9F;
      // 
      // 
      // 
      this.speedChart.Legend.Shadow.Visible = false;
      this.speedChart.Location = new System.Drawing.Point(-46, 249);
      this.speedChart.Name = "speedChart";
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      // 
      // 
      // 
      this.speedChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.speedChart.Panel.Brush.Gradient.Visible = false;
      this.speedChart.Series.Add(this.circularGauge2);
      this.speedChart.Size = new System.Drawing.Size(632, 571);
      this.speedChart.TabIndex = 1;
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.speedChart.Walls.Back.Brush.Visible = false;
      this.speedChart.Walls.Back.Visible = false;
      // 
      // circularGauge2
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.Center.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      this.circularGauge2.Center.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.circularGauge2.Center.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      // 
      // 
      // 
      this.circularGauge2.Center.Brush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.circularGauge2.Center.Brush.Gradient.Style.Visible = true;
      this.circularGauge2.Center.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.circularGauge2.Center.HorizSize = 45;
      // 
      // 
      // 
      this.circularGauge2.Center.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge2.Center.Pen.Width = 2;
      this.circularGauge2.Center.Position = 0;
      this.circularGauge2.Center.SizeDouble = 0D;
      this.circularGauge2.Center.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.Center.Spiralled = false;
      this.circularGauge2.Center.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style18")));
      this.circularGauge2.Center.VertSize = 45;
      this.circularGauge2.Center.Visible = true;
      this.circularGauge2.Circled = true;
      this.circularGauge2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.circularGauge2.ColorEach = false;
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      // 
      // 
      // 
      this.circularGauge2.FaceBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.FaceBrush.Gradient.Style.CenterXOffset = 86;
      this.circularGauge2.FaceBrush.Gradient.Style.CenterYOffset = -86;
      this.circularGauge2.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.Drawing.PathGradientMode.Radial;
      this.circularGauge2.FaceBrush.Gradient.Style.Visible = true;
      this.circularGauge2.FaceBrush.Gradient.Visible = false;
      this.circularGauge2.FaceBrush.Visible = false;
      // 
      // 
      // 
      this.circularGauge2.Frame.Circled = true;
      this.circularGauge2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.circularGauge2.Frame.Visible = false;
      this.circularGauge2.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      // 
      // 
      // 
      this.circularGauge2.Legend.Visible = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      // 
      // 
      // 
      this.circularGauge2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.circularGauge2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.circularGauge2.Marks.Brush.Gradient.UseMiddle = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      // 
      // 
      // 
      this.circularGauge2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
      // 
      // 
      // 
      this.circularGauge2.Marks.Shadow.Visible = false;
      // 
      // 
      // 
      this.circularGauge2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
      this.circularGauge2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos4")));
      this.circularGauge2.Marks.TailParams.Margin = 0F;
      this.circularGauge2.Marks.TailParams.PointerHeight = 5D;
      this.circularGauge2.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.circularGauge2.Maximum = 160D;
      this.circularGauge2.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.MinorTicks.Brush.Color = System.Drawing.Color.Transparent;
      this.circularGauge2.MinorTicks.HorizSize = 1;
      this.circularGauge2.MinorTicks.Position = 0;
      this.circularGauge2.MinorTicks.SizeDouble = 0D;
      this.circularGauge2.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.MinorTicks.Spiralled = false;
      this.circularGauge2.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style19")));
      this.circularGauge2.MinorTicks.VertSize = 1;
      this.circularGauge2.MinorTicks.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Axis.Horizontal = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Axis.MinorTicks.Length = 1;
      this.circularGauge2.NumericGauge.Axis.OtherSide = false;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Axis.Ticks.Length = 20;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Axis.Title.Visible = false;
      this.circularGauge2.NumericGauge.Color = System.Drawing.Color.Empty;
      this.circularGauge2.NumericGauge.ColorEach = false;
      this.circularGauge2.NumericGauge.ColorLineEndValues.Add(100D);
      this.circularGauge2.NumericGauge.ColorLineEndValues.Add(70D);
      this.circularGauge2.NumericGauge.ColorLineStartValues.Add(80D);
      this.circularGauge2.NumericGauge.ColorLineStartValues.Add(0D);
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Frame.Circled = false;
      this.circularGauge2.NumericGauge.GaugeColorPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.GreenLine.Brush.Gradient.UseMiddle = false;
      this.circularGauge2.NumericGauge.GreenLine.Position = 0;
      this.circularGauge2.NumericGauge.GreenLine.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.GreenLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.GreenLine.Spiralled = false;
      this.circularGauge2.NumericGauge.GreenLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style20")));
      this.circularGauge2.NumericGauge.GreenLine.Visible = true;
      this.circularGauge2.NumericGauge.GreenLineEndValue = 70D;
      this.circularGauge2.NumericGauge.GreenLineStartValue = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Hand.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge2.NumericGauge.Hand.Position = 0;
      this.circularGauge2.NumericGauge.Hand.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.Hand.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.Hand.Spiralled = false;
      this.circularGauge2.NumericGauge.Hand.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style21")));
      this.circularGauge2.NumericGauge.Hand.Visible = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos5")));
      this.circularGauge2.NumericGauge.Marks.TailParams.Margin = 0F;
      this.circularGauge2.NumericGauge.Marks.TailParams.PointerHeight = 8D;
      this.circularGauge2.NumericGauge.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge2.NumericGauge.Maximum = double.PositiveInfinity;
      this.circularGauge2.NumericGauge.Minimum = 0D;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.MinorTicks.Brush.Color = System.Drawing.Color.Transparent;
      this.circularGauge2.NumericGauge.MinorTicks.Position = 0;
      this.circularGauge2.NumericGauge.MinorTicks.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.MinorTicks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.MinorTicks.Spiralled = false;
      this.circularGauge2.NumericGauge.MinorTicks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style22")));
      this.circularGauge2.NumericGauge.MinorTicks.Visible = true;
      this.circularGauge2.NumericGauge.OriginalCursor = null;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.RedLine.Position = 0;
      this.circularGauge2.NumericGauge.RedLine.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.RedLine.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.RedLine.Spiralled = false;
      this.circularGauge2.NumericGauge.RedLine.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style23")));
      this.circularGauge2.NumericGauge.RedLine.Visible = true;
      this.circularGauge2.NumericGauge.RedLineEndValue = 100D;
      this.circularGauge2.NumericGauge.RedLineStartValue = 80D;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge2.NumericGauge.TextMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.TextMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.TextMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.TextMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.TextMarker.UsePalette = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.Ticks.Position = 0;
      this.circularGauge2.NumericGauge.Ticks.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.Ticks.Spiralled = false;
      this.circularGauge2.NumericGauge.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style24")));
      this.circularGauge2.NumericGauge.Ticks.Visible = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.UnitsMarker.UsePalette = true;
      this.circularGauge2.NumericGauge.UseExtendedNumRange = false;
      this.circularGauge2.NumericGauge.Value = 0D;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.AutoSize = true;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHeadSize = 8;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Callout.Brush.Color = System.Drawing.Color.Black;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Centered = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Pen.Visible = false;
      // 
      // 
      // 
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.ValueMarker.UsePalette = true;
      this.circularGauge2.OriginalCursor = null;
      this.circularGauge2.RotationAngle = 259;
      this.circularGauge2.ShowInLegend = false;
      // 
      // 
      // 
      // 
      // 
      // 
      this.circularGauge2.Ticks.Brush.Color = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.circularGauge2.Ticks.Brush.Gradient.Transparency = 100;
      this.circularGauge2.Ticks.Position = 0;
      this.circularGauge2.Ticks.SizeDouble = 0D;
      this.circularGauge2.Ticks.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.Ticks.Spiralled = false;
      this.circularGauge2.Ticks.Style = ((Steema.TeeChart.Styles.GaugePointerStyles)(resources.GetObject("resource.Style25")));
      this.circularGauge2.Ticks.VertSize = 12;
      this.circularGauge2.Ticks.Visible = true;
      this.circularGauge2.Title = "circularGauge1";
      this.circularGauge2.TotalAngle = 242D;
      this.circularGauge2.UniqueCustomRadius = true;
      this.circularGauge2.UseExtendedNumRange = false;
      this.circularGauge2.Value = 100.65046635486674D;
      // 
      // 
      // 
      this.circularGauge2.XValues.DataMember = "Angle";
      this.circularGauge2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
      // 
      // 
      // 
      this.circularGauge2.YValues.DataMember = "Y";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(1425, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(73, 21);
      this.button1.TabIndex = 2;
      this.button1.Text = "re-run car";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // CarDash
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1501, 958);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chartController1);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.Name = "CarDash";
      this.Text = "TeeChart for NET - Subaru BRZ acceleration simulation";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Steema.TeeChart.ChartController chartController1;
    private System.Windows.Forms.Panel panel1;
    private Steema.TeeChart.TChart revChart;
    private Steema.TeeChart.Styles.CircularGauge circularGauge1;
    private Steema.TeeChart.Styles.NumericGauge numericGauge1;
    private Steema.TeeChart.Styles.NumericGauge numericGauge2;
    private System.Windows.Forms.Timer timer1;
    private Steema.TeeChart.TChart speedChart;
    private Steema.TeeChart.Styles.CircularGauge circularGauge2;
    private System.Windows.Forms.Button button1;
  }
}

