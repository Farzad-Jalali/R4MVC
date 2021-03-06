using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

// Use this file to add custom extensions and helper methods to R4Mvc in your project
internal class R4MvcExtensions
{
    public static string AppendGuid(string virtualPath)
    {
        virtualPath += virtualPath.Contains("?")
            ? "&_v=" + Guid.NewGuid()
            : "?_v=" + Guid.NewGuid();
        return virtualPath;
    }
}
