namespace Models
{
    public class ExibitionHall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsImax { get; set; }
        public bool HasSeatForCouples { get; set; }

    }
}
