using System;
using System.Collections.Generic;

namespace Soenneker.DataTables.Attributes.Column;

/// <summary>
/// Attribute for defining DataTables column configuration metadata on properties or classes.
/// This allows customization of column behavior, rendering, visibility, sorting, and more.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class DataTableColumnAttribute : Attribute
{
    /// <summary>
    /// Sets the ARIA label for the column header, used for accessibility purposes.
    /// </summary>
    public string? AriaTitle { get; set; }

    /// <summary>
    /// Specifies the HTML cell type to be created for this column (e.g., "td", "th").
    /// </summary>
    public string? CellType { get; set; }

    /// <summary>
    /// A CSS class or space-separated list of classes to assign to each cell in the column.
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    /// Additional padding to add to the text content when calculating optimal column width.
    /// </summary>
    public string? ContentPadding { get; set; }

    /// <summary>
    /// Default static content to render in this column when no data is available.
    /// </summary>
    public string? DefaultContent { get; set; }

    /// <summary>
    /// Sets the footer text content for this column.
    /// </summary>
    public string? Footer { get; set; }

    /// <summary>
    /// A name used for identifying the column programmatically (e.g., in column visibility APIs).
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Determines whether sorting is enabled on this column.
    /// </summary>
    public bool? Orderable { get; set; }

    /// <summary>
    /// Specifies other columns to sort alongside this one. Can be an integer index or an array of indices.
    /// </summary>
    public object? OrderData { get; set; }

    /// <summary>
    /// Defines a custom sort data type for the column (e.g., "dom-text", "dom-checkbox").
    /// </summary>
    public string? OrderDataType { get; set; }

    /// <summary>
    /// A sequence of sorting directions (e.g., ["asc", "desc"]) to apply in order when sorting this column.
    /// </summary>
    public List<string>? OrderSequence { get; set; }

    /// <summary>
    /// Determines whether this column can be searched using the global search box.
    /// </summary>
    public bool? Searchable { get; set; }

    /// <summary>
    /// Sets the column title displayed in the table header.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Sets the column's internal data type (used for filtering and sorting logic).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Indicates whether this column is visible in the table.
    /// </summary>
    public bool? Visible { get; set; }

    /// <summary>
    /// Sets the fixed width for this column (e.g., "100px", "10%").
    /// </summary>
    public string? Width { get; set; }

    /// <summary>
    /// Specifies the data source for the column.
    /// Can be a property path (e.g., "user.email") or a static value.
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Defines the priority for column visibility when using the DataTables Responsive extension.
    /// Lower values have higher priority and are shown first on smaller screens. Columns with higher
    /// values will be hidden first as screen space becomes limited.
    /// </summary>
    public int? ResponsivePriority { get; set; }

    /// <summary>
    /// Specifies the display order of the column in the table.
    /// Columns with lower values appear earlier. If null, default ordering is used.
    /// </summary>
    public int? Order { get; set; }
}