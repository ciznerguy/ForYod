namespace ForYod.Components.Services
{
    public class UserService
    {
        public string FullName { get; private set; } = "not";

        public void SetFullName(string fullName)
        {
            FullName = fullName;
        }
    }
}
