namespace SupportingScripts
{
    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            //var a = new ScriptUsingFacebook();
            //a.GenerateFacebookHelpApi();
            new IterateFiles().PrintCode();
        }
    }
}
