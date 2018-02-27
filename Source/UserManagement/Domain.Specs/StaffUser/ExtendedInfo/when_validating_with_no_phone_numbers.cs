using System;
using Machine.Specifications;
using FluentValidation.Results;
using Domain.StaffUser;
using Concepts;

namespace Domain.Specs.StaffUser.ExtendedInfo
{
    [Subject(typeof(ExtendedInfoValidator))]
    public class when_validating_with_no_phone_numbers
    {
        static ExtendedInfoValidator validator;
        static ValidationResult validation_results;
        static Domain.StaffUser.ExtendedInfo extended;

        Establish context = () =>
        {
            validator = new ExtendedInfoValidator();
            extended = given.extended_info.build_instance_with(ei => ei.PhoneNumbers = new string[0]);
            extended.YearOfBirth = 1980;
            extended.Sex = Sex.Female;
        };

        Because of = () => { validation_results = validator.Validate(extended); };

        It should_be_invalid = () => validation_results.ShouldBeInvalid();    
        It should_have_one_error = () => validation_results.ShouldHaveInvalidCountOf(1);
        It should_identify_phone_numbers_as_the_error = () => validation_results.ShouldHaveInvalidProperty(nameof(extended.PhoneNumbers));      
    }
}