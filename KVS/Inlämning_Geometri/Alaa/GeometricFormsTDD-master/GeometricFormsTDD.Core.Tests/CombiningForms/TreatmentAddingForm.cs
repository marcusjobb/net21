using System;
using System.Collections.Generic;

namespace GeometricFormsTDD.Core
{
    internal class TreatmentAddingForm
    {
        private List<AddToForm> CartForms;
        public TreatmentAddingForm()
        {
            CartForms = new List<AddToForm>();
        }

        internal AddToCartResponse AddToCart(AddToGroupForms addGeoForm)
        {
            var Form = CartForms.Find(x => x.FormPerimeter > 0);
            if (Form != null)
            {
                Form.FormPerimeter += addGeoForm.Form.FormPerimeter;
                Form.FormArea += addGeoForm.Form.FormArea;
            }
            else
            {
                CartForms.Add(addGeoForm.Form);
            }
            CartForms.Add(addGeoForm.Form);
            return new AddToCartResponse()
            {
                Forms = CartForms.ToArray()
            };
        }
    }
}