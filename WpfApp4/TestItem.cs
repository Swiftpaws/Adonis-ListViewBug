namespace WpfApp4
{
    public class TestItem
    {
        public string Content { get; }

        public TestItem(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}