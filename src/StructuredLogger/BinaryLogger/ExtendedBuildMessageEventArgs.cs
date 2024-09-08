﻿namespace Microsoft.Build.Framework;

/// <summary>
/// Generic custom build events including extended data for event enriching.
/// Extended data are implemented by <see cref="IExtendedBuildEventArgs"/>
/// </summary>
public sealed class ExtendedBuildMessageEventArgs : BuildMessageEventArgs, IExtendedBuildEventArgs
{
    /// <inheritdoc />
    public string ExtendedType { get; set; }

    /// <inheritdoc />
    public IDictionary<string, string?>? ExtendedMetadata { get; set; }

    /// <inheritdoc />
    public string? ExtendedData { get; set; }

    /// <summary>
    /// Default constructor. Used for deserialization.
    /// </summary>
    internal ExtendedBuildMessageEventArgs() : this("undefined") { }

    /// <summary>
    /// This constructor specifies only type of extended data.
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    public ExtendedBuildMessageEventArgs(string type) => ExtendedType = type;

    /// <summary>
    /// This constructor allows all event data to be initialized
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    public ExtendedBuildMessageEventArgs(string type, string? message, string? helpKeyword, string? senderName, MessageImportance importance)
        : base(message, helpKeyword, senderName, importance) => ExtendedType = type;

    /// <summary>
    /// This constructor allows a timestamp to be set
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    /// <param name="eventTimestamp">Timestamp when event was created</param>
    public ExtendedBuildMessageEventArgs(string type, string? message, string? helpKeyword, string? senderName, MessageImportance importance, DateTime eventTimestamp)
        : base(message, helpKeyword, senderName, importance, eventTimestamp) => ExtendedType = type;

    /// <summary>
    /// This constructor allows a timestamp to be set
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    /// <param name="eventTimestamp">Timestamp when event was created</param>
    /// <param name="messageArgs">message arguments</param>
    public ExtendedBuildMessageEventArgs(string type, string? message, string? helpKeyword, string? senderName, MessageImportance importance, DateTime eventTimestamp, params object[]? messageArgs)
        : base(message, helpKeyword, senderName, importance, eventTimestamp, messageArgs) => ExtendedType = type;

    /// <summary>
    /// This constructor allows all event data to be initialized
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="subcategory">event sub-category</param>
    /// <param name="code">event code</param>
    /// <param name="file">file associated with the event</param>
    /// <param name="lineNumber">line number (0 if not applicable)</param>
    /// <param name="columnNumber">column number (0 if not applicable)</param>
    /// <param name="endLineNumber">end line number (0 if not applicable)</param>
    /// <param name="endColumnNumber">end column number (0 if not applicable)</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    public ExtendedBuildMessageEventArgs(string type, string? subcategory, string? code, string? file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber,
        string? message, string? helpKeyword, string? senderName, MessageImportance importance)
        : base(subcategory, code, file, lineNumber, columnNumber, endLineNumber, endColumnNumber, message, helpKeyword, senderName, importance) => ExtendedType = type;

    /// <summary>
    /// This constructor which allows a timestamp to be set
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="subcategory">event sub-category</param>
    /// <param name="code">event code</param>
    /// <param name="file">file associated with the event</param>
    /// <param name="lineNumber">line number (0 if not applicable)</param>
    /// <param name="columnNumber">column number (0 if not applicable)</param>
    /// <param name="endLineNumber">end line number (0 if not applicable)</param>
    /// <param name="endColumnNumber">end column number (0 if not applicable)</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    /// <param name="eventTimestamp">Timestamp when event was created</param>
    public ExtendedBuildMessageEventArgs(string type, string? subcategory, string? code, string? file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber,
        string? message, string? helpKeyword, string? senderName, MessageImportance importance, DateTime eventTimestamp)
        : base(subcategory, code, file, lineNumber, columnNumber, endLineNumber, endColumnNumber, message, helpKeyword, senderName, importance, eventTimestamp) => ExtendedType = type;

    /// <summary>
    /// This constructor which allows a timestamp to be set
    /// </summary>
    /// <param name="type">Type of <see cref="IExtendedBuildEventArgs.ExtendedType"/>.</param>
    /// <param name="subcategory">event sub-category</param>
    /// <param name="code">event code</param>
    /// <param name="file">file associated with the event</param>
    /// <param name="lineNumber">line number (0 if not applicable)</param>
    /// <param name="columnNumber">column number (0 if not applicable)</param>
    /// <param name="endLineNumber">end line number (0 if not applicable)</param>
    /// <param name="endColumnNumber">end column number (0 if not applicable)</param>
    /// <param name="message">text message</param>
    /// <param name="helpKeyword">help keyword </param>
    /// <param name="senderName">name of event sender</param>
    /// <param name="importance">importance of the message</param>
    /// <param name="eventTimestamp">Timestamp when event was created</param>
    /// <param name="messageArgs">message arguments</param>
    public ExtendedBuildMessageEventArgs(string type, string? subcategory, string? code, string? file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber,
        string? message, string? helpKeyword, string? senderName, MessageImportance importance, DateTime eventTimestamp, params object[]? messageArgs)
        : base(subcategory, code, file, lineNumber, columnNumber, endLineNumber, endColumnNumber, message, helpKeyword, senderName, importance, eventTimestamp, messageArgs) => ExtendedType = type;
}
