namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirtYear = 2002,
                FirstName = "Efekan",
                LastName = "ULUBAŞ",
                IdentityNumber = 54382823
            });
        }
    }
}