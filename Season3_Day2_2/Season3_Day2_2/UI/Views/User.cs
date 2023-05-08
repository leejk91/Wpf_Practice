namespace Season3_Day2_2.UI.Views
{
    internal class User
    {
        public string Name { get; private set; }
        public string Location { get; private set; }

        internal User GenData(string name, string location)
        {
            var user = new User();
            user.Name = name;
            user.Location = location;
            return user;
        }
    }
}