using StronglyTypedId.Utilities;

namespace StronglyTypedId.Extensions;

public static class SourceBuilderExtensions
{
    public static void AddCodeBlock(this SourceBuilder sourceBuilder, Action<SourceBuilder> codeBlockFactory)
    {
        sourceBuilder.AppendLine("{");
        sourceBuilder.AddIndent();
        codeBlockFactory.Invoke(sourceBuilder);
        sourceBuilder.RemoveIndent();
        sourceBuilder.AppendLine("}");
    }
}