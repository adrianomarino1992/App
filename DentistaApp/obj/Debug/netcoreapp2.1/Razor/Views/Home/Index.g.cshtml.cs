#pragma checksum "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f0ff5fe99cd5ec451e283fa5760cc999b747eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\_ViewImports.cshtml"
using DentistaApp;

#line default
#line hidden
#line 2 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\_ViewImports.cshtml"
using DentistaApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f0ff5fe99cd5ec451e283fa5760cc999b747eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124660ab9d0bfe0fc6b89c6d2e7e0590eff6058c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 94, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://openlayers.org/en/v4.6.5/css/ol.css\" type=\"text/css\">\r\n\r\n");
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(219, 131, true);
            WriteLiteral("<script src=\"https://cdn.polyfill.io/v2/polyfill.min.js?features=requestAnimationFrame,Element.prototype.classList,URL\"></script>\r\n");
            EndContext();
            BeginContext(366, 372, true);
            WriteLiteral(@"<script src=""https://openlayers.org/en/v4.6.5/build/ol.js""></script>


<div>
    <h2 class=""h2"">Aplicação Escritorio de Dentitas</h2>


    <hr />


    <h4 class=""h4"">Clientes</h4>

    <table class=""table"" style=""background-color : aliceblue;"">
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Cidade</th>
        </tr>

");
            EndContext();
#line 35 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
          

            List<ClienteBuscaResult> clientes = (List<ClienteBuscaResult>)ViewData["Clientes"];
            foreach (ClienteBuscaResult p in clientes)
            {

#line default
#line hidden
            BeginContext(920, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(967, 12, false);
#line 41 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.Cliente.Id);

#line default
#line hidden
            EndContext();
            BeginContext(979, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1011, 14, false);
#line 42 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1057, 12, false);
#line 43 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.CidadeName);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
            }

        

#line default
#line hidden
            BeginContext(1127, 217, true);
            WriteLiteral("    </table>\r\n\r\n\r\n\r\n    <h4 class=\"h4\">Dentistas</h4>\r\n\r\n    <table class=\"table\" style=\"background-color : aliceblue;\">\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Id</th>            \r\n        </tr>\r\n\r\n");
            EndContext();
#line 60 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
          

            List<Dentista> dentistas = (List<Dentista>)ViewData["Dentistas"];
            foreach (Dentista d in dentistas)
            {

#line default
#line hidden
            BeginContext(1499, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1546, 6, false);
#line 66 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(d.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1584, 4, false);
#line 67 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(d.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 50, true);
            WriteLiteral("</td>                    \r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
            }

        

#line default
#line hidden
            BeginContext(1666, 248, true);
            WriteLiteral("    </table>\r\n\r\n    <h4 class=\"h4\">Fornecedores</h4>\r\n\r\n    <table class=\"table\" style=\"background-color : aliceblue;\">\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Cadastro</th>\r\n            <th>Tipo de Produto</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 83 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
          

            List<Fornecedor> fornecedores = (List<Fornecedor>)ViewData["Fornecedores"];
            foreach (Fornecedor f in fornecedores)
            {

#line default
#line hidden
            BeginContext(2084, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2131, 6, false);
#line 89 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(f.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2137, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2169, 10, false);
#line 90 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(f.Cadastro);

#line default
#line hidden
            EndContext();
            BeginContext(2179, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2211, 13, false);
#line 91 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(f.TipoProduto);

#line default
#line hidden
            EndContext();
            BeginContext(2224, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 93 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
            }

        

#line default
#line hidden
            BeginContext(2282, 234, true);
            WriteLiteral("    </table>\r\n\r\n\r\n    <h4 class=\"h4\">Produtos</h4>\r\n\r\n    <table class=\"table\" style=\"background-color : aliceblue;\">\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Tipo</th>\r\n            <th>Estoque</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 108 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
          

            List<Produto> produtos = (List<Produto>)ViewData["Produtos"];
            foreach (Produto p in produtos)
            {

#line default
#line hidden
            BeginContext(2665, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2712, 6, false);
#line 114 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2718, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2750, 6, false);
#line 115 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(2756, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2788, 9, false);
#line 116 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
                   Write(p.Estoque);

#line default
#line hidden
            EndContext();
            BeginContext(2797, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 118 "C:\xamarin\Aspx\DentistaApp\DentistaApp\Views\Home\Index.cshtml"
            }

        

#line default
#line hidden
            BeginContext(2855, 1538, true);
            WriteLiteral(@"    </table>



    <hr />

    <h3 class=""h3"">Estamos Aqui : </h3>
    <p>Avenida Exemplo 123456, Jacareí - Centro </p>

    <div class=""container""
         id=""map""
         style=""height:400px;
         border : 2px solid grey;
         margin-left : -10px;
         "">
    </div>



    <script>
        var map = new ol.Map({
            layers: [
                new ol.layer.Tile({
                    source: new ol.source.OSM()
                })
            ],
            target: 'map',
            view: new ol.View({
                projection: 'EPSG:4326',
                center: [-45.96, -23.3],
                zoom: 5,
                minZoom: 5,
                maxZoom: 15
            })
        });


        var iconFeature = new ol.Feature({
            geometry: new ol.geom.Point([-45.96, -23.3]),
            name: 'Yellow Tooth'
        });

        var iconStyle = new ol.style.Style({
            image: new ol.style.Icon(({
                anchor: [0");
            WriteLiteral(@".5, 46],
                anchorXUnits: 'fraction',
                anchorYUnits: 'pixels',
                src: 'https://openlayers.org/en/v4.6.5/examples/data/icon.png'
            }))
        });

        iconFeature.setStyle(iconStyle);

        var vectorSource = new ol.source.Vector({
            features: [iconFeature]
        });

        var vectorLayer = new ol.layer.Vector({
            source: vectorSource
        });

        map.addLayer(vectorLayer);

    </script>

</div>
");
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
