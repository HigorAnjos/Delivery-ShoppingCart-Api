namespace ShoppingCart.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }


        public BaseEntity()
        {
            SetNewId();
        }

        public BaseEntity(Guid id)
        {
            Id = id;
        }

        private void SetNewId()
        {
            Id = Guid.NewGuid();
        }
    }
}
