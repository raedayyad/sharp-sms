#region Copyright & License

//
// Copyright 2001-2005 The Apache Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#endregion

using log4net.Core;

namespace log4net.Layout.Pattern {
  /// <summary>
  /// Converter for logger name
  /// </summary>
  /// <remarks>
  /// <para>
  /// Outputs the <see cref="LoggingEvent.LoggerName"/> of the event.
  /// </para>
  /// </remarks>
  /// <author>Nicko Cadell</author>
  sealed class LoggerPatternConverter : NamedPatternConverter {
    /// <summary>
    /// Gets the fully qualified name of the logger
    /// </summary>
    /// <param name="loggingEvent">the event being logged</param>
    /// <returns>The fully qualified logger name</returns>
    /// <remarks>
    /// <para>
    /// Returns the <see cref="LoggingEvent.LoggerName"/> of the <paramref name="loggingEvent"/>.
    /// </para>
    /// </remarks>
    protected override string GetFullyQualifiedName(LoggingEvent loggingEvent) {
      return loggingEvent.LoggerName;
    }
  }
}