namespace GeometricFormsTDD.Core
{
    /// <summary>
    /// Enum countaens six Form states
    /// </summary>
    public enum formId { Circle, Square, Rectangle, RightTriangle, EquilateralTriangle, IsoscelesTriangle }
    
    internal class AddToForm
    {
        /// <summary>
        /// This class defines the form
        /// </summary>
        public AddToForm()
        {
        }
        
        public formId FormID { get; set; }
        public float FormPerimeter { get; set; }
        public float FormArea { get; set; }
    }
}