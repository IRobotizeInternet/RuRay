using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RobotizeFacebook.Utilities
{
    public class DynamicCodeGeneration
    {
        public void GenerateClassCode(string nameSpace, string className, IEnumerable<string> methods)
        {
            //var compileUnit = BuildHelloWorldGraph(nameSpace, new List<string> { "System" }, className, methods);
            //var classString = CreateClass(compileUnit, className);
            CreateClass("cs", "ChecksumPragma.cs");
        }

        public void CreateClass(string providerName, string sourceFileName)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider(providerName);

            Console.WriteLine("Building the CodeDOM graph...");

            CodeCompileUnit cu = new CodeCompileUnit();

            CreateGraph(cu);

            StringWriter sw = new StringWriter();

            Console.WriteLine("Generating code...");
            provider.GenerateCodeFromCompileUnit(cu, sw, null);

            string output = sw.ToString();
            output = Regex.Replace(output, "Runtime Version:[^\r\n]*",
                "Runtime Version omitted for demo");

            Console.WriteLine("Dumping source code...");
            Console.WriteLine(output);

            Console.WriteLine("Writing source code to file...");
            Stream s = File.Open(sourceFileName, FileMode.Create);
            StreamWriter t = new StreamWriter(s);
            t.Write(output);
            t.Close();
            s.Close();
        }

        // Create a CodeDOM graph.
        static void CreateGraph(CodeCompileUnit cu)
        {
            CodeNamespace ns = new CodeNamespace("Namespace1");
            ns.Imports.Add(new CodeNamespaceImport("System"));
            ns.Imports.Add(new CodeNamespaceImport("System.IO"));
            cu.Namespaces.Add(ns);
            ns.Comments.Add(new CodeCommentStatement("Namespace Comment"));
            CodeTypeDeclaration cd = new CodeTypeDeclaration("Class1");
            ns.Types.Add(cd);

            cd.Comments.Add(new CodeCommentStatement("Outer Type Comment"));

            CodeMemberMethod method1 = new CodeMemberMethod();
            method1.Name = "Method1";
            method1.Attributes = (method1.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;

            CodeMemberMethod method2 = new CodeMemberMethod();
            method2.Name = "Method2";
            method2.Attributes = (method2.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
            method2.Comments.Add(new CodeCommentStatement("Method 2 Comment"));

            cd.Members.Add(method1);
            cd.Members.Add(method2);

            CodeMemberField field1 = new CodeMemberField(typeof(string), "field1");
            CodeMemberProperty cp = new CodeMemberProperty();
            cp.Name = "StringProperty";
            cp.Type = new CodeTypeReference("System.String");
            cp.Attributes = (cp.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
            cp.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), nameof(field1))));
            cd.Members.Add(cp);
            cd.Members.Add(field1);
            field1.Comments.Add(new CodeCommentStatement("Field 1 Comment"));

            CodeSnippetStatement snippet1 = new CodeSnippetStatement();
            snippet1.Value = "            Console.WriteLine(field1);";

            // CodeStatement example
            CodeConstructor constructor1 = new CodeConstructor();
            constructor1.Attributes = (constructor1.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
           
            method2.Statements.Add(snippet1);
        }

        public CodeMemberMethod CreateMethod(string methodName)
        {
            var codeMemberMethod = new CodeMemberMethod();
            codeMemberMethod.Name = methodName;
            codeMemberMethod.Attributes = MemberAttributes.Public;
            codeMemberMethod.ReturnType = new CodeTypeReference(typeof(bool));
            var parameter = new CodeParameterDeclarationExpression();
            codeMemberMethod.Comments.Add(new CodeCommentStatement(new CodeComment("New Comments")));
            parameter.Name = "userName";
            parameter.Type = new CodeTypeReference(typeof(int));
            codeMemberMethod.Parameters.Add(parameter);

            return codeMemberMethod;
        }

        public void AddProperty(CodeTypeDeclaration targetClass)
        {
            // Declares a property of type String named StringProperty.
            CodeMemberProperty property1 = new CodeMemberProperty();
            property1.Name = "StringProperty";
            property1.Type = new CodeTypeReference("System.String");
            property1.Attributes = MemberAttributes.Public;
            property1.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "testStringField")));
            property1.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "testStringField"), new CodePropertySetValueReferenceExpression()));
            targetClass.Members.Add(targetClass);
        }
    }
}
