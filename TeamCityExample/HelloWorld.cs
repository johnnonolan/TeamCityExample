namespace TeamCityExample
{
    public class HelloWorld
    {
        public string SayHi(string hello)
        {
            return "Hello: "+ hello;
        }

        public string GetStuffed(string hello)
        {
            if (hello == "Steve")
              return "Bog off: " + hello;
            if (hello == "world")
              return "Hello: " + hello;
            return "Get Stuffed" + hello;
        }


        public void noop2()
        {
            return;
        }


        public void noop()
        {
            return;
        }

    }
}
