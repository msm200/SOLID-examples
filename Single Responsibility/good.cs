public SingleResponsibility
{
    public double getCelsiusTemperature(double kelvin)
    {
        return kelvin - 273.15;
    }
    public double getFahrenheitTemperature(double kelvin)
    {
        double celsiusTemp = getCelsiusTemperature;
        double fahrenheitTemp = (9/5) * celsiusTemp + 32;
        return fahrenheitTemp;
    }
}