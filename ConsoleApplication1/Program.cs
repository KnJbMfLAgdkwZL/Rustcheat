namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Form1 form1 = new Form1();
            MyInterceptor myInterceptor = new MyInterceptor(form1);
            form1.ShowDialog();
        }
    }
}