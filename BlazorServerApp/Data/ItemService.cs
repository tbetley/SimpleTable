namespace BlazorServerApp.Data
{
    public class ItemService
    {
        private readonly List<TestItem> Items = new();

        public ItemService()
        {
            SeedItems();
            
        }

        public List<TestItem> GetTestItems()
        {
            return Items;
        }

        public TestItem? GetTestItemById(int id)
        {
            var item = Items.Where(i => i.Id == id).FirstOrDefault();

            return item;
        }

        private void SeedItems()
        {
            Items.Add(new TestItem()
            {
                Id = 1,
                FistName = "Bob",
                LastName = "Johnson",
                StartDate = new DateTime(2020, 12, 1),
                Salary = 40000.00M
            });

            Items.Add(new TestItem
            {
                Id = 2,
                FistName = "Ken",
                LastName = "Test",
                StartDate = new DateTime(1990, 3, 4),
                Salary = 100000M
            });

            Items.Add(new TestItem
            {
                Id = 3,
                FistName = "Sarah",
                LastName = "Testerman",
                StartDate = new DateTime(2010, 4, 12),
                Salary = 90000M
            });

            Items.Add(new TestItem
            {
                Id = 4,
                FistName = "Bill",
                LastName = "Bobby",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 5,
                FistName = "Billy",
                LastName = "Bobby2",
                StartDate = new DateTime(2020, 4, 23),
                Salary = 75000.20M
            });

            Items.Add(new TestItem
            {
                Id = 6,
                FistName = "Mike",
                LastName = "Jergenson",
                StartDate = new DateTime(2011, 4, 23),
                Salary = 70000.60M
            });

            Items.Add(new TestItem
            {
                Id = 7,
                FistName = "Skldf",
                LastName = "LKkdyfe4",
                StartDate = new DateTime(1990, 4, 23),
                Salary = 60000.20M
            });

            Items.Add(new TestItem
            {
                Id = 8,
                FistName = "Borb",
                LastName = "Bosdkfljy",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 9,
                FistName = "JMdiii",
                LastName = "Bobby",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 10,
                FistName = "Dlsfj",
                LastName = "Bobby",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 11,
                FistName = "Bill",
                LastName = "sdDflkd",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 12,
                FistName = "Kdkjf",
                LastName = "wqeirnm",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });

            Items.Add(new TestItem
            {
                Id = 13,
                FistName = "Aaron",
                LastName = "Rogers",
                StartDate = new DateTime(2012, 4, 23),
                Salary = 70000.20M
            });
        }
    }
}
