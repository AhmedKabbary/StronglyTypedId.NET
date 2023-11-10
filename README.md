# StronglyTypedId

Strongly Typed Ids (ULID) for C#.

> This project uses Roslyn source generators.

Supports System.Text.Json and MongoDB.Bson serialization.

## Usage

Define a partial struct with the StronglyTypedId attribute.
```csharp
using StronglyTypedId.Attributes;

[StronglyTypedId]
public partial struct UserId
{
}
```

Then the source generator will generate another partial struct and the required serializers for it.