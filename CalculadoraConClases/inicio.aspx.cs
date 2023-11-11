using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraConClases
{
    public partial class inicio : System.Web.UI.Page
    {
        
        VariablesGlobales global = new VariablesGlobales();

        string operador;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string AgregarNumero(object sender, EventArgs e) 
        {

            var boton = ((Button)sender);
            if(txt_Pantalla.Text == "0") 
            
            {
                txt_Pantalla.Text = "";
            
            
            }
            txt_Pantalla.Text += boton;

            return boton.ToString();
                
        }

        protected void Btn_MasMenos_Click(object sender, EventArgs e)
        {
            double resultado;

            if(txt_Pantalla.Text != "") 
            
            {
                VariablesGlobales.Num1 = txt_Pantalla.Text;
                resultado = (Convert.ToDouble(VariablesGlobales.Num1)) * -1;
                txt_Pantalla.Text = resultado.ToString();

            }
            else 
            {
               
                txt_Pantalla.Text += "-";
            }
            
            


        }

        public void btn_Igual_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text != "" && VariablesGlobales.Operador.Equals("+")) 
            {

                //txt_Pantalla.Text = "Este es el valor NUM1 " + VariablesGlobales.Num1;
                double resultado;
                VariablesGlobales.Num2 = txt_Pantalla.Text;
                resultado = Convert.ToDouble(VariablesGlobales.Num1) + Convert.ToDouble(VariablesGlobales.Num2);
                txt_Pantalla.Text = resultado.ToString();
                
            }else if (txt_Pantalla.Text != "" && VariablesGlobales.Operador.Equals("-")) 
            {
                double resultado;
                VariablesGlobales.Num2 = txt_Pantalla.Text;
                resultado = Convert.ToDouble(VariablesGlobales.Num1) - Convert.ToDouble(VariablesGlobales.Num2);
                txt_Pantalla.Text = resultado.ToString();

            }
            else if (txt_Pantalla.Text != "" && VariablesGlobales.Operador.Equals("x"))
            {
                double resultado;
                VariablesGlobales.Num2 = txt_Pantalla.Text;
                resultado = Convert.ToDouble(VariablesGlobales.Num1) * Convert.ToDouble(VariablesGlobales.Num2);
                txt_Pantalla.Text = resultado.ToString();

            }

            else if (txt_Pantalla.Text != "" && VariablesGlobales.Operador.Equals("÷"))
            {

                try
                {

                    double resultado;
                    VariablesGlobales.Num2 = txt_Pantalla.Text;
                    resultado = Convert.ToDouble(VariablesGlobales.Num1) / Convert.ToDouble(VariablesGlobales.Num2);
                    txt_Pantalla.Text = resultado.ToString();

                }
                catch (Exception)
                {
                    txt_Pantalla.Text = "Error";
                    throw;
                }
                

            }
        }

       

        protected void btn_Uno_Click(object sender, EventArgs e)
        {

            if(txt_Pantalla.Text == "0") 
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "1";

        }

        protected void btn_Dos_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "2";

        }

        protected void btn_Tres_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "3";
        }

        protected void btn_Cuatro_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "4";
        }

        

        public void btn_Cinco_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "5";
        }

        public void btn_Seis_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "6";
        }

        protected void btn_Siete_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "7";
        }

        public void btn_Ocho_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "8";
        }

        public void btn_Nueve_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text == "0")
            {
                txt_Pantalla.Text = "";

            }

            txt_Pantalla.Text += "9";
        }

        public void btn_Mas_Click(object sender, EventArgs e)
        {
            if(txt_Pantalla.Text != "") 
            {
                VariablesGlobales.Num1 = txt_Pantalla.Text;

                VariablesGlobales.Operador = "+";
                
                txt_Pantalla.Text = "";
            
            }
        }

        protected void btn_Cero_Click(object sender, EventArgs e)
        {

            txt_Pantalla.Text += "0";

        }

        protected void btn_Menos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pantalla.Text != "")
                {
                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "-";

                    txt_Pantalla.Text = "";

                }

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        protected void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pantalla.Text != "")
                {
                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "x";

                    txt_Pantalla.Text = "";

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Division_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pantalla.Text != "")
                {
                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "÷";

                    txt_Pantalla.Text = "";

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_X_2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Pantalla.Text != "")
                {
                    double resultado = 0;

                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "x²";

                    resultado = Math.Pow(Convert.ToDouble(VariablesGlobales.Num1), 2);

                    txt_Pantalla.Text = resultado.ToString();
                   

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btn_Log_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pantalla.Text != "")
                {
                    double resultado = 0;

                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "log";

                    resultado = Math.Pow(Convert.ToDouble(VariablesGlobales.Num1), 2);

                    txt_Pantalla.Text = resultado.ToString();


                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_DiezX_Click(object sender, EventArgs e)
        {
            

            try
            {
                

                if (txt_Pantalla.Text != "")
                {
                    double resultado = 0;
                                                       

                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "10˟";

                    resultado = Math.Pow(10, Convert.ToDouble( VariablesGlobales.Num1));

                    txt_Pantalla.Text = resultado.ToString();


                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        protected void btn_XaLaY_Click(object sender, EventArgs e)
        {

            double resultado = 0;
           
            if(txt_Pantalla.Text != "") 
            {
                VariablesGlobales.Num1 = txt_Pantalla.Text;
                txt_Pantalla.Text = "";

                VariablesGlobales.Num2 = txt_Pantalla.Text;




            }

            resultado = Math.Pow(Convert.ToDouble(VariablesGlobales.Num1), Convert.ToDouble(VariablesGlobales.Num2));


            
            
                 
            //elevar(VariablesGlobales.Num1, VariablesGlobales.Num2); 

            
        }

        protected void Limpiar(object sender, EventArgs e) 
        
        {
            txt_Pantalla.Text = "";

        }

     

        


        protected void btn_Raiz_Click(object sender, EventArgs e)
        {
            try
            {


                if (txt_Pantalla.Text != "")
                {
                    double resultado = 0;


                    VariablesGlobales.Num1 = txt_Pantalla.Text;

                    VariablesGlobales.Operador = "10˟";

                    resultado = Math.Sqrt( Convert.ToDouble(VariablesGlobales.Num1));

                    txt_Pantalla.Text = resultado.ToString();


                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btn_C_Click(object sender, EventArgs e)
        {
            Limpiar(sender, e);
        }

        protected void btn_Retroceso_Click(object sender, EventArgs e)
        {

            if (txt_Pantalla.Text.Length   > 1) 
            
            {
                int largo= txt_Pantalla.Text.Length;

                txt_Pantalla.Text =txt_Pantalla.Text.Substring(0, largo-1);

            }
            else 
            {
                txt_Pantalla.Text = "0";
            }

        }

        protected void btn_Coma_Click(object sender, EventArgs e)
        {
            if(!txt_Pantalla.Text.Contains(",")) 
            {
                txt_Pantalla.Text += ",";
            }
            else if(txt_Pantalla.Text == "")
            {
                txt_Pantalla.Text += "0,"; 
            }


            
        }

        protected void btn_Factorial_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text != "") 
            {
                VariablesGlobales.Num1 = txt_Pantalla.Text;
                double temp = 0;
                temp = Convert.ToDouble(VariablesGlobales.Num1);
                double resultado = 1;

                for (double i = 1;temp >= i; i++) 
                {
                    resultado = (resultado * i);
                        
                    
                }

                txt_Pantalla.Text =resultado.ToString();
            
            }
        }
    }
}