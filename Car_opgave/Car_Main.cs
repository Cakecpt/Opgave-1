namespace Car_opgave
{
    public class Car_Main
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public double LicensePlate { get; set; }

        public void ValidateID()
        {
            if (Id == null)
            {
                throw new ArgumentNullException("ID does not exist");
            }

        }

        public void ValidateModel()
        {
            if (Model?.Length <= 4);
            {
                throw new ArgumentOutOfRangeException($"{nameof(Model)} Must be minimum four Characters :)");
            }
        }

        public void ValidatePrice()
        {
            if (Price > 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate <= 2 && LicensePlate <= 7)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}