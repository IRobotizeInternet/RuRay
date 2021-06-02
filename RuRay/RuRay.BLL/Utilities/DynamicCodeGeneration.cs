using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="DynamicCodeGeneration" />.
    /// </summary>
    public class DynamicCodeGeneration
    {
        /// <summary>
        /// The GenerateClassCode.
        /// </summary>
        /// <param name="classDefination">The classDefination<see cref="ClassDefinationDTO"/>.</param>
        public void GenerateClassCode(ClassDefinationDTO classDefination)
        {
            var compileUnit = CreateClassGraph(classDefination);
            GenerateClassFile(compileUnit, "cs", $"{classDefination.ClassDefination.Name}.cs");
        }

        /// <summary>
        /// The GenerateClassFile.
        /// </summary>
        /// <param name="cu">The cu<see cref="CodeCompileUnit"/>.</param>
        /// <param name="providerName">The providerName<see cref="string"/>.</param>
        /// <param name="sourceFileName">The sourceFileName<see cref="string"/>.</param>
        public void GenerateClassFile(CodeCompileUnit cu, string providerName, string sourceFileName)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider(providerName);
            StringWriter sw = new StringWriter();
            sourceFileName = $@"C:\Dev\RuRay\RuRayFacebook\Services\RuRayAPIs\{sourceFileName}";
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
        /// <summary>
        /// The CreateClassGraph.
        /// </summary>
        /// <param name="classDefination">The classDefination<see cref="ClassDefinationDTO"/>.</param>
        /// <returns>The <see cref="CodeCompileUnit"/>.</returns>
        public CodeCompileUnit CreateClassGraph(ClassDefinationDTO classDefination)
        {
            CodeCompileUnit cu = new CodeCompileUnit();
            CodeNamespace ns = new CodeNamespace(classDefination.NameSpace.Name);

            foreach (var directive in classDefination?.Directives)
            {
                ns.Imports.Add(new CodeNamespaceImport(directive));
            }

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

        /// <summary>
        /// The AddComment.
        /// </summary>
        /// <param name="codeCommentStatementCollection">The codeCommentStatementCollection<see cref="CodeCommentStatementCollection"/>.</param>
        /// <param name="comments">The comments<see cref="IEnumerable{string}"/>.</param>
        public void AddComment(CodeCommentStatementCollection codeCommentStatementCollection, IEnumerable<string> comments)
        {
            codeCommentStatementCollection.Add(new CodeCommentStatement("<summary>", true));
            foreach (var comment in comments)
            {
                codeCommentStatementCollection.Add(new CodeCommentStatement(comment, true));
            }

            codeCommentStatementCollection.Add(new CodeCommentStatement("</summary>", true));
        }

        /// <summary>
        /// The AddMethods.
        /// </summary>
        /// <param name="cd">The cd<see cref="CodeTypeDeclaration"/>.</param>
        /// <param name="methods">The methods<see cref="IEnumerable{Defiantion}"/>.</param>
        public void AddMethods(CodeTypeDeclaration cd, IEnumerable<Defiantion> methods)
        {
            foreach (var method in methods)
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
                CodeSnippetStatement snippet1 = new CodeSnippetStatement
                {
                    Value = "            Console.WriteLine(field1);"
                };
                codeMemberMethod.Statements.Add(snippet1);
                cd.Members.Add(codeMemberMethod);
            }
        }

        /// <summary>
        /// The AddCodeMembers.
        /// </summary>
        public void AddCodeMembers()
        {
        }

        /// <summary>
        /// The AddProperty.
        /// </summary>
        /// <param name="targetClass">The targetClass<see cref="CodeTypeDeclaration"/>.</param>
        public void AddProperty(CodeTypeDeclaration targetClass)
        {
            CodeMemberField field1 = new CodeMemberField(typeof(string), "field1");
            CodeMemberProperty cp = new CodeMemberProperty
            {
                Name = "StringProperty",
                Type = new CodeTypeReference("System.String")
            };
            cp.Attributes = (cp.Attributes & ~MemberAttributes.AccessMask) | MemberAttributes.Public;
            cp.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), nameof(field1))));
            cp.SetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), nameof(field1))));
            targetClass.Members.Add(cp);
            targetClass.Members.Add(field1);
            field1.Comments.Add(new CodeCommentStatement("Field 1 Comment"));
        }
    }
}
