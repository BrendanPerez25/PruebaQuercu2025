using Abp.Collections.Extensions;
using Abp.Extensions;
using Abp.Timing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace PruebaQuercu.Web.Resources;

public class WebResourceManager : IWebResourceManager
{
    private readonly IWebHostEnvironment _environment;
    private readonly List<string> _scriptUrls;

    public WebResourceManager(IWebHostEnvironment environment)
    {
        _environment = environment;
        _scriptUrls = new List<string>();
    }

    public void AddScript(string url, bool addMinifiedOnProd = true)
    {
        _scriptUrls.AddIfNotContains(NormalizeUrl(url, "js"));
    }

    public IReadOnlyList<string> GetScripts()
    {
        return _scriptUrls.ToImmutableList();
    }

    public HelperResult RenderScripts()
    {
        return new HelperResult(async writer =>
        {
            foreach (var scriptUrl in _scriptUrls)
            {
                await writer.WriteAsync($"<script src=\"{scriptUrl}?v=" + Clock.Now.Ticks + "\"></script>");
            }
        });
    }

    private string NormalizeUrl(string url, string ext)
    {
        if (_environment.IsDevelopment())
        {
            return url;
        }

        if (url.EndsWith(".min." + ext))
        {
            return url;
        }

        return url.Left(url.Length - ext.Length) + "min." + ext;
    }
}
