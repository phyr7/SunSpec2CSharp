using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using IctBaden.Framework.Types;

namespace Smdx2CSharp
{
    public class ClassGenerator
    {
        private readonly string _outputPath;
        private readonly IEnumerable<XmlNode> _data;
        private readonly IEnumerable<XmlNode> _descriptions;
        private readonly StringBuilder _codeText;

        public ClassGenerator(string outputPath, IEnumerable<XmlNode> data)
        {
            _outputPath = outputPath;
            _data = data;
            _codeText = new StringBuilder();
            _descriptions = _data.First(n => n.Name == "strings")
                .ChildNodes
                .Cast<XmlNode>();
        }
        
        public void CreateModelClass()
        {
            var model = _data.First(n => n.Name == "model");
            if(model == null) return;

            var name = model.Attributes["name"]?.InnerText;

            if (string.IsNullOrEmpty(name))
            {
                var comment = _data
                    .FirstOrDefault(n => n.GetType() == typeof(XmlComment))
                    ?.InnerText;
                var getName = new Regex(@" *\d+\: *(.*) *").Match(comment);
                if (getName.Success)
                {
                    name = getName.Groups[1].Value
                        .Trim()
                        .Replace(" ", "_");
                }
            }
            
            var className = NamingConverter.SnakeToPascalCase(name);
            var fileName = Path.Combine(_outputPath, $"{className}.cs");
            CreateClassFile(fileName, className, model);
        }

        private void CreateClassFile(string fileName, string className, XmlNode model)
        {
            var id = UniversalConverter.ConvertTo<long>(model.Attributes["id"].InnerText);
            var length = UniversalConverter.ConvertTo<long>(model.Attributes["len"].InnerText);

            if (className == "Common" && id != 1)
            {
                // Test Model
                return;
            }

            Console.WriteLine($"Generating class {className}");
            
            _codeText.AppendLine($"namespace {GeneratorSettings.Namespace}");
            _codeText.AppendLine("{");
            {
                AddComment("  ", null);
                
                _codeText.AppendLine($"  [SunSpecModel(id: {id}, length: {length})]");
                _codeText.AppendLine($"  public class {className}");
                _codeText.AppendLine("  {");
                {
                    var blocks = model.ChildNodes
                        .Cast<XmlNode>()
                        .Where(n => n.Name == "block")
                        .ToArray();

                    foreach (var block in blocks)
                    {
                        var blockName = block.Attributes["name"]?.InnerText;
                        var blockType = block.Attributes["type"]?.InnerText ?? "fixed";
                        var points = block
                            .ChildNodes
                            .Cast<XmlNode>();

                        if (blockType == "fixed")
                        {
                            AddPoints("    ", points);
                        }
                        else
                        {
                            blockName = NamingConverter.SnakeToPascalCase(blockName);
                            _codeText.AppendLine($"    public struct {blockName}");
                            _codeText.AppendLine("    {");
                            AddPoints("      ", points);
                            _codeText.AppendLine("    }[];");
                        }
                    }

                }
                _codeText.AppendLine("  }");
            }
            _codeText.AppendLine("}");
            File.WriteAllText(fileName, _codeText.ToString());
        }

        private void AddPoints(string indent, IEnumerable<XmlNode> points)
        {
            foreach (XmlNode point in points)
            {
                if(point == null) continue;
                        
                var name = point.Attributes["id"].InnerText;
                var sunSpecType = point.Attributes["type"].InnerText;
                var typeName = SunSpecType.ToSystemType(sunSpecType).Name;

                if (sunSpecType.StartsWith("enum") || sunSpecType.StartsWith("bitfield"))
                {
                    var flags = sunSpecType.StartsWith("bitfield");
                    AddEnum(indent, point, typeName, flags);
                    typeName = "E_" + name;
                }
                
                var offset = UniversalConverter.ConvertTo<long>(point.Attributes["offset"].InnerText);
                var length = UniversalConverter.ConvertTo<long>(point.Attributes["len"]?.InnerText ?? "1");
                var access = point.Attributes["access"]?.InnerText ?? "rw";
                var mandatory = UniversalConverter.ConvertTo<bool>(point.Attributes["mandatory"]?.InnerText) ? "" : "?";
                var units = point.Attributes["units"]?.InnerText;

                if (!string.IsNullOrEmpty(units))
                {
                    _codeText.AppendLine($"{indent}/// [{units}]");
                }
                AddComment(indent, name);
                _codeText.AppendLine($"{indent}[SunSpecProperty(offset: {offset}, length: {length})]");
                _codeText.Append($"{indent}public {typeName}{mandatory} {name} {{ get; ");
                if (access == "r") _codeText.Append("private ");
                _codeText.AppendLine("set; }");
            }
        }
        
        private void AddEnum(string indent, XmlNode point, string typeName, bool flags)
        {
            var name = point.Attributes["id"].InnerText;
            var values = point.ChildNodes.Cast<XmlNode>()
                .Where(n => n.GetType() == typeof(XmlElement))
                .ToArray();

            if (flags)
            {
                _codeText.AppendLine($"{indent}[Flags]");
            }
            _codeText.AppendLine($"{indent}public enum E_{name} : {typeName}");
            _codeText.AppendLine($"{indent}{{");
            
            foreach (var val in values)
            {
                var eName = val.Attributes["id"].InnerText
                    .Replace("-", "_");
                _codeText.AppendLine($"{indent}  {eName} = {val.InnerText},");
            }
            
            _codeText.AppendLine($"{indent}}}");
        }

        private void AddComment(string indent, string? id)
        {
            var infos = _descriptions
                .Where(n => n.GetType() == typeof(XmlElement))
                .FirstOrDefault(n => n.Attributes["id"]?.InnerText == id);
            if (infos == null) return;

            var label = id != null
                ? infos.ChildNodes.Cast<XmlNode>().FirstOrDefault(n => n.Name == "label")?.InnerText
                : "";
            var description = infos.ChildNodes.Cast<XmlNode>().FirstOrDefault(n => n.Name == "description")?.InnerText;
            var notes = infos.ChildNodes.Cast<XmlNode>().FirstOrDefault(n => n.Name == "notes")?.InnerText;

            if(!string.IsNullOrEmpty(label))
            {
                _codeText.AppendLine($"{indent}/// {label} - {description}");
            }
            if (!string.IsNullOrEmpty(description))
            {
                _codeText.AppendLine($"{indent}/// {description}");
            }
            if (!string.IsNullOrEmpty(notes))
            {
                _codeText.AppendLine($"{indent}/// NOTES: {notes}");
            }
        }

        
    }
    
}