namespace FractalGenerator.Model
{
    public struct FractalSettings
    {
        public double Zoom;
        public double MoveX;
        public double MoveY;
        public int MaxIterations;
        public double CRe;
        public double CIm;
        public int Angle;

        public FractalSettings(double zoom, double moveX, double moveY, int maxIterations, double cRe, double cIm, int angle)
        {
            Zoom = zoom;
            MoveX = moveX;
            MoveY = moveY;
            MaxIterations = maxIterations;
            CRe = cRe;
            CIm = cIm;
            Angle = angle;
        }
    }
}
