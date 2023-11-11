<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="CalculadoraConClases.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <title>Calculadora</title>
    <style type="text/css">

        #form1
        {
            width; 100%;
            height: 100%;
            border: solid 1 black;
        }
        .auto-style4 {

            
            height: 200px;
            width: 500px;
           
        }
        .auto-style5 {
            width: 49%;
            height: 49%;
            border: 1px solid #000000;
            background-color: #b5bdef;
            margin: 0 auto;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style8 {
            width: 80px;
        }
        .auto-style9 {
            height: 161px;
            width: 80px;
        }
        .auto-style23 {
            width: 154px;
            text-align: center;
        }
        .auto-style29 {
            margin-left: 0px;
            text-align: right;
            
        }

        button
        {
            height: 100px;
            width: 100px;

        }
        .auto-style31 {
            width: 80px;
            text-align: center;
        }
        .auto-style32 {
            width: 139px;
            text-align: center;
        }
        .auto-style33 {
            width: 136px;
        }
        .auto-style34 {
            height: 161px;
            width: 136px;
        }
        .auto-style35 {
            width: 136px;
            text-align: center;
        }
        .auto-style36 {
            width: 120px;
            text-align: center;
        }
        .auto-style37 {
            width: 136px;
            text-align: center;
            height: 20px;
        }
        .auto-style38 {
            width: 80px;
            text-align: center;
            height: 20px;
        }
        .auto-style39 {
            width: 139px;
            text-align: center;
            height: 20px;
        }
        .auto-style40 {
            width: 154px;
            text-align: center;
            height: 20px;
        }
        .auto-style41 {
            width: 120px;
            text-align: center;
            height: 20px;
        }
        .auto-style42 {
            text-align: left;
        }

    </style>
</head>

<body style="height: 1077px">
    <form id="form1" runat="server">
        <div class="auto-style4">
            

          <div class="text-center">
                    <h5 class="Calculadora text-dark">Calculadora</h5>  </div>

            <table class="auto-style5">
                <tr>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6" colspan="3" rowspan="2">
                        <asp:TextBox ID="txt_Pantalla" runat="server" CssClass="auto-style29" Height="73px" Width="92%" ReadOnly="True"  >0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:button ID="btn_Raiz" runat="server" Text="  √ " Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Raiz_Click" />
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btn_C" runat="server" Text="C" Height="50px" Width="50px" class="btn btn-danger" OnClick="btn_C_Click" />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="btn_Retroceso" runat="server" Text="&lt;&lt;" Height="50px" Width="50px" class="btn btn-danger" OnClick="btn_Retroceso_Click" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btn_Factorial" runat="server" Text="n!" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Factorial_Click" />
                    </td>
                    <td class="auto-style36">
                        <asp:Button ID="btn_Division" runat="server" Text="÷" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Division_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:Button ID="btn_XaLaY" runat="server" Text="x^y" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_XaLaY_Click" />
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btn_Siete" runat="server" Text="7" class="btn btn-light"  OnClick="btn_Siete_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="btn_Ocho" runat="server" Text="8" class="btn btn-light"  Height="50px" OnClick="btn_Ocho_Click" Width="50px" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btn_Nueve" runat="server" Text="9" class="btn btn-light"  Height="50px" OnClick="btn_Nueve_Click" Width="50px" />
                    </td>
                    <td class="auto-style36">
                        <asp:Button ID="btn_Multiplicar" runat="server" Text="x" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Multiplicar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:Button ID="btn_DiezX" runat="server" Text="10˟" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_DiezX_Click" />
                    </td>
                    <td class="auto-style31">
                        <asp:button ID="btn_Cuatro" runat="server" Text="4" class="btn btn-light"  OnClick="btn_Cuatro_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="btn_Cinco" runat="server" Text="5" class="btn btn-light"  Height="50px" OnClick="btn_Cinco_Click" Width="50px" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btn_Seis" runat="server" Text="6" class="btn btn-light"  Height="50px" OnClick="btn_Seis_Click" Width="50px" />
                    </td>
                    <td class="auto-style36">
                        <asp:Button ID="btn_Menos" runat="server" Text="-" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Menos_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:Button ID="btn_Log" runat="server" Text="log" Height="50px" Width="50px" class="btn btn-dark" OnClick="btn_Log_Click" />
                    </td>
                    <td class="auto-style31">
                        <asp:Button ID="btn_Uno" runat="server" Text="1" class="btn btn-light"  OnClick="btn_Uno_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="btn_Dos" runat="server" Text="2" class="btn btn-light"  OnClick="btn_Dos_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btn_Tres" runat="server" Text="3" class="btn btn-light"  OnClick="btn_Tres_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style36">
                        <asp:Button ID="btn_Mas" runat="server" Text="+" Height="50px" class="btn btn-dark" OnClick="btn_Mas_Click" Width="50px"   />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">
                        <asp:Button ID="btn_X_2" runat="server" Height="50px" Text="x²" class="btn btn-dark" Width="50px" OnClick="btn_X_2_Click" />
                    </td>
                    <td class="auto-style38">
                        <asp:Button ID="btn_Mas_Menos" runat="server" OnClick="Btn_MasMenos_Click" class="btn btn-dark" Text="+/-" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style39">
                        <asp:Button ID="btn_Cero" runat="server" Text="0" class="btn btn-light"  OnClick="btn_Cero_Click" Height="50px" Width="50px" />
                    </td>
                    <td class="auto-style40">
                        <asp:Button ID="btn_Coma" runat="server" Height="50px" Text="," Width="50px" class="btn btn-dark" OnClick="btn_Coma_Click" />
                    </td>
                    <td class="auto-style41">
                        <asp:Button ID="btn_Igual" runat="server" class="btn btn-success" OnClick="btn_Igual_Click" Text="=" Height="50px" Width="50px" />
                    </td>
                </tr>
            </table>


        </div>
    </form>
    <p class="auto-style42">
        &nbsp;</p>
    </body>
</html>
