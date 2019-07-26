namespace ExercicesBase.Extensions
{
    static class FloatExtensions
    {
        public static float ToKelvin(this float degrees) {
            return  degrees + 273.15f;
        }

        public static float ToFahrenheit(this float degrees) {
            return degrees * 9.0f / 5.0f + 32;
        }
    }
}
