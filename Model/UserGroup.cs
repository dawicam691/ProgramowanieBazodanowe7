namespace Model
{
    public class UserGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User>? Users { get; set; }
    }
}
