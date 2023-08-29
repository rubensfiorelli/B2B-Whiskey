using Whiskey.Application.Abstrations.Command.Interfaces;

namespace Whiskey.Application.Abstrations.Command
{
    public sealed class CreateCategoryCommand : ICommand
    {
        public CreateCategoryCommand(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }

    }
}
