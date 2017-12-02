using System;
namespace STM32CP
{
    public class Arcticle
    {
        public Arcticle(string title, string description, string text)
        {
            this.Title = title;
            this.Description = description;
            this.Title = title;
        }

        public string Title { private set; get; }

        public string Description { private set; get; }

        public string Text { private set; get; }
    }
}
