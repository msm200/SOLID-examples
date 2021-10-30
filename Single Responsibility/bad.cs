public SingleResponsibility
{
    public double[] getTemperatures(double kelvin)
    {
        double celsiusTemp = kelvin - 273.15;
        double fahrenheitTemp = (9/5) * celsiusTemp + 32;
        return new double[] {kelvin, celsiusTemp, fahrenheitTemp};
    }
}