using System;
using System.ComponentModel.DataAnnotations;
using McMaster.Extensions.CommandLineUtils;

namespace ConsoleTips
{
    [Command(Name = "dotnet <ConsoleTips.dll Path>", Description = "Sample project")]
    //[HelpOption("--my-custom-help-option")] // Change from default --help to --my-custom-help-option
    class Program
    {
        [Argument(0, Description="Your FirstName")]
        [Required]
        public string FirstName { get; }

        [Argument(1)]
        public string LastName { get; }  // this one is optional because it doesn't have `[Required]`

        [Option(Description="Middle Name")]
        [Required]
        public string MiddleName { get; }
        private void OnExecute()
        {
            Console.WriteLine($"Hello {FirstName} {MiddleName} {LastName}");
        }

        static void Main(string[] args)
        {
            CommandLineApplication.Execute<Program>(args);
        }
    }
}
