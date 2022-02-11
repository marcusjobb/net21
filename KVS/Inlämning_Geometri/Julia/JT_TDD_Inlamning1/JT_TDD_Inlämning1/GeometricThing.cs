namespace JT_TDD_Inlämning1
{
    /// <summary>
    /// Abstract class that provide member variables and methods that are shared by all subclasses.
    /// </summary>
    public abstract class GeometricThing
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public abstract float Area();
        public abstract float Perimeter();
    }
}