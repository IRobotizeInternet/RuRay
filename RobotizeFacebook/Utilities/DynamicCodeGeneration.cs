using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RobotizeFacebook.Utilities
{
    public class DynamicCodeGeneration
    {
        public void GenerateClassCode()
        {
            var namespaceName = "FacebookHelpCode";
            var className = "HelloWorld";

            var compileUnit = BuildHelloWorldGraph(namespaceName, new List<string> { "System" }, className);
            var classString = CreateClass(compileUnit);
        }
        public string CreateClass(CodeCompileUnit compileunit)
        {
            // Generate the code with the C# code provider.
            var provider = new CSharpCodeProvider();

            // Build the output file name.
            string sourceFile;
            if (provider.FileExtension[0] == '.')
            {
                sourceFile = "HelloWorld" + provider.FileExtension;
            }
            else
            {
                sourceFile = "HelloWorld." + provider.FileExtension;
            }

            // Create a TextWriter to a StreamWriter to the output file.
            using (StreamWriter sw = new StreamWriter(sourceFile, false))
            {
                var tw = new IndentedTextWriter(sw, "    ");

                // Generate source code using the code provider.
                provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());

                // Close the output file.
                tw.Close();
            }

            return sourceFile;
        }

        // Build a Hello World program graph using
        // System.CodeDom types.
        public CodeCompileUnit BuildHelloWorldGraph(
            string nameSpaceString, 
            IEnumerable<string> directives, 
            string classNameString)
        {
            // Create a new CodeCompileUnit to contain
            // the program graph.
            CodeCompileUnit compileUnit = new CodeCompileUnit();

            // Declare a new namespace called Samples.
            CodeNamespace nameSpace = new CodeNamespace(nameSpaceString);

            // Add the new namespace to the compile unit.
            compileUnit.Namespaces.Add(nameSpace);

            // Add the new namespace import for the System namespace.
            foreach(var directive in directives) nameSpace.Imports.Add(new CodeNamespaceImport(directive));

            // Declare a new type called classNameString.
            var className = new CodeTypeDeclaration(classNameString);

            // Add the new type to the namespace type collection.
            nameSpace.Types.Add(className);

            // Declare a new code entry point method.
            CodeEntryPointMethod start = new CodeEntryPointMethod();
           
            
            className.Members.Add(CreateMethod());

            // Create a type reference for the System.Console class.
            CodeTypeReferenceExpression csSystemConsoleType = new CodeTypeReferenceExpression("System.Console");

            // Build a Console.WriteLine statement.
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
                csSystemConsoleType, "WriteLine",
                new CodePrimitiveExpression("Hello World!"));

            // Add the WriteLine call to the statement collection.
            start.Statements.Add(cs1);

            // Build another Console.WriteLine statement.
            CodeMethodInvokeExpression cs2 = new CodeMethodInvokeExpression(
                csSystemConsoleType, "WriteLine",
                new CodePrimitiveExpression("Press the Enter key to continue."));

            // Add the WriteLine call to the statement collection.
            start.Statements.Add(cs2);

            // Build a call to System.Console.ReadLine.
            CodeMethodInvokeExpression csReadLine = new CodeMethodInvokeExpression(
                csSystemConsoleType, "ReadLine");

            // Add the ReadLine statement.
            start.Statements.Add(csReadLine);

            // Add the code entry point method to
            // the Members collection of the type.
            className.Members.Add(start);

            return compileUnit;
        }

        public CodeMemberMethod CreateMethod()
        {
            var codeMemberMethod = new CodeMemberMethod();
            codeMemberMethod.Name = "NewMethod";

            var parameter = new CodeParameterDeclarationExpression();
            parameter.Name = "userName";
            parameter.Type = new CodeTypeReference(typeof(int));
            codeMemberMethod.Parameters.Add(parameter);
            return codeMemberMethod;
        }
    }
}
