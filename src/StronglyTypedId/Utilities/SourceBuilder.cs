using System.Text;

namespace StronglyTypedId.Utilities;

public class SourceBuilder
{
    private int _indentationLevel;
    private readonly StringBuilder _stringBuilder = new();

    public void Append(string value, bool withoutIndentation = false)
    {
        if (withoutIndentation is false)
            _stringBuilder.Append('\t', _indentationLevel);

        _stringBuilder.Append(value);
    }

    public void AppendLine(string value, bool withoutIndentation = false)
    {
        if (withoutIndentation is false)
            _stringBuilder.Append('\t', _indentationLevel);

        _stringBuilder.AppendLine(value);
    }

    public void AppendLine() => _stringBuilder.AppendLine();

    public void AddIndent() => _indentationLevel++;

    public void RemoveIndent() => _indentationLevel--;

    public override string ToString() => _stringBuilder.ToString();
}