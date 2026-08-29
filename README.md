[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.column/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.column/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.column.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.column/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.column/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.column/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Column

Attribute for defining DataTables column configuration metadata on properties or classes. This allows customization of column behavior, rendering, visibility, sorting, and more.

## Install

```bash
dotnet add package Soenneker.DataTables.Attributes.Column
```

## Quick start

```csharp
using Soenneker.DataTables.Attributes.Column;

public sealed class Request
{
    [DataTableColumn]
    public string? Value { get; init; }
}
```

Attribute for defining DataTables column configuration metadata on properties or classes. This allows customization of column behavior, rendering, visibility, sorting, and more.

## What you get

- `DataTableColumnAttribute` — Attribute for defining DataTables column configuration metadata on properties or classes. This allows customization of column behavior, rendering, visibility, sorting, and more.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DataTableColumnAttribute.AriaTitle` | Sets the ARIA label for the column header, used for accessibility purposes. | Sets the ARIA label for the column header, used for accessibility purposes. |
| `DataTableColumnAttribute.CellType` | Specifies the HTML cell type to be created for this column (e.g., "td", "th"). | Specifies the HTML cell type to be created for this column (e.g., "td", "th"). |
| `DataTableColumnAttribute.ClassName` | A CSS class or space-separated list of classes to assign to each cell in the column. | A CSS class or space-separated list of classes to assign to each cell in the column. |
| `DataTableColumnAttribute.ContentPadding` | Additional padding to add to the text content when calculating optimal column width. | Additional padding to add to the text content when calculating optimal column width. |
| `DataTableColumnAttribute.DefaultContent` | Default static content to render in this column when no data is available. | Default static content to render in this column when no data is available. |
| `DataTableColumnAttribute.Footer` | Sets the footer text content for this column. | Sets the footer text content for this column. |
| `DataTableColumnAttribute.Name` | A name used for identifying the column programmatically (e.g., in column visibility APIs). | A name used for identifying the column programmatically (e.g., in column visibility APIs). |
| `DataTableColumnAttribute.Orderable` | Determines whether sorting is enabled on this column. | Determines whether sorting is enabled on this column. |
| `DataTableColumnAttribute.OrderData` | Specifies other columns to sort alongside this one. Can be an integer index or an array of indices. | Specifies other columns to sort alongside this one. Can be an integer index or an array of indices. |
| `DataTableColumnAttribute.OrderDataType` | Defines a custom sort data type for the column (e.g., "dom-text", "dom-checkbox"). | Defines a custom sort data type for the column (e.g., "dom-text", "dom-checkbox"). |
| `DataTableColumnAttribute.OrderSequence` | A sequence of sorting directions (e.g., ["asc", "desc"]) to apply in order when sorting this column. | A sequence of sorting directions (e.g., ["asc", "desc"]) to apply in order when sorting this column. |
| `DataTableColumnAttribute.Searchable` | Determines whether this column can be searched using the global search box. | Determines whether this column can be searched using the global search box. |
| `DataTableColumnAttribute.Title` | Sets the column title displayed in the table header. | Sets the column title displayed in the table header. |
| `DataTableColumnAttribute.Type` | Sets the column's internal data type (used for filtering and sorting logic). | Sets the column's internal data type (used for filtering and sorting logic). |
| `DataTableColumnAttribute.Visible` | Indicates whether this column is visible in the table. | Indicates whether this column is visible in the table. |
| `DataTableColumnAttribute.Width` | Sets the fixed width for this column (e.g., "100px", "10%"). | Sets the fixed width for this column (e.g., "100px", "10%"). |
| `DataTableColumnAttribute.Data` | Specifies the data source for the column. Can be a property path (e.g., "user.email") or a static value. | Specifies the data source for the column. Can be a property path (e.g., "user.email") or a static value. |
| `DataTableColumnAttribute.ResponsivePriority` | Defines the priority for column visibility when using the DataTables Responsive extension. Lower values have higher priority and are shown first on smaller screens. Columns with higher values will be hidden first as screen space becomes limited. | Defines the priority for column visibility when using the DataTables Responsive extension. Lower values have higher priority and are shown first on smaller screens. Columns with higher values will be hidden first as screen space becomes limited. |
