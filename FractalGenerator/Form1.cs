using Alea;
using Alea.Parallel;
using FractalGenerator.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalGenerator
{
    public partial class Form1 : Form
    {
        private FractalSettings settings = new FractalSettings();
        private Timer animationTimer;
        private bool isAnimating = false;
        private double time = 0;
        private double zoomDirection = 1;

        private FractalType currentFractalType = FractalType.Mandelbrot;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fractalTypeComboBox.SelectedIndex = 0;
        }

        #region Events
        private async void StartBtn_Click(object sender, EventArgs e)
        {
            await GenerateFractalAsync();
        }

        private async void TextBox_TextChanged(object sender, EventArgs e)
        {
            await GenerateFractalAsync();
        }

        private async void Form_FormChanged(object sender, EventArgs e)
        {
            await GenerateFractalAsync();
        }

        private void startAnimationButton_Click(object sender, EventArgs e)
        {
            StartAnimation();
        }

        private void stopAnimationButton_Click(object sender, EventArgs e)
        {
            StopAnimation();
        }

        #endregion

        private async Task GenerateFractalAsync()
        {
            if (pictureBox.Width == 0 || pictureBox.Height == 0 || this.IsDisposed)
                return;

            if (!isAnimating)
            {
                UpdateSettingsFromControls();
            }

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            bool useGpu = gpuRadioButton.Checked;

            await Task.Run(() => DrawFractal(bitmap, useGpu));

            pictureBox.Image = bitmap;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private double ParseOrDefault(string text, double defaultValue)
        {
            if (double.TryParse(text, out var value))
                return value;
            else
                return defaultValue;
        }

        private int ParseOrDefault(string text, int defaultValue)
        {
            if (int.TryParse(text, out var value))
                return value;
            else
                return defaultValue;
        }

        

        private void fractalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFractalType = fractalTypeComboBox.SelectedItem.ToString();

            if (Enum.TryParse(selectedFractalType, out FractalType result))
            {
                currentFractalType = result;
                SetDefaultParameters();
                GenerateFractalAsync();
            }
            else
            {
                MessageBox.Show("Invalid fractal type selected.");
            }
        }

        private void UpdateSettingsFromControls()
        {
            settings.Zoom = ParseOrDefault(zoomBox.Text, 1.5);
            settings.MoveX = ParseOrDefault(moveXBox.Text, -0.5);
            settings.MoveY = ParseOrDefault(moveYBox.Text, 0);
            settings.MaxIterations = ParseOrDefault(iterationsBox.Text, 500);

            switch (currentFractalType)
            {
                case FractalType.Mandelbrot:
                    settings.CRe = 0;
                    settings.CIm = 0;
                    SetAvailableValues(true, true, true, true, false, false, false, true, false); // Блокируем все элементы
                    break;

                case FractalType.Julia:
                    settings.CRe = ParseOrDefault(cReBox.Text, -0.8);
                    settings.CIm = ParseOrDefault(cImBox.Text, 0.156);
                    SetAvailableValues(true, true, true, true, true, true, false, true, true);
                    break;

                case FractalType.SierpinskiTriangle:
                    settings.Zoom = 1.0;
                    settings.MoveX = 0.0;
                    settings.MoveY = 0.0;
                    settings.MaxIterations = 7;

                    SetAvailableValues(false, false, false, false, false, false, false, true, false);
                    break;

                case FractalType.DragonCurve:
                    settings.Zoom = 1.0;
                    settings.MoveX = 0.0;
                    settings.MoveY = 0.0;
                    settings.Angle = ParseOrDefault(angleBox.Text, 90);

                    SetAvailableValues(false, false, false, true, false, false, true, false, false); 
                    break;

                case FractalType.FractalTree:
                    settings.Zoom = 0;
                    settings.MoveX = 0;
                    settings.MoveY = 0;
                    settings.Angle = ParseOrDefault(angleBox.Text, 90);
                    settings.MaxIterations = ParseOrDefault(iterationsBox.Text, 10);

                    SetAvailableValues(false, false, false, true, false, false, false, false, false); 
                    break;

                default:
                    break;
            }
        }

        private void SetAvailableValues(bool isZoom = true, bool isMoveX = true, bool isMoveY = true, bool isIterations = true, 
                                        bool isCRe = true, bool isCIm = true, bool isAngle = true, bool isRadioButtonGPU = true, bool isAnimation = true)
        {
            zoomBox.Enabled = isZoom;
            moveXBox.Enabled = isMoveX;
            moveYBox.Enabled = isMoveY;
            iterationsBox.Enabled = isIterations;
            cReBox.Enabled = isCRe;
            cImBox.Enabled = isCIm;
            angleBox.Enabled = isAngle;
            animationBox.Enabled = isAnimation;

            gpuRadioButton.Enabled = isRadioButtonGPU;
            if (!isRadioButtonGPU)
            {
                cpuRadioButton.Checked = true;
            }

        }

        private void SetDefaultParameters()
        {
            switch (currentFractalType)
            {
                case FractalType.Mandelbrot:
                    iterationsBox.Text = "500";
                    zoomBox.Text = "1";
                    moveXBox.Text = "-0.5";
                    moveYBox.Text = "0";
                    cReBox.Text = "0";
                    cImBox.Text = "0";
                    angleBox.Text = "0";
                    break;

                case FractalType.Julia:
                    iterationsBox.Text = "500";
                    zoomBox.Text = "1.5";
                    moveXBox.Text = "-0.5";
                    moveYBox.Text = "0";
                    cReBox.Text = "-0.8";
                    cImBox.Text = "0.156";
                    angleBox.Text = "0";
                    break;

                case FractalType.SierpinskiTriangle:
                    iterationsBox.Text = "0";
                    zoomBox.Text = "0";
                    moveXBox.Text = "10";
                    moveYBox.Text = "0";
                    cReBox.Text = "0";
                    cImBox.Text = "0";
                    angleBox.Text = "0";
                    break;

                case FractalType.DragonCurve:
                    iterationsBox.Text = "15";
                    zoomBox.Text = "0";
                    moveXBox.Text = "10";
                    moveYBox.Text = "0";
                    cReBox.Text = "0";
                    cImBox.Text = "0";
                    angleBox.Text = "90";
                    break;

                case FractalType.FractalTree:
                    iterationsBox.Text = "10";
                    zoomBox.Text = "0";       
                    moveXBox.Text = "0";      
                    moveYBox.Text = "0";      
                    cReBox.Text = "0";        
                    cImBox.Text = "0";        
                    angleBox.Text = "90";
                    break;

                default:
                    break;
            }
        }

        private void DrawFractal(Bitmap bitmap, bool useGpu)
        {
            Environment.SetEnvironmentVariable("TMP", @"G:\Temp");
            Environment.SetEnvironmentVariable("TEMP", @"G:\Temp");

            int width = bitmap.Width;
            int height = bitmap.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(stride) * height;
            byte[] rgbValues = new byte[bytes];

            var s = new FractalSettings(settings.Zoom, settings.MoveX, settings.MoveY, settings.MaxIterations, settings.CRe, settings.CIm, settings.Angle);

            switch (currentFractalType)
            {
                case FractalType.Mandelbrot:
                    if (useGpu)
                    {
                        Gpu.Default.For(0, height, y =>
                        {
                            ComputeFractalPixel(y, width, height, stride, rgbValues, s, false);
                        });
                    }
                    else
                    {
                        Parallel.For(0, height, y =>
                        {
                            ComputeFractalPixel(y, width, height, stride, rgbValues, s, false);
                        });
                    }
                    break;

                case FractalType.Julia:
                    if (useGpu)
                    {
                        Gpu.Default.For(0, height, y =>
                        {
                            ComputeFractalPixel(y, width, height, stride, rgbValues, s, true);
                        });
                    }
                    else
                    {
                        Parallel.For(0, height, y =>
                        {
                            ComputeFractalPixel(y, width, height, stride, rgbValues, s, true);
                        });
                    }
                    break;

                case FractalType.SierpinskiTriangle:
                    if (useGpu)
                    {
                        Gpu.Default.For(0, height, y =>
                        {
                            DrawSierpinski(width, height, stride, rgbValues);
                        });
                    }
                    else
                    {
                        Parallel.For(0, height, y =>
                        {
                            DrawSierpinski(width, height, stride, rgbValues);
                        });
                    }
                    break;

                case FractalType.DragonCurve:
                    if (useGpu)
                    {
                        Gpu.Default.For(0, height, y =>
                        {
                            DrawDragonCurve(width, height, stride, s, rgbValues);
                        });
                    }
                    else
                    {
                        Parallel.For(0, height, y =>
                        {
                            DrawDragonCurve(width, height, stride, s, rgbValues);
                        });
                    }
                    break;

                case FractalType.FractalTree:
                    if (useGpu)
                    {
                        Gpu.Default.For(0, height, y =>
                        {
                            DrawFractalTree(width, height, stride, s, rgbValues);
                        });
                    }
                    else
                    {
                        Parallel.For(0, height, y =>
                        {
                            DrawFractalTree(width, height, stride, s, rgbValues);
                        });
                    }
                    break;
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            bitmap.UnlockBits(bmpData);
        }

        private void ComputeFractalPixel(int y, int width, int height, int stride, byte[] rgbValues, FractalSettings s, bool isJulia)
        {
            int rowOffset = y * stride;

            for (int x = 0; x < width; x++)
            {
                double zx = 1.5 * (x - width / 2) / (0.5 * s.Zoom * width) + s.MoveX;
                double zy = (y - height / 2) / (0.5 * s.Zoom * height) + s.MoveY;

                double cRe = isJulia ? s.CRe : zx;
                double cIm = isJulia ? s.CIm : zy;

                int i;
                for (i = 0; i < s.MaxIterations; i++)
                {
                    double temp = zx * zx - zy * zy + cRe; 
                    zy = 2.0 * zx * zy + cIm;              
                    zx = temp;

                    if ((zx * zx + zy * zy) > 4) break;
                }

                byte r = (byte)((i * 9) % 255);
                byte g = 0;
                byte b = (byte)((i * 9) % 255);

                int index = rowOffset + x * 3;
                rgbValues[index] = b;
                rgbValues[index + 1] = g;
                rgbValues[index + 2] = r;
            }
        }

        private void DrawSierpinski(int width, int height, int stride, byte[] rgbValues)
        {
            int rowOffset = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (IsInSierpinski(x, y))
                    {
                        int index = rowOffset + x * 3;
                        rgbValues[index] = 0;
                        rgbValues[index + 1] = 255;
                        rgbValues[index + 2] = 0;
                    }
                }
                rowOffset += stride;
            }
        }

        private bool IsInSierpinski(int x, int y)
        {
            while (x > 0 || y > 0)
            {
                if ((x % 2 == 1) && (y % 2 == 1)) return false;
                x /= 2;
                y /= 2;
            }
            return true;
        }

        private void DrawDragonCurve(int width, int height, int stride, FractalSettings s, byte[] rgbValues)
        {
            int x = width / 2;
            int y = height / 2;
            int angle = 0;

            int iterations = settings.MaxIterations;

            string dragonCurve = "FX";
            string result = dragonCurve;
            for (int i = 0; i < iterations; i++)
            {
                StringBuilder nextResult = new StringBuilder();
                foreach (char c in result)
                {
                    if (c == 'X')
                        nextResult.Append("X+YF+");
                    else if (c == 'Y')
                        nextResult.Append("-FX-Y");
                    else
                        nextResult.Append(c);
                }
                result = nextResult.ToString();
            }
            
            foreach (char c in result)
            {
                if (c == 'F')
                {
                    int newX = x + (int)(Math.Cos(Math.PI * angle / 180) * 10);
                    int newY = y + (int)(Math.Sin(Math.PI * angle / 180) * 10);

                    DrawLine(x, y, newX, newY, rgbValues, width, height, stride);

                    x = newX;
                    y = newY;
                }
                else if (c == '+')
                {
                    angle += s.Angle;
                }
                else if (c == '-')
                {
                    angle -= s.Angle;
                }
            }
        }

        private void DrawLine(int x1, int y1, int x2, int y2, byte[] rgbValues, int width, int height, int stride)
        {
            // Проверяем, чтобы координаты были в пределах изображения
            if (x1 < 0 || x1 >= width || y1 < 0 || y1 >= height || x2 < 0 || x2 >= width || y2 < 0 || y2 >= height)
                return;

            // Рисуем линию (алгоритм Брезенхэма для рисования прямой)
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                int index = (y1 * stride) + x1 * 3;
                if (index >= 0 && index < rgbValues.Length)
                {
                    rgbValues[index] = 255; // Рисуем белую линию (можно поменять на цвет)
                    rgbValues[index + 1] = 255;
                    rgbValues[index + 2] = 255;
                }

                if (x1 == x2 && y1 == y2)
                    break;

                int e2 = err * 2;
                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }
        }

        private void DrawFractalTree(int width, int height, int stride, FractalSettings s, byte[] rgbValues)
        {
            int startX = width / 2;
            int startY = height - 10;

            int trunkLength = (int)(height / 4);
            double angle = -90;

            DrawBranch(rgbValues, startX, startY, trunkLength, angle, stride, width, height, s.MaxIterations);
        }

        private void DrawBranch(byte[] rgbValues, int x1, int y1, int length, double angle, int stride, int width, int height, int depth)
        {
            if (depth <= 0 || length <= 0)
                return;

            int x2 = x1 + (int)(length * Math.Cos(angle * Math.PI / 180));
            int y2 = y1 + (int)(length * Math.Sin(angle * Math.PI / 180));

            DrawLine(rgbValues, x1, y1, x2, y2, stride, width, height);

            DrawBranch(rgbValues, x2, y2, (int)(length * 0.7), angle - 20, stride, width, height, depth - 1);
            DrawBranch(rgbValues, x2, y2, (int)(length * 0.7), angle + 20, stride, width, height, depth - 1);
        }

        private void DrawLine(byte[] rgbValues, int x0, int y0, int x1, int y1, int stride, int width, int height)
        {
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = -Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = dx + dy, e2;

            while (true)
            {
                if (x0 >= 0 && x0 < width && y0 >= 0 && y0 < height)
                {
                    int index = y0 * stride + x0 * 3;
                    rgbValues[index] = 0;       
                    rgbValues[index + 1] = 255; 
                    rgbValues[index + 2] = 0;   
                }

                if (x0 == x1 && y0 == y1) break;
                e2 = 2 * err;
                if (e2 >= dy) { err += dy; x0 += sx; }
                if (e2 <= dx) { err += dx; y0 += sy; }
            }
        }


        #region Animation
        private void StartAnimation()
        {
            if (animationTimer == null)
            {
                animationTimer = new Timer();
                animationTimer.Interval = 50;
                animationTimer.Tick += AnimationTimer_Tick;
            }

            isAnimating = true;
            animationTimer.Start();
        }

        private void StopAnimation()
        {
            if (animationTimer != null)
            {
                animationTimer.Stop();
            }
            isAnimating = false;
        }

        private async void AnimationTimer_Tick(object sender, EventArgs e)
        {
            time += 0.05;

            if (settings.Zoom < 0.5)
                zoomDirection = 1;
            else if (settings.Zoom > 5.0)
                zoomDirection = -1;

            settings.Zoom *= (zoomDirection > 0) ? (1.02) : (0.98);

            settings.MoveX = Math.Sin(time * 0.5) * 0.5;
            settings.MoveY = Math.Cos(time * 0.5) * 0.5;

            settings.CRe = Math.Sin(time * 0.3) * 0.7;
            settings.CIm = Math.Cos(time * 0.4) * 0.7;

            await GenerateFractalAsync();
        }
        #endregion
    }
}