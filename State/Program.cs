namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Music music1 = new Music("1 композиция", new StopState());
            Music music2 = new Music("2 композиция", new StopState());

            music1.Play();
            music1.PlayNext(music2);
            music2.Stop();
        }
    }
}
