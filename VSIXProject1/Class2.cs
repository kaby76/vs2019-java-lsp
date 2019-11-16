﻿using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace VSIXProject1
{
    public class JavaContentDefinition
    {
        [Export]
        [Name("java")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition JavaContentTypeDefinition;

        [Export]
        [FileExtension(".java")]
        [ContentType("java")]
        internal static FileExtensionToContentTypeDefinition JavaFileExtensionDefinition;
    }
}