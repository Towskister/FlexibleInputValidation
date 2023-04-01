Input Validation Library for C#
This input validation library provides a flexible and modular way to validate user input in C# applications. It currently supports validation for number, string, and character inputs.

Implementation
To implement this library in your C# program, follow these steps:

Add the provided classes (InputValidatorBase, NumberValidator, StringValidator, and CharValidator) to your project.

Create instances of the validator classes as needed, and configure their properties to specify the desired validation rules.

Call the IsValid method on the validator instances to validate user input.

Configuring Validators
NumberValidator
NumberValidator is used for validating numeric inputs. You can set the following properties to configure the validation rules:

MinValue: The minimum allowed value for the numeric input (default: int.MinValue)
MaxValue: The maximum allowed value for the numeric input (default: int.MaxValue)
MaxLength: The maximum allowed length for the numeric input (default: int.MaxValue)
Example:

csharp
Copy code
var numberValidator = new NumberValidator(0, 100, 3); // Only accepts numbers between 0 and 100 with a max length of 3
StringValidator
StringValidator is used for validating string inputs. You can set the following properties to configure the validation rules:

MaxLength: The maximum allowed length for the string input (default: int.MaxValue)
Exclusions: A list of characters to exclude from the string input (default: empty list)
Example:

csharp
Copy code
var stringValidator = new StringValidator(10, new List<char> { '!', '@', '#' }); // Accepts strings up to 10 characters long, excluding '!', '@', and '#'
CharValidator
CharValidator is used for validating character inputs. You can set the following properties to configure the validation rules:

AllowedChars: A list of allowed characters for the input
Example:

csharp
Copy code
var charValidator = new CharValidator(new List<char> { 'Y', 'N', 'y', 'n' }); // Accepts a single character input, either 'Y', 'N', 'y', or 'n'
Making Changes
To add new input types or validation rules to the library, create new classes that inherit from InputValidatorBase. Override the IsValid method and implement the validation logic according to your requirements. Add any necessary properties to configure the validation rules for your new input type.

For example, to create a validator for date inputs, you could create a new DateValidator class that inherits from InputValidatorBase, and add properties to specify the allowed date range and format.

To modify the existing validation rules, you can update the IsValid method implementations in the NumberValidator, StringValidator, or CharValidator classes. You can also add or modify properties to configure the rules as needed.

Remember to update the README documentation accordingly when making changes to the library.