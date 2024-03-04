namespace ShoeCompany.Models
{
    public class Inventory
    {
        public int Number_in_Stock { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
            =>  $"Number in Stock: {Number_in_Stock}, Product: {ProductId}";
        


    }
}
