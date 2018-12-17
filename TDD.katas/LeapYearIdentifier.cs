namespace TDD.katas
{
    public class LeapYearIdentifier
    {
        public static bool IsLeapYear(int year)
        {
            if (ATypicalLeap(year))
                return true;

            if (ATypicalCommon(year))
                return false;

            return CommonLeap(year);
        }

        private static bool CommonLeap(int year)
        {
            return year % 4 == 0;
        }

        private static bool ATypicalCommon(int year)
        {
            return year % 100 == 0;
        }

        private static bool ATypicalLeap(int year)
        {
            return year % 400 == 0;
        }
    }
}