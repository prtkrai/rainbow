#pragma checksum "G:\study\C#实验\初期\rainbow\rainbow-site\Views\Home\Doc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8de11d0a5abf9d5a937dfe1f8079e71e8ab1237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Doc), @"mvc.1.0.view", @"/Views/Home/Doc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Doc.cshtml", typeof(AspNetCore.Views_Home_Doc))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\study\C#实验\初期\rainbow\rainbow-site\Views\_ViewImports.cshtml"
using rainbow_site;

#line default
#line hidden
#line 2 "G:\study\C#实验\初期\rainbow\rainbow-site\Views\_ViewImports.cshtml"
using rainbow_site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8de11d0a5abf9d5a937dfe1f8079e71e8ab1237", @"/Views/Home/Doc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e273881fbdbc920e6feb1dd8f878c25eaee8a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Doc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\study\C#实验\初期\rainbow\rainbow-site\Views\Home\Doc.cshtml"
  
ViewData["Title"] = "Rainbow - 关于";

#line default
#line hidden
            BeginContext(44, 5443, true);
            WriteLiteral(@"
<div class=""text-center v-top"">
    <div class=""h2"">
        <p class=""h3 text-white"" id=""subtitle"">
        </p>
    </div>
</div>


<div class=""py-5"" id=""board"">
    <div class=""post-content mx-auto"" id=""post"">
        <article class=""markdown-body"">
            <h2 id=""介绍""><a href=""#介绍"" class=""headerlink"" title=""介绍""></a>Rainbow - 一朵彩虹</h2>
            <p>Rainbow - 一朵彩虹是 <code>EatRiceTeam</code>建立的一个旨在收集优美英语句子的一套网站。</p>
            <p>我们希望能够与大家分享我们在日常的学习生活中遇到的优美的英语句子，希望它能像彩虹一样，美丽天空，温暖人心。</p>
            <p>其由<code>C#</code>开发，基于<code>ASP.NET Core 2.2</code>框架。包括<code>Web API</code>提供导出<code>JSON</code>的数据接口，和基于<code>MVC</code>的动态展示网站。
            </p>
            <h2 id=""关于Rainbow""><a href=""#关于Rainbow"" class=""headerlink"" title=""关于Rainbow""></a>关于Rainbow
            </h2>
            <p>Rainbow 收集的英语句子的要求为：</p>
            <ol>
                <li>读起来感觉很优美的文章句子段落或诗歌节选；</li>
                <li>含义特别丰富且引人深思的鸡汤或哲学句子；</li>
                <li>句子奇怪，但意义完整且显得很有个性的电影台词；</li>
                <");
            WriteLiteral(@"li>你特别喜欢，且引起你感情上共鸣的英语歌词。</li>
            </ol>
            <p>Rainbow 创建的初衷是替代我们的个人网站目前正在使用的 一言
                ，我们希望自己能够自己定义一句话的意思和表现形式。目前句子库不是特别丰富，收集的资源有限，所以欢迎大家投稿，并发表自己的看法。</p>
            <h2 id=""给Rainbow投稿""><a href=""#给Rainbow投稿"" class=""headerlink"" title=""给Rainbow投稿""></a>给Rainbow投稿</h2>
            <p>我们希望找到小伙伴们和我们一起充实我们的句子库，希望大家能够将自己珍藏的句子分享给我们：</p>
            <p><strong>投稿要求</strong>：</p>
            <ol>
                <li>提供完整的句子</li>
                <li>提供句子的作者</li>
                <li>提供句子的来源，如书名、文章名、电影名、歌曲名等。</li>
            </ol>
            <p>投稿方式：</p>
            <ol>
                <li>
                    <p><a href=""mailto:qiqi@eatrice.top"">EatRice的邮箱：qiqi@eatrice.top</a></p>
                </li>
                <li>
                    <p><a href=""dipper.ruru@gmail.com"">Courir的邮箱：dipper.ruru@gmail.com</a></p>
                </li>
                <li>
                    <p>在本页下方留言</p>
                </li>
                <li>好友QQ或微信直接发送</li>
            </ol>");
            WriteLiteral(@"
            <h2 id=""使用方法""><a href=""#使用方法"" class=""headerlink"" title=""使用方法""></a>使用方法</h2>
            <h3 id=""数据接口""><a href=""#数据接口"" class=""headerlink"" title=""数据接口""></a>数据接口</h3>
            <p>目前语句库饱含了三种类型的语句：reading、movies、songs</p>
            <p>需要从语句库中随机获得语句的<code>Json</code>格式的接口：<code>https://api.eatrice.top/</code></p>
            <p>需要按照三个单独分类请求语句的接口：<br><code>https://api.eatrice.top/reading/</code><br><code>https://api.eatrice.top/movies/</code><br><code>https://api.eatrice.top/songs/</code>
            </p>
            <p>需要根据语句ID请求语句的接口：<code>https://api.eatrice.top/?ID=1001</code><br>ID编号从1001开始增加，若该ID不存在则随机返回语句，同<code>https://api.eatrice.top/</code>
            </p>
            <p>返回的数据格式如下：<br>
            <div class=""hljs"">
                <pre><code class=""hljs json"">&#123;
    <span class=""hljs-attr"">""Content""</span>: <span class=""hljs-string"">""Because I am your mom,It counts the most because I know you the most.""</span>,
    <span class=""hljs-attr"">""Author""</span>: <span class=""hl");
            WriteLiteral(@"js-string"">""Stephen Chbosky""</span>,
    <span class=""hljs-attr"">""Source""</span>: <span class=""hljs-string"">""Wonder""</span>,
    <span class=""hljs-attr"">""ID""</span>: <span class=""hljs-string"">""1009""</span>
&#125;</code></pre>
            </div>
            <br>其中，<code>Content</code>为句子内容<br><code>Author</code>为句子作者<br><code>Source</code>为句子来源<br><code>ID</code>为句子ID
            </p>
            <h3 id=""展示网站""><a href=""#展示网站"" class=""headerlink"" title=""展示网站""></a>展示网站</h3>
            <p>Rainbow的展示网站为：<a href=""https://rainbow.eatrice.top/"" target=""_blank""
                    rel=""noopener"">https://rainbow.eatrice.top/</a><br>欢迎大家访问和提供意见😊😊😊。</p>
            <p><img src=""1.png"" srcset=""https://eatrice.top/post/Rainbow/1.png"" alt=""""></p>
            <h2 id=""贡献者""><a href=""#贡献者"" class=""headerlink"" title=""贡献者""></a>贡献者</h2>
            <br />
            <p>
                <a href=""https://eatrice.top"">EatRice-https://eatrice.top</a>
                <br />
                <br />
                <a ");
            WriteLiteral(@"href=""https://ruru.eatrice.top"" target=""_blank"" rel=""noopener"">上屋顶看北斗七星-https://ruru.eatrice.top</a>
            </p>

        </article>
        <div class=""comments"" id=""comments"">
            <div id=""vcomments""></div>
            <script src=""https://cdn.staticfile.org/valine/1.4.4/Valine.min.js""></script>
            <script type=""text/javascript"">
                console.log('评论正在加载...');
                new Valine({
                    el: ""#vcomments"",
                    app_id: ""ut4YhjXKhs59W7h1ljDfgOAG-gzGzoHsz"",
                    app_key: ""dzKTc4w4K1maxEg8E5243rrH"",
                    placeholder: ""休伯利安号在等待接收你的信号哟^0^\n(支持MarkDown语法)"",
                    path: window.location.pathname,
                    avatar: ""retro"",
                    meta: [""nick"", ""mail"", ""link""],
                    pageSize: ""10"",
                    lang: ""zh-CN"",
                    highlight: true,
                    recordIP: true,
                    serverURLs: """",
                });
  ");
            WriteLiteral(@"              console.log('评论加载完成');
            </script>
            <noscript>Please enable JavaScript to view the <a href=""https://valine.js.org"" target=""_blank""
                    rel=""nofollow noopener noopener"">comments
                    powered by Valine.</a></noscript>

        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
