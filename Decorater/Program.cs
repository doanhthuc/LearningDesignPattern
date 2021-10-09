using System;
using Decorater.Decorators;

namespace Decorater
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMilkTea =
                new EggPudding(
                    new FruitPudding(
                        new BlackSugar(
                            new Bubble(
                                new Milktea()
                            )
                        )
                    )
                );

            Console.WriteLine("EggPuddingAnbFruitPuddingBlackSugarBubleMilktea: \t" +
                                firstMilkTea.Cost());

            WebPage myPage = new BasicWebPage();
            myPage = new AuthorizedWebPage(myPage);
            myPage = new AuthenticatedWebPage(myPage);
            myPage.Display();
        }
    }

    interface WebPage
    {
        void Display();
    }

    class BasicWebPage : WebPage
    {
        public string HTML { get; set; }
        public string Css { get; set; }
        public string JS { get; set; }
        public void Display()
        {
            Console.WriteLine("Display basic web page ... ");
        }
    }

    abstract class WebpageDecorator : WebPage
    {
        protected WebPage page;
        public WebpageDecorator(WebPage _page)
        {
            page = _page;
        }
        public virtual void Display()
        {
            page.Display();
        }
    }

    class AuthorizedWebPage : WebpageDecorator
    {
        public AuthorizedWebPage(WebPage page) : base(page)
        {
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Authorized web page ... ");
        }
    }

    class AuthenticatedWebPage : WebpageDecorator
    {
        public AuthenticatedWebPage(WebPage page) : base(page)
        {
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Authenticated web page ... ");
        }
    }
}
