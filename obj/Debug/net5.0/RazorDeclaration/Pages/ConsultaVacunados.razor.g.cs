// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea8_P3.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Tarea8_P3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Tarea8_P3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\ConsultaVacunados.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConsultaVacunados")]
    public partial class ConsultaVacunados : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 394 "C:\Users\a\Downloads\Telegram Desktop\Tarea8-P3\Tarea8-P3\Pages\ConsultaVacunados.razor"
        

    String FiltroParaMostrar = "-- Sin seleccionar --";
    String provincia = "-- Sin seleccionar --";
    List<vacunados> Vacunados = new List<vacunados>();
    vacunados ActualizarVacunados = new vacunados();

    DateTime FechaDeNacimiento;

    string TipoVacuna_A;
    int CanditadVacunaTipoA = 0;

    string TipoVacuna_B;
    int CanditadVacunaTipoB = 0;

    string TipoVacuna_C;
    int CanditadVacunaTipoC = 0;

    int CantidadCapricornio = 0;
    int CantidadAcuario = 0;
    int CantidadPiscis = 0;
    int CantidadAries = 0;
    int CantidadTauro = 0;
    int CantidadGéminis = 0;
    int CantidadCancer = 0;
    int CantidadLeo = 0;
    int CantidadVirgo = 0;
    int CantidadLibra = 0;
    int CantidadEscorpio = 0;
    int CantidadSagitario = 0;

    public double GraficoVacunaTipoA(double VacunaTipoA)
    {
        VacunaTipoA = CanditadVacunaTipoA;
        VacunaTipoA = (VacunaTipoA * 10);
        return VacunaTipoA;
    }
    public double GraficoVacunaTipoB(double VacunaTipoB)
    {
        VacunaTipoB = CanditadVacunaTipoB;
        VacunaTipoB = (VacunaTipoB * 10);
        return VacunaTipoB;
    }
    public double GraficoVacunaTipoC(double VacunaTipoC)
    {
        VacunaTipoC = CanditadVacunaTipoC;
        VacunaTipoC = (VacunaTipoC * 10);
        return VacunaTipoC;
    }

    public void InicializarCero()
    {
        CantidadCapricornio = 0;
        CantidadAcuario = 0;
        CantidadPiscis = 0;
        CantidadAries = 0;
        CantidadTauro = 0;
        CantidadGéminis = 0;
        CantidadCancer = 0;
        CantidadLeo = 0;
        CantidadVirgo = 0;
        CantidadLibra = 0;
        CantidadEscorpio = 0;
        CantidadSagitario = 0;

        CanditadVacunaTipoA = 0;
        CanditadVacunaTipoB = 0;
        CanditadVacunaTipoC = 0;
    }

    public void provincias(ChangeEventArgs e)
    {
        provincia = e.Value.ToString();
    }

    //Codigo del select, para poder mostrar datos y filtrarlos por el select
    public void FiltroMostrar(ChangeEventArgs e)
    {
        FiltroParaMostrar = e.Value.ToString();
    }

    //Codigo para poder visualizar los datos de la Base de Datos
    protected override async Task OnInitializedAsync()
    {
        await RefreshVacunados();
    }

    private void SetProductForUpdate(vacunados vacun)
    {
        ActualizarVacunados = vacun;
    }

    private async Task RefreshVacunados()
    {
        Vacunados = await service.GetProductAsync();
    }

    private async Task DeleteVacunados(vacunados vacun)
    {
        await service.DeleteProductAsync(vacun);
        await RefreshVacunados();
    }

    //Codigo para poder implementar el Datatable
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunadosServices service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
