using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormExportCanvasToImage : Form
	{
		public CanvasControl Canvas { get; set; }

		public bool IsBlackAndWhite { get; set; }

		public Color BackgroundColor { get; set; }

		public Size OldSizeImage
		{
			get
			{
				return this.size_0;
			}
			set
			{
				this.size_0 = new Size(Math.Abs(value.Width), Math.Abs(value.Height));
				this.labelOldSizeImage.Text = value.Width.ToString() + " x " + value.Height.ToString() + " пкс";
				this.numUpDownPercent.Maximum = (decimal)Math.Sqrt(5368709120000.0 / (double)(this.size_0.Width * this.size_0.Height));
			}
		}

		public RectangleF RectangleIamge { get; set; }

		public Size NewSizeImage
		{
			get
			{
				return this.size_1;
			}
			set
			{
				this.size_1 = value;
				this.labelNewSizeImage.Text = value.Width.ToString() + " x " + value.Height.ToString() + " пкс";
			}
		}

		public string FileName { get; set; }

		public FormExportCanvasToImage()
		{
			
			
			this.InitializeComponent();
		}

		private void FormExportCanvasToImage_Load(object sender, EventArgs e)
		{
			this.textBoxFileName.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\default.jpeg";
			this.numUpDownNewHeight.Enabled = false;
			this.numUpDownNewWidth.Enabled = false;
			this.numUpDownPercent.Enabled = false;
			this.method_0();
			this.method_1();
		}

		private void method_0()
		{
			if (this.radioButtonCurrentSizeImage.Checked)
			{
				this.NewSizeImage = new Size(this.OldSizeImage.Width, this.OldSizeImage.Height);
			}
			if (this.radioButtonChangeSizeImage.Checked)
			{
				this.NewSizeImage = new Size((int)this.numUpDownNewWidth.Value, (int)this.numUpDownNewHeight.Value);
			}
			if (this.radioButtonPercentImageSize.Checked)
			{
				this.NewSizeImage = new Size((int)(this.OldSizeImage.Width * (this.numUpDownPercent.Value / 100m)), (int)(this.OldSizeImage.Height * (this.numUpDownPercent.Value / 100m)));
			}
		}

		protected void SetIndexedPixel(int x, int y, BitmapData bmd, bool pixel)
		{
			int ofs = y * bmd.Stride + (x >> 3);
			byte b = Marshal.ReadByte(bmd.Scan0, ofs);
			byte b2 = (byte)(128 >> (x & 7));
			if (pixel)
			{
				b |= b2;
			}
			else
			{
				b &= (b2 ^ byte.MaxValue);
			}
			Marshal.WriteByte(bmd.Scan0, ofs, b);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				Bitmap bitmap = this.method_1();
				if (bitmap != null)
				{
					string a = Path.GetExtension(this.textBoxFileName.Text).ToLower();
					if (!(a == ".bmp"))
					{
						if (!(a == ".gif"))
						{
							if (!(a == ".jpeg"))
							{
								if (!(a == ".png"))
								{
									if (!(a == ".tiff"))
									{
										if (!(a == ".wmf"))
										{
											bitmap.Save(this.textBoxFileName.Text);
										}
										else
										{
											bitmap.Save(this.textBoxFileName.Text, ImageFormat.Wmf);
										}
									}
									else
									{
										bitmap.Save(this.textBoxFileName.Text, ImageFormat.Tiff);
									}
								}
								else
								{
									bitmap.Save(this.textBoxFileName.Text, ImageFormat.Png);
								}
							}
							else
							{
								bitmap.Save(this.textBoxFileName.Text, ImageFormat.Jpeg);
							}
						}
						else
						{
							bitmap.Save(this.textBoxFileName.Text, ImageFormat.Gif);
						}
					}
					else
					{
						bitmap.Save(this.textBoxFileName.Text, ImageFormat.Bmp);
					}
					MessageBox.Show("Файл успешно сохранен");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void radioButtonCurrentSizeImage_CheckedChanged(object sender, EventArgs e)
		{
			this.numUpDownNewHeight.Enabled = false;
			this.numUpDownNewWidth.Enabled = false;
			this.numUpDownPercent.Enabled = false;
			this.method_0();
			this.method_1();
		}

		private void radioButtonChangeSizeImage_CheckedChanged(object sender, EventArgs e)
		{
			this.numUpDownNewHeight.Enabled = true;
			this.numUpDownNewWidth.Enabled = true;
			this.numUpDownPercent.Enabled = false;
			this.method_0();
			this.method_1();
		}

		private void radioButtonPercentImageSize_CheckedChanged(object sender, EventArgs e)
		{
			this.numUpDownNewHeight.Enabled = false;
			this.numUpDownNewWidth.Enabled = false;
			this.numUpDownPercent.Enabled = true;
			this.method_0();
			this.method_1();
		}

		private void numUpDownNewWidth_ValueChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.numUpDownNewHeight.Maximum = 536870912m / this.numUpDownNewWidth.Value - 1m;
			this.method_1();
		}

		private void numUpDownNewHeight_ValueChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.numUpDownNewWidth.Maximum = 536870912m / this.numUpDownNewHeight.Value - 1m;
			this.method_1();
		}

		private void numUpDownPercent_ValueChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.method_1();
		}

		private void panelBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = this.panelBackgroundColor.BackColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.panelBackgroundColor.BackColor = colorDialog.Color;
				this.method_1();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private Bitmap method_1()
		{
			try
			{
				CanvasControl canvasControl = new CanvasControl();
				canvasControl.Size = new Size(this.NewSizeImage.Width, this.NewSizeImage.Height);
				canvasControl.method_28(this.RectangleIamge, true);
				canvasControl.DoInvalidate(true);
				Bitmap bitmap = new Bitmap(this.NewSizeImage.Width, this.NewSizeImage.Height);
				canvasControl.Graphics = Graphics.FromImage(bitmap);
				canvasControl.Graphics.Clear(Color.White);
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvasControl, this.RectangleIamge);
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, (int)rectangleF.X, canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, canvasControl.Size.Width, (int)rectangleF.Y));
				canvasControl.Graphics.ExcludeClip(new Rectangle((int)(rectangleF.X + rectangleF.Width), 0, canvasControl.Size.Width - (int)(rectangleF.X + rectangleF.Width), canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, (int)(rectangleF.Y + rectangleF.Height), canvasControl.Size.Width, canvasControl.Size.Height - (int)(rectangleF.Y + rectangleF.Height)));
				if (this.radioButtonManyColor.Checked)
				{
					canvasControl.Settings.BackgroundColor = this.panelBackgroundColor.BackColor;
				}
				else
				{
					canvasControl.Settings.BackgroundColor = Color.White;
				}
				canvasControl.BackgroundLayer.Draw(canvasControl, this.RectangleIamge);
				foreach (ICanvasLayer canvasLayer in this.Canvas.Layers)
				{
					foreach (DrawObjectBase drawObjectBase in ((DrawingLayer)canvasLayer).Objects)
					{
						if (this.radioButtonManyColor.Checked)
						{
							drawObjectBase.Draw(canvasControl, this.RectangleIamge, eDrawMode.Print | eDrawMode.Color);
						}
						else
						{
							drawObjectBase.Draw(canvasControl, this.RectangleIamge, eDrawMode.Print);
						}
					}
				}
				this.pictureBox1.Image = bitmap;
				return bitmap;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			return null;
		}

		private void radioButtonTwoColor_CheckedChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void buttonFileName_Click(object sender, EventArgs e)
		{
			this.saveFileDialog_0.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf";
			this.saveFileDialog_0.InitialDirectory = Path.GetDirectoryName(this.textBoxFileName.Text);
			this.saveFileDialog_0.FileName = Path.GetFileName(this.textBoxFileName.Text);
			if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.textBoxFileName.Text = this.saveFileDialog_0.FileName;
			}
		}

		[CompilerGenerated]
		private CanvasControl canvasControl_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private Color color_0;

		private Size size_0;

		[CompilerGenerated]
		private RectangleF rectangleF_0;

		private Size size_1;

		[CompilerGenerated]
		private string string_0;
	}
}
