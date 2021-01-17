using System.Collections.Generic;
using FluentValidation;

namespace Application
{
    public class NumberInput {
        public int[] Numbers {get; set;}

        public NumberInput() {
            Numbers = new int[] {};
        }
    }

    public class AddInput : NumberInput { }

    public class AddValidator : AbstractValidator<AddInput> 
    {
        public AddValidator()
        {
            RuleFor(x => x.Numbers.Length).GreaterThan(1)
                .WithMessage("Number of parameters must be greater than 1"); 
        }
    }

    public class SubstractInput : NumberInput {}

    public class SubstractValidator : AbstractValidator<SubstractInput> 
    {
        public SubstractValidator()
        {
            RuleFor(x => x.Numbers.Length).GreaterThan(1)
                .WithMessage("Number of parameters must be greater than 1"); 
        }
    }
    
    public class MultiplyInput : NumberInput { }

    public class MultiplyValidator : AbstractValidator<MultiplyInput> 
    {
        public MultiplyValidator()
        {
            RuleFor(x => x.Numbers.Length).GreaterThan(1)
                .WithMessage("Number of parameters must be greater than 1"); 
        }
    }

    public class DivideInput : NumberInput { }

    public class DivideValidator : AbstractValidator<DivideInput> 
    {
        public DivideValidator()
        {
            RuleFor(x => x.Numbers.Length).Equal(2)
                .WithMessage("Number of parameters must be 2").WithName("Numbers"); 
            RuleFor(x => x.Numbers.Length != 2 ? 0 : x.Numbers[1]).NotEqual(0)
                .WithMessage("second parameter can't be 0 or empty")
                .WithName("Numbers");
        }
    }

    public class SplitEqInput : NumberInput { }

    public class SplitEqValidator : AbstractValidator<SplitEqInput> 
    {
        public SplitEqValidator()
        {
            RuleFor(x => x.Numbers.Length).GreaterThan(1)
                .WithMessage("Number of parameters must be greater than 1"); 
            RuleFor(x => x.Numbers.Length != 2 ? -1 : x.Numbers[0] % x.Numbers[1]).Equal(0)
                .WithMessage("Parameter 1 can't be split")
                .WithName("Numbers"); 
            // x.Numbers.length != 2 check is for preventing index out of range exception when
            // there is no second parameter
        }
    }

    public class SplitNumInput : NumberInput { }

    public class SplitValidator : AbstractValidator<SplitNumInput> 
    {
        public SplitValidator()
        {
            RuleFor(x => x.Numbers.Length).GreaterThan(1)
                .WithMessage("Number of parameters must be greater than 1"); 
        }
    }

    
}