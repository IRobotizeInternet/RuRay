using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.IO;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="DynamicCodeCompilation" />.
    /// </summary>
    internal class DynamicCodeCompilation
    {
        /// <summary>
        /// The CompleCode.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string"/>.</param>
        [STAThread]
        public void CompleCode(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || File.Exists(filePath))
            {
                return;
            }

            CompileExecutable(filePath);
        }

        /// <summary>
        /// The CompileExecutable.
        /// </summary>
        /// <param name="sourceName">The sourceName<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool CompileExecutable(string sourceName)
        {
            FileInfo sourceFile = new FileInfo(sourceName);
            CodeDomProvider provider = null;
            bool compileOk = false;

            // Select the code provider based on the input file extension.
            if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
            {
                provider = CodeDomProvider.CreateProvider("CSharp");
            }
            else
            {
                Console.WriteLine("Source file must have a .cs extension");
            }

            if (provider != null)
            {

                // Format the executable file name.
                // Build the output assembly path using the current directory
                // and <source>_cs.exe or <source>_vb.exe.

                string exeName = string.Format(@"{0}\{1}.exe",
                    System.Environment.CurrentDirectory,
                    sourceFile.Name.Replace(".", "_"));

                CompilerParameters cp = new CompilerParameters
                {

                    // Generate an executable instead of
                    // a class library.
                    GenerateExecutable = true,

                    // Specify the assembly file name to generate.
                    OutputAssembly = exeName,

                    // Save the assembly as a physical file.
                    GenerateInMemory = true,

                    // Set whether to treat all warnings as errors.
                    TreatWarningsAsErrors = false
                };

                // Invoke compilation of the source file.
                var cr = provider.CompileAssemblyFromFile(cp, sourceName);

                if (cr.Errors.Count > 0)
                {
                    // Display compilation errors.
                    Console.WriteLine("Errors building {0} into {1}",
                        sourceName, cr.PathToAssembly);
                    foreach (CompilerError ce in cr.Errors)
                    {
                        Console.WriteLine("  {0}", ce.ToString());
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    Console.WriteLine("Source {0} built into {1} successfully.",
                        sourceName, cr.PathToAssembly);
                }

                // Return the results of the compilation.
                if (cr.Errors.Count > 0)
                {
                    compileOk = false;
                }
                else
                {
                    compileOk = true;
                }
            }
            return compileOk;
        }
    }
}
