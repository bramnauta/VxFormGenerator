using System.Collections.Generic;
using VxFormGenerator.Core;

namespace VxFormGenerator.Form
{

    public class BootstrapFormElementComponent<TFormElement> : FormElementBase<TFormElement>
    {
        public BootstrapFormElementComponent()
        {
            DefaultFieldClasses = new List<string>() { "form-control"};
            CssClasses = new List<string>() { "form-group", "row" };
        }

        public string GetFieldClasses()
        {
            var classes = "d-flex justify-content-center flex-column";

            if (string.IsNullOrWhiteSpace(Label))
            {
                classes += " col-sm-12";
            }
            else
            {
                classes += " col-sm-9";
            }

            return classes;
        }
    }
}
