using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricFormsTDD.Core
{
    internal class GeometricFormTests
    {
        /// <summary>
        /// The SetUp method is used for the assertion phase.
        /// We adorn it with setup attribute
        /// </summary>
        [SetUp]
        public void SetUp()
        {

        }

        /// <summary>
        /// CircleCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a Circle´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void CircleCalibrationAreaAndPerimeter()
        {
            var Circle = new CircleForm()
            {
                Radius = 5.2f
            };

            float CirclePerimeter = Circle.GetPerimeter();

            float CircleArea = Circle.GetArea();

            Assert.AreEqual(32.6725616f, CirclePerimeter);
            Assert.AreEqual(84.9486542f, CircleArea);

        }

        /// <summary>
        /// SquareCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a Square´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void SquareCalibrationAreaAndPerimeter()
        {
            var Square = new SquareForm()
            {
                Side = 5.2f
            };

            float SquarePerimeter = Square.GetPerimeter();

            float SquareArea = Square.GetArea();

            Assert.AreEqual(20.7999992f, SquarePerimeter);
            Assert.AreEqual(27.0399971f, SquareArea);

        }

        /// <summary>
        /// RectangleCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a Rectangle´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void RectangleCalibrationAreaAndPerimeter()
        {
            var Rectangle = new RectangleForm()
            {
                SideA = 5.2f,
                SideB = 10
            };

            float RectanglePerimeter = Rectangle.GetPerimeter();

            float RectangleArea = Rectangle.GetArea();

            Assert.AreEqual(30.4f, RectanglePerimeter);
            Assert.AreEqual(52.0f, RectangleArea);

        }

        /// <summary>
        /// RightTriangleCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a RightTriangle´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void RightTriangleCalibrationAreaAndPerimeter()
        {
            var RightTriangle = new RightTriangleForm()
            {
                Base = 5.2f,
                Height = 8.5f
                
            };

            float Hypotenuse = RightTriangle.GetHypotenuse();

            float RightTrianglePerimeter = RightTriangle.GetPerimeter();

            float RightTriangleArea = RightTriangle.GetArea();

            Assert.AreEqual(23.6644363f, RightTrianglePerimeter);
            Assert.AreEqual(22.0999985f, RightTriangleArea);

        }


        /// <summary>
        /// EquilateralTriangleCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a Equilateral Triangle´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void EquilateralTriangleCalibrationAreaAndPerimeter()
        {
            var EquilateralTriangle = new EquilateralTriangleForm()
            {
                Side = 5.2f,
            };

            float EquilateralTrianglePerimeter = EquilateralTriangle.GetPerimeter();

            float EquilateralTriangleArea = EquilateralTriangle.GetArea();

            Assert.AreEqual(15.5999994f, EquilateralTrianglePerimeter);
            Assert.AreEqual(11.708663f, EquilateralTriangleArea);

        }


        /// <summary>
        /// IsoscelesTriangleCalibrationAreaAndPerimeter is a test method for anssertion that 
        /// a Isosceles Triangle´s area and perimeter are calculated right.
        /// </summary>
        [Test]
        public void IsoscelesTriangleCalibrationAreaAndPerimeter()
        {
            var IsoscelesTriangle = new IsoscelesTriangleForm()
            {
                Side = 10.4f,
                Base = 6.5f
            };

            float IsoscelesTrianglePerimeter = IsoscelesTriangle.GetPerimeter();

            float IsoscelesTriangleArea = IsoscelesTriangle.GetArea();

            Assert.AreEqual(27.2999992f, IsoscelesTrianglePerimeter);
            Assert.AreEqual(32.1072197f, IsoscelesTriangleArea);

        }

        /// <summary>
        /// GeometricThing is a test method that implement the functionality to add a form to the form group
        /// and then return the form's area and perimeter and be anssertion that area and perimeter are right.
        /// </summary>
        [Test]
        public void GeometricThing()
        {
            var form = new AddToForm()
            {
                FormID = formId.Circle,
                FormPerimeter = 32.6725616f,
                FormArea = 84.9486542f
            };

            var AddGeoForm = new AddToGroupForms()
            {
                Form = form
            };

            var manager = new TreatmentAddingForm();

            AddToCartResponse response = manager.AddToCart(AddGeoForm);

            Assert.NotNull(response);
            Assert.Contains(form, response.Forms);

        }

        /// <summary>
        /// GeometricThing is a test method that implement the functionality to add a lot of forms to the form group
        /// and then return the form's area and perimeter and be anssertion that area and perimeter are right for evry form.
        /// </summary>
        [Test]
        public void GeometricAllThings()
        {
            var Circle = new AddToForm()
            {
                FormID = formId.Circle,
                FormPerimeter = 32.6725616f,
                FormArea = 84.9486542f
            };

            var AddGeoForm = new AddToGroupForms()
            {
                Form = Circle
            };

            var manager = new TreatmentAddingForm();

            AddToCartResponse response = manager.AddToCart(AddGeoForm);

            var Square = new AddToForm()
            {
                FormID = formId.Square,
                FormPerimeter = 20.7999992f,
                FormArea = 27.0399971f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = Square
            };
            response = manager.AddToCart(AddGeoForm);

            var Rectangle = new AddToForm()
            {
                FormID = formId.Rectangle,
                FormPerimeter = 30.4f,
                FormArea = 52.0f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = Rectangle
            };
            response = manager.AddToCart(AddGeoForm);

            var RightTriangle = new AddToForm()
            {
                FormID = formId.RightTriangle,
                FormPerimeter = 23.6644363f,
                FormArea = 22.0999985f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = RightTriangle
            };
            response = manager.AddToCart(AddGeoForm);

            var EquilateralTriangle = new AddToForm()
            {
                FormID = formId.EquilateralTriangle,
                FormPerimeter = 15.5999994f,
                FormArea = 11.708663f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = EquilateralTriangle
            };
            response = manager.AddToCart(AddGeoForm);

            var IsoscelesTriangle = new AddToForm()
            {
                FormID = formId.IsoscelesTriangle,
                FormPerimeter = 27.2999992f,
                FormArea = 32.1072197f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = IsoscelesTriangle
            };
            response = manager.AddToCart(AddGeoForm);

            Assert.NotNull(response);
            Assert.Contains(Circle, response.Forms);
            Assert.Contains(Square, response.Forms);
            Assert.Contains(Rectangle, response.Forms);
            Assert.Contains(RightTriangle, response.Forms);
            Assert.Contains(EquilateralTriangle, response.Forms);
            Assert.Contains(IsoscelesTriangle, response.Forms);

        }

        /// <summary>
        /// GeometricThing is a test method that implement the functionality to add a lot of forms to the form group
        /// and then return the form's area and perimeter and be anssertion that the sum of the areas and perimeters 
        /// of all form we added are right.
        /// </summary>
        [Test]
        public void ShouldCombinedAreaAndPerimeterAllThings()
        {
            var Circle = new AddToForm()
            {
                FormID = formId.Circle,
                FormPerimeter = 32.7f,
                FormArea = 84.9f
            };

            var AddGeoForm = new AddToGroupForms()
            {
                Form = Circle
            };

            var manager = new TreatmentAddingForm();

            AddToCartResponse response = manager.AddToCart(AddGeoForm);

            var Square = new AddToForm()
            {
                FormID = formId.Square,
                FormPerimeter = 20.8f,
                FormArea = 27.0f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = Square
            };
            response = manager.AddToCart(AddGeoForm);

            var Rectangle = new AddToForm()
            {
                FormID = formId.Rectangle,
                FormPerimeter = 30.4f,
                FormArea = 52.0f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = Rectangle
            };
            response = manager.AddToCart(AddGeoForm);

            var RightTriangle = new AddToForm()
            {
                FormID = formId.RightTriangle,
                FormPerimeter = 23.7f,
                FormArea = 22.1f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = RightTriangle
            };
            response = manager.AddToCart(AddGeoForm);

            var EquilateralTriangle = new AddToForm()
            {
                FormID = formId.EquilateralTriangle,
                FormPerimeter = 15.6f,
                FormArea = 11.7f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = EquilateralTriangle
            };
            response = manager.AddToCart(AddGeoForm);

            var IsoscelesTriangle = new AddToForm()
            {
                FormID = formId.IsoscelesTriangle,
                FormPerimeter = 27.3f,
                FormArea = 32.2f
            };

            AddGeoForm = new AddToGroupForms()
            {
                Form = IsoscelesTriangle
            };
            response = manager.AddToCart(AddGeoForm);




            Assert.NotNull(response);
            Assert.That(Array.Exists(response.Forms, x => x.FormPerimeter == 150.5f));
            Assert.That(Array.Exists(response.Forms, x => x.FormArea == 229.9f));


        }

        
    }
}
