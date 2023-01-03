namespace ShoppingCart.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime RegistryVersion { get; set; }


        // Private Methods
        private Customer SetNewId()
        {
            Id = Guid.NewGuid();

            return this;
        }

        private Customer ChangeNameInternal(string firstName, string lastName)
        {
            FirstName = firstName;
            
            LastName = lastName;

            return this;
        }

        private Customer ChangeBirthDateInternal(DateTime birthDate)
        {
            BirthDate = birthDate;

            return this;
        }

        private Customer GenerateNewRegistryVersionInternal()
        {
            RegistryVersion = DateTime.UtcNow;

            return this;
        }

        // Public Methods
        public Customer ImportCustomer(string firstName, string lastName, DateTime birthDate)
        {
            return
                SetNewId()
                .ChangeNameInternal(firstName, lastName)
                .ChangeBirthDateInternal(birthDate)
                .GenerateNewRegistryVersionInternal();
        }

        public Customer ChangeName(string firstName, string lastName)
        {
            return ChangeNameInternal(firstName, lastName)
                .GenerateNewRegistryVersionInternal();
        }

        public Customer ChangeBirthDate(DateTime birthDate)
        {
            return ChangeBirthDateInternal(birthDate)
                .GenerateNewRegistryVersionInternal();
        }
    }
}
