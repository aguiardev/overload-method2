namespace OverloadMethod2
{
    public static class Address
    {
        public static string Format(string street) 
            => Format(street, null, null, null);

        public static string Format(string street, string number)
            => Format(street, number, null, null);

        public static string Format(string street, string number, string zipcode)
            => Format(street, number, zipcode, null);

        public static string Format(string street, string number, string zipcode, string country)
        {
            var addressFormated = street;
            if(!string.IsNullOrEmpty(number))
            {
                addressFormated += $", {number}";
            }

            if(!string.IsNullOrEmpty(zipcode))
            {
                addressFormated += $" - Zipcode: {zipcode}";
            }

            if(!string.IsNullOrEmpty(country))
            {
                addressFormated += $" - Country: {country}";
            }

            return addressFormated;
        }
    }
}