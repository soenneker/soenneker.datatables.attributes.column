[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.column/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.column/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.column/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.column/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Column

`DataTableColumnAttribute` attaches DataTables column metadata to properties so a table-building layer can discover it through reflection.

## Installation

```bash
dotnet add package Soenneker.DataTables.Attributes.Column
```

## Usage

```csharp
using Soenneker.DataTables.Attributes.Column;

public sealed class CustomerRow
{
    [DataTableColumn(
        Title = "Customer",
        Data = "name",
        Name = "name",
        Searchable = true,
        Orderable = true,
        ResponsivePriority = 1,
        Order = 0)]
    public required string Name { get; init; }

    [DataTableColumn(
        Title = "Email",
        Data = "contact.email",
        DefaultContent = "—",
        ClassName = "text-nowrap",
        Width = "18rem",
        Order = 1)]
    public string? Email { get; init; }

    [DataTableColumn(Visible = false, Order = 2)]
    public Guid Id { get; init; }
}
```

Read the metadata from a property with normal reflection:

```csharp
using System.Reflection;

PropertyInfo property = typeof(CustomerRow).GetProperty(nameof(CustomerRow.Name))!;
DataTableColumnAttribute? column = property.GetCustomAttribute<DataTableColumnAttribute>();
```

The package stores configuration only. Your application or a companion table builder must translate the attribute into the JavaScript DataTables column definition.

## Defaults and conventions

- `Visible` defaults to `true`.
- `Searchable` and `Orderable` default to `false`; opt in explicitly.
- `Order` and `ResponsivePriority` default to `-1`, which is useful as an “unspecified” sentinel in the consuming mapper.
- `Data` and `OrderData` are `object` because DataTables accepts more than one value shape. Attribute arguments are restricted by the CLR, so use strings, numeric values, or arrays that your mapper understands.
- Property names and nested data paths are not validated by this package.
