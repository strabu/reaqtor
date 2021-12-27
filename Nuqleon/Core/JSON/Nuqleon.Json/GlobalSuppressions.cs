// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT License.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "~N:System.Collections.Generic")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "~N:Nuqleon.Json.Serialization")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "~N:Nuqleon.Json.Parser")]
[assembly: SuppressMessage("Performance", "CA1846:Prefer 'AsSpan' over 'Substring'", Justification = "<Pending>", Scope = "member", Target = "~M:Nuqleon.Json.Parser.Tokenizer.Tokenize(System.Boolean)~System.Collections.Generic.IEnumerator{Nuqleon.Json.Parser.Token}")]
