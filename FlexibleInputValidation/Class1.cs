namespace FlexibleInputValidation
{
    public abstract class InputValidatorBase
    {
        public abstract bool IsValid(string input);
    }

    public class NumberValidator : InputValidatorBase
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int MaxLength { get; set; }

        public NumberValidator(int minValue = int.MinValue, int maxValue = int.MaxValue, int maxLength = int.MaxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MaxLength = maxLength;
        }

        public override bool IsValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length > MaxLength)
                return false;

            if (int.TryParse(input, out int result))
            {
                return result >= MinValue && result <= MaxValue;
            }

            return false;
        }
    }

    public class StringValidator : InputValidatorBase
    {
        public int MaxLength { get; set; }
        public List<char> Exclusions { get; set; }

        public StringValidator(int maxLength = int.MaxValue, List<char> exclusions = null)
        {
            MaxLength = maxLength;
            Exclusions = exclusions ?? new List<char>();
        }

        public override bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length > MaxLength)
                return false;

            return !input.Any(c => Exclusions.Contains(c));
        }
    }

    public class CharValidator : InputValidatorBase
    {
        public List<char> AllowedChars { get; set; }

        public CharValidator(List<char> allowedChars)
        {
            AllowedChars = allowedChars;
        }

        public override bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length != 1)
                return false;

            return AllowedChars.Contains(input[0]);
        }
    }

}