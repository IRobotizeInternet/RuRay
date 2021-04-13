using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RobotizeFacebook.Utilities
{
    public class DynamicCodeGeneration
    {
        public void GenerateClassCode(ClassDefinationDTO classDefination)
        {
            var compileUnit = CreateClassGraph(classDefination);
            GenerateClassFile(compileUnit, "cs", $"{classDefination.ClassDefination.Name}.cs");
        }

        public void GenerateClassFile(CodeCompileUnit cu, string providerName, string sourceFileName)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider(providerName);
            StringWriter sw = new StringWriter();
            sourceFileName = $@"C:\Dev\Robotize\RobotizeFacebook\Services\RobotizeAPIs\{sourceFileName}";
            Console.WriteLine("Generating code...");
            provider.GenerateCodeFromCompileUnit(cu, sw, null);

            string output = sw.ToString();
            output = Regex.Replace(output, "Runtime Version:[^\r\n]*",
                "Runtime Version omitted for demo");

            Console.WriteLine("Dumping source code...");
            Console.WriteLine(output);
            Console.WriteLine("Writing source code to file...");
            Stream s = File.Open(sourceFileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter t = new StreamWriter(s);
            t.Write(output);
            t.Close();
            s.Close();
        }

        // Create a CodeDOM graph.
        public CodeCompileUnit CreateClassGraph(ClassDefinationDTO classDefination)
        {
            CodeCompileUnit cu = new CodeCompileUnit();
            CodeNamespace ns = new CodeNamespace(classDefination.NameSpace.Name);

            foreach(var directive in classDefination?.Directives) ns.Imports.Add(new CodeNamespaceImport(directive));
            AddComment(ns.Comments, classDefination.NameSpace.Comments);

            cu.Namespaces.Add(ns);
            
            CodeTypeDeclaration cd = new CodeTypeDeclaration(classDefination.ClassDefination.Name);
            AddComment(cd.Comments, classDefination.ClassDefination.Comments);

            ns.Types.Add(cd);

            AddMethods(cd, classDefination.Methods);
            
            //AddProperty(cd);

            // CodeStatement example
            CodeConstructor constructor1 = new CodeConstructor();
            constructor1.Attributes = (constructor1.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;

            return cu;
        }

        public void AddComment(CodeCommentStatementCollection codeCommentStatementCollection, IEnumerable<string> comments)
        {
            codeCommentStatementCollection.Add(new CodeCommentStatement("<summary>", true));
            foreach (var comment in comments) codeCommentStatementCollection.Add(new CodeCommentStatement(comment, true));
            codeCommentStatementCollection.Add(new CodeCommentStatement("</summary>", true));
        }

        public void AddMethods(CodeTypeDeclaration cd, IEnumerable<Defiantion> methods)
        {
            foreach(var method in methods)
            {
                var codeMemberMethod = new CodeMemberMethod();

                AddComment(codeMemberMethod.Comments, method.Comments);

                codeMemberMethod.Name = method.Name;
                codeMemberMethod.Attributes = (codeMemberMethod.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public; ;
                codeMemberMethod.ReturnType = new CodeTypeReference(typeof(bool));
                var parameter = new CodeParameterDeclarationExpression();
                codeMemberMethod.Comments.Add(new CodeCommentStatement(new CodeComment("New Comments")));
                parameter.Name = "userName";
                parameter.Type = new CodeTypeReference(typeof(int));
                codeMemberMethod.Parameters.Add(parameter);
                CodeSnippetStatement snippet1 = new CodeSnippetStatement();
                snippet1.Value = "            Console.WriteLine(field1);";
                codeMemberMethod.Statements.Add(snippet1);
                cd.Members.Add(codeMemberMethod);
            }
        }

        public void AddCodeMembers()
        {

        }

        public void AddProperty(CodeTypeDeclaration targetClass)
        {
            CodeMemberField field1 = new CodeMemberField(typeof(string), "field1");
            CodeMemberProperty cp = new CodeMemberProperty();
            cp.Name = "StringProperty";
            cp.Type = new CodeTypeReference("System.String");
            cp.Attributes = (cp.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
            cp.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), nameof(field1))));
            cp.SetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), nameof(field1))));
            targetClass.Members.Add(cp);
            targetClass.Members.Add(field1);
            field1.Comments.Add(new CodeCommentStatement("Field 1 Comment"));
        }
    }
}
