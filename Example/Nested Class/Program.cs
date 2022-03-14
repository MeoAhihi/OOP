class Outer {
    private int x = 7;
    public class Inner {
        private int y = 1000;
        public Inner() => System.Console.WriteLine(x + y);
    }
}
