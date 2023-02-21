using Our.Umbraco.Forms.Validator.Core;
using Our.Umbraco.Forms.Validator.Core.Rules;

namespace Our.Umbraco.Forms.Validator.Rules;

public class FieldsGreaterThanOrEqual : FieldsComparisonRule
{
    public FieldsGreaterThanOrEqual(FormValueProvider provider, FormValidationCollector collector) : base(provider, collector)
    {
    }
    
    public override bool Validate(FormFieldValue current, FormFieldValue compare)
    {
        throw new NotImplementedException();
    }

}