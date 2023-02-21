using Our.Umbraco.Forms.Validator.Core;
using Our.Umbraco.Forms.Validator.Core.Rules;
using Umbraco.Forms.Core.Models;

namespace Our.Umbraco.Forms.Validator.Rules;

public class FieldsLessThan : FieldsComparisonRule
{
    public FieldsLessThan(Form form) : base(form)
    {
    }

    public override bool Validate(FormValue current, FormValue compare, FormValidationContext context)
    {
        throw new NotImplementedException();
    }
}